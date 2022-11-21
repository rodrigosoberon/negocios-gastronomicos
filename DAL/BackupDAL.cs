using BE;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class BackupDAL
    {
        private static string Key = "5c69Ycj6rwdHOJbvfgt4mD50MM96Opxm"; //Clave de 32
        private static string IV = "dKho5jGR8nsqZswy"; //Vector de inicialización de 16
        public static List<Backup> Listar()
        {
            string mCommandText = "SELECT * FROM Resguardo";
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Backup> mBackups = new List<Backup>();
            foreach (DataRow dataRow in mDataSet.Tables[0].Rows)
            {
                Backup mBackup = new Backup();
                mBackup.IdResguardo = int.Parse(dataRow["IdResguardo"].ToString());
                mBackup.Usuario = ObtenerUsuario(int.Parse(dataRow["IdUsuario"].ToString()));
                mBackup.Descripcion = dataRow["Descripcion"].ToString();
                mBackup.Creado = (DateTime)dataRow["Creado"];
                mBackup.Particiones = int.Parse(dataRow["Particiones"].ToString());
                mBackup.Ubicacion = dataRow["Ubicacion"].ToString();
                mBackups.Add(mBackup);
            }

            return mBackups;
        }

        public static Usuario ObtenerUsuario(int IdUsuario)
        {
            Usuario mUsuario = new Usuario();

            DataSet mDataSet = UsuarioDAL.ConsultarRegistro(IdUsuario);
            DataRow mDataRow = mDataSet.Tables[0].Rows[0];
            mUsuario.IdUsuario = IdUsuario;
            mUsuario.NombreUsuario = mDataRow["NombreUsuario"].ToString();
            mUsuario.Nombre = Seguridad.Desencriptar(mDataRow["Nombre"].ToString(), Key, IV);
            mUsuario.Apellido = Seguridad.Desencriptar(mDataRow["Apellido"].ToString(), Key, IV);
            mUsuario.Email = Seguridad.Desencriptar(mDataRow["Email"].ToString(), Key, IV);
            mUsuario.Idioma = mDataRow["Idioma"].ToString();
            mUsuario.Estado = bool.Parse(mDataRow["Estado"].ToString());
            
            return mUsuario;
        }
        public static int Resguardar(Backup pBackup)
        {
            int numeroParticion = 1;
            string mCommandText = "BACKUP DATABASE NegociosGastronomicos "; 
            
            if(pBackup.Particiones == 1)
            {
                mCommandText += "TO DISK = '" + pBackup.Ubicacion + @"\" + pBackup.Descripcion + ".bak' ";
            }
            else
            {
                while (numeroParticion < pBackup.Particiones + 1)
                {
                    if (numeroParticion == 1)
                    {
                        mCommandText += "TO DISK = '" + pBackup.Ubicacion + @"\" + pBackup.Descripcion + "-" + numeroParticion + ".bak'";
                    }
                    else
                    {
                        mCommandText += ", DISK = '" + pBackup.Ubicacion + @"\" + pBackup.Descripcion + "-" + numeroParticion + ".bak'";
                    }
                    numeroParticion++;
                }
            }
            
            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);
            return 1;
        }

        public static int GuardarBackup(Backup pBackup)
        {
            string mCommandText = "INSERT INTO Resguardo (IdUsuario, Descripcion, Creado, Particiones, Ubicacion, DVH) VALUES ('" + pBackup.Usuario.IdUsuario + "', '" + pBackup.Descripcion + "', '" + pBackup.Creado + "', '" + pBackup.Particiones + "', '" + pBackup.Ubicacion + "', '1'); SELECT CAST(scope_identity() AS int)";
            // Con scope_indetity() objtengo el ID creado
            DAO mDAO = new DAO();
            pBackup.IdResguardo = mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pBackup.DVH = Verificacion.CalcularDVH(ConsultarRegistroBackup(pBackup.IdResguardo).Tables[0]);
            Verificacion.AgregarDVH("Resguardo", pBackup.IdResguardo, pBackup.DVH);
            int dvv = Verificacion.CalcularDVV("Resguardo");
            Verificacion.AgregarDVV("Resguardo", dvv);
            
            return 1;
        }

        public static DataSet ConsultarRegistroBackup(int idBackup)
        {
            string mCommandText = "SELECT * FROM Resguardo WHERE IdResguardo = " + idBackup;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static int Restaurar(Backup pBackup)
        {
            string mCommandText = "USE master; RESTORE DATABASE NegociosGastronomicos ";
            int numeroParticion = 1;

            if (pBackup.Particiones == 1)
            {
                mCommandText += "FROM DISK = '" + pBackup.Ubicacion + @"\" + pBackup.Descripcion + ".bak' ";
            }
            else
            {
                while (numeroParticion < pBackup.Particiones + 1)
                {
                    if (numeroParticion == 1)
                    {
                        mCommandText += "FROM DISK = '" + pBackup.Ubicacion + @"\" + pBackup.Descripcion + "-" + numeroParticion + ".bak'";
                    }
                    else
                    {
                        mCommandText += ", DISK = '" + pBackup.Ubicacion + @"\" + pBackup.Descripcion + "-" + numeroParticion + ".bak'";
                    }
                    numeroParticion++;
                }
            }


            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);
            return 1;
        }
    }
}
