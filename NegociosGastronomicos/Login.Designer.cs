namespace NegociosGastronomicos
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hpLogin = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.toolTip1.SetToolTip(this.label1, "Ingrese su nombre de usuario");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            this.toolTip1.SetToolTip(this.label2, "Ingrese su contraseña");
            // 
            // txtUsuario
            // 
            this.hpLogin.SetHelpString(this.txtUsuario, "Ingrese su nombre de usuario");
            this.txtUsuario.Location = new System.Drawing.Point(134, 83);
            this.txtUsuario.Name = "txtUsuario";
            this.hpLogin.SetShowHelp(this.txtUsuario, true);
            this.txtUsuario.Size = new System.Drawing.Size(198, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.hpLogin.SetHelpString(this.txtPassword, "Ingrese su contraseña");
            this.txtPassword.Location = new System.Drawing.Point(134, 143);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.hpLogin.SetShowHelp(this.txtPassword, true);
            this.txtPassword.Size = new System.Drawing.Size(198, 20);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            // 
            // button1
            // 
            this.hpLogin.SetHelpString(this.button1, "Iniciar sesión");
            this.button1.Location = new System.Drawing.Point(185, 202);
            this.button1.Name = "button1";
            this.hpLogin.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ingresar";
            this.toolTip1.SetToolTip(this.button1, "Iniciar sesión");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 301);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider hpLogin;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}