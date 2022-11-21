

using System.Collections.Generic;

namespace BE
{
    public class Plato
    {
        public Plato() { }

        public int IdPlato { get; set; }
        public string Descripcion { get; set; }
        public float Importe { get; set; }
        public int DVH { get; set; } = 1;
        public List<Material> Materiales = new List<Material>();
    }
}
