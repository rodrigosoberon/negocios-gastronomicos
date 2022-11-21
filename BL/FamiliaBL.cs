using BE;
using DAL;
using System.Collections.Generic;

namespace BL
{
    public class FamiliaBL
    {
        public List<Familia> Listar()
        {
            return FamiliaDAL.Listar();
        }
        public int GuardarNuevo(Familia pFamilia)
        {
            return FamiliaDAL.GuardarNuevo(pFamilia);
        }

        public int Modificar(Familia pFamilia)
        {
            return FamiliaDAL.Modificar(pFamilia);
        }

        public int Borrar(Familia pFamilia)
        {
            return FamiliaDAL.Borrar(pFamilia);
        }

        public int AsignarPatente(Familia pFamilia, Patente pPatente)
        {
            return FamiliaDAL.Asignar(pFamilia, pPatente);
        }

        public int DesasignarPatente(Familia pFamilia, Patente pPatente)
        {
            return FamiliaDAL.Desasignar(pFamilia, pPatente);
        }

        public void ObtenerAsignados(Familia pFamilia)
        {
           FamiliaDAL.ObtenerAsignados(pFamilia);
        }

        public bool EnFamiliaAsignada(Familia pFamilia,Patente pPatente)
        {
            return FamiliaDAL.EnFamiliaAsignada(pFamilia, pPatente);
        }
    }
}
