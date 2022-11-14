using BE;
using System.Collections.Generic;
using System.Data;


namespace DAL
{
    public class PlatoDAL
    {
        public static List<Plato> Listar()
        {
            string mCommandText = "SELECT * FROM Plato";
            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Plato> mPlatos = new List<Plato>();
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                Plato mPlato = new Plato();
                mPlato.IdPlato = int.Parse(mDataRow["IdPlato"].ToString());
                mPlato.Descripcion = mDataRow["Descripcion"].ToString();
                mPlato.Importe = float.Parse(mDataRow["Importe"].ToString());
                mPlato.DVH = int.Parse(mDataRow["DVH"].ToString());
                ObtenerMateriales(mPlato);
                mPlatos.Add(mPlato);
            }

            return mPlatos;
        }

        public static void ObtenerMateriales(Plato pPlato)
        {
            string mCommandText = "SELECT * FROM PlatMat WHERE IdPlato = " + pPlato.IdPlato;
            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                foreach (Material mMaterial in MaterialDAL.Listar())
                {
                    if (int.Parse(mDataRow["IdMaterial"].ToString()) == mMaterial.IdMaterial)
                    {
                        pPlato.Materiales.Add(mMaterial);
                    }
                }
            }
        }

        public static int GuardarNuevo(Plato pPlato)
        {
            string mCommandText = "INSERT INTO Plato (Descripcion, Importe, DVH) VALUES ('" + pPlato.Descripcion + "', '" + pPlato.Importe + "', '" + pPlato.DVH + "'); SELECT CAST(scope_identity() AS int)";
            // Con scope_indetity() objtengo el ID creado
            DAO mDAO = new DAO();
            pPlato.IdPlato = mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pPlato.DVH = Verificacion.CalcularDVH(ConsultarRegistroPlato(pPlato.IdPlato).Tables[0]);
            Verificacion.AgregarDVH("Plato", pPlato.IdPlato, pPlato.DVH);
            int dvv = Verificacion.CalcularDVV("Plato");
            Verificacion.AgregarDVV("Plato", dvv);

            return pPlato.IdPlato;
        }

        public static int Modificar(Plato pPlato)
        {
            string mCommandText = "UPDATE Plato SET Descripcion = '" + pPlato.Descripcion + "' WHERE IdPlato = " + pPlato.IdPlato;

            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pPlato.DVH = Verificacion.CalcularDVH(ConsultarRegistroPlato(pPlato.IdPlato).Tables[0]);
            Verificacion.AgregarDVH("Plato", pPlato.IdPlato, pPlato.DVH);
            int dvv = Verificacion.CalcularDVV("Plato");
            Verificacion.AgregarDVV("Plato", dvv);

            return 1;
        }

        public static int Borrar(Plato pPlato)
        {
            string mCommandText;
            DAO mDAO = new DAO();
            int dvv;

            //Elimino relaciones con Materiales
            mCommandText = "DELETE FROM PlatMat WHERE IdPlato = " + pPlato.IdPlato;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("PlatMat");
            Verificacion.AgregarDVV("PlatMat", dvv);

            //Elimino el Plato
            mCommandText = "DELETE FROM Plato WHERE IdPlato = " + pPlato.IdPlato;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("Plato");
            Verificacion.AgregarDVV("Plato", dvv);
            return 1;
        }

        public static int Incluir(Plato pPlato, Material pMaterial)
        {
            DAO mDAO = new DAO();
            string mCommandText = "INSERT INTO PlatMat (IdPlato, IdMaterial, DVH) VALUES (" + pPlato.IdPlato + ", " + pMaterial.IdMaterial + ", 1)";
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            int DVH = Verificacion.CalcularDVH(ConsultarRegistroPlatMat(pPlato.IdPlato, pMaterial.IdMaterial).Tables[0]);
            Verificacion.AgregarDVH("PlatMat", "IdPlato", "IdMaterial", pPlato.IdPlato, pMaterial.IdMaterial, DVH);
            int DVV = Verificacion.CalcularDVV("PlatMat");
            Verificacion.AgregarDVV("PlatMat", DVV);

            return 1;
        }

        public static int Quitar(Plato pPlato, Material pMaterial)
        {
            DAO mDAO = new DAO();
            string mCommandText = "DELETE FROM PlatMat WHERE IdPlato = " + pPlato.IdPlato + " AND IdMaterial = " + pMaterial.IdMaterial;
            mDAO.ExecuteScalar(mCommandText);
            int DVV = Verificacion.CalcularDVV("PlatMat");
            Verificacion.AgregarDVV("PlatMat", DVV);
            return 1;
        }

        public static DataSet ConsultarRegistroPlato(int idPlato)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM Plato WHERE IdPlato = " + idPlato;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static DataSet ConsultarRegistroPlatMat(int idPlato, int idMaterial)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM PlatMat WHERE IdPlato = " + idPlato + " AND IdMaterial = " + idMaterial;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

    }
}
