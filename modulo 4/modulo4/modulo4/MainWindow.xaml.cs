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
using System.Windows.Navigation;
using System.Windows.Shapes;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace modulo4
{
    /// <summary>
    /// Interaction logic for ffdfdfMainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void hola() {
        }

        private void textBox_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox.SelectAll();
        }

        private void textBox1_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox2.SelectAll();
        }

        private void textBox3_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox5_GotFocus(object sender, RoutedEventArgs e)
        {
            textBox5.SelectAll();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            // Se crea la conexión a la base de datos
            MySqlConnection _conexion = new MySqlConnection(ConfigurationManager.ConnectionStrings[&quot; cadConexion & quot;].ToString());

            // Se abre la conexion
            _conexion.Open();

            // Se crea un DataTable que almacenará los datos desde donde se cargaran los datos al DataGridView
            DataTable dtDatos = new DataTable();

            // Se crea un MySqlAdapter para obtener los datos de la base
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(&quot; SELECT* FROM tblCliente; &quot;, _conexion);

            // Con la información del adaptador se rellena el DataTable
            mdaDatos.Fill(dtDatos);

            // Se asigna el DataTable como origen de datos del DataGridView
            dgvDatos.DataSource = dtDatos;

            // Se cierra la conexión a la base de datos
            _conexion.Close();
        }
    }
}
