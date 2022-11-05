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

        public int AsignarFamilia(Usuario pUsuario, Familia pFamilia)
        {
            return UsuarioDAL.AsignarFamilia(pUsuario, pFamilia);
        }

        public int RemoverFamilia(Usuario pUsuario, Familia pFamilia)
        {
            return UsuarioDAL.RemoverFamilia(pUsuario, pFamilia);
        }

        public int AsignarPatente(Usuario pUsuario, Patente pPatente)
        {
            return UsuarioDAL.AsignarPatente(pUsuario, pPatente);
        }

        public int RemoverPatente(Usuario pUsuario, Patente pPatente)
        {
            return UsuarioDAL.RemoverPatente(pUsuario, pPatente);
        }
    }
}
