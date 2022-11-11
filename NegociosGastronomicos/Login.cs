using BE;
using BL;
using System;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public Usuario intentoUsuario = new Usuario();

        private void button1_Click(object sender, EventArgs e)
        {
            EjecutarLoggin();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EjecutarLoggin();
        }

        public void EjecutarLoggin()
        {
            intentoUsuario.NombreUsuario = txtUsuario.Text;
            intentoUsuario.Password = txtPassword.Text;

            UsuarioBL mUsuarioBL = new UsuarioBL();

            bool valido = mUsuarioBL.ValidarCredenciales(intentoUsuario);
            bool estado = mUsuarioBL.ValidarEstado(intentoUsuario);

            txtUsuario.Text = "";
            txtPassword.Text = "";
            if (valido)
            {
                if (estado)
                {
                    //Login satisfactorio
                    Usuario usuarioLogueado = new Usuario
                    {
                        NombreUsuario = intentoUsuario.NombreUsuario,
                        Password = intentoUsuario.Password
                    };
                    intentoUsuario.Intentos = 0;
                    mUsuarioBL.ActualizarIntentos(intentoUsuario);
                    this.Hide();
                    Menu menu = new Menu(usuarioLogueado);
                    menu.Show();
                }
                else
                {
                    //Usuario bloqueado
                    MessageBox.Show("Usuario bloqueado. Contacte al administrador.");
                    //Log en bitacora
                    Bitacora bitacora = new Bitacora
                    {
                        Usuario = intentoUsuario.IdUsuario,
                        Fecha = DateTime.Now,
                        Descripcion = "Usuario id " + intentoUsuario.IdUsuario + " bloqueado intentó iniciar sesión.",
                        Criticidad = "Media"
                    };
                    BitacoraBL mBitacoraBL = new BitacoraBL();
                    mBitacoraBL.AgregarBitacora(bitacora);
                }

            }
            else
            {
                //Login incorrecto
                intentoUsuario.Intentos = mUsuarioBL.ObtenerIntentos(intentoUsuario) + 1;
                mUsuarioBL.ActualizarIntentos(intentoUsuario);
                if (intentoUsuario.Intentos > 2 )
                {
                    intentoUsuario.Estado = false;
                    mUsuarioBL.CambiarEstado(intentoUsuario);
                    MessageBox.Show("Usuario bloqueado. Contacte al administrador.");
                    
                    Bitacora bitacora = new Bitacora
                    {
                        Usuario = intentoUsuario.IdUsuario,
                        Fecha = DateTime.Now,
                        Descripcion = "Usuario " + intentoUsuario.NombreUsuario + " bloqueado por exceder intentos de inicio de sesión.",
                        Criticidad = "Media"
                    };
                    BitacoraBL mBitacoraBL = new BitacoraBL();
                    mBitacoraBL.AgregarBitacora(bitacora);

                }
                else
                {
                    MessageBox.Show("Usuario y/o contraseña incorrectos.");
                    Bitacora bitacora = new Bitacora
                    {
                        Fecha = DateTime.Now,
                        Descripcion = "Intento fallido de inicio de sesión para usuario " + intentoUsuario.NombreUsuario,
                        Criticidad = "Bajo"
                    };
                    BitacoraBL mBitacoraBL = new BitacoraBL();
                    mBitacoraBL.AgregarBitacora(bitacora);
                }
            }
        }
    }
}
