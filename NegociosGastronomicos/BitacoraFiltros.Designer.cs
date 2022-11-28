namespace NegociosGastronomicos
{
    partial class BitacoraFiltros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label4 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUsuario = new System.Windows.Forms.ComboBox();
            this.cbCriticidad = new System.Windows.Forms.ComboBox();
            this.gbFecha = new System.Windows.Forms.GroupBox();
            this.rbFechaDesc = new System.Windows.Forms.RadioButton();
            this.rbFechaAsc = new System.Windows.Forms.RadioButton();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.rbUsuarioDesc = new System.Windows.Forms.RadioButton();
            this.rbUsuarioAsc = new System.Windows.Forms.RadioButton();
            this.gbCriticidad = new System.Windows.Forms.GroupBox();
            this.rbCriticidadDesc = new System.Windows.Forms.RadioButton();
            this.rbCriticidadAsc = new System.Windows.Forms.RadioButton();
            this.checkFecha = new System.Windows.Forms.CheckBox();
            this.checkUsuarios = new System.Windows.Forms.CheckBox();
            this.checkCriticidad = new System.Windows.Forms.CheckBox();
            this.gbFecha.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.gbCriticidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "Reporte bitácora";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(597, 449);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 14;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Hasta";
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(377, 243);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 20);
            this.dtpDesde.TabIndex = 17;
            this.dtpDesde.Value = new System.DateTime(2022, 11, 1, 0, 0, 0, 0);
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(377, 281);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 20);
            this.dtpHasta.TabIndex = 18;
            this.dtpHasta.Value = new System.DateTime(2022, 11, 21, 12, 16, 38, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Criticidad";
            // 
            // cbUsuario
            // 
            this.cbUsuario.FormattingEnabled = true;
            this.cbUsuario.Location = new System.Drawing.Point(377, 328);
            this.cbUsuario.Name = "cbUsuario";
            this.cbUsuario.Size = new System.Drawing.Size(200, 21);
            this.cbUsuario.TabIndex = 21;
            // 
            // cbCriticidad
            // 
            this.cbCriticidad.FormattingEnabled = true;
            this.cbCriticidad.Items.AddRange(new object[] {
            "",
            "Alta",
            "Medio",
            "Bajo"});
            this.cbCriticidad.Location = new System.Drawing.Point(377, 380);
            this.cbCriticidad.Name = "cbCriticidad";
            this.cbCriticidad.Size = new System.Drawing.Size(200, 21);
            this.cbCriticidad.TabIndex = 22;
            // 
            // gbFecha
            // 
            this.gbFecha.Controls.Add(this.rbFechaDesc);
            this.gbFecha.Controls.Add(this.rbFechaAsc);
            this.gbFecha.Enabled = false;
            this.gbFecha.Location = new System.Drawing.Point(756, 243);
            this.gbFecha.Name = "gbFecha";
            this.gbFecha.Size = new System.Drawing.Size(200, 60);
            this.gbFecha.TabIndex = 24;
            this.gbFecha.TabStop = false;
            this.gbFecha.Text = "Orden fecha";
            // 
            // rbFechaDesc
            // 
            this.rbFechaDesc.AutoSize = true;
            this.rbFechaDesc.Location = new System.Drawing.Point(105, 24);
            this.rbFechaDesc.Name = "rbFechaDesc";
            this.rbFechaDesc.Size = new System.Drawing.Size(89, 17);
            this.rbFechaDesc.TabIndex = 1;
            this.rbFechaDesc.Text = "Descendente";
            this.rbFechaDesc.UseVisualStyleBackColor = true;
            // 
            // rbFechaAsc
            // 
            this.rbFechaAsc.AutoSize = true;
            this.rbFechaAsc.Checked = true;
            this.rbFechaAsc.Location = new System.Drawing.Point(6, 24);
            this.rbFechaAsc.Name = "rbFechaAsc";
            this.rbFechaAsc.Size = new System.Drawing.Size(82, 17);
            this.rbFechaAsc.TabIndex = 0;
            this.rbFechaAsc.TabStop = true;
            this.rbFechaAsc.Text = "Ascendente";
            this.rbFechaAsc.UseVisualStyleBackColor = true;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.rbUsuarioDesc);
            this.gbUsuario.Controls.Add(this.rbUsuarioAsc);
            this.gbUsuario.Enabled = false;
            this.gbUsuario.Location = new System.Drawing.Point(756, 309);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(200, 45);
            this.gbUsuario.TabIndex = 25;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Orden usuarios";
            // 
            // rbUsuarioDesc
            // 
            this.rbUsuarioDesc.AutoSize = true;
            this.rbUsuarioDesc.Location = new System.Drawing.Point(105, 19);
            this.rbUsuarioDesc.Name = "rbUsuarioDesc";
            this.rbUsuarioDesc.Size = new System.Drawing.Size(89, 17);
            this.rbUsuarioDesc.TabIndex = 1;
            this.rbUsuarioDesc.Text = "Descendente";
            this.rbUsuarioDesc.UseVisualStyleBackColor = true;
            // 
            // rbUsuarioAsc
            // 
            this.rbUsuarioAsc.AutoSize = true;
            this.rbUsuarioAsc.Checked = true;
            this.rbUsuarioAsc.Location = new System.Drawing.Point(6, 19);
            this.rbUsuarioAsc.Name = "rbUsuarioAsc";
            this.rbUsuarioAsc.Size = new System.Drawing.Size(82, 17);
            this.rbUsuarioAsc.TabIndex = 0;
            this.rbUsuarioAsc.TabStop = true;
            this.rbUsuarioAsc.Text = "Ascendente";
            this.rbUsuarioAsc.UseVisualStyleBackColor = true;
            // 
            // gbCriticidad
            // 
            this.gbCriticidad.Controls.Add(this.rbCriticidadDesc);
            this.gbCriticidad.Controls.Add(this.rbCriticidadAsc);
            this.gbCriticidad.Enabled = false;
            this.gbCriticidad.Location = new System.Drawing.Point(756, 361);
            this.gbCriticidad.Name = "gbCriticidad";
            this.gbCriticidad.Size = new System.Drawing.Size(200, 44);
            this.gbCriticidad.TabIndex = 26;
            this.gbCriticidad.TabStop = false;
            this.gbCriticidad.Text = "Orden criticidad";
            // 
            // rbCriticidadDesc
            // 
            this.rbCriticidadDesc.AutoSize = true;
            this.rbCriticidadDesc.Location = new System.Drawing.Point(105, 19);
            this.rbCriticidadDesc.Name = "rbCriticidadDesc";
            this.rbCriticidadDesc.Size = new System.Drawing.Size(89, 17);
            this.rbCriticidadDesc.TabIndex = 1;
            this.rbCriticidadDesc.Text = "Descendente";
            this.rbCriticidadDesc.UseVisualStyleBackColor = true;
            // 
            // rbCriticidadAsc
            // 
            this.rbCriticidadAsc.AutoSize = true;
            this.rbCriticidadAsc.Checked = true;
            this.rbCriticidadAsc.Location = new System.Drawing.Point(7, 20);
            this.rbCriticidadAsc.Name = "rbCriticidadAsc";
            this.rbCriticidadAsc.Size = new System.Drawing.Size(82, 17);
            this.rbCriticidadAsc.TabIndex = 0;
            this.rbCriticidadAsc.TabStop = true;
            this.rbCriticidadAsc.Text = "Ascendente";
            this.rbCriticidadAsc.UseVisualStyleBackColor = true;
            // 
            // checkFecha
            // 
            this.checkFecha.AutoSize = true;
            this.checkFecha.Location = new System.Drawing.Point(635, 267);
            this.checkFecha.Name = "checkFecha";
            this.checkFecha.Size = new System.Drawing.Size(112, 17);
            this.checkFecha.TabIndex = 27;
            this.checkFecha.Text = "Ordenar por fecha";
            this.checkFecha.UseVisualStyleBackColor = true;
            this.checkFecha.CheckStateChanged += new System.EventHandler(this.checkFecha_CheckStateChanged);
            // 
            // checkUsuarios
            // 
            this.checkUsuarios.AutoSize = true;
            this.checkUsuarios.Location = new System.Drawing.Point(635, 328);
            this.checkUsuarios.Name = "checkUsuarios";
            this.checkUsuarios.Size = new System.Drawing.Size(119, 17);
            this.checkUsuarios.TabIndex = 28;
            this.checkUsuarios.Text = "Ordenar por usuario";
            this.checkUsuarios.UseVisualStyleBackColor = true;
            this.checkUsuarios.CheckStateChanged += new System.EventHandler(this.checkUsuarios_CheckStateChanged);
            // 
            // checkCriticidad
            // 
            this.checkCriticidad.AutoSize = true;
            this.checkCriticidad.Location = new System.Drawing.Point(635, 378);
            this.checkCriticidad.Name = "checkCriticidad";
            this.checkCriticidad.Size = new System.Drawing.Size(115, 17);
            this.checkCriticidad.TabIndex = 29;
            this.checkCriticidad.Text = "Order por criticidad";
            this.checkCriticidad.UseVisualStyleBackColor = true;
            this.checkCriticidad.CheckStateChanged += new System.EventHandler(this.checkCriticidad_CheckStateChanged);
            // 
            // BitacoraFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.checkCriticidad);
            this.Controls.Add(this.checkUsuarios);
            this.Controls.Add(this.checkFecha);
            this.Controls.Add(this.gbCriticidad);
            this.Controls.Add(this.gbUsuario);
            this.Controls.Add(this.gbFecha);
            this.Controls.Add(this.cbCriticidad);
            this.Controls.Add(this.cbUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpHasta);
            this.Controls.Add(this.dtpDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BitacoraFiltros";
            this.Text = "BitacoraFiltros";
            this.Load += new System.EventHandler(this.BitacoraFiltros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BitacoraFiltros_KeyDown);
            this.gbFecha.ResumeLayout(false);
            this.gbFecha.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbCriticidad.ResumeLayout(false);
            this.gbCriticidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbUsuario;
        private System.Windows.Forms.ComboBox cbCriticidad;
        private System.Windows.Forms.GroupBox gbFecha;
        private System.Windows.Forms.RadioButton rbFechaDesc;
        private System.Windows.Forms.RadioButton rbFechaAsc;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.RadioButton rbUsuarioDesc;
        private System.Windows.Forms.RadioButton rbUsuarioAsc;
        private System.Windows.Forms.GroupBox gbCriticidad;
        private System.Windows.Forms.RadioButton rbCriticidadDesc;
        private System.Windows.Forms.RadioButton rbCriticidadAsc;
        private System.Windows.Forms.CheckBox checkFecha;
        private System.Windows.Forms.CheckBox checkUsuarios;
        private System.Windows.Forms.CheckBox checkCriticidad;
    }
}