using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Material
    {
        public Material() { }
        public Material(int pId)
        {
            IdMaterial = pId;
        }
        public int IdMaterial { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public bool EnRequisicion { get; set; } = false;
        public int DVH { get; set; } = 1;
    }
}
