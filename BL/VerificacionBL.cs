using DAL;

namespace BL
{
    public class VerificacionBL
    {
        public bool VerificarIntegridad()
        {
            return Verificacion.VerificarIntegridad();
        }
    }
}
