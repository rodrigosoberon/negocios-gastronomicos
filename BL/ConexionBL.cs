using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ConexionBL
    {
        public bool ValidarConexion()
        {
            return ConexionDAL.ValidarConexion();
        }

        public static void ActualizarCadenaConexion(string nuevaCadena)
        {
            ConexionDAL.ActualizarCadenaConexion(nuevaCadena);
        }
    }
}
