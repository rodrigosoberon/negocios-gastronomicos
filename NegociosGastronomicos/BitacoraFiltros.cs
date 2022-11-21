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
        }

        private void btnEjecutar_Click(object sender, EventArgs e)
        {
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpHasta.Value;
            ReporteBitacora reporteBitacora = new ReporteBitacora(desde, hasta, cbUsuario.Text, cbCriticidad.Text);
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


    }
}
