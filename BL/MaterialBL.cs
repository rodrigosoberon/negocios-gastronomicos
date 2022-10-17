using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    public class MaterialBL
    {
        public List<Material> Listar()
        {
            return MaterialDAL.Listar();
        }
        public int GuardarNuevo(Material pMaterial)
        {
            return MaterialDAL.GuardarNuevo(pMaterial);
        }

        public int Modificar(Material pMaterial)
        {
            return MaterialDAL.Modificar(pMaterial);
        }
    }
}
