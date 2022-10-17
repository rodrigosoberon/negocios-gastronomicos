using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAO
    {
        SqlConnection mConnection = new SqlConnection(@"Data Source=PREDATOR\SQLEXPRESS;Initial Catalog=NegociosGastronomicos; Integrated Security=True");

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
