using Practica_bd;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClientesPracticaBd
    {
        private static string stringconexion;
        private static SqlConnection conexion ;
        private static SqlCommand comando ;

        static ClientesPracticaBd() {

            stringconexion = @"Server = localhost ; Database = test ; Trusted_Connection=True; ";
            conexion = new SqlConnection(stringconexion);
            comando = new SqlCommand();
        }

        public static List<cliente> ObtenerDatos(string strComando)
        {
            List<cliente> clientes = new List<cliente>();
             
            
            conexion.Open();

          
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = strComando;

            SqlDataReader reader =  comando.ExecuteReader();

            while (reader.Read())
            {
                clientes.Add(new cliente(reader.GetString(1), reader.GetInt32(0)));
            }

            conexion.Close();
            return clientes;
        }
        
        
        public static void EscribirDatos(cliente cliente)
        {
     
            try
            {
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "INSERT INTO Cliente VALUES (@Nombre)";

                comando.Parameters.AddWithValue("@Nombre", cliente.Nombre);

                comando.ExecuteNonQuery();
           
            }catch(Exception)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }

        }

        public void Modificar(cliente cliente)
        {
            try
            {
                
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
