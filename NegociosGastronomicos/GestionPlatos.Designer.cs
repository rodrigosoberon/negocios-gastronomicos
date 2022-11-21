namespace NegociosGastronomicos
{
    partial class GestionPlatos
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
            this.components = new System.ComponentModel.Container();
            this.lblGestionPlatos = new System.Windows.Forms.Label();
            this.grdPlatos = new System.Windows.Forms.DataGridView();
            this.grdIncluidos = new System.Windows.Forms.DataGridView();
            this.grdDisponibles = new System.Windows.Forms.DataGridView();
            this.lblPlatos = new System.Windows.Forms.Label();
            this.lblMaterialesIncluidos = new System.Windows.Forms.Label();
            this.lblMaterialesDisponibles = new System.Windows.Forms.Label();
            this.lblNombrePlato = new System.Windows.Forms.Label();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtImporte = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdPlatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncluidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisponibles)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionPlatos
            // 
            this.lblGestionPlatos.AutoSize = true;
            this.lblGestionPlatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionPlatos.Location = new System.Drawing.Point(15, 15);
            this.lblGestionPlatos.Name = "lblGestionPlatos";
            this.lblGestionPlatos.Size = new System.Drawing.Size(225, 31);
            this.lblGestionPlatos.TabIndex = 13;
            this.lblGestionPlatos.Text = "Gestión de platos";
            // 
            // grdPlatos
            // 
            this.grdPlatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPlatos.Location = new System.Drawing.Point(20, 85);
            this.grdPlatos.Name = "grdPlatos";
            this.grdPlatos.Size = new System.Drawing.Size(444, 474);
            this.grdPlatos.TabIndex = 14;
            this.grdPlatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPlatos_CellClick);
            // 
            // grdIncluidos
            // 
            this.grdIncluidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIncluidos.Location = new System.Drawing.Point(894, 85);
            this.grdIncluidos.Name = "grdIncluidos";
            this.grdIncluidos.Size = new System.Drawing.Size(332, 200);
            this.grdIncluidos.TabIndex = 15;
            this.grdIncluidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdIncluidos_CellClick);
            // 
            // grdDisponibles
            // 
            this.grdDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisponibles.Location = new System.Drawing.Point(894, 355);
            this.grdDisponibles.Name = "grdDisponibles";
            this.grdDisponibles.Size = new System.Drawing.Size(332, 204);
            this.grdDisponibles.TabIndex = 16;
            this.grdDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdDisponibles_CellClick);
            // 
            // lblPlatos
            // 
            this.lblPlatos.AutoSize = true;
            this.lblPlatos.Location = new System.Drawing.Point(18, 58);
            this.lblPlatos.Name = "lblPlatos";
            this.lblPlatos.Size = new System.Drawing.Size(36, 13);
            this.lblPlatos.TabIndex = 17;
            this.lblPlatos.Text = "Platos";
            // 
            // lblMaterialesIncluidos
            // 
            this.lblMaterialesIncluidos.AutoSize = true;
            this.lblMaterialesIncluidos.Location = new System.Drawing.Point(891, 58);
            this.lblMaterialesIncluidos.Name = "lblMaterialesIncluidos";
            this.lblMaterialesIncluidos.Size = new System.Drawing.Size(99, 13);
            this.lblMaterialesIncluidos.TabIndex = 18;
            this.lblMaterialesIncluidos.Text = "Materiales incluidos";
            // 
            // lblMaterialesDisponibles
            // 
            this.lblMaterialesDisponibles.AutoSize = true;
            this.lblMaterialesDisponibles.Location = new System.Drawing.Point(891, 328);
            this.lblMaterialesDisponibles.Name = "lblMaterialesDisponibles";
            this.lblMaterialesDisponibles.Size = new System.Drawing.Size(110, 13);
            this.lblMaterialesDisponibles.TabIndex = 19;
            this.lblMaterialesDisponibles.Text = "Materiales disponibles";
            // 
            // lblNombrePlato
            // 
            this.lblNombrePlato.AutoSize = true;
            this.lblNombrePlato.Location = new System.Drawing.Point(492, 239);
            this.lblNombrePlato.Name = "lblNombrePlato";
            this.lblNombrePlato.Size = new System.Drawing.Size(87, 13);
            this.lblNombrePlato.TabIndex = 20;
            this.lblNombrePlato.Text = "Nombre del plato";
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(492, 301);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 21;
            this.lblImporte.Text = "Importe";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(495, 255);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(280, 20);
            this.txtDescripcion.TabIndex = 22;
            // 
            // txtImporte
            // 
            this.txtImporte.Location = new System.Drawing.Point(495, 321);
            this.txtImporte.Name = "txtImporte";
            this.txtImporte.Size = new System.Drawing.Size(280, 20);
            this.txtImporte.TabIndex = 23;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(444, 610);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 24;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(552, 610);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 25;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(676, 610);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 26;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBaja_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(801, 610);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(581, 366);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(113, 23);
            this.btnLimpiarCampos.TabIndex = 28;
            this.btnLimpiarCampos.Text = "Limpiar Campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(801, 157);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(79, 45);
            this.btnQuitar.TabIndex = 29;
            this.btnQuitar.Text = "Quitar material";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(801, 428);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(79, 42);
            this.btnIncluir.TabIndex = 30;
            this.btnIncluir.Text = "Incluir material";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // GestionPlatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtImporte);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblImporte);
            this.Controls.Add(this.lblNombrePlato);
            this.Controls.Add(this.lblMaterialesDisponibles);
            this.Controls.Add(this.lblMaterialesIncluidos);
            this.Controls.Add(this.lblPlatos);
            this.Controls.Add(this.grdDisponibles);
            this.Controls.Add(this.grdIncluidos);
            this.Controls.Add(this.grdPlatos);
            this.Controls.Add(this.lblGestionPlatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionPlatos";
            this.Text = "GestionPlatos";
            this.Load += new System.EventHandler(this.GestionPlatos_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GestionPlatos_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdPlatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdIncluidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisponibles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionPlatos;
        private System.Windows.Forms.DataGridView grdPlatos;
        private System.Windows.Forms.DataGridView grdIncluidos;
        private System.Windows.Forms.DataGridView grdDisponibles;
        private System.Windows.Forms.Label lblPlatos;
        private System.Windows.Forms.Label lblMaterialesIncluidos;
        private System.Windows.Forms.Label lblMaterialesDisponibles;
        private System.Windows.Forms.Label lblNombrePlato;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtImporte;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolTip toolTip;
    }
}