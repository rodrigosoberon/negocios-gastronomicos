namespace NegociosGastronomicos
{
    partial class GestionPermisos
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
            this.lblGestionPermisos = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFamilias = new System.Windows.Forms.TabPage();
            this.tabPatentes = new System.Windows.Forms.TabPage();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grdPatentes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPatentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatentes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPermisos
            // 
            this.lblGestionPermisos.AutoSize = true;
            this.lblGestionPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPermisos.Location = new System.Drawing.Point(15, 15);
            this.lblGestionPermisos.Name = "lblGestionPermisos";
            this.lblGestionPermisos.Size = new System.Drawing.Size(262, 31);
            this.lblGestionPermisos.TabIndex = 13;
            this.lblGestionPermisos.Text = "Gestión de permisos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFamilias);
            this.tabControl1.Controls.Add(this.tabPatentes);
            this.tabControl1.Location = new System.Drawing.Point(21, 58);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1216, 577);
            this.tabControl1.TabIndex = 14;
            // 
            // tabFamilias
            // 
            this.tabFamilias.Location = new System.Drawing.Point(4, 22);
            this.tabFamilias.Name = "tabFamilias";
            this.tabFamilias.Padding = new System.Windows.Forms.Padding(3);
            this.tabFamilias.Size = new System.Drawing.Size(1208, 551);
            this.tabFamilias.TabIndex = 0;
            this.tabFamilias.Text = "Familias";
            this.tabFamilias.UseVisualStyleBackColor = true;
            // 
            // tabPatentes
            // 
            this.tabPatentes.Controls.Add(this.btnLimpiarCampos);
            this.tabPatentes.Controls.Add(this.txtDescripcion);
            this.tabPatentes.Controls.Add(this.lblDescripcion);
            this.tabPatentes.Controls.Add(this.grdPatentes);
            this.tabPatentes.Controls.Add(this.btnModificar);
            this.tabPatentes.Controls.Add(this.btnCancelar);
            this.tabPatentes.Controls.Add(this.btnAgregar);
            this.tabPatentes.Controls.Add(this.btnBaja);
            this.tabPatentes.Location = new System.Drawing.Point(4, 22);
            this.tabPatentes.Name = "tabPatentes";
            this.tabPatentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPatentes.Size = new System.Drawing.Size(1208, 551);
            this.tabPatentes.TabIndex = 1;
            this.tabPatentes.Text = "Patentes";
            this.tabPatentes.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(777, 448);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(89, 23);
            this.btnLimpiarCampos.TabIndex = 25;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(428, 450);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(317, 20);
            this.txtDescripcion.TabIndex = 21;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(425, 425);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 20;
            this.lblDescripcion.Text = "Descripción";
            // 
            // grdPatentes
            // 
            this.grdPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatentes.Location = new System.Drawing.Point(12, 15);
            this.grdPatentes.Name = "grdPatentes";
            this.grdPatentes.Size = new System.Drawing.Size(314, 522);
            this.grdPatentes.TabIndex = 19;
            this.grdPatentes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatentes_CellClick);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(549, 502);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(791, 502);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(428, 502);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(670, 502);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 16;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // GestionPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblGestionPermisos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionPermisos";
            this.Text = "GestionPermisos";
            this.Load += new System.EventHandler(this.GestionPermisos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPatentes.ResumeLayout(false);
            this.tabPatentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPermisos;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFamilias;
        private System.Windows.Forms.TabPage tabPatentes;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView grdPatentes;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}