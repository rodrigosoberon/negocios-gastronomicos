using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Backup
    {
        public int IdResguardo { get; set; }
        public Usuario Usuario { get; set; }
        public string Descripcion { get; set; }
        public DateTime Creado { get; set; }
        public int Particiones { get; set; }
        public string Ubicacion { get; set; }
        public int DVH { get; set; } = 1;
    }
}
