using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MensajeDAL
    {
        public static List<Mensaje> Listar(string pIdioma)
        {
            string mCommandText = "SELECT * FROM Mensaje WHERE Idioma = '" + pIdioma + "'";
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Mensaje> mMensajes = new List<Mensaje>();
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                Mensaje mMensaje = new Mensaje
                {
                    IdMensaje = int.Parse(mDataRow["IdMensaje"].ToString()),
                    Idioma = mDataRow["Idioma"].ToString(),
                    Nombre = mDataRow["Nombre"].ToString(),
                    Texto = mDataRow["Texto"].ToString(),
                };
                mMensajes.Add(mMensaje);
            }
            return mMensajes;
        }
    }
}
