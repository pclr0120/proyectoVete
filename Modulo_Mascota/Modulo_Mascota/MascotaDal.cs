using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modulo_Mascota
{
    class MascotaDal
    {
        public static int InvocarSP(Mascota pMascota)
        {
            using (MySqlCommand cmd = new MySqlCommand())
            {
                try
                {
                    int retorno = 0;
                    // setear parametros del command
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = BDConexion.ObtenerConexion();
                    cmd.CommandText = "RegMasc";

                    //asignar paramentros
                    cmd.Parameters.AddWithValue("_idCliente", pMascota.idCliente);
                    cmd.Parameters.AddWithValue("_Nombre", pMascota.nombre);
                    cmd.Parameters.AddWithValue("_Especie", pMascota.especie);
                    cmd.Parameters.AddWithValue("_Raza", pMascota.raza);
                    cmd.Parameters.AddWithValue("_Color", pMascota.color);
                    cmd.Parameters.AddWithValue("_Peso", pMascota.peso);
                    cmd.Parameters.AddWithValue("_Sexo", pMascota.sexo);
                    cmd.Parameters.AddWithValue("_Notas", pMascota.senasParticulares);
                    cmd.Parameters.AddWithValue("_FechaNac", pMascota.fechaNacimiento);
                    cmd.Parameters.AddWithValue("_Statuss", pMascota.statuss);
                    //abrir la conexion
                    BDConexion.ObtenerConexion();

                    //ejecutar el query
                    retorno = cmd.ExecuteNonQuery();
                    return retorno;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    BDConexion.CerrarConexion();
                } // end try
            } // end using
        
        } // end GuardarHuella
    }
}

