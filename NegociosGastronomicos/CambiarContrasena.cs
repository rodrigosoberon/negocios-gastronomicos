using BE;
using BL;
using System;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class CambiarContrasena : Form
    {
        public static Usuario usuarioLogueado = new Usuario();
        public CambiarContrasena(Usuario usuario)
        {
            this.KeyPreview = true;
            InitializeComponent();
            usuarioLogueado = usuario;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void LimpiarCampos()
        {
            txtPassNuevo.Text = "";
            txtPassActual.Text = "";
            txtPassConfirm.Text = "";
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if(txtPassNuevo.Text != txtPassConfirm.Text)
            {
                MessageBox.Show("Las nueva contraseña no coincide con la confirmación");
            }
            else
            {
                UsuarioBL mUsuarioBL = new UsuarioBL();

                bool actualizada = mUsuarioBL.CambiarPassword(txtPassActual.Text, txtPassNuevo.Text, usuarioLogueado.IdUsuario);

                if (actualizada)
                {
                    MessageBox.Show("Contraseña actualizada correctamente");
                    LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("Contraseña actual incorrecta");
                    LimpiarCampos();
                }
            }
        }

        private void CambiarContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Ayuda ayuda = new Ayuda();
                ayuda.Focus();
                ayuda.Show();
            }
        }
    }
}
