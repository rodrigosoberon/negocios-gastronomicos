using BL;
using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            bool conectado = false;
            while (!conectado)
            {
                conectado = ValidarConexion();
                if (!conectado)
                {
                    string nuevaCadena = Interaction.InputBox("No se pudo establecer conexion a la base de datos. Por favor reingrese la cadena de conexion", "Configuracion de conexión", "");
                    ActualizarCadenaConexion(nuevaCadena);
                    conectado = ValidarConexion();
                }
            }
            MessageBox.Show("Conexion establecida");

            ValidarIntegridad();
            Login login = new Login();
            login.Show();
        }

        public static void ActualizarCadenaConexion(string nuevaCadena)
        {
            ConexionBL.ActualizarCadenaConexion(nuevaCadena);
        }


        public static bool ValidarConexion()
        {
            //bool conectado = false;
            //Codigo para validar conexion
            //ConexionBL mConexionBL = new ConexionBL();
            bool conectado = new ConexionBL().ValidarConexion();
            return conectado;
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

        private void Inicio_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
