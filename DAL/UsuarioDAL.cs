using System.Collections.Generic;
using System.Data;
using BE;

namespace DAL
{
    public class UsuarioDAL
    {
        public static List<Usuario> Listar() {
            string mCommandText = "SELECT * FROM Usuario";
            DAO mDAO = new DAO();

            DataSet mDataSet = mDAO.ExecuteDataSet(mCommandText);
            List<Usuario> mUsuarios = new List<Usuario>();
            foreach(DataRow mDataRow in mDataSet.Tables[0].Rows){
                Usuario mUsuario = new Usuario
                {
                    IdUsuario = int.Parse(mDataRow["IdUsuario"].ToString()),
                    NombreUsuario = mDataRow["NombreUsuario"].ToString(),
                    Password = mDataRow["Password"].ToString(),
                    Nombre = mDataRow["Nombre"].ToString(),
                    Apellido = mDataRow["Apellido"].ToString(),
                    Email = mDataRow["Email"].ToString(),
                    Idioma = mDataRow["Idioma"].ToString(),
                    Estado = bool.Parse(mDataRow["Estado"].ToString()),
                };
                mUsuarios.Add(mUsuario);
            }
            return mUsuarios;
        }

        public static int GuardarNuevo(Usuario pUsuario)
        {
            string mCommandText = "INSERT INTO Usuario (NombreUsuario, Password, Nombre, Apellido, Email, Estado, Idioma, DVH) VALUES ('" + pUsuario.NombreUsuario + "', '" + pUsuario.Password + "', '" + pUsuario.Nombre + "', '" + pUsuario.Apellido + "', '" + pUsuario.Email + "', '" + pUsuario.Estado + "', '" + pUsuario.Idioma + "', '" + pUsuario.DVH + "'); SELECT CAST(scope_identity() AS int)";
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
    }
}
