using BL;
using System;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            ValidarIntegridad();



            Application.Run(new Login());
        }


        public static void ValidarIntegridad()
        {


            VerificarDVV();
            MessageBox.Show("Checkeo de integridad completado. Bienvenido al sistema de gestión de negocios gastronómicos.");

        }

        public static void VerificarDVV()
        {
            VerificacionBL mVerificacionBL = new VerificacionBL();
            bool dvvOK = true;
            dvvOK = mVerificacionBL.VerificarIntegridadDVV();

            if (!dvvOK)
            {
                MessageBox.Show("La integridad de los datos a nivel de tabla (DVV) ha sido comprometida. Revise bitácora de seguridad para mayor detalle.");
            }

        }
    }
}