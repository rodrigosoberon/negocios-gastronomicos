using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Patente
    {
        public Patente() { }
        public int IdPatente { get; set; }
        public string Descripcion { get; set; }
        public int DVH { get; set; } = 1;
    }
}
