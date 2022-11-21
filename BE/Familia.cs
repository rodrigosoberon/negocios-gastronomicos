

using System.Collections.Generic;

namespace BE
{
    public class Familia
    {
        public Familia() { }
        public int IdFamilia { get; set; }
        public string Descripcion { get; set; }
        public int DVH { get; set; } = 1;
        public List<Patente> mPatentes = new List<Patente>();
    }
}
