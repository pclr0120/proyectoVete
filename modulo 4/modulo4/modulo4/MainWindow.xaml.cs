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

using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace VeterinariaClientes
{
    /// <summary>
    /// Interaction logic for ffdfdfMainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String Database, Server, User, Password;
        public MainWindow(String Database, String Server, String User,String Password)
        {
            this.Database = Database;
            this.Server = Server;
            this.User = User;
            this.Password = Password;
            InitializeComponent();
        }
        private void hola() {
        }

        private void TxtNombre_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtNombre.SelectAll();
        }

        private void Txtapp_GotFocus(object sender, RoutedEventArgs e)
        {
            Txtapp.SelectAll();
        }

        private void TxtApm_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtApm.SelectAll();
        }

        private void TxtTelefono_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtTelefono.SelectAll();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DgGrid_Loaded_1(object sender, RoutedEventArgs e)
        {
            DbConexion Conexion = new DbConexion(Server, User, Password, Database);
            Conexion.Abrir();
            MySqlCommand cmd = new MySqlCommand("", Conexion.Get());
        }

        private void TxtEmail_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtEmail.SelectAll();
        }

        private void TxtDireccion_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtDireccion.SelectAll();
        }

        private void DgGrid_Loaded(object sender, RoutedEventArgs e)
        {
            DbConexion Conexion = new DbConexion(Server, User, Password, Database);
            Conexion.Abrir();
            MySqlCommand cmd = new MySqlCommand("", Conexion.Get());
        }
    }
}
