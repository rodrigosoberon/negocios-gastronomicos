using BE;
using System;
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
            string mCommandText;
            DAO mDAO = new DAO();
            int dvv;

            //Elimino relaciones con Familias
            mCommandText = "DELETE FROM FamPat WHERE IdPatente = " + pPatente.IdPatente;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("FamPat");
            Verificacion.AgregarDVV("FamPat", dvv);

            //Elimino relaciones con Usuarios
            mCommandText = "DELETE FROM PatUsu WHERE IdPatente = " + pPatente.IdPatente;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("PatUsu");
            Verificacion.AgregarDVV("PatUsu", dvv);

            //Elimino la patente
            mCommandText = "DELETE FROM Patente WHERE IdPatente = " + pPatente.IdPatente;
            mDAO.ExecuteScalar(mCommandText);
            dvv = Verificacion.CalcularDVV("Patente");
            Verificacion.AgregarDVV("Patente", dvv);

            return 1;
        }

        public static bool PatenteAsignada(Usuario pUsuario, Patente pPatente)
        {
            DAO mDAO = new DAO();
            //List<int> usuariosConLaPatente = new List<int>();

            bool asignada = false;

            //Compruebo si hay otros usuarios habilitados con la patente asignada directamente
            string mCommandText = "SELECT * FROM PatUsu INNER JOIN Usuario ON PatUsu.IdUsuario = Usuario.IdUsuario WHERE PatUsu.IdPatente = " + pPatente.IdPatente + " AND Usuario.Estado = 1 AND PatUsu.IdUsuario != " + pUsuario.IdUsuario;
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                asignada= true;
            }


            //Compruebo si hay otros usuarios que tengan la patante a traves de una familia
            mCommandText = "SELECT * FROM FamPat WHERE IdPatente = '" + pPatente.IdPatente + "'";
            mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                //Loopeo cada famila que contenga la patente
                string mCommandText2 = "SELECT * FROM FamUsu INNER JOIN Usuario ON FamUsu.IdUsuario = Usuario.IdUsuario WHERE FamUsu.IdFamilia = " + mDataRow["IdFamilia"].ToString() + " AND Usuario.Estado = 1 AND FamUsu.IdUsuario != " + pUsuario.IdUsuario;
                //string mCommandText2 = "SELECT * FROM FamUsu INNER JOIN Usuario ON FamUsu.IdUsuario = Usuario.IdUsuario WHERE FamUsu.IdFamilia = " + mDataRow["IdFamilia"].ToString() + " AND Usuario.Estado = 1 ";
                DataSet famUsuDS = mDAO.ExecuteDataSet(mCommandText2);
                foreach (DataRow famUsuDR in famUsuDS.Tables[0].Rows)
                {
                    //Agrego los usuarios habilitados con la familia asignada -NO-
                    //usuariosConLaPatente.Add(Int32.Parse(famUsuDR["IdUsuario"].ToString()));


                    asignada = true;
                }
            }

            return asignada;


            //Elimino usuarios repetidos de la lista

            //Hace falta elimnar los repetidos?? 
            //usuariosConLaPatente = usuariosConLaPatente.Distinct().ToList();


            //Si hay mas de dos usuarios relacionados a la patente, considero que se puede desasignar
            //if (usuariosConLaPatente.Count > 1)
            //{
            //    return true;
            //}
            //else
            //{
            //    //Valido si esta incluida en una familia asignada a un usuario habilitado

            //    return false;
            //}

        }

        public static bool PatenteAsignada(Patente pPatente)
        {
            DAO mDAO = new DAO();
            bool asignada = false;
            List<int> usuariosConLaPatente = new List<int>();

            //Compruebo si hay usuarios habilitados con la patente asignada directamente
            string mCommandText = "SELECT * FROM PatUsu INNER JOIN Usuario ON PatUsu.IdUsuario = Usuario.IdUsuario WHERE PatUsu.IdPatente = " + pPatente.IdPatente + " AND Usuario.Estado = 1 ";
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                usuariosConLaPatente.Add(Int32.Parse(mDataRow["IdUsuario"].ToString()));
            }


            //Compruebo si hay otros usuarios que tengan la patante a traves de una familia
            mCommandText = "SELECT * FROM FamPat WHERE IdPatente = '" + pPatente.IdPatente + "'";
            mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                //Loopeo cada famila que contenga la patente
                string mCommandText2 = "SELECT * FROM FamUsu INNER JOIN Usuario ON FamUsu.IdUsuario = Usuario.IdUsuario WHERE FamUsu.IdFamilia = " + mDataRow["IdFamilia"].ToString() + " AND Usuario.Estado = 1";
                DataSet famUsuDS = mDAO.ExecuteDataSet(mCommandText2);
                foreach (DataRow famUsuDR in famUsuDS.Tables[0].Rows)
                {
                    //Agrego los usuarios habilitados con la familia asignada
                    usuariosConLaPatente.Add(Int32.Parse(famUsuDR["IdUsuario"].ToString()));

                }
            }

            //Elimino usuarios repetidos de la lista

            //Hace falta elimnar los repetidos?? 
            //usuariosConLaPatente = usuariosConLaPatente.Distinct().ToList();


            //Si hay mas de dos usuarios relacionados a la patente, considero que se puede desasignar
            if (usuariosConLaPatente.Count > 1)
            {
                return true;
            }
            else
            {
                //Valido si esta incluida en una familia asignada a un usuario habilitado
                return false;
            }
        }

        public static bool PatenteAsignadaDirecta(Patente pPatente)
        {
            DAO mDAO = new DAO();
            //Devuelve true si la patente esta asociada a uno o mas usuarios activos
            bool asignada = true;
            string mCommandText = "SELECT * FROM PatUsu INNER JOIN Usuario ON PatUsu.IdUsuario = Usuario.IdUsuario WHERE PatUsu.IdPatente = " + pPatente.IdPatente + " AND Usuario.Estado = 1";
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            if (mDataSet.Tables[0].Rows.Count < 1)
            {
                asignada = false;
            }
            return asignada;
        }
    }
}
