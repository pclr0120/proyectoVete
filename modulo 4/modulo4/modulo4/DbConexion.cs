using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeterinariaClientes
{
    public class DbConexion
    {
        String StrConn;
        MySqlConnection Conn;
        public DbConexion(String Server,String User,String Password,String Database ) {
            StrConn = "server=" + Server + "; database = " + Database + "; Uid=" + User + "; pwd=" + Password + ";";
        }
        public bool Abrir()
        {
            try
            {
                Conn = new MySqlConnection(StrConn);
                Conn.Open();
                return true;
            }
            catch { return false; }
        }

        public MySqlConnection Get()
        {
            return Conn;
        }

        public bool Cerrar()
        {
            try
            {
                Conn.Close();
                return true;
            }
            catch { return false; }
        }
    }
}
