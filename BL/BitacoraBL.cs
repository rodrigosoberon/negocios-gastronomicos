using BE;
using DAL;
using System.Collections.Generic;

namespace BL
{
    public class BitacoraBL
    {
        public List<Bitacora> Listar()
        {
            return BitacoraDAL.Listar();
        }
        public int AgregarBitacora(Bitacora pBitacora)
        {
            return BitacoraDAL.AgregarBitacora(pBitacora);
        }

    }
}
