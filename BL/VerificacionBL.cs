using DAL;

namespace BL
{
    public class VerificacionBL
    {
        public bool VerificarIntegridadVertical()
        {
            return Verificacion.VerificarIntegridadVertical();
        }
        public bool VerificarIntegridadHorizontal()
        {
            return Verificacion.VerificarIntegridadHorizontal();
        }
    }
}
