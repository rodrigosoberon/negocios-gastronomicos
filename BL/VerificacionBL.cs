using DAL;

namespace BL
{
    public class VerificacionBL
    {
        public bool VerificarIntegridadDVV()
        {
            return Verificacion.VerificarDVV();
        }
    }
}
