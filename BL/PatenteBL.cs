using System.Collections.Generic;
using BE;
using DAL;

namespace BL
{
    public class PatenteBL
    {
        public List<Patente> Listar()
        {
            return PatenteDAL.Listar();
        }
        public int GuardarNuevo(Patente pPatente)
        {
            return PatenteDAL.GuardarNuevo(pPatente);
        }

        public int Modificar(Patente pPatente)
        {
            return PatenteDAL.Modificar(pPatente);
        }

        public int Borrar(Patente pPatente)
        {
            return PatenteDAL.Borrar(pPatente);
        }

        public bool PatenteAsignada(Usuario pUsuario, Patente pPatente)
        {
            return PatenteDAL.PatenteAsignada(pUsuario, pPatente);
        }

        public bool PatenteAsignada( Patente pPatente)
        {
            return PatenteDAL.PatenteAsignada(pPatente);
        }

        public bool PatenteAsignadaDirecta(Patente pPatente)
        {
            return PatenteDAL.PatenteAsignadaDirecta(pPatente) ;
        }
    }
}
