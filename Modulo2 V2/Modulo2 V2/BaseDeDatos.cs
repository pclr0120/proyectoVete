using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Modulo2_V2
{
   public class BaseDeDatos
    {
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conectar = new MySqlConnection("server=localhost; database=bdvete; Uid=root; pwd=paulico99");

            conectar.Open();
            return conectar;
        }
    }
}
