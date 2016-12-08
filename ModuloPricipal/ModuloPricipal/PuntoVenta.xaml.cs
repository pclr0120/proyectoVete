using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Threading;
using MahApps.Metro.Controls;
using MahApps.Metro.Behaviours;
using MahApps.Metro.Controls.Dialogs;

using System.Linq;



namespace ModuloPricipal
{
    /// <summary>
    /// Lógica de interacción para PuntoVenta.xaml
    /// </summary>
    public partial class PuntoVenta : Window
    {


     
        public PuntoVenta()
        {
            InitializeComponent();

            conexion = "server=localhost;user id=root;password=pclr0120;database=bdvt;";
            consultarCombobox();
            cb_produc.ItemsSource = consulta.Tables["produc"].DefaultView;
            cb_produc.DisplayMemberPath = consulta.Tables["produc"].Columns["nombre"].ToString();
            cb_produc.SelectedValuePath = consulta.Tables["produc"].Columns["idProductos"].ToString();
            cb_produc.Focus();
            reloj();

           



        }
        
        int _id;
        double _iva;
        double _precio;
        string _nombre;
        string p;
        public string conexion = "";
        DataSet consulta = new DataSet(); // tabla para llenar el combobox
        DataSet consultap = new DataSet();// para agregar los productos a la venta
        public List<string> miLista = new List<string>();
        string valor;
        int c = 0;
        int venta;
        double dd, iva;
        int cc;
        int registroProducto = 1;

        public void reloj()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += tickeven;
            timer.Start();



        }

        private void tickeven(object sender, EventArgs e)
        {
            lblfecha.Content = DateTime.Now.ToString();
        }


        public DataSet consultarPro()
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    valor = cb_produc.SelectedValue.ToString();
                    int id = Convert.ToInt32(valor);

                    MySqlCommand cmd = new MySqlCommand();

                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ConsultaDetalleProducto";
                    cmd.Parameters.Add(new MySqlParameter("_id", id));
                    conn.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);

                    adaptador.Fill(consultap, "productos");




                    //producto prod = new producto();
                    //prod.Nombre = "sandia";
                    //prod.Precio = 20;
                   
                    //productos.Add(prod);
                    return consultap;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Consulte a su Administrador:" + ex.Message.ToString(), "Mensaje");
                return new DataSet();
            }
        }
        List<producto> productos = new List<producto>();
        static List<producto> lista = new List<producto>();
        public class producto{
            private string _nombre;
            private double _precio;
            private double _iva;
            private int Registro;
            private int _id;



            public string Nombre
            {
                get
                {
                    return _nombre;
                }

                set
                {
                    _nombre = value;
                }
            }

       

            public double Iva
            {
                get
                {
                    return _iva;
                }

                set
                {
                    _iva = value;
                }
            }

            public int Registro1
            {
                get
                {
                    return Registro;
                }

                set
                {
                    Registro = value;
                }
            }

            public int Id
            {
                get
                {
                    return _id;
                }

                set
                {
                    _id = value;
                }
            }

            public double Precio
            {
                get
                {
                    return _precio;
                }

                set
                {
                    _precio = value;
                }
            }
        }

        public void _Eliminar()
        {
            DialogoEliminarProducto win = new DialogoEliminarProducto();
            win.ShowDialog();
            if (win.valor < dataGrid.Items.Count)
            {



                int valor = win.valor - 1;
                //int valor = val;
                //ACtualizar LAS label
                //dd -= Convert.ToInt32(((DataRowView)dataGrid.Items[win.valor]).Row[3]);
                dd -= lista[valor].Precio;
                //iva -= Convert.ToInt32(((DataRowView)dataGrid.Items[win.valor]).Row[2]);
                iva -= lista[valor].Iva;
                cc -= 1;
                lbliva.Content = iva.ToString();
                lblsubtol.Content = dd.ToString();

                lbltotal.Content = (dd + iva).ToString();
                //label
                lista.Remove(lista.FirstOrDefault(c => c.Registro1 == win.valor));
                int ccc = 1;
                for (int i = 0; i < lista.Count; i++)
                {

                    lista[i].Registro1 = ccc;
                    ccc += 1;
                    registroProducto = ccc;
                }

                this.dataGrid.ItemsSource = lista;
                this.dataGrid.Items.Refresh();
            }
            else { MessageBox.Show("No existe ese producto", "Eliminar Producto"); }



        }
        public static List<producto> Consultar(int id, string key,int c)
        {
            //string source;
            //if (string.IsNullOrEmpty(key))
            //    source = conexion;
            //else
            //    source = Conexion.getDataSource(key);
         
            using (MySqlConnection conn = new MySqlConnection(key))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand() { Connection = conn };
                //cmd.CommandText = "Select * from Caja";
                //if (IDOrganizacion != 0)
                //    cmd.CommandText = "Select * from Caja where IDOrganizacion =" + IDOrganizacion;
                //if (IDCaja != 0)
                //    cmd.CommandText = "Select * from Caja where ID =" + IDCaja;
                cmd.CommandText = "ConsultaDetalleProducto";
                cmd.Parameters.Add(new MySqlParameter("_id", id));
                cmd.CommandType = CommandType.StoredProcedure;
                return Leer(cmd,c);
            }
        }

      public  static List<producto> Leer(MySqlCommand cmd,int c)
        {

            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                
                int ID = dr.GetOrdinal("idProductos");
                int IDCentroOperacion = dr.GetOrdinal("nombre");
                int IDOrganizacion = dr.GetOrdinal("precio");
                int Descripcion = dr.GetOrdinal("iva");
                int colCount = dr.FieldCount;
                object[] values = new object[colCount];
                while (dr.Read())
                {
                    producto t = new producto();
                    dr.GetValues(values);
                    t.Registro1 = c;
                    t.Id = Convert.ToInt16(values[ID]);
                    t.Nombre =values[IDCentroOperacion] == DBNull.Value ? "" : Convert.ToString(values[IDCentroOperacion]);
                    t.Precio = values[IDOrganizacion] == DBNull.Value ? 0 : Convert.ToDouble(values[IDOrganizacion]);
                    t.Iva =values[Descripcion] == DBNull.Value ? 0 : Convert.ToDouble(values[Descripcion]);
                    lista.Add(t);
                
                    t = new producto();

                  
                }
            }
            return lista;
        }
        public DataSet consultarCombobox()
    {
        try
        {

            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                consulta = new DataSet();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ComboboxProducto";
                cmd.Parameters.Clear();
                conn.Open();
                MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                adaptador.Fill(consulta, "produc");
                return consulta;

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error Consulte a su Administrador:" + ex.Message.ToString(), "Mensaje");
            return new DataSet();
        }
    }
        producto prod = new producto();
       
        private void Addventa( )

    {
        try
        {

    
                valor = cb_produc.SelectedValue.ToString();
                int id = Convert.ToInt32(valor);
                Consultar(id, conexion,registroProducto);
             
                //prod.Registro1 = registroProducto;

                //lista.Add(prod);
                this.dataGrid.ItemsSource = lista;
                this.dataGrid.Items.Refresh();
               
                sumar();
                registroProducto += 1;

            }
        catch (Exception e) { MessageBox.Show("Consulte a su Administrador:" + e, "Mensaje de Error"); }
    }

        public void sumar()
        {
            try
            {
                //consultarPro();
               
                iva += lista[registroProducto-1].Iva;
                dd += lista[registroProducto-1].Precio;
                cc += 1;
                lbliva.Content = iva.ToString();
                lblsubtol.Content = dd.ToString();
                lbltotal.Content = dd + iva;

            }
            catch (Exception e) { MessageBox.Show("Consulte a su Administrador:" + e, "Mensaje de Error"); }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
    {
        Addventa();
           
        //sumar();
    }

    private void btnActualizar_Click(object sender, RoutedEventArgs e)
    {

        MessageBox.Show(miLista[c].ToString());
        c += 1;
    }



    int NumeroRegistro;


    public void EvaluerTecla(object sender, KeyEventArgs e)
    {
        if (Key.Escape == e.Key)
        {


            this.Close();


        }
        if (Key.F1 == e.Key && dataGrid.Items.Count > 0)
        {
            VentaFinalizada();
        }

        if (Key.F2 == e.Key && dataGrid.Items.Count > 0)
        {
                _Eliminar();
                Reporte R = new Reporte();


                


        }

            if (Key.F3 == e.Key )
            {
                
                Reporte R = new Reporte();
                R.Show();




            }

        }
    //public void EliminarProducto(int NumeroRegistro)
    //{
    //    //int valor;

    //    //dataGrid.Items.Remove(DeleteIndex);
    //    try
    //    {
    //        dd -= Convert.ToInt32(((DataRowView)dataGrid.Items[NumeroRegistro]).Row[3]);

    //        iva -= Convert.ToInt32(((DataRowView)dataGrid.Items[NumeroRegistro]).Row[6]);
    //        cc -= 1;
    //        lbliva.Content = iva.ToString();
    //        lblsubtol.Content = dd.ToString();

    //        lbltotal.Content = (dd + iva).ToString();

    //        MessageBox.Show("Eliminado", "Mensaje");
    //    }
    //    catch (Exception)
    //    {
    //        MessageBox.Show("seleccione un producto para Eliminar", "Mensaje");
    //    }


    //}

    private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
    {
        NumeroRegistro = dataGrid.SelectedIndex;

    }

    public void registrarVentamaestra()
    {

        MySqlCommand cmd = new MySqlCommand();
        try
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Connection = conn;
                conn.Open();
                MySqlTransaction tranOperaciones = null;
                tranOperaciones = cmd.Connection.BeginTransaction();
                cmd.Transaction = tranOperaciones;
                try
                {




                    cmd.CommandText = "savevVetaMaestra";
                    cmd.Parameters.Clear();

                    cmd.Parameters.Add(new MySqlParameter("_subtotal", Convert.ToDouble(lblsubtol.Content)));
                    cmd.Parameters.Add(new MySqlParameter("_iva", Convert.ToDouble(lbliva.Content)));
                    cmd.Parameters.Add(new MySqlParameter("_total", Convert.ToDouble(lbltotal.Content)));
                    venta = Convert.ToInt32(cmd.ExecuteScalar());
                    tranOperaciones.Commit();
                    conn.Close();
                }
                catch
                {
                    tranOperaciones.Rollback();
                }


            }



            MessageBox.Show("Venta registrada", "mensaje");
            venta += 1;

        }
        catch (Exception e)
        {

        }

        //==============
    }
    public void VentaFinalizada()
    {




        registrarVentamaestra();
        MySqlCommand cmd = new MySqlCommand();
        try
        {
            using (MySqlConnection conn = new MySqlConnection(conexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                for (int i = 0; i < dataGrid.Items.Count; i++)
                {
                    cmd.Connection = conn;
                    conn.Open();
                    MySqlTransaction tranOperaciones = null;
                    tranOperaciones = cmd.Connection.BeginTransaction();
                    cmd.Transaction = tranOperaciones;
                    try
                    {
                            _id = lista[i].Id;
                            _iva = lista[i].Iva;
                            _precio = lista[i].Precio;
                        //_id = Convert.ToInt32(((DataRowView)dataGrid.Items[i]).Row["idProductos"].ToString());
                        //_iva = Convert.ToDouble(((DataRowView)dataGrid.Items[i]).Row["Iva"].ToString());

                            //_precio = Convert.ToDouble(((DataRowView)dataGrid.Items[i]).Row["Precio"].ToString());



                            cmd.CommandText = "RegistrarVenta";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new MySqlParameter("_venta", venta));
                        cmd.Parameters.Add(new MySqlParameter("_id", _id));
                        cmd.Parameters.Add(new MySqlParameter("_iva", _iva));
                        cmd.Parameters.Add(new MySqlParameter("_precio", _precio));
                        cmd.ExecuteNonQuery();
                        tranOperaciones.Commit();
                        conn.Close();
                    }
                    catch { tranOperaciones.Rollback(); }



                }

                MessageBox.Show("Venta registrada", "mensaje");
                venta += 1;
            }
        }
        catch (Exception a)
        {
            MessageBox.Show("Erro: no se registro la venta:" + a + ", consulte con su admin ", "Mensaje de Error");
        }



    }





}
}
