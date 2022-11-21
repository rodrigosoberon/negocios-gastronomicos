
namespace NegociosGastronomicos
{
    partial class GestionMateriales
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblDesccripcion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grdMateriales = new System.Windows.Forms.DataGridView();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnBaja = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblGestionMateriales = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(440, 622);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // lblDesccripcion
            // 
            this.lblDesccripcion.AutoSize = true;
            this.lblDesccripcion.Location = new System.Drawing.Point(747, 76);
            this.lblDesccripcion.Name = "lblDesccripcion";
            this.lblDesccripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDesccripcion.TabIndex = 1;
            this.lblDesccripcion.Text = "Descripcion";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(747, 144);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            this.helpProvider.SetHelpString(this.txtDescripcion, "Ingrese una descripción para el material");
            this.txtDescripcion.Location = new System.Drawing.Point(846, 73);
            this.txtDescripcion.Name = "txtDescripcion";
            this.helpProvider.SetShowHelp(this.txtDescripcion, true);
            this.txtDescripcion.Size = new System.Drawing.Size(406, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(846, 141);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(406, 20);
            this.txtCantidad.TabIndex = 4;
            // 
            // grdMateriales
            // 
            this.grdMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMateriales.Location = new System.Drawing.Point(12, 73);
            this.grdMateriales.Name = "grdMateriales";
            this.grdMateriales.ReadOnly = true;
            this.grdMateriales.Size = new System.Drawing.Size(710, 526);
            this.grdMateriales.TabIndex = 5;
            this.grdMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMateriales_CellClick);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(959, 207);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(92, 23);
            this.btnLimpiarCampos.TabIndex = 7;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnBaja
            // 
            this.btnBaja.Location = new System.Drawing.Point(682, 622);
            this.btnBaja.Name = "btnBaja";
            this.btnBaja.Size = new System.Drawing.Size(75, 23);
            this.btnBaja.TabIndex = 8;
            this.btnBaja.Text = "Baja";
            this.btnBaja.UseVisualStyleBackColor = true;
            this.btnBaja.Click += new System.EventHandler(this.btnBajaMaterial_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(803, 622);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(561, 622);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 10;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificarMaterial_Click);
            // 
            // lblGestionMateriales
            // 
            this.lblGestionMateriales.AutoSize = true;
            this.lblGestionMateriales.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionMateriales.Location = new System.Drawing.Point(15, 15);
            this.lblGestionMateriales.Name = "lblGestionMateriales";
            this.lblGestionMateriales.Size = new System.Drawing.Size(277, 31);
            this.lblGestionMateriales.TabIndex = 11;
            this.lblGestionMateriales.Text = "Gestión de materiales";
            // 
            // GestionMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.lblGestionMateriales);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBaja);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.grdMateriales);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblDesccripcion);
            this.Controls.Add(this.btnAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionMateriales";
            this.Text = "Gestión de Materiales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GestionMateriales_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblDesccripcion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView grdMateriales;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnBaja;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblGestionMateriales;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

