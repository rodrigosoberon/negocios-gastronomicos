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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void abrirMesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedorPrincipal.Controls.Clear();
            AbrirMesa abrirMesa = new AbrirMesa() { TopLevel = false, Dock = DockStyle.Fill };
            panelContenedorPrincipal.Controls.Add(abrirMesa);
            abrirMesa.Show();
        }

        private void gestiónDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenedorPrincipal.Controls.Clear();
            Form1 form1 = new Form1() { TopLevel = false, Dock = DockStyle.Fill };
            panelContenedorPrincipal.Controls.Add(form1);
            form1.Show();
        }
    }
}
