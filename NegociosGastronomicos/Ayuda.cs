using System;
using System.IO;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void Ayuda_Load(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(Path.Combine(Environment.CurrentDirectory, "manualDeUsuario.rtf"));
        }
    }
}
