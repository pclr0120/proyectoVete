﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Threading;

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
            InitializeComponent();
            conexion = "server=localhost;user id=root;password=pclr0120;database=bdvt;";
            consultarCombobox();
            cb_produc.ItemsSource = consulta.Tables["produc"].DefaultView;
            cb_produc.DisplayMemberPath = consulta.Tables["produc"].Columns["nombre"].ToString();
            cb_produc.SelectedValuePath = consulta.Tables["produc"].Columns["idProductos"].ToString();
            cb_produc.Focus();
            reloj();
            venta = 1;
            
        }
        int venta;
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

        public string conexion = "";
        DataSet consulta = new DataSet(); // tabla para llenar el combobox
        DataSet consultap = new DataSet();// para agregar los productos a la venta
        public List<string> miLista = new List<string>();
        string valor;
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
        string p;
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
        int dd,cc,iva;
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
        int c = 0;
        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            
           MessageBox.Show( miLista[c].ToString());
            c += 1;
        }
        int DeleteIndex;


      

        private void dataGrid_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            DeleteIndex = dataGrid.SelectedIndex;

            
        }

        public void btnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            //dataGrid.Items.Remove(DeleteIndex);
            try
            {
                dd -= Convert.ToInt32(((DataRowView)dataGrid.Items[DeleteIndex]).Row[3]);
               
                iva -= Convert.ToInt32(((DataRowView)dataGrid.Items[DeleteIndex]).Row[6]);
                cc -= 1;
                lbliva.Content = iva.ToString();
                lblsubtol.Content = dd.ToString();
               
                lbltotal.Content = (dd + iva).ToString();
                consultap.Tables["productos"].Rows.RemoveAt(DeleteIndex);
                


               
                dataGrid.ItemsSource = consultap.Tables["productos"].DefaultView;
                DeleteIndex = -1;
            }
            catch (Exception) {
                MessageBox.Show("seleccione un producto para Eliminar", "Mensaje");
            }
            
           
        }
        int _id;
        double _iva;
        double _precio;
        string _nombre;
        
        public void VentaFinalizada() {
           
                MySqlCommand cmd = new MySqlCommand();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    

                    for (int i = 0; i < dataGrid.Items.Count; i++)
                    {
                        _id = Convert.ToInt32(((DataRowView)dataGrid.Items[i]).Row["idProductos"].ToString());
                        _iva = Convert.ToDouble(((DataRowView)dataGrid.Items[i]).Row["iva"].ToString());
                        
                        _precio = Convert.ToDouble(((DataRowView)dataGrid.Items[i]).Row["precio"].ToString());

                        cmd.Connection = conn;
                        conn.Open();
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandText = "RegistrarVenta";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add(new MySqlParameter("_venta", venta));
                        cmd.Parameters.Add(new MySqlParameter("_id", _id));
                        cmd.Parameters.Add(new MySqlParameter("_iva", _iva));
                        cmd.Parameters.Add(new MySqlParameter("_precio", _precio));
                        cmd.ExecuteNonQuery();
                        
                  
                        conn.Close();
                   
                       

                    }

                    MessageBox.Show("Venta registrada", "mensaje");
                    venta += 1;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro: no se registro la venta:"+e+", consulte con su admin ","Mensaje de Error");
            }
                


        }
        private void btnlimpiar_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid.Items.Count > 0)
            {
                VentaFinalizada();
                
            }
            else {
                MessageBox.Show("no se registro ningun producto a la venta agrege uno ", "mensaje");
            }
        }

      
    }
}
