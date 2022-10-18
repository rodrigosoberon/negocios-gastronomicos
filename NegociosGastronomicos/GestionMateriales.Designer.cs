
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
            this.btnAgregarMaterial = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.grdMateriales = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBajaMaterial = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificarMaterial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarMaterial
            // 
            this.btnAgregarMaterial.Location = new System.Drawing.Point(440, 622);
            this.btnAgregarMaterial.Name = "btnAgregarMaterial";
            this.btnAgregarMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarMaterial.TabIndex = 0;
            this.btnAgregarMaterial.Text = "Agregar";
            this.btnAgregarMaterial.UseVisualStyleBackColor = true;
            this.btnAgregarMaterial.Click += new System.EventHandler(this.btnAgregarMaterial_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(747, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(846, 73);
            this.txtDescripcion.Name = "txtDescripcion";
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
            this.grdMateriales.Size = new System.Drawing.Size(581, 526);
            this.grdMateriales.TabIndex = 5;
            this.grdMateriales.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMateriales_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(959, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpiar campos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBajaMaterial
            // 
            this.btnBajaMaterial.Location = new System.Drawing.Point(682, 622);
            this.btnBajaMaterial.Name = "btnBajaMaterial";
            this.btnBajaMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnBajaMaterial.TabIndex = 8;
            this.btnBajaMaterial.Text = "Baja";
            this.btnBajaMaterial.UseVisualStyleBackColor = true;
            this.btnBajaMaterial.Click += new System.EventHandler(this.btnBajaMaterial_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(803, 622);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnModificarMaterial
            // 
            this.btnModificarMaterial.Location = new System.Drawing.Point(561, 622);
            this.btnModificarMaterial.Name = "btnModificarMaterial";
            this.btnModificarMaterial.Size = new System.Drawing.Size(75, 23);
            this.btnModificarMaterial.TabIndex = 10;
            this.btnModificarMaterial.Text = "Modificar";
            this.btnModificarMaterial.UseVisualStyleBackColor = true;
            this.btnModificarMaterial.Click += new System.EventHandler(this.btnModificarMaterial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 31);
            this.label4.TabIndex = 11;
            this.label4.Text = "Gestión de materiales";
            // 
            // GestionMateriales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnModificarMaterial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnBajaMaterial);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grdMateriales);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarMaterial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionMateriales";
            this.Text = "Gestión de Materiales";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.DataGridView grdMateriales;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBajaMaterial;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificarMaterial;
        private System.Windows.Forms.Label label4;
    }
}

