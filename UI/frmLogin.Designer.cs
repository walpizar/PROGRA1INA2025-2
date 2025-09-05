namespace UI
{
    partial class frmLogin
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
            gbxLogin = new GroupBox();
            linkLblOlvidoContra = new LinkLabel();
            btnCancelar = new Button();
            btnAceptar = new Button();
            txtPassword = new TextBox();
            txtUusario = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // gbxLogin
            // 
            gbxLogin.Controls.Add(linkLblOlvidoContra);
            gbxLogin.Controls.Add(btnCancelar);
            gbxLogin.Controls.Add(btnAceptar);
            gbxLogin.Controls.Add(txtPassword);
            gbxLogin.Controls.Add(txtUusario);
            gbxLogin.Controls.Add(label2);
            gbxLogin.Controls.Add(label1);
            gbxLogin.Location = new Point(12, 12);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(448, 228);
            gbxLogin.TabIndex = 0;
            gbxLogin.TabStop = false;
          
            // 
            // linkLblOlvidoContra
            // 
            linkLblOlvidoContra.AutoSize = true;
            linkLblOlvidoContra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLblOlvidoContra.Location = new Point(257, 188);
            linkLblOlvidoContra.Name = "linkLblOlvidoContra";
            linkLblOlvidoContra.Size = new Size(143, 17);
            linkLblOlvidoContra.TabIndex = 6;
            linkLblOlvidoContra.TabStop = true;
            linkLblOlvidoContra.Text = "¿Olvidó su contraseña?";
            linkLblOlvidoContra.VisitedLinkColor = Color.Blue;
            linkLblOlvidoContra.LinkClicked += linkLblOlvidoContra_LinkClicked_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.AliceBlue;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.Location = new Point(157, 139);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.AliceBlue;
            btnAceptar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAceptar.Location = new Point(288, 139);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(112, 34);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 98);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(259, 23);
            txtPassword.TabIndex = 3;
            // 
            // txtUusario
            // 
            txtUusario.Location = new Point(141, 55);
            txtUusario.Name = "txtUusario";
            txtUusario.Size = new Size(259, 23);
            txtUusario.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label2.Location = new Point(34, 99);
            label2.Name = "label2";
            label2.Size = new Size(101, 22);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            label1.Location = new Point(61, 55);
            label1.Name = "label1";
            label1.Size = new Size(74, 22);
            label1.TabIndex = 0;
            label1.Text = "Usuario:";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(473, 252);
            Controls.Add(gbxLogin);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            Text = "frmLogin";
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxLogin;
        private TextBox txtUusario;
        private Label label2;
        private Label label1;
        private Button btnCancelar;
        private Button btnAceptar;
        private TextBox txtPassword;
        private LinkLabel linkLblOlvidoContra;
    }
}