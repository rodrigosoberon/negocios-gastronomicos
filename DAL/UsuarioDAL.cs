using BE;
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
                    NombreUsuario = mDataRow["NombreUsuario"].ToString(),
                    //Password = mDataRow["Password"].ToString(),
                    Nombre = Seguridad.Desencriptar(mDataRow["Nombre"].ToString(), Key, IV),
                    Apellido = Seguridad.Desencriptar(mDataRow["Apellido"].ToString(), Key, IV),
                    Email = Seguridad.Desencriptar(mDataRow["Email"].ToString(), Key, IV),
                    Idioma = mDataRow["Idioma"].ToString(),
                    Estado = bool.Parse(mDataRow["Estado"].ToString()),
                };
                mUsuarios.Add(mUsuario);
            }
            return mUsuarios;
        }

        public static int GuardarNuevo(Usuario pUsuario)
        {
            string passwordEncriptado = Seguridad.EncriptarNR(pUsuario.Password);
            string nombreEncriptado = Seguridad.Encriptar(pUsuario.Nombre, Key, IV);
            string apellidoEncriptado = Seguridad.Encriptar(pUsuario.Apellido, Key, IV);
            string emailEncriptado = Seguridad.Encriptar(pUsuario.Email, Key, IV);

            string mCommandText = "INSERT INTO Usuario (NombreUsuario, Password, Nombre, Apellido, Email, Idioma, Estado, DVH) VALUES ('" + pUsuario.NombreUsuario + "', '" + passwordEncriptado + "', '" + nombreEncriptado + "', '" + apellidoEncriptado + "', '" + emailEncriptado + "', '" + pUsuario.Idioma + "', '" + pUsuario.Estado + "', '" + pUsuario.DVH + "'); SELECT CAST(scope_identity() AS int)";
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
            pUsuario.Nombre = Seguridad.Encriptar(pUsuario.Nombre, Key, IV);
            pUsuario.Apellido = Seguridad.Encriptar(pUsuario.Apellido, Key, IV);
            pUsuario.Email = Seguridad.Encriptar(pUsuario.Email, Key, IV);

            string mCommandText = "UPDATE Usuario SET NombreUsuario = '" + pUsuario.NombreUsuario + "', Nombre = '" + pUsuario.Nombre + "', Apellido = '" + pUsuario.Apellido + "', Email = '" + pUsuario.Email + "', Idioma = '" + pUsuario.Idioma + "', Estado = '" + pUsuario.Estado + "' WHERE IdUsuario = " + pUsuario.IdUsuario;

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
    }
}
