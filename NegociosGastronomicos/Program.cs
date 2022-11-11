﻿using BL;
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

            VerificacionBL mVerificacionBL = new VerificacionBL();
            bool integridadVok;
            bool integridadHok;

            //Validar DVH
            integridadHok = mVerificacionBL.VerificarIntegridadHorizontal();
            if (!integridadHok)
            {
                MessageBox.Show("La integridad de los datos a nivel de registro ha sido comprometida. Revise bitácora de seguridad para mayor detalle.");
            }
            
            //Validar DVV
            integridadVok = mVerificacionBL.VerificarIntegridadVertical();
            if (!integridadVok)
            {
                MessageBox.Show("La integridad de los datos a nivel de tabla ha sido comprometida. Revise bitácora de seguridad para mayor detalle.");
            }
            
            MessageBox.Show("Checkeo de integridad completado. Bienvenido al sistema de gestión de negocios gastronómicos.");

        }
    }
}