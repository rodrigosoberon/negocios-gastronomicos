using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public Usuario(){}
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Idioma { get; set; } = "es";
        public bool Estado { get; set; } = true;
        public int Intentos { get; set; } = 0;
        public int DVH { get; set; } = 1;
        public List<Familia> mFamilias = new List<Familia>();
        public List<Patente> mPatentes = new List<Patente>();
    }
}
