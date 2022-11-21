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
        public DateTime desde { get; set; }
        public DateTime hasta { get; set; }
        public String usuario { get; set; }
        public String criticidad { get; set; }
        public ReporteBitacora(DateTime pDesde, DateTime pHasta, String pNombreUsuario, String pCriticidad)
        {
            desde = pDesde;
            hasta = pHasta;
            usuario = pNombreUsuario;
            criticidad = pCriticidad;
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void ReporteBitacora_Load(object sender, EventArgs e)
        {
            List<Bitacora> bitacoras = new BitacoraBL().Listar(desde, hasta, usuario, criticidad);
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
