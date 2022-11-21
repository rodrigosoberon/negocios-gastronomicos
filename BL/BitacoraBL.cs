using BE;
using DAL;
using System;
using System.Collections.Generic;

namespace BL
{
    public class BitacoraBL
    {
        public List<Bitacora> Listar(DateTime desde, DateTime hasta, String usuario, String criticidad)
        {
            return BitacoraDAL.Listar(desde, hasta, usuario, criticidad);
        }
        public int AgregarBitacora(Bitacora pBitacora)
        {
            return BitacoraDAL.AgregarBitacora(pBitacora);
        }

    }
}
