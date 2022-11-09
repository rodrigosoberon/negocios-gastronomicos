using System.Data;
using System.Linq;
using System.Text;

namespace DAL
{
    public class Verificacion
    {
        public static int CalcularDVH(DataTable pDataTable)
        {
            string cadena = "";
            int cantidadCampos = pDataTable.Columns.Count;
            int contador = 0;

            while (contador < cantidadCampos - 1) //con -1 ignoro campo DVH
            {
                cadena += pDataTable.Rows[0][contador].ToString();
                contador++;
            }


            int sumaCaracteresASCII = 0;

            for (int i = 0; i < Encoding.ASCII.GetBytes(cadena.ToString()).Count(); i++)
            {
                sumaCaracteresASCII += (Encoding.ASCII.GetBytes(cadena.ToString())[i]) * i;
            }

            return sumaCaracteresASCII;
        }


        public static int AgregarDVH(string nombreTabla, int id, int dvh)
        {
            string mCommandText = "update " + nombreTabla + " set DVH = " + dvh + " where id" + nombreTabla + "=" + id;
            DAO mDAO = new DAO();
            return mDAO.ExecuteScalar(mCommandText);
        }

        public static int AgregarDVH(string nombreTabla, string key1, string key2, int id1, int id2, int dvh)
        {
            {
                string mCommandText = "update " + nombreTabla + " set DVH = " + dvh + " where " + key1 + " = " + id1 + " and " + key2 + " = " + id2;
                DAO mDAO = new DAO();
                return mDAO.ExecuteScalar(mCommandText);
            }
        }

        public static int CalcularDVV(string nombreTabla)
        {
            string mCommandText = "select DVH from " + nombreTabla;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            int sumaDVH = 0;
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                sumaDVH += int.Parse(mDataRow["DVH"].ToString());
            }
            return sumaDVH;
        }

        public static int AgregarDVV(string nombreTabla, int dvv)
        {
            string mCommandText = "update DigitoVerificador set DVV = " + dvv + " where NombreTabla = '" + nombreTabla + "'";
            DAO mDAO = new DAO();
            return mDAO.ExecuteScalar(mCommandText);
        }

        public static bool VerificarIntegridad()
        {
            bool resultado = true;
            DAO mDAO = new DAO();
            string mCommandText = "SELECT * from DigitoVerificador";
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {

                //Verificación de DVV
                int DVVCalculado = CalcularDVV(mDataRow["NombreTabla"].ToString());
                if (DVVCalculado != int.Parse(mDataRow["DVV"].ToString()))
                {
                    AgregarDVV(mDataRow["NombreTabla"].ToString(), DVVCalculado);
                    
                    //REGISTRAR ACTIVIDAD EN BITACORA!

                    resultado = false;
                }

                //Verificación de DVH
                mCommandText = "SELECT * FROM " + mDataRow["NombreTabla"].ToString();
                DataSet dataSetTabla = mDAO.ExecuteDataSet(mCommandText);
                foreach (DataRow dataRow in dataSetTabla.Tables[0].Rows)
                {
                    DataTable registro = dataSetTabla.Tables[0].Copy();
                    registro.Rows.Clear();
                    registro.ImportRow(dataRow);
                    //Genero un nuevo DataTable solo con el registro a verificar
                    int DVHCalculado = CalcularDVH(registro);
                    int DVHEnTabla = int.Parse(dataRow["DVH"].ToString());
                    if (DVHCalculado != DVHEnTabla){
                        string nombreCampoId = "Id" + mDataRow["NombreTabla"].ToString();
                        int id = int.Parse(dataRow[nombreCampoId].ToString());
                        AgregarDVH(mDataRow["NombreTabla"].ToString(), id, DVHCalculado);

                        //REGISTRAR ACTIVIDAD EN BITACORA!
                        resultado = false;
                    }

                }
            }

            return resultado;
        }
    }
}
