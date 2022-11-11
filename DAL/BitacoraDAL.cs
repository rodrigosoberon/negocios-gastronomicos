using BE;
using System.Data;

namespace DAL
{
    public class BitacoraDAL
    {
        public static int AgregarBitacora(Bitacora pBitacora)
        {
            //Si el usuario es 0, inserto un NULL
            string usuario;
            if (pBitacora.Usuario == 0)
            {
                usuario = "NULL";
            }
            else
            {
                usuario = pBitacora.Usuario.ToString();
            }

            string mCommandText = "INSERT INTO Bitacora (Descripcion, Criticidad, Usuario, Fecha, DVH) values ('" + pBitacora.Descripcion + "', '" + pBitacora.Criticidad + "', " + usuario + ", '" + pBitacora.Fecha + "', '" + pBitacora.DVH + "'); SELECT CAST(scope_identity() AS int)";
            // Con scope_indetity() objtengo el ID creado
            DAO mDAO = new DAO();
            pBitacora.IdBitacora = mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pBitacora.DVH = Verificacion.CalcularDVH(ConsultarRegistroBitacora(pBitacora.IdBitacora).Tables[0]);
            Verificacion.AgregarDVH("Bitacora", pBitacora.IdBitacora, pBitacora.DVH);
            int dvv = Verificacion.CalcularDVV("Bitacora");
            Verificacion.AgregarDVV("Bitacora", dvv);

            return 1;
        }

        public static DataSet ConsultarRegistroBitacora(int IdBitacora)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM Bitacora WHERE IdBitacora = " + IdBitacora;
            DAO mDAO = new DAO();
            DataSet mDataSet =  mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }
    }
}
