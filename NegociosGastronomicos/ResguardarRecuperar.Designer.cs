namespace NegociosGastronomicos
{
    partial class ResguardarRecuperar
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
            this.lblResguardarRecuperar = new System.Windows.Forms.Label();
            this.btnResguardar = new System.Windows.Forms.Button();
            this.btnRestaurar = new System.Windows.Forms.Button();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.lblUbicacion = new System.Windows.Forms.Label();
            this.grdBackups = new System.Windows.Forms.DataGridView();
            this.cbPartes = new System.Windows.Forms.ComboBox();
            this.lblParticiones = new System.Windows.Forms.Label();
            this.lblCopias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdBackups)).BeginInit();
            this.SuspendLayout();
            // 
            // lblResguardarRecuperar
            // 
            this.lblResguardarRecuperar.AutoSize = true;
            this.lblResguardarRecuperar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResguardarRecuperar.Location = new System.Drawing.Point(15, 15);
            this.lblResguardarRecuperar.Name = "lblResguardarRecuperar";
            this.lblResguardarRecuperar.Size = new System.Drawing.Size(305, 31);
            this.lblResguardarRecuperar.TabIndex = 13;
            this.lblResguardarRecuperar.Text = "Resguardar / Recuperar";
            // 
            // btnResguardar
            // 
            this.btnResguardar.Location = new System.Drawing.Point(297, 142);
            this.btnResguardar.Name = "btnResguardar";
            this.btnResguardar.Size = new System.Drawing.Size(93, 23);
            this.btnResguardar.TabIndex = 14;
            this.btnResguardar.Text = "Resguardar";
            this.btnResguardar.UseVisualStyleBackColor = true;
            this.btnResguardar.Click += new System.EventHandler(this.btnResguardar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Location = new System.Drawing.Point(813, 591);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(93, 23);
            this.btnRestaurar.TabIndex = 15;
            this.btnRestaurar.Text = "Restaurar";
            this.btnRestaurar.UseVisualStyleBackColor = true;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Location = new System.Drawing.Point(21, 104);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(369, 20);
            this.txtUbicacion.TabIndex = 16;
            this.txtUbicacion.Text = "c:\\backups";
            // 
            // lblUbicacion
            // 
            this.lblUbicacion.AutoSize = true;
            this.lblUbicacion.Location = new System.Drawing.Point(18, 77);
            this.lblUbicacion.Name = "lblUbicacion";
            this.lblUbicacion.Size = new System.Drawing.Size(55, 13);
            this.lblUbicacion.TabIndex = 17;
            this.lblUbicacion.Text = "Ubicación";
            // 
            // grdBackups
            // 
            this.grdBackups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBackups.Location = new System.Drawing.Point(491, 104);
            this.grdBackups.Name = "grdBackups";
            this.grdBackups.Size = new System.Drawing.Size(716, 472);
            this.grdBackups.TabIndex = 18;
            this.grdBackups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBackups_CellClick);
            // 
            // cbPartes
            // 
            this.cbPartes.FormattingEnabled = true;
            this.cbPartes.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPartes.Location = new System.Drawing.Point(83, 144);
            this.cbPartes.Name = "cbPartes";
            this.cbPartes.Size = new System.Drawing.Size(45, 21);
            this.cbPartes.TabIndex = 19;
            this.cbPartes.Text = "1";
            // 
            // lblParticiones
            // 
            this.lblParticiones.AutoSize = true;
            this.lblParticiones.Location = new System.Drawing.Point(18, 147);
            this.lblParticiones.Name = "lblParticiones";
            this.lblParticiones.Size = new System.Drawing.Size(59, 13);
            this.lblParticiones.TabIndex = 20;
            this.lblParticiones.Text = "Particiones";
            // 
            // lblCopias
            // 
            this.lblCopias.AutoSize = true;
            this.lblCopias.Location = new System.Drawing.Point(491, 77);
            this.lblCopias.Name = "lblCopias";
            this.lblCopias.Size = new System.Drawing.Size(103, 13);
            this.lblCopias.TabIndex = 21;
            this.lblCopias.Text = "Copias de seguridad";
            // 
            // ResguardarRecuperar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.lblCopias);
            this.Controls.Add(this.lblParticiones);
            this.Controls.Add(this.cbPartes);
            this.Controls.Add(this.grdBackups);
            this.Controls.Add(this.lblUbicacion);
            this.Controls.Add(this.txtUbicacion);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnResguardar);
            this.Controls.Add(this.lblResguardarRecuperar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResguardarRecuperar";
            this.Text = "ResguardarRecuperar";
            this.Load += new System.EventHandler(this.ResguardarRecuperar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ResguardarRecuperar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.grdBackups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResguardarRecuperar;
        private System.Windows.Forms.Button btnResguardar;
        private System.Windows.Forms.Button btnRestaurar;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label lblUbicacion;
        private System.Windows.Forms.DataGridView grdBackups;
        private System.Windows.Forms.ComboBox cbPartes;
        private System.Windows.Forms.Label lblParticiones;
        private System.Windows.Forms.Label lblCopias;
    }
}