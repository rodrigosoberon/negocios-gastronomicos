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
            this.btnLimpiarCamposF = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoverPatente = new System.Windows.Forms.Button();
            this.btnAsignarPatente = new System.Windows.Forms.Button();
            this.txtDescripcionF = new System.Windows.Forms.TextBox();
            this.btnModificarF = new System.Windows.Forms.Button();
            this.btnCancelarF = new System.Windows.Forms.Button();
            this.btnAgregarF = new System.Windows.Forms.Button();
            this.btnBajaF = new System.Windows.Forms.Button();
            this.grdAsignadas = new System.Windows.Forms.DataGridView();
            this.grdDisponibles = new System.Windows.Forms.DataGridView();
            this.lblPatentesAsignadas = new System.Windows.Forms.Label();
            this.lblPatentesDisponibles = new System.Windows.Forms.Label();
            this.lblDescripcionF = new System.Windows.Forms.Label();
            this.lblListadoFamilias = new System.Windows.Forms.Label();
            this.grdFamilias = new System.Windows.Forms.DataGridView();
            this.tabPatentes = new System.Windows.Forms.TabPage();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.grdPatentes = new System.Windows.Forms.DataGridView();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.tabControl1.SuspendLayout();
            this.tabFamilias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamilias)).BeginInit();
            this.tabPatentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
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
            this.tabFamilias.Controls.Add(this.btnLimpiarCamposF);
            this.tabFamilias.Controls.Add(this.label6);
            this.tabFamilias.Controls.Add(this.label5);
            this.tabFamilias.Controls.Add(this.btnRemoverPatente);
            this.tabFamilias.Controls.Add(this.btnAsignarPatente);
            this.tabFamilias.Controls.Add(this.txtDescripcionF);
            this.tabFamilias.Controls.Add(this.btnModificarF);
            this.tabFamilias.Controls.Add(this.btnCancelarF);
            this.tabFamilias.Controls.Add(this.btnAgregarF);
            this.tabFamilias.Controls.Add(this.btnBajaF);
            this.tabFamilias.Controls.Add(this.grdAsignadas);
            this.tabFamilias.Controls.Add(this.grdDisponibles);
            this.tabFamilias.Controls.Add(this.lblPatentesAsignadas);
            this.tabFamilias.Controls.Add(this.lblPatentesDisponibles);
            this.tabFamilias.Controls.Add(this.lblDescripcionF);
            this.tabFamilias.Controls.Add(this.lblListadoFamilias);
            this.tabFamilias.Controls.Add(this.grdFamilias);
            this.tabFamilias.Location = new System.Drawing.Point(4, 22);
            this.tabFamilias.Name = "tabFamilias";
            this.tabFamilias.Padding = new System.Windows.Forms.Padding(3);
            this.tabFamilias.Size = new System.Drawing.Size(1208, 551);
            this.tabFamilias.TabIndex = 0;
            this.tabFamilias.Text = "Familias";
            this.tabFamilias.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarCamposF
            // 
            this.btnLimpiarCamposF.Location = new System.Drawing.Point(97, 511);
            this.btnLimpiarCamposF.Name = "btnLimpiarCamposF";
            this.btnLimpiarCamposF.Size = new System.Drawing.Size(89, 23);
            this.btnLimpiarCamposF.TabIndex = 28;
            this.btnLimpiarCamposF.Text = "Limpiar campos";
            this.btnLimpiarCamposF.UseVisualStyleBackColor = true;
            this.btnLimpiarCamposF.Click += new System.EventHandler(this.btnLimpiarCamposF_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(779, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "← ← ← ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(779, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "→ → →";
            // 
            // btnRemoverPatente
            // 
            this.btnRemoverPatente.Location = new System.Drawing.Point(753, 281);
            this.btnRemoverPatente.Name = "btnRemoverPatente";
            this.btnRemoverPatente.Size = new System.Drawing.Size(104, 23);
            this.btnRemoverPatente.TabIndex = 25;
            this.btnRemoverPatente.Text = "Remover patente";
            this.btnRemoverPatente.UseVisualStyleBackColor = true;
            this.btnRemoverPatente.Click += new System.EventHandler(this.btnRemoverPatente_Click);
            // 
            // btnAsignarPatente
            // 
            this.btnAsignarPatente.Location = new System.Drawing.Point(753, 145);
            this.btnAsignarPatente.Name = "btnAsignarPatente";
            this.btnAsignarPatente.Size = new System.Drawing.Size(104, 23);
            this.btnAsignarPatente.TabIndex = 24;
            this.btnAsignarPatente.Text = "Asignar patente";
            this.btnAsignarPatente.UseVisualStyleBackColor = true;
            this.btnAsignarPatente.Click += new System.EventHandler(this.btnAsignarPatente_Click);
            // 
            // txtDescripcionF
            // 
            this.txtDescripcionF.Location = new System.Drawing.Point(15, 476);
            this.txtDescripcionF.Name = "txtDescripcionF";
            this.txtDescripcionF.Size = new System.Drawing.Size(271, 20);
            this.txtDescripcionF.TabIndex = 23;
            // 
            // btnModificarF
            // 
            this.btnModificarF.Location = new System.Drawing.Point(540, 511);
            this.btnModificarF.Name = "btnModificarF";
            this.btnModificarF.Size = new System.Drawing.Size(75, 23);
            this.btnModificarF.TabIndex = 22;
            this.btnModificarF.Text = "Modificar";
            this.btnModificarF.UseVisualStyleBackColor = true;
            this.btnModificarF.Click += new System.EventHandler(this.btnModificarF_Click);
            // 
            // btnCancelarF
            // 
            this.btnCancelarF.Location = new System.Drawing.Point(782, 511);
            this.btnCancelarF.Name = "btnCancelarF";
            this.btnCancelarF.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarF.TabIndex = 21;
            this.btnCancelarF.Text = "Cancelar";
            this.btnCancelarF.UseVisualStyleBackColor = true;
            this.btnCancelarF.Click += new System.EventHandler(this.btnCancelarF_Click);
            // 
            // btnAgregarF
            // 
            this.btnAgregarF.Location = new System.Drawing.Point(419, 511);
            this.btnAgregarF.Name = "btnAgregarF";
            this.btnAgregarF.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarF.TabIndex = 19;
            this.btnAgregarF.Text = "Agregar";
            this.btnAgregarF.UseVisualStyleBackColor = true;
            this.btnAgregarF.Click += new System.EventHandler(this.btnAgregarF_Click);
            // 
            // btnBajaF
            // 
            this.btnBajaF.Location = new System.Drawing.Point(661, 511);
            this.btnBajaF.Name = "btnBajaF";
            this.btnBajaF.Size = new System.Drawing.Size(75, 23);
            this.btnBajaF.TabIndex = 20;
            this.btnBajaF.Text = "Baja";
            this.btnBajaF.UseVisualStyleBackColor = true;
            this.btnBajaF.Click += new System.EventHandler(this.btnBajaF_Click);
            // 
            // grdAsignadas
            // 
            this.grdAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAsignadas.Location = new System.Drawing.Point(406, 35);
            this.grdAsignadas.Name = "grdAsignadas";
            this.grdAsignadas.ReadOnly = true;
            this.grdAsignadas.Size = new System.Drawing.Size(274, 406);
            this.grdAsignadas.TabIndex = 6;
            this.grdAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAsignadas_CellClick);
            // 
            // grdDisponibles
            // 
            this.grdDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisponibles.Location = new System.Drawing.Point(914, 35);
            this.grdDisponibles.Name = "grdDisponibles";
            this.grdDisponibles.ReadOnly = true;
            this.grdDisponibles.Size = new System.Drawing.Size(274, 406);
            this.grdDisponibles.TabIndex = 5;
            this.grdDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDisponibles_CellClick);
            // 
            // lblPatentesAsignadas
            // 
            this.lblPatentesAsignadas.AutoSize = true;
            this.lblPatentesAsignadas.Location = new System.Drawing.Point(403, 16);
            this.lblPatentesAsignadas.Name = "lblPatentesAsignadas";
            this.lblPatentesAsignadas.Size = new System.Drawing.Size(101, 13);
            this.lblPatentesAsignadas.TabIndex = 4;
            this.lblPatentesAsignadas.Text = "Patentes Asignadas";
            // 
            // lblPatentesDisponibles
            // 
            this.lblPatentesDisponibles.AutoSize = true;
            this.lblPatentesDisponibles.Location = new System.Drawing.Point(911, 16);
            this.lblPatentesDisponibles.Name = "lblPatentesDisponibles";
            this.lblPatentesDisponibles.Size = new System.Drawing.Size(106, 13);
            this.lblPatentesDisponibles.TabIndex = 3;
            this.lblPatentesDisponibles.Text = "Patentes Disponibles";
            // 
            // lblDescripcionF
            // 
            this.lblDescripcionF.AutoSize = true;
            this.lblDescripcionF.Location = new System.Drawing.Point(12, 460);
            this.lblDescripcionF.Name = "lblDescripcionF";
            this.lblDescripcionF.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionF.TabIndex = 2;
            this.lblDescripcionF.Text = "Descripcion";
            // 
            // lblListadoFamilias
            // 
            this.lblListadoFamilias.AutoSize = true;
            this.lblListadoFamilias.Location = new System.Drawing.Point(12, 16);
            this.lblListadoFamilias.Name = "lblListadoFamilias";
            this.lblListadoFamilias.Size = new System.Drawing.Size(93, 13);
            this.lblListadoFamilias.TabIndex = 1;
            this.lblListadoFamilias.Text = "Listado de familias";
            // 
            // grdFamilias
            // 
            this.grdFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFamilias.Location = new System.Drawing.Point(12, 35);
            this.grdFamilias.Name = "grdFamilias";
            this.grdFamilias.ReadOnly = true;
            this.grdFamilias.Size = new System.Drawing.Size(274, 406);
            this.grdFamilias.TabIndex = 0;
            this.grdFamilias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFamilias_CellClick);
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
            this.grdPatentes.ReadOnly = true;
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
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
            this.tabFamilias.ResumeLayout(false);
            this.tabFamilias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamilias)).EndInit();
            this.tabPatentes.ResumeLayout(false);
            this.tabPatentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoverPatente;
        private System.Windows.Forms.Button btnAsignarPatente;
        private System.Windows.Forms.TextBox txtDescripcionF;
        private System.Windows.Forms.Button btnModificarF;
        private System.Windows.Forms.Button btnCancelarF;
        private System.Windows.Forms.Button btnAgregarF;
        private System.Windows.Forms.Button btnBajaF;
        private System.Windows.Forms.DataGridView grdAsignadas;
        private System.Windows.Forms.DataGridView grdDisponibles;
        private System.Windows.Forms.Label lblPatentesAsignadas;
        private System.Windows.Forms.Label lblPatentesDisponibles;
        private System.Windows.Forms.Label lblDescripcionF;
        private System.Windows.Forms.Label lblListadoFamilias;
        private System.Windows.Forms.DataGridView grdFamilias;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Button btnLimpiarCamposF;
    }
}