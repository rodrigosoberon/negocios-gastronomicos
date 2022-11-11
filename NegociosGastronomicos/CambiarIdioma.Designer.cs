namespace NegociosGastronomicos
{
    partial class CambiarIdioma
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblCambiarIdioma = new System.Windows.Forms.Label();
            this.lblIdiomaActual = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblIdiomasDisponibles = new System.Windows.Forms.Label();
            this.cbIdioma = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(211, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCambiar
            // 
            this.btnCambiar.Location = new System.Drawing.Point(61, 258);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(75, 23);
            this.btnCambiar.TabIndex = 23;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblCambiarIdioma
            // 
            this.lblCambiarIdioma.AutoSize = true;
            this.lblCambiarIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCambiarIdioma.Location = new System.Drawing.Point(15, 15);
            this.lblCambiarIdioma.Name = "lblCambiarIdioma";
            this.lblCambiarIdioma.Size = new System.Drawing.Size(202, 31);
            this.lblCambiarIdioma.TabIndex = 22;
            this.lblCambiarIdioma.Text = "Cambiar idioma";
            // 
            // lblIdiomaActual
            // 
            this.lblIdiomaActual.AutoSize = true;
            this.lblIdiomaActual.Location = new System.Drawing.Point(56, 117);
            this.lblIdiomaActual.Name = "lblIdiomaActual";
            this.lblIdiomaActual.Size = new System.Drawing.Size(70, 13);
            this.lblIdiomaActual.TabIndex = 25;
            this.lblIdiomaActual.Text = "Idioma actual";
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(185, 115);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(49, 17);
            this.lblIdioma.TabIndex = 26;
            this.lblIdioma.Text = "idioma";
            // 
            // lblIdiomasDisponibles
            // 
            this.lblIdiomasDisponibles.AutoSize = true;
            this.lblIdiomasDisponibles.Location = new System.Drawing.Point(56, 172);
            this.lblIdiomasDisponibles.Name = "lblIdiomasDisponibles";
            this.lblIdiomasDisponibles.Size = new System.Drawing.Size(101, 13);
            this.lblIdiomasDisponibles.TabIndex = 27;
            this.lblIdiomasDisponibles.Text = "Idiomas disponibles:";
            // 
            // cbIdioma
            // 
            this.cbIdioma.FormattingEnabled = true;
            this.cbIdioma.Items.AddRange(new object[] {
            "es",
            "en",
            "pt"});
            this.cbIdioma.Location = new System.Drawing.Point(188, 169);
            this.cbIdioma.Name = "cbIdioma";
            this.cbIdioma.Size = new System.Drawing.Size(46, 21);
            this.cbIdioma.TabIndex = 28;
            // 
            // CambiarIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.cbIdioma);
            this.Controls.Add(this.lblIdiomasDisponibles);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.lblIdiomaActual);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCambiar);
            this.Controls.Add(this.lblCambiarIdioma);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CambiarIdioma";
            this.Text = "CambiarIdioma";
            this.Load += new System.EventHandler(this.CambiarIdioma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lblCambiarIdioma;
        private System.Windows.Forms.Label lblIdiomaActual;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblIdiomasDisponibles;
        private System.Windows.Forms.ComboBox cbIdioma;
    }
}