using BE;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class MaterialDAL
    {
        public static List<Material> Listar()
        {
            string mCommandText = "select Material.IdMaterial, Material.Descripcion, Material.Cantidad, Material.EnRequisicion from Material";

            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Material> mMateriales = new List<Material>();
            foreach(DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                Material mMaterial = new Material
                {
                    IdMaterial = int.Parse(mDataRow["IdMaterial"].ToString()),
                    Descripcion = mDataRow["Descripcion"].ToString(),
                    Cantidad = int.Parse(mDataRow["Cantidad"].ToString()),
                    EnRequisicion = bool.Parse(mDataRow["EnRequisicion"].ToString()),
                };
                mMateriales.Add(mMaterial);
            }
            return mMateriales;
        }
        public static int GuardarNuevo(Material pMaterial)
        {
            string mCommandText = "INSERT INTO Material (Descripcion, Cantidad, EnRequisicion, DVH) VALUES ('" + pMaterial.Descripcion + "', '" + pMaterial.Cantidad + "', '" + pMaterial.EnRequisicion + "', '" + pMaterial.DVH + "'); SELECT CAST(scope_identity() AS int)";
            // Con scope_indetity() objtengo el ID creado
            DAO mDAO = new DAO();
            pMaterial.IdMaterial = mDAO.ExecuteScalar(mCommandText);
            
            //Verificadores
            pMaterial.DVH = Verificacion.CalcularDVH(ConsultarRegistroMaterial(pMaterial.IdMaterial).Tables[0]);
            Verificacion.AgregarDVH("Material", pMaterial.IdMaterial, pMaterial.DVH);
            int dvv = Verificacion.CalcularDVV("Material");
            Verificacion.AgregarDVV("Material", dvv);

            return pMaterial.IdMaterial;
        }
        
        public static DataSet ConsultarRegistroMaterial(int idMaterial)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM Material WHERE IdMaterial = " + idMaterial;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static int Modificar(Material pMaterial)
        {
            string mCommandText = "UPDATE Material SET Descripcion = '" + pMaterial.Descripcion + "', Cantidad = '" + pMaterial.Cantidad + "', EnRequisicion = '" + pMaterial.EnRequisicion + "' WHERE IdMaterial = " + pMaterial.IdMaterial;
            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);
            
            //Verificadores
            pMaterial.DVH = Verificacion.CalcularDVH(ConsultarRegistroMaterial(pMaterial.IdMaterial).Tables[0]);
            Verificacion.AgregarDVH("Material", pMaterial.IdMaterial, pMaterial.DVH);
            int dvv = Verificacion.CalcularDVV("Material");
            Verificacion.AgregarDVV("Material", dvv);

            return 1;
        }

        public static int Borrar(Material pMaterial)
        {
            
            string mCommandText = "DELETE FROM Material WHERE IdMaterial = " + pMaterial.IdMaterial;
            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);
            int dvv = Verificacion.CalcularDVV("Material");
            Verificacion.AgregarDVV("Material", dvv);
            return 1;
        }
    }
}
