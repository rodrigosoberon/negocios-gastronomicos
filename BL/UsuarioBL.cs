using BE;
using DAL;
using System;
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

            bool existeUsuario = UsuarioDAL.ExisteNombreUsuario(pUsuario);
            bool existeEmail = UsuarioDAL.ExisteEmail(pUsuario);

            if (existeEmail)
            {
                throw new Exception("Ya existe un usuario registrado con esa dirección email.");
            }
            else
            {
                if (existeUsuario)
                {
                    throw new Exception("El nombre de usuario ya existe. Elija otro");
                }
                else
                {
                    return UsuarioDAL.GuardarNuevo(pUsuario);
                }
            }
        }

        public int Modificar(Usuario pUsuario)
        {
            bool existeUsuario = UsuarioDAL.ExisteNombreUsuario(pUsuario);
            bool existeEmail = UsuarioDAL.ExisteEmail(pUsuario);

            if (existeEmail)
            {
                throw new Exception("Ya existe un usuario registrado con esa dirección email.");
            }
            else
            {
                if (existeUsuario)
                {
                    throw new Exception("El nombre de usuario ya existe. Elija otro");
                }
                else
                {
                    return UsuarioDAL.Modificar(pUsuario);
                }
            }
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

        public bool ValidarCredenciales(Usuario pUsuario)
        {
            return UsuarioDAL.ValidarCredenciales(pUsuario);
        }

        public bool ValidarEstado(Usuario pUsuario)
        {
            return UsuarioDAL.ValidarEstado(pUsuario);
        }

        public int ObtenerIntentos(Usuario pUsuario)
        {
            return UsuarioDAL.ObtenerIntentos(pUsuario);
        }

        public int ActualizarIntentos(Usuario pUsuario)
        {
            return UsuarioDAL.ActualizarIntentos(pUsuario);
        }

        public static List<Patente> ObtenerPermisos(Usuario pUsuario)
        {
            return UsuarioDAL.ObtenerPermisos(pUsuario);
        }

        public static List<Patente> ObtenerPatentes(Usuario pUsuario)
        {
            return UsuarioDAL.ObtenerPatentes(pUsuario);
        }

        public bool CambiarPassword(string pPassActual, string pPassNuevo, int pIdUsuario)
        {
            return UsuarioDAL.CambiarPassword(pPassActual, pPassNuevo, pIdUsuario);
        }

        public Usuario ValorizarUsuario(Usuario pIdUsuario)
        {
            return UsuarioDAL.ValorizarUsuario(pIdUsuario);
        }

        public int ActualizarIdioma(Usuario pUsuario)
        {
            return UsuarioDAL.ActualizarIdioma(pUsuario);
        }
    }
}
