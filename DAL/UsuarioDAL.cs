using BE;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAL
{
    public class UsuarioDAL
    {

        private static string Key = "5c69Ycj6rwdHOJbvfgt4mD50MM96Opxm"; //Clave de 32
        private static string IV = "dKho5jGR8nsqZswy"; //Vector de inicialización de 16


        public static List<Usuario> Listar()
        {
            string mCommandText = "SELECT * FROM Usuario";
            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Usuario> mUsuarios = new List<Usuario>();
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                Usuario mUsuario = new Usuario
                {
                    IdUsuario = int.Parse(mDataRow["IdUsuario"].ToString()),
                    NombreUsuario = Seguridad.Desencriptar(mDataRow["NombreUsuario"].ToString(), Key, IV),
                    Nombre = Seguridad.Desencriptar(mDataRow["Nombre"].ToString(), Key, IV),
                    Apellido = Seguridad.Desencriptar(mDataRow["Apellido"].ToString(), Key, IV),
                    Email = Seguridad.Desencriptar(mDataRow["Email"].ToString(), Key, IV),
                    Idioma = mDataRow["Idioma"].ToString(),
                    Estado = bool.Parse(mDataRow["Estado"].ToString()),

                };
                ObtenerFamilias(mUsuario);
                ObtenerPatentes(mUsuario);
                mUsuarios.Add(mUsuario);
            }
            return mUsuarios;
        }

        public static int GuardarNuevo(Usuario pUsuario)
        {
            string passwordEncriptado = Seguridad.EncriptarNR(pUsuario.Password);
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);
            string nombreEncriptado = Seguridad.Encriptar(pUsuario.Nombre, Key, IV);
            string apellidoEncriptado = Seguridad.Encriptar(pUsuario.Apellido, Key, IV);
            string emailEncriptado = Seguridad.Encriptar(pUsuario.Email, Key, IV);

            string mCommandText = "INSERT INTO Usuario (NombreUsuario, Password, Nombre, Apellido, Email, Idioma, Estado, Intentos, DVH) VALUES ('" + nombreUsuarioEncriptado + "', '" + passwordEncriptado + "', '" + nombreEncriptado + "', '" + apellidoEncriptado + "', '" + emailEncriptado + "', '" + pUsuario.Idioma + "', '" + pUsuario.Estado + "', '" + pUsuario.Intentos + "', '" + pUsuario.DVH + "'); SELECT CAST(scope_identity() AS int)";
            // Con scope_indetity() objtengo el ID creado
            DAO mDAO = new DAO();
            pUsuario.IdUsuario = mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pUsuario.DVH = Verificacion.CalcularDVH(ConsultarRegistro(pUsuario.IdUsuario).Tables[0]);
            Verificacion.AgregarDVH("Usuario", pUsuario.IdUsuario, pUsuario.DVH);
            int dvv = Verificacion.CalcularDVV("Usuario");
            Verificacion.AgregarDVV("Usuario", dvv);

            return pUsuario.IdUsuario;
        }

        public static void ObtenerFamilias(Usuario pUsuario)
        {
            string mCommandText = "SELECT * FROM FamUsu WHERE IdUsuario = " + pUsuario.IdUsuario;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                foreach (Familia mFamilia in FamiliaDAL.Listar())
                {
                    if (int.Parse(mDataRow["IdFamilia"].ToString()) == mFamilia.IdFamilia)
                    {
                        pUsuario.mFamilias.Add(mFamilia);
                    }
                }
            }
        }

        public static List<Patente> ObtenerPatentes(Usuario pUsuario)
        {
            string mCommandText = "SELECT * FROM PatUsu WHERE IdUsuario = " + pUsuario.IdUsuario;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            foreach (DataRow mDataRow in mDataSet.Tables[0].Rows)
            {
                foreach (Patente mPatente in PatenteDAL.Listar())
                {
                    if (int.Parse(mDataRow["IdPatente"].ToString()) == mPatente.IdPatente)
                    {
                        pUsuario.mPatentes.Add(mPatente);
                    }
                }
            }

            return pUsuario.mPatentes;
        }

        public static DataSet ConsultarRegistro(int idUsuario)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM Usuario WHERE IdUsuario = " + idUsuario;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static int Modificar(Usuario pUsuario)
        {
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);
            pUsuario.Nombre = Seguridad.Encriptar(pUsuario.Nombre, Key, IV);
            pUsuario.Apellido = Seguridad.Encriptar(pUsuario.Apellido, Key, IV);
            pUsuario.Email = Seguridad.Encriptar(pUsuario.Email, Key, IV);

            string mCommandText = "UPDATE Usuario SET NombreUsuario = '" + nombreUsuarioEncriptado + "', Nombre = '" + pUsuario.Nombre + "', Apellido = '" + pUsuario.Apellido + "', Email = '" + pUsuario.Email + "', Idioma = '" + pUsuario.Idioma + "', Estado = '" + pUsuario.Estado + "' WHERE IdUsuario = " + pUsuario.IdUsuario;

            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pUsuario.DVH = Verificacion.CalcularDVH(ConsultarRegistro(pUsuario.IdUsuario).Tables[0]);
            Verificacion.AgregarDVH("Usuario", pUsuario.IdUsuario, pUsuario.DVH);
            int dvv = Verificacion.CalcularDVV("Usuario");
            Verificacion.AgregarDVV("Usuario", dvv);

            return 1;
        }

        public static int CambiarEstado(Usuario pUsuario)
        {

            string mCommandText = "UPDATE Usuario SET Estado = '" + pUsuario.Estado + "' WHERE IdUsuario = " + pUsuario.IdUsuario;

            DAO mDAO = new DAO();
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pUsuario.DVH = Verificacion.CalcularDVH(ConsultarRegistro(pUsuario.IdUsuario).Tables[0]);
            Verificacion.AgregarDVH("Usuario", pUsuario.IdUsuario, pUsuario.DVH);
            int dvv = Verificacion.CalcularDVV("Usuario");
            Verificacion.AgregarDVV("Usuario", dvv);

            return 1;
        }

        public static int AsignarFamilia(Usuario pUsuario, Familia pFamilia)
        {
            DAO mDAO = new DAO();
            string mCommandText = "INSERT INTO FamUsu (IdFamilia, IdUsuario, DVH) VALUES (" + pFamilia.IdFamilia + ", " + pUsuario.IdUsuario + ", 1)";
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            int DVH = Verificacion.CalcularDVH(ConsultarRegistroFamUsu(pFamilia.IdFamilia, pUsuario.IdUsuario).Tables[0]);
            Verificacion.AgregarDVH("FamUsu", "IdFamilia", "IdUsuario", pFamilia.IdFamilia, pUsuario.IdUsuario, DVH);
            int DVV = Verificacion.CalcularDVV("FamUsu");
            Verificacion.AgregarDVV("FamUsu", DVV);


            return 1;
        }

        public static int RemoverFamilia(Usuario pUsuario, Familia pFamilia)
        {
            DAO mDAO = new DAO();
            string mCommandText = "DELETE FROM FamUsu WHERE IdFamilia = " + pFamilia.IdFamilia + " AND IdUsuario = " + pUsuario.IdUsuario;
            mDAO.ExecuteScalar(mCommandText);
            int DVV = Verificacion.CalcularDVV("FamUsu");
            Verificacion.AgregarDVV("FamUsu", DVV);

            return 1;
        }

        public static int AsignarPatente(Usuario pUsuario, Patente pPatente)
        {
            DAO mDAO = new DAO();
            string mCommandText = "INSERT INTO PatUsu (IdPatente, IdUsuario, DVH) VALUES (" + pPatente.IdPatente + ", " + pUsuario.IdUsuario + ", 1)";
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            int DVH = Verificacion.CalcularDVH(ConsultarRegistroPatUsu(pPatente.IdPatente, pUsuario.IdUsuario).Tables[0]);
            Verificacion.AgregarDVH("PatUsu", "IdPatente", "IdUsuario", pPatente.IdPatente, pUsuario.IdUsuario, DVH);
            int DVV = Verificacion.CalcularDVV("PatUsu");
            Verificacion.AgregarDVV("PatUsu", DVV);
            return 1;
        }

        public static int RemoverPatente(Usuario pUsuario, Patente pPatente)
        {
            DAO mDAO = new DAO();
            string mCommandText = "DELETE FROM PatUsu WHERE IdPatente = " + pPatente.IdPatente + " AND IdUsuario = " + pUsuario.IdUsuario;
            mDAO.ExecuteScalar(mCommandText);
            int DVV = Verificacion.CalcularDVV("PatUsu");
            Verificacion.AgregarDVV("PatUsu", DVV);

            return 1;
        }

        public static DataSet ConsultarRegistroFamUsu(int idFamilia, int idUsuario)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM FamUsu WHERE IdFamilia = " + idFamilia + " AND IdUsuario = " + idUsuario;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        public static DataSet ConsultarRegistroPatUsu(int idPatente, int idUsuario)
        {
            //Consulto por un registro en particular para calculcar su DVH
            string mCommandText = "SELECT * FROM PatUsu WHERE IdPatente = " + idPatente + " AND IdUsuario = " + idUsuario;
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            return mDataSet;
        }

        //LOGIN
        public static bool ValidarCredenciales(Usuario pUsuario)
        {
            pUsuario.Password = Seguridad.EncriptarNR(pUsuario.Password);
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);

            string mCommandText = "SELECT * FROM Usuario WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "' AND Password = '" + pUsuario.Password + "'";
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            if (mDataSet.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarEstado(Usuario pUsuario)
        {
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);
            string mCommandText = "SELECT * FROM Usuario WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "' AND Estado = 1";
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            if (mDataSet.Tables[0].Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int ObtenerIntentos(Usuario pUsuario)
        {
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);
            string mCommandText = "SELECT * FROM Usuario WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "'";
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);

            if (mDataSet.Tables[0].Rows.Count > 0)
            {
                return Int32.Parse(mDataSet.Tables[0].Rows[0]["Intentos"].ToString());
            }
            else
            {
                return 1;
            }
        }

        public static int ActualizarIntentos(Usuario pUsuario)
        {
            
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);
            DAO mDAO = new DAO();
            string mCommandText = "SELECT * FROM Usuario WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "'";
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);

            //Solo actualizo contador de intentos si el usuario ingresado existe
            if (mDataSet.Tables[0].Rows.Count > 0)
            {
                pUsuario.IdUsuario = Int32.Parse(mDataSet.Tables[0].Rows[0]["IdUsuario"].ToString());
                mCommandText = "UPDATE Usuario SET Intentos = " + pUsuario.Intentos + " WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "'";
                mDAO.ExecuteScalar(mCommandText);

                //Verificadores
                pUsuario.DVH = Verificacion.CalcularDVH(ConsultarRegistro(pUsuario.IdUsuario).Tables[0]);
                Verificacion.AgregarDVH("Usuario", pUsuario.IdUsuario, pUsuario.DVH);
                int dvv = Verificacion.CalcularDVV("Usuario");
                Verificacion.AgregarDVV("Usuario", dvv);
            }

            return 1;
        }


        public static List<Patente> ObtenerPermisos(Usuario pUsuario)
        {
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);
            DAO mDAO = new DAO();
            string mCommandText = "SELECT * FROM Usuario WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "'";
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);

            pUsuario.IdUsuario = Int32.Parse(mDataSet.Tables[0].Rows[0]["IdUsuario"].ToString());

            List<Patente> mPermisos = new List<Patente>();
            ObtenerPatentes(pUsuario);
            ObtenerFamilias(pUsuario);

            foreach (Patente patente in pUsuario.mPatentes)
            {
                mPermisos.Add(patente);
            }

            foreach (Familia mFamilia in pUsuario.mFamilias)
            {
                foreach (Patente patente in mFamilia.mPatentes)
                {
                    mPermisos.Add(patente);
                }
            }

            return mPermisos;
        }

        public static bool CambiarPassword(string passActual, string passNuevo, int idUsuario)
        {
            bool resultado = false;
            passActual = Seguridad.EncriptarNR(passActual);
            passNuevo = Seguridad.EncriptarNR(passNuevo);
            DAO mDAO = new DAO();

            string mCommandText = "SELECT * FROM Usuario WHERE IdUsuario = " + idUsuario + " AND Password = '" + passActual + "'";
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            if (mDataSet.Tables[0].Rows.Count > 0)
            {
                mCommandText = "UPDATE Usuario SET Password = '" + passNuevo + "' WHERE IdUsuario = " + idUsuario;
                mDAO.ExecuteScalar(mCommandText);

                //Verificadores
                Usuario pUsuario = new Usuario();
                pUsuario.IdUsuario = idUsuario;
                pUsuario.DVH = Verificacion.CalcularDVH(ConsultarRegistro(pUsuario.IdUsuario).Tables[0]);
                Verificacion.AgregarDVH("Usuario", pUsuario.IdUsuario, pUsuario.DVH);
                int dvv = Verificacion.CalcularDVV("Usuario");
                Verificacion.AgregarDVV("Usuario", dvv);

                resultado = true;
            }

            return resultado;
        }

        public static Usuario ValorizarUsuario(Usuario pUsuario)
        {
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);

            DAO mDAO = new DAO();
            string mCommandText = "SELECT * FROM Usuario WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "'";
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            Usuario mUsuario = new Usuario
            {
                IdUsuario = Int32.Parse(mDataSet.Tables[0].Rows[0]["IdUsuario"].ToString()),
                //NombreUsuario = mDataSet.Tables[0].Rows[0]["NombreUsuario"].ToString(),
                NombreUsuario = pUsuario.NombreUsuario,
                Idioma = mDataSet.Tables[0].Rows[0]["Idioma"].ToString(),
            };

            return mUsuario;
        }

        public static int ActualizarIdioma(Usuario pUsuario)
        {
            DAO mDAO = new DAO();
            string mCommandText = "UPDATE Usuario SET Idioma = '" + pUsuario.Idioma + "' WHERE IdUsuario = " + pUsuario.IdUsuario;
            mDAO.ExecuteScalar(mCommandText);

            //Verificadores
            pUsuario.DVH = Verificacion.CalcularDVH(ConsultarRegistro(pUsuario.IdUsuario).Tables[0]);
            Verificacion.AgregarDVH("Usuario", pUsuario.IdUsuario, pUsuario.DVH);
            int dvv = Verificacion.CalcularDVV("Usuario");
            Verificacion.AgregarDVV("Usuario", dvv);
            return 1;
        }

        public static bool ExisteNombreUsuario(Usuario pUsuario)
        {
            string nombreUsuarioEncriptado = Seguridad.Encriptar(pUsuario.NombreUsuario, Key, IV);

            string mCommandText = "SELECT * FROM Usuario WHERE NombreUsuario = '" + nombreUsuarioEncriptado + "'";
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            if (mDataSet.Tables[0].Rows.Count > 0)
            {
                //Valido si es una actualización (mismo IdUsuario)
                if (int.Parse(mDataSet.Tables[0].Rows[0]["IdUsuario"].ToString()) != pUsuario.IdUsuario)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }

        public static bool ExisteEmail(Usuario pUsuario)
        {

            string mCommandText = "SELECT * FROM Usuario WHERE Email = '" + Seguridad.Encriptar(pUsuario.Email, Key, IV) + "'";
            DAO mDAO = new DAO();
            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            if (mDataSet.Tables[0].Rows.Count > 0)
            {
                //Valido si es una actualización (mismo IdUsuario)
                if (int.Parse(mDataSet.Tables[0].Rows[0]["IdUsuario"].ToString()) != pUsuario.IdUsuario)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }
    }
}
