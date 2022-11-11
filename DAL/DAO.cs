using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace DAL
{
    public class DAO
    {
        private static string Key = "5c69Ycj6rwdHOJbvfgt4mD50MM96Opxm"; //Clave de 32
        private static string IV = "dKho5jGR8nsqZswy"; //Vector de inicialización de 16

        SqlConnection mConnection = new SqlConnection(Seguridad.Desencriptar(ConfigurationManager.ConnectionStrings["myKey"].ConnectionString, Key, IV));
        public DataSet ExecuteDataSet(string pCommandText)
        {
            try
            {
                SqlDataAdapter mDataAdapter = new SqlDataAdapter(pCommandText, mConnection);
                DataSet mDataSet = new DataSet();
                mDataAdapter.Fill(mDataSet);
                return (mDataSet);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (mConnection.State != ConnectionState.Closed)
                    mConnection.Close();
            }
        }
        public int ExecuteScalar(string pCommandText)
        {
            // Ejecuta la query y devuelve el primer valor de la primera fila
            try
            {
                SqlCommand mCommand = new SqlCommand(pCommandText, mConnection);
                mConnection.Open();
                return Convert.ToInt32(mCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw (ex);
            }
            finally
            {
                if (mConnection.State != ConnectionState.Closed)
                    mConnection.Close();
            }
        }
    }
}
