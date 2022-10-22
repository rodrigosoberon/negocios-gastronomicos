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
        //public Usuario(int pId)
        //{
        //    IdUsuario = pId;
        //}

        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Idioma { get; set; } = "es";
        public bool Estado { get; set; } = true;
        public int DVH { get; set; } = 1;

    }
}
