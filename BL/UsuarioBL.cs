using BE;
using DAL;
using System.Collections.Generic;

namespace BL
{
    public class UsuarioBL
    {
        public List<Usuario> Listar()
        {
            return UsuarioDAL.Listar();
        }
        public int GuardarNuevo(Usuario pUsuario)
        {
            return UsuarioDAL.GuardarNuevo(pUsuario);
        }

        public int Modificar(Usuario pUsuario)
        {
            return UsuarioDAL.Modificar(pUsuario);
        }

        public int CambiarEstado(Usuario pUsuario)
        {
            return UsuarioDAL.CambiarEstado(pUsuario);
        }
    }
}
