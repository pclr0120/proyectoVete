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
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace ModuloPricipal
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    /// //jojojds
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            conexion = "server=localhost;user id=root;password=pclr0120;database=bdvt;";
            InitializeComponent();
        }
        
        public string conexion = "";
        DataSet consulta = new DataSet();   // donde se guardar la tabla

        MySqlCommand Cmds = new MySqlCommand();  // para ejecutar el comando sql
        MySqlDataAdapter ad = new MySqlDataAdapter();
        MySqlDataReader rdd;

     


        

        public bool _login_in()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    consulta = new DataSet();
                    MySqlCommand cmd = new MySqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "Loginvt";
                    cmd.Parameters.Clear();
                    cmd.Parameters.Add(new MySqlParameter("_usuario", txt_user.Text));
                    cmd.Parameters.Add(new MySqlParameter("_pass", txt_pass.Password));
                    conn.Open();
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(cmd);
                    adaptador.Fill(consulta, "usuarios");
                    if (consulta.Tables[0].Rows.Count > 0)
                    {

                        Menu m = new Menu();
                        m.Show();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("USUARIO O CONTRASEÑA INCORRECTA", "LOGIN"); txt_user.Focus();
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Consulte a su Administrador:" + ex.Message.ToString(), "Mensaje");
                return false;
            }

          
        }
        private void cmd_star_Click_1(object sender, RoutedEventArgs e)
        {
            if (txt_pass.Password != "" && txt_user.Text != "")
            {
                _login_in();
            }
            else { MessageBox.Show("Capture el nombre de Usuario y contraseña", "Login"); }
        }

        private void txt_pass_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (Key.Enter == e.Key)
            {
                if (txt_pass.Password != "" && txt_user.Text != "")
                {
                    _login_in();
                }
                else { MessageBox.Show("Capture el nombre de Usuario y contraseña", "Login"); }
            }

        }
    }
}
