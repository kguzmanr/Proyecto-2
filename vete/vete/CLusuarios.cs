using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace vete
{
    public class CLusuarios
    {
        public static string nombre { get; set; }
        public static string clave { get; set; }
        public static string nombrecompleto { get; set; }

        public static int cantidadsi { get; set; }
        public static int cantidadno { get; set; }

        public CLusuarios(String n, String c, String nc)
        {
            nombre = n;
            clave = c;
            nombrecompleto = nc;
        }

        public static int Ingresar(string username, string password)
        {

            nombre = username;
            clave = password;

            int resultado = 0;
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select usuario, clave from usuario where Ingresar = '" + username + "'" +
                "and clave = '" + password + "'", conexion);
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                nombrecompleto = registro[2].ToString();
                resultado = 1;

            }
            else
            {
                resultado = -1;

            }
            conexion.Close();

            return resultado;
        }
        public int Salvar()
        {
            int resultado = 0;
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            try
            {
                using (SqlConnection connection = new SqlConnection(s))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand("Ingresar", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = nombre;
                        command.Parameters.Add("@clave", SqlDbType.NVarChar).Value = clave;
                        command.Parameters.Add("@nombre", SqlDbType.NVarChar).Value = nombrecompleto;
                        // command.Parameters.Add("@edad", SqlDbType.NVarChar).Value = edad;
                        // command.Parameters.Add("@correo", SqlDbType.NVarChar).Value = correo;
                        // command.Parameters.Add("@carropropio", SqlDbType.NVarChar).Value = carropropio;


                        command.ExecuteNonQuery();

                        connection.Close();

                    }
                }


            }

            catch (Exception ex)
            {

            }
            finally
            {

                Console.WriteLine("El bloque Finally se ejecuto");

            }

            return resultado;
        }
    }
}