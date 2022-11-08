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

            //Cambiar aca el form de inicio
            Application.Run(new Login());
        }
    }
}
