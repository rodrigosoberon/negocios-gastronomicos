namespace NegociosGastronomicos
{
    partial class GestionUsuarios
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
            this.lblGestionUsuarios = new System.Windows.Forms.Label();
            this.grdUsuarios = new System.Windows.Forms.DataGridView();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEstado = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tabControlFP = new System.Windows.Forms.TabControl();
            this.tabPageFamilias = new System.Windows.Forms.TabPage();
            this.btnFamRemover = new System.Windows.Forms.Button();
            this.btnFamAsignar = new System.Windows.Forms.Button();
            this.lblFamDisponibles = new System.Windows.Forms.Label();
            this.lblFamAsignadas = new System.Windows.Forms.Label();
            this.grdFamDisponibles = new System.Windows.Forms.DataGridView();
            this.grdFamAsignadas = new System.Windows.Forms.DataGridView();
            this.tabPagePatentes = new System.Windows.Forms.TabPage();
            this.btnPatRemover = new System.Windows.Forms.Button();
            this.btnPatAsignar = new System.Windows.Forms.Button();
            this.lblPatDisponibles = new System.Windows.Forms.Label();
            this.lblPatAsignadas = new System.Windows.Forms.Label();
            this.grdPatDisponibles = new System.Windows.Forms.DataGridView();
            this.grdPatAsignadas = new System.Windows.Forms.DataGridView();
            this.hpUsuario = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).BeginInit();
            this.tabControlFP.SuspendLayout();
            this.tabPageFamilias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamAsignadas)).BeginInit();
            this.tabPagePatentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatAsignadas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGestionUsuarios
            // 
            this.lblGestionUsuarios.AutoSize = true;
            this.lblGestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionUsuarios.Location = new System.Drawing.Point(15, 15);
            this.lblGestionUsuarios.Name = "lblGestionUsuarios";
            this.lblGestionUsuarios.Size = new System.Drawing.Size(255, 31);
            this.lblGestionUsuarios.TabIndex = 12;
            this.lblGestionUsuarios.Text = "Gestión de usuarios";
            // 
            // grdUsuarios
            // 
            this.grdUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuarios.Location = new System.Drawing.Point(21, 62);
            this.grdUsuarios.Name = "grdUsuarios";
            this.grdUsuarios.ReadOnly = true;
            this.grdUsuarios.Size = new System.Drawing.Size(545, 531);
            this.grdUsuarios.TabIndex = 13;
            this.grdUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdUsuarios_CellClick);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(586, 195);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(586, 262);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(586, 330);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 16;
            this.lblApellido.Text = "Apellido";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(586, 396);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 17;
            this.lblEmail.Text = "Email";
            // 
            // txtNombreUsuario
            // 
            this.hpUsuario.SetHelpString(this.txtNombreUsuario, "Ingrese un nombre identificatorio para el usuario");
            this.txtNombreUsuario.Location = new System.Drawing.Point(586, 211);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.hpUsuario.SetShowHelp(this.txtNombreUsuario, true);
            this.txtNombreUsuario.Size = new System.Drawing.Size(188, 20);
            this.txtNombreUsuario.TabIndex = 19;
            // 
            // txtNombre
            // 
            this.hpUsuario.SetHelpKeyword(this.txtNombre, "");
            this.hpUsuario.SetHelpString(this.txtNombre, "Ingrese el nombre de pila del usuario");
            this.txtNombre.Location = new System.Drawing.Point(586, 278);
            this.txtNombre.Name = "txtNombre";
            this.hpUsuario.SetShowHelp(this.txtNombre, true);
            this.txtNombre.Size = new System.Drawing.Size(188, 20);
            this.txtNombre.TabIndex = 20;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(586, 346);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(188, 20);
            this.txtApellido.TabIndex = 21;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(586, 412);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 22;
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(643, 466);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(89, 23);
            this.btnLimpiarCampos.TabIndex = 24;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(536, 611);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 28;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(790, 611);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 27;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Location = new System.Drawing.Point(641, 611);
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Size = new System.Drawing.Size(119, 23);
            this.btnEstado.TabIndex = 26;
            this.btnEstado.Text = "Habilitar/Deshabilitar";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.btnEstado_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(431, 611);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tabControlFP
            // 
            this.tabControlFP.Controls.Add(this.tabPageFamilias);
            this.tabControlFP.Controls.Add(this.tabPagePatentes);
            this.tabControlFP.Location = new System.Drawing.Point(787, 62);
            this.tabControlFP.Name = "tabControlFP";
            this.tabControlFP.SelectedIndex = 0;
            this.tabControlFP.Size = new System.Drawing.Size(465, 531);
            this.tabControlFP.TabIndex = 29;
            // 
            // tabPageFamilias
            // 
            this.tabPageFamilias.Controls.Add(this.btnFamRemover);
            this.tabPageFamilias.Controls.Add(this.btnFamAsignar);
            this.tabPageFamilias.Controls.Add(this.lblFamDisponibles);
            this.tabPageFamilias.Controls.Add(this.lblFamAsignadas);
            this.tabPageFamilias.Controls.Add(this.grdFamDisponibles);
            this.tabPageFamilias.Controls.Add(this.grdFamAsignadas);
            this.tabPageFamilias.Location = new System.Drawing.Point(4, 22);
            this.tabPageFamilias.Name = "tabPageFamilias";
            this.tabPageFamilias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFamilias.Size = new System.Drawing.Size(457, 505);
            this.tabPageFamilias.TabIndex = 0;
            this.tabPageFamilias.Text = "Familias";
            this.tabPageFamilias.UseVisualStyleBackColor = true;
            // 
            // btnFamRemover
            // 
            this.btnFamRemover.Location = new System.Drawing.Point(208, 275);
            this.btnFamRemover.Name = "btnFamRemover";
            this.btnFamRemover.Size = new System.Drawing.Size(52, 23);
            this.btnFamRemover.TabIndex = 5;
            this.btnFamRemover.Text = "->";
            this.btnFamRemover.UseVisualStyleBackColor = true;
            this.btnFamRemover.Click += new System.EventHandler(this.btnFamRemover_Click);
            // 
            // btnFamAsignar
            // 
            this.btnFamAsignar.Location = new System.Drawing.Point(208, 193);
            this.btnFamAsignar.Name = "btnFamAsignar";
            this.btnFamAsignar.Size = new System.Drawing.Size(52, 23);
            this.btnFamAsignar.TabIndex = 4;
            this.btnFamAsignar.Text = "<-";
            this.btnFamAsignar.UseVisualStyleBackColor = true;
            this.btnFamAsignar.Click += new System.EventHandler(this.btnFamAsignar_Click);
            // 
            // lblFamDisponibles
            // 
            this.lblFamDisponibles.AutoSize = true;
            this.lblFamDisponibles.Location = new System.Drawing.Point(274, 15);
            this.lblFamDisponibles.Name = "lblFamDisponibles";
            this.lblFamDisponibles.Size = new System.Drawing.Size(61, 13);
            this.lblFamDisponibles.TabIndex = 3;
            this.lblFamDisponibles.Text = "Disponibles";
            // 
            // lblFamAsignadas
            // 
            this.lblFamAsignadas.AutoSize = true;
            this.lblFamAsignadas.Location = new System.Drawing.Point(15, 15);
            this.lblFamAsignadas.Name = "lblFamAsignadas";
            this.lblFamAsignadas.Size = new System.Drawing.Size(56, 13);
            this.lblFamAsignadas.TabIndex = 2;
            this.lblFamAsignadas.Text = "Asigandas";
            // 
            // grdFamDisponibles
            // 
            this.grdFamDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFamDisponibles.Location = new System.Drawing.Point(274, 34);
            this.grdFamDisponibles.Name = "grdFamDisponibles";
            this.grdFamDisponibles.Size = new System.Drawing.Size(166, 456);
            this.grdFamDisponibles.TabIndex = 1;
            this.grdFamDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFamDisponibles_CellClick);
            // 
            // grdFamAsignadas
            // 
            this.grdFamAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFamAsignadas.Location = new System.Drawing.Point(15, 34);
            this.grdFamAsignadas.Name = "grdFamAsignadas";
            this.grdFamAsignadas.Size = new System.Drawing.Size(176, 456);
            this.grdFamAsignadas.TabIndex = 0;
            this.grdFamAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdFamAsignadas_CellClick);
            // 
            // tabPagePatentes
            // 
            this.tabPagePatentes.Controls.Add(this.btnPatRemover);
            this.tabPagePatentes.Controls.Add(this.btnPatAsignar);
            this.tabPagePatentes.Controls.Add(this.lblPatDisponibles);
            this.tabPagePatentes.Controls.Add(this.lblPatAsignadas);
            this.tabPagePatentes.Controls.Add(this.grdPatDisponibles);
            this.tabPagePatentes.Controls.Add(this.grdPatAsignadas);
            this.tabPagePatentes.Location = new System.Drawing.Point(4, 22);
            this.tabPagePatentes.Name = "tabPagePatentes";
            this.tabPagePatentes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePatentes.Size = new System.Drawing.Size(457, 505);
            this.tabPagePatentes.TabIndex = 1;
            this.tabPagePatentes.Text = "Patentes";
            this.tabPagePatentes.UseVisualStyleBackColor = true;
            // 
            // btnPatRemover
            // 
            this.btnPatRemover.Location = new System.Drawing.Point(206, 291);
            this.btnPatRemover.Name = "btnPatRemover";
            this.btnPatRemover.Size = new System.Drawing.Size(52, 23);
            this.btnPatRemover.TabIndex = 7;
            this.btnPatRemover.Text = "->";
            this.btnPatRemover.UseVisualStyleBackColor = true;
            this.btnPatRemover.Click += new System.EventHandler(this.btnPatRemover_Click);
            // 
            // btnPatAsignar
            // 
            this.btnPatAsignar.Location = new System.Drawing.Point(206, 209);
            this.btnPatAsignar.Name = "btnPatAsignar";
            this.btnPatAsignar.Size = new System.Drawing.Size(52, 23);
            this.btnPatAsignar.TabIndex = 6;
            this.btnPatAsignar.Text = "<-";
            this.btnPatAsignar.UseVisualStyleBackColor = true;
            this.btnPatAsignar.Click += new System.EventHandler(this.btnPatAsignar_Click);
            // 
            // lblPatDisponibles
            // 
            this.lblPatDisponibles.AutoSize = true;
            this.lblPatDisponibles.Location = new System.Drawing.Point(272, 12);
            this.lblPatDisponibles.Name = "lblPatDisponibles";
            this.lblPatDisponibles.Size = new System.Drawing.Size(61, 13);
            this.lblPatDisponibles.TabIndex = 5;
            this.lblPatDisponibles.Text = "Disponibles";
            // 
            // lblPatAsignadas
            // 
            this.lblPatAsignadas.AutoSize = true;
            this.lblPatAsignadas.Location = new System.Drawing.Point(12, 12);
            this.lblPatAsignadas.Name = "lblPatAsignadas";
            this.lblPatAsignadas.Size = new System.Drawing.Size(56, 13);
            this.lblPatAsignadas.TabIndex = 4;
            this.lblPatAsignadas.Text = "Asigandas";
            // 
            // grdPatDisponibles
            // 
            this.grdPatDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatDisponibles.Location = new System.Drawing.Point(275, 34);
            this.grdPatDisponibles.Name = "grdPatDisponibles";
            this.grdPatDisponibles.Size = new System.Drawing.Size(166, 456);
            this.grdPatDisponibles.TabIndex = 3;
            this.grdPatDisponibles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatDisponibles_CellClick);
            // 
            // grdPatAsignadas
            // 
            this.grdPatAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPatAsignadas.Location = new System.Drawing.Point(15, 34);
            this.grdPatAsignadas.Name = "grdPatAsignadas";
            this.grdPatAsignadas.Size = new System.Drawing.Size(176, 456);
            this.grdPatAsignadas.TabIndex = 2;
            this.grdPatAsignadas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPatAsignadas_CellClick);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 657);
            this.Controls.Add(this.tabControlFP);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEstado);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.grdUsuarios);
            this.Controls.Add(this.lblGestionUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionUsuarios";
            this.Text = "GestionUsuarios";
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuarios)).EndInit();
            this.tabControlFP.ResumeLayout(false);
            this.tabPageFamilias.ResumeLayout(false);
            this.tabPageFamilias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdFamAsignadas)).EndInit();
            this.tabPagePatentes.ResumeLayout(false);
            this.tabPagePatentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdPatAsignadas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGestionUsuarios;
        private System.Windows.Forms.DataGridView grdUsuarios;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnLimpiarCampos;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEstado;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TabControl tabControlFP;
        private System.Windows.Forms.TabPage tabPageFamilias;
        private System.Windows.Forms.TabPage tabPagePatentes;
        private System.Windows.Forms.Button btnFamRemover;
        private System.Windows.Forms.Button btnFamAsignar;
        private System.Windows.Forms.Label lblFamDisponibles;
        private System.Windows.Forms.Label lblFamAsignadas;
        private System.Windows.Forms.DataGridView grdFamDisponibles;
        private System.Windows.Forms.DataGridView grdFamAsignadas;
        private System.Windows.Forms.DataGridView grdPatDisponibles;
        private System.Windows.Forms.DataGridView grdPatAsignadas;
        private System.Windows.Forms.Label lblPatDisponibles;
        private System.Windows.Forms.Label lblPatAsignadas;
        private System.Windows.Forms.Button btnPatRemover;
        private System.Windows.Forms.Button btnPatAsignar;
        public System.Windows.Forms.HelpProvider hpUsuario;
    }
}