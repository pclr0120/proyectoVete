using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Modulo_Mascota
{
    public class BDConexion
    {

        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bdvt; Uid=root; pwd=20601;");
            conectar.Open();
            return conectar;
        }
        public static MySqlConnection CerrarConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=bdvt; Uid=root; pwd=20601;");
            conectar.Close();
            return conectar;
        }

    }
}