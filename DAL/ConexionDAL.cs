using System;
using System.Data.SqlClient;
using System.IO;

namespace DAL
{
    public class ConexionDAL
    {
        private static string Key = "5c69Ycj6rwdHOJbvfgt4mD50MM96Opxm"; //Clave de 32
        private static string IV = "dKho5jGR8nsqZswy"; //Vector de inicialización de 16
        public static bool ValidarConexion()
        {




            try
            {
                StreamReader Archivo = new StreamReader(Path.Combine(Environment.CurrentDirectory, "stringConnection.txt"));
                string cadenaConexion = Archivo.ReadLine();
                Archivo.Close();
                SqlConnection mConnection = new SqlConnection(Seguridad.Desencriptar(cadenaConexion, Key, IV));
                mConnection.Open();
                mConnection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void ActualizarCadenaConexion(string nuevaCadena)
        {
            string cadenaEncriptada = Seguridad.Encriptar(nuevaCadena, Key, IV);
            StreamWriter Archivo = new StreamWriter(Path.Combine(Environment.CurrentDirectory, "stringConnection.txt"));
            Archivo.WriteLine(cadenaEncriptada);
            Archivo.Close();
        }
    }
}
