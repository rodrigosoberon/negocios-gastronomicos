using BE;
using BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class CambiarIdioma : Form
    {
        public static Usuario usuarioLogueado = new Usuario();
        public CambiarIdioma(Usuario usuario)
        {
            this.KeyPreview = true;
            usuarioLogueado = usuario;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            usuarioLogueado.Idioma = cbIdioma.SelectedItem.ToString();
            UsuarioBL mUsuarioBL = new UsuarioBL();
            mUsuarioBL.ActualizarIdioma(usuarioLogueado);
            lblIdioma.Text = usuarioLogueado.Idioma;
            MessageBox.Show("Idioma actualizado correctamente. Cierre sesión para ver los cambios");
        }

        private void CambiarIdioma_Load(object sender, EventArgs e)
        {
            lblIdioma.Text = usuarioLogueado.Idioma;
        }

        private void CambiarIdioma_KeyDown(object sender, KeyEventArgs e)
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
