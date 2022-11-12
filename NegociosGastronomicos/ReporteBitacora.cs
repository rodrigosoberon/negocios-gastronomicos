﻿using BE;
using BL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NegociosGastronomicos
{
    public partial class ReporteBitacora : Form
    {
        public ReporteBitacora()
        {
            InitializeComponent();
        }

        private void ReporteBitacora_Load(object sender, EventArgs e)
        {
            //List<Bitacora> bitacora = new List<Bitacora>();

            List<Bitacora> bitacoras = new BitacoraBL().Listar();

            this.reportViewer1.LocalReport.ReportPath = "ReporteBitacora.rdlc";
            ReportDataSource source = new ReportDataSource("DataSetBitacora", bitacoras);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(source);



            this.reportViewer1.RefreshReport();
        }
    }
}