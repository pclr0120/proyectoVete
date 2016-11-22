using System;
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
            
        }
        public string conexion = "";
        DataSet consulta = new DataSet(); // tabla para llenar el combobox
        DataSet consultap = new DataSet();// para agregar los productos a la venta
        public List<string> miLista = new List<string>();

        public DataSet consultarPro()
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    string valor = cb_produc.SelectedValue.ToString();
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

                    miLista.Add(valor.ToString());
                
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
                dataGrid.ItemsSource = consultap.Tables["productos"].DefaultView;


                //this.dataGrid.ItemsSource = miLista;



            }
            catch (Exception e) { MessageBox.Show("Consulte a su Administrador:" + e, "Mensaje de Error"); }
        }
        int dd;
        private void sumar()
        {
            try
            {
                //consultarPro();
                for (int i = 0; i < dataGrid.Items.Count; i++)
                {
                    dd = dd + Convert.ToInt32(((DataRowView)dataGrid.Items[i]).Row[5]);
                }
                lbltotal.Content = dd.ToString();
            }
            catch (Exception e) { MessageBox.Show("Consulte a su Administrador:" + e, "Mensaje de Error"); }
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Addventa();
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
            MessageBox.Show(DeleteIndex.ToString());
        }

        private void btnCancelar_Click_1(object sender, RoutedEventArgs e)
        {
            //dataGrid.Items.Remove(DeleteIndex);
            consultap.Tables["productos"].Rows.RemoveAt(2);
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = consultap.Tables["productos"].DefaultView;
        }
    }
}
