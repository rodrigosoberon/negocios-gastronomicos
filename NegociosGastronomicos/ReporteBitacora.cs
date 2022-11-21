using BE;
using BL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class ReporteBitacora : Form
    {
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }
        public string Usuario { get; set; }
        public string Criticidad { get; set; }
        public bool OrdenarFecha { get; set; }
        public bool OrdenarUsuarios { get; set; }
        public bool OrdenarCriticidad { get; set; }
        public bool FechaDesc { get; set; }
        public bool UsuarioDesc { get; set; }
        public bool CriticidadDesc { get; set; }

        public ReporteBitacora(DateTime pDesde, DateTime pHasta, string pNombreUsuario, string pCriticidad,bool ordenarFecha, bool ordenarUsuarios, bool ordenarCriticidad, bool fechaDesc, bool usuarioDesc, bool criticidadDesc)
        {
            this.KeyPreview = true;
            InitializeComponent();
            Desde = pDesde;
            Hasta = pHasta;
            Usuario = pNombreUsuario;
            Criticidad = pCriticidad;
            OrdenarFecha= ordenarFecha;
            OrdenarUsuarios= ordenarUsuarios;
            OrdenarCriticidad= ordenarCriticidad;
            FechaDesc = fechaDesc;
            UsuarioDesc = usuarioDesc;
            CriticidadDesc = criticidadDesc;
        }

        private void ReporteBitacora_Load(object sender, EventArgs e)
        {
            List<Bitacora> bitacoras = new BitacoraBL().Listar(Desde, Hasta, Usuario, Criticidad, OrdenarFecha, OrdenarUsuarios, OrdenarCriticidad, FechaDesc, UsuarioDesc, CriticidadDesc);
            this.reportViewer1.LocalReport.ReportPath = "ReporteBitacora.rdlc";
            ReportDataSource source = new ReportDataSource("DataSetBitacora", bitacoras);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void ReporteBitacora_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Ayuda ayuda = new Ayuda();
                ayuda.Show();
            }
        }
    }
}
