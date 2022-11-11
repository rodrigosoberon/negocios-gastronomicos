using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class FamiliaDAL
    {
        public static List<Familia> Listar()
        {
            string mCommandText = "SELECT * FROM Familia";
            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Familia> mFamilias = new List<Familia>();
            foreach (DataRow dataRow in mDataSet.Tables[0].Rows)
            {
                Familia mFamilia = new Familia();
                mFamilia.IdFamilia = int.Parse(dataRow["IdFamilia"].ToString());
                mFamilia.Descripcion = dataRow["Descripcion"].ToString();
                mFamilia.DVH = int.Parse(dataRow["DVH"].ToString());
                ObtenerAsignados(mFamilia);
                mFamilias.Add(mFamilia);                
            }
            return mFamilias;
        }

        public static void ObtenerAsignados(Familia pFamilia) {
            string mCommandText = "SELECT * FROM FamPat WHERE IdFamilia = " + pFamilia.IdFamilia;
            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                foreach(Patente mPatente in PatenteDAL.Listar()){
                    if (int.Parse(mDataRow["IdPatente"].ToString()) == mPatente.IdPatente)
                    {
                        pFamilia.mPatentes.Add(mPatente);
                    }
                }
            }
        }

        public static int GuardarNuevo(Familia pFamilia)
        {
            string mCommandText = "INSERT INTO Familia (Descripcion, DVH) VALUES ('" + pFamilia.Descripcion + "', '" + pFamilia.DVH + "'); SELECT CAST(scope_identity() AS int)";
            // Con scope_indetity() objtengo el ID creado
            DAO mDAO = new DAO();
            pFamilia.IdFamilia = mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pFamilia.DVH = Verificacion.CalcularDVH(ConsultarRegistroFamilia(pFamilia.IdFamilia).Tables[0]);
            Verificacion.AgregarDVH("Familia", pFamilia.IdFamilia, pFamilia.DVH);
            int dvv = Verificacion.CalcularDVV("Familia");
            Verificacion.AgregarDVV("Familia", dvv);

            return pFamilia.IdFamilia;
        }

        public static DataSet ConsultarRegistroFamilia(int idFamilia)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM Familia WHERE IdFamilia = " + idFamilia;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static DataSet ConsultarRegistroFamPat(int idFamilia, int idPatente)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM FamPat WHERE IdFamilia = " + idFamilia + " AND IdPatente = " + idPatente;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static int Modificar(Familia pFamilia)
        {
            string mCommandText = "UPDATE Familia SET Descripcion = '" + pFamilia.Descripcion + "' WHERE IdFamilia = " + pFamilia.IdFamilia;

            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pFamilia.DVH = Verificacion.CalcularDVH(ConsultarRegistroFamilia(pFamilia.IdFamilia).Tables[0]);
            Verificacion.AgregarDVH("Familia", pFamilia.IdFamilia, pFamilia.DVH);
            int dvv = Verificacion.CalcularDVV("Familia");
            Verificacion.AgregarDVV("Familia", dvv);

            return 1;
        }

        public static int Borrar(Familia pFamilia)
        {
            string mCommandText;
            DAO mDAO = new DAO();
            int dvv;
            
            //Elimino relaciones con Usuarios
            mCommandText = "DELETE FROM FamUsu WHERE IdFamilia = " + pFamilia.IdFamilia;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("FamUsu");
            Verificacion.AgregarDVV("FamUsu", dvv);

            //Elimino relaciones con Patentes
            mCommandText = "DELETE FROM FamPat WHERE IdFamilia = " + pFamilia.IdFamilia;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("FamPat");
            Verificacion.AgregarDVV("FamPat", dvv);

            //Elimino la Familia
            mCommandText = "DELETE FROM Familia WHERE IdFamilia = " + pFamilia.IdFamilia;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("Familia");
            Verificacion.AgregarDVV("Familia", dvv);
            return 1;
        }

        public static int Asignar(Familia pFamilia, Patente pPatente)
        {
            DAO mDAO = new DAO();
            string mCommandText = "INSERT INTO FamPat (IdFamilia, IdPatente, DVH) VALUES (" + pFamilia.IdFamilia + ", " + pPatente.IdPatente + ", 1)";
            

            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            int DVH = Verificacion.CalcularDVH(ConsultarRegistroFamPat(pFamilia.IdFamilia, pPatente.IdPatente).Tables[0]);
            Verificacion.AgregarDVH("FamPat", "IdFamilia", "IdPatente", pFamilia.IdFamilia, pPatente.IdPatente, DVH);
            int DVV = Verificacion.CalcularDVV("FamPat");
            Verificacion.AgregarDVV("FamPat", DVV);

            return 1;
        }

        public static int Desasignar(Familia pFamilia, Patente pPatente)
        {
            DAO mDAO = new DAO();
            string mCommandText = "DELETE FROM FamPat WHERE IdFamilia = " + pFamilia.IdFamilia + " AND IdPatente = " + pPatente.IdPatente;
            mDAO.ExecuteScalar(mCommandText);
            int DVV = Verificacion.CalcularDVV("FamPat");
            Verificacion.AgregarDVV("FamPat", DVV);
            return 1;
        }
        
    }
}
