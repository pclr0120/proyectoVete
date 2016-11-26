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
        int dd, cc, iva;
      
        public void reloj() {
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
                    consulta = new DataSet();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "ConsultaDetalleProducto";
                    //cmd.Parameters.Clear();
                    //if (txt_cantidad.Text != "") {
                    //    cmd.Parameters.Add(new MySqlParameter("_cant", Convert.ToInt32(txt_cantidad.Text)));
                    //}
                    //else { cmd.Parameters.Add(new MySqlParameter("_cant", 1)); }
                    cmd.Parameters.Add(new MySqlParameter("_id", id));
                    conn.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(consultap, "productos");

                   
                
                    return consultap;

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error Consulte a su Administrador:" + ex.Message.ToString(), "Mensaje");
                return new DataSet();
            }
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
       
        private void Addventa()
        {
            try
            {
            
                
                consultarPro();
                miLista.Add(valor.ToString());
                dataGrid.ItemsSource = consultap.Tables["productos"].DefaultView;


                //this.dataGrid.ItemsSource = miLista;



            }
            catch (Exception e) { MessageBox.Show("Consulte a su Administrador:" + e, "Mensaje de Error"); }
        }
       
        private void sumar()
        {
            try
            {
                //consultarPro();
                    iva+=  Convert.ToInt32(((DataRowView)dataGrid.Items[cc]).Row[6]);
                dd += Convert.ToInt32(((DataRowView)dataGrid.Items[cc]).Row[3]);
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
            sumar();
        }
    
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            
           MessageBox.Show( miLista[c].ToString());
            c += 1;
        }



        int NumeroRegistro;

   
        public void EvaluerTecla(object sender, KeyEventArgs e)
        {
            if (Key.F1 == e.Key && dataGrid.Items.Count > 0)
            {
                VentaFinalizada();
            }
          
            if (Key.F2==e.Key && dataGrid.Items.Count > 0) {

                EliminarProducto();
              
               
               
              
            }

        }
        public void EliminarProducto()
        {
            //int valor;
           
            //dataGrid.Items.Remove(DeleteIndex);
            try
            {
                dd -= Convert.ToInt32(((DataRowView)dataGrid.Items[NumeroRegistro]).Row[3]);

                iva -= Convert.ToInt32(((DataRowView)dataGrid.Items[NumeroRegistro]).Row[6]);
                cc -= 1;
                lbliva.Content = iva.ToString();
                lblsubtol.Content = dd.ToString();
               
                lbltotal.Content = (dd + iva).ToString();
                consultap.Tables["productos"].Rows.RemoveAt(NumeroRegistro);
                


               
                dataGrid.ItemsSource = consultap.Tables["productos"].DefaultView;
                NumeroRegistro = -1;
                MessageBox.Show("Eliminado", "Mensaje");
            }
            catch (Exception) {
                MessageBox.Show("seleccione un producto para Eliminar", "Mensaje");
            }
            
           
        }

        private void dataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            NumeroRegistro = dataGrid.SelectedIndex;
            
        }

        public void registrarVentamaestra() {

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
                        venta=Convert.ToInt32(cmd.ExecuteScalar());
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
                MessageBox.Show("haf");
            }

            //==============
        }
        public void VentaFinalizada() {

          


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
                                _id = Convert.ToInt32(((DataRowView)dataGrid.Items[i]).Row["idProductos"].ToString());
                                _iva = Convert.ToDouble(((DataRowView)dataGrid.Items[i]).Row["iva"].ToString());

                                _precio = Convert.ToDouble(((DataRowView)dataGrid.Items[i]).Row["precio"].ToString());



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
