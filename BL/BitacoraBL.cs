using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BL
{
    public class BitacoraBL
    {
        public List<Bitacora> Listar(DateTime desde, DateTime hasta, String usuario, String criticidad, bool ordFecha, bool ordUsuario, bool ordCriticidad, bool fechDesc, bool usuarioDesc, bool criticidadDesc)
        {
            return BitacoraDAL.Listar(desde, hasta, usuario, criticidad, ordFecha, ordUsuario, ordCriticidad, fechDesc, usuarioDesc, criticidadDesc);
        }
        public int AgregarBitacora(Bitacora pBitacora)
        {
            return BitacoraDAL.AgregarBitacora(pBitacora);
        }

    }
}
