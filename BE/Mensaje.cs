using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mensaje
    {
        public Mensaje() { }
        public int IdMensaje { get; set; }
        public string Idioma { get; set; }
        public string Nombre { get; set; }
        public string Texto { get; set; }
    }
}
