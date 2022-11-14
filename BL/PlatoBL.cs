using BE;
using DAL;
using System.Collections.Generic;



namespace BL
{
    public class PlatoBL
    {
        public List<Plato> Listar()
        {
            return PlatoDAL.Listar();
        }
        public int GuardarNuevo(Plato pPlato)
        {
            return PlatoDAL.GuardarNuevo(pPlato);
        }
        public int Modificar(Plato pPlato)
        {
            return PlatoDAL.Modificar(pPlato);
        }
        public int Borrar(Plato pPlato)
        {
            return PlatoDAL.Borrar(pPlato);
        }
        public int IncluirMaterial(Plato pPlato, Material pMaterial)
        {
            return PlatoDAL.Incluir(pPlato, pMaterial);
        }

        public int QuitarMaterial(Plato pPlato, Material pMaterial)
        {
            return PlatoDAL.Quitar(pPlato, pMaterial);
        }
    }
}
