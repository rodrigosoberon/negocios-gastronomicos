using BE;
using DAL;

namespace BL
{
    public class BitacoraBL
    {
        public int AgregarBitacora(Bitacora pBitacora)
        {
            return BitacoraDAL.AgregarBitacora(pBitacora);
        }
    }
}
