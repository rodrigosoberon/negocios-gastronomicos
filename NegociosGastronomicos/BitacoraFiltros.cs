using BE;
using BL;
using System;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class BitacoraFiltros : Form
    {
        public BitacoraFiltros()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void BitacoraFiltros_Load(object sender, EventArgs e)
        {
            cbUsuario.Items.Add("");
            foreach (Usuario mUsuario in new UsuarioBL().Listar())
            {
                cbUsuario.Items.Add(mUsuario.NombreUsuario);
            }
            dtpHasta.Value = DateTime.Now;
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            ReporteBitacora reporteBitacora = new ReporteBitacora(desde, hasta, cbUsuario.Text, cbCriticidad.Text, checkFecha.Checked, checkUsuarios.Checked, checkCriticidad.Checked, rbFechaDesc.Checked, rbUsuarioDesc.Checked, rbCriticidadDesc.Checked);
            reporteBitacora.Show();
        }

        private void BitacoraFiltros_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Ayuda ayuda = new Ayuda();
                ayuda.Show();
            }
        }

        private void checkFecha_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkFecha.Checked)
            { gbFecha.Enabled = true; }
            else
            { gbFecha.Enabled = false; }

        }

        private void checkUsuarios_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkUsuarios.Checked)
            { gbUsuario.Enabled = true; }
            else
            { gbUsuario.Enabled = false; }
        }

        private void checkCriticidad_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkCriticidad.Checked)
            { gbCriticidad.Enabled = true; }
            else
            { gbCriticidad.Enabled = false; }
        }
    }
}
