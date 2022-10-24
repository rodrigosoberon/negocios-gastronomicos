using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class PatenteDAL
    {
        public static List<Patente> Listar()
        {
            string mCommandText = "SELECT * FROM Patente";
            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Patente> mPatentes = new List<Patente>();
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                Patente mPatente = new Patente();
                mPatente.IdPatente = int.Parse(mDataRow["IdPatente"].ToString());
                mPatente.Descripcion = mDataRow["Descripcion"].ToString();
                mPatente.DVH = int.Parse(mDataRow["DVH"].ToString());
                mPatentes.Add(mPatente);
            }
            return mPatentes;
        }
        public static int GuardarNuevo(Patente pPatente)
        {
            string mCommandText = "INSERT INTO Patente (Descripcion, DVH) VALUES ('" + pPatente.Descripcion + "', '" + pPatente.DVH + "'); SELECT CAST(scope_identity() AS int)";
            // Con scope_indetity() objtengo el ID creado
            DAO mDAO = new DAO();
            pPatente.IdPatente = mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pPatente.DVH = Verificacion.CalcularDVH(ConsultarRegistroPatente(pPatente.IdPatente).Tables[0]);
            Verificacion.AgregarDVH("Patente", pPatente.IdPatente, pPatente.DVH);
            int dvv = Verificacion.CalcularDVV("Patente");
            Verificacion.AgregarDVV("Patente", dvv);

            return pPatente.IdPatente;
        }
        
        public static DataSet ConsultarRegistroPatente(int idPatente)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM Patente WHERE IdPatente = " + idPatente;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static int Modificar(Patente pPatente)
        {
            string mCommandText = "UPDATE Patente SET Descripcion = '" + pPatente.Descripcion + "' WHERE IdPatente = " + pPatente.IdPatente;

            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pPatente.DVH = Verificacion.CalcularDVH(ConsultarRegistroPatente(pPatente.IdPatente).Tables[0]);
            Verificacion.AgregarDVH("Material", pPatente.IdPatente, pPatente.DVH);
            int dvv = Verificacion.CalcularDVV("Material");
            Verificacion.AgregarDVV("Material", dvv);

            return 1;
        }
        
        public static int Borrar(Patente pPatente)
        {
            string mCommandText = "DELETE FROM Patente WHERE IdPatente = " + pPatente.IdPatente;
            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);
            int dvv = Verificacion.CalcularDVV("Patente");
            Verificacion.AgregarDVV("Patente", dvv);
            return 1;
        }
    }
}
