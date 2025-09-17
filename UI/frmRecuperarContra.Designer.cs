namespace UI
{
    partial class frmRecuperarContra
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            gbxRecuperarContra = new GroupBox();
            btnCancelarRecuperarContra = new Button();
            btnAceptarRecuperarContra = new Button();
            txtConfirmarContra = new TextBox();
            txtNuevaContra = new TextBox();
            lblConfirmarContra = new Label();
            lblNuevaContra = new Label();
            lblRecuperarContra = new Label();
            gbxRecuperarContra.SuspendLayout();
            SuspendLayout();
            // 
            // gbxRecuperarContra
            // 
            gbxRecuperarContra.Controls.Add(btnCancelarRecuperarContra);
            gbxRecuperarContra.Controls.Add(btnAceptarRecuperarContra);
            gbxRecuperarContra.Controls.Add(txtConfirmarContra);
            gbxRecuperarContra.Controls.Add(txtNuevaContra);
            gbxRecuperarContra.Controls.Add(lblConfirmarContra);
            gbxRecuperarContra.Controls.Add(lblNuevaContra);
            gbxRecuperarContra.Location = new Point(23, 82);
            gbxRecuperarContra.Name = "gbxRecuperarContra";
            gbxRecuperarContra.Size = new Size(469, 218);
            gbxRecuperarContra.TabIndex = 0;
            gbxRecuperarContra.TabStop = false;
            // 
            // btnCancelarRecuperarContra
            // 
            btnCancelarRecuperarContra.BackColor = Color.AliceBlue;
            btnCancelarRecuperarContra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelarRecuperarContra.Location = new Point(211, 144);
            btnCancelarRecuperarContra.Name = "btnCancelarRecuperarContra";
            btnCancelarRecuperarContra.Size = new Size(112, 34);
            btnCancelarRecuperarContra.TabIndex = 4;
            btnCancelarRecuperarContra.Text = "Cancelar";
            btnCancelarRecuperarContra.UseVisualStyleBackColor = false;
            btnCancelarRecuperarContra.Click += btnCancelar_Click;
            // 
            // btnAceptarRecuperarContra
            // 
            btnAceptarRecuperarContra.BackColor = Color.AliceBlue;
            btnAceptarRecuperarContra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAceptarRecuperarContra.Location = new Point(342, 144);
            btnAceptarRecuperarContra.Name = "btnAceptarRecuperarContra";
            btnAceptarRecuperarContra.Size = new Size(112, 34);
            btnAceptarRecuperarContra.TabIndex = 3;
            btnAceptarRecuperarContra.Text = "Aceptar";
            btnAceptarRecuperarContra.UseVisualStyleBackColor = false;
            btnAceptarRecuperarContra.Click += btnAceptarRecuperarContra_Click;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(195, 100);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.PasswordChar = '*';
            txtConfirmarContra.Size = new Size(259, 23);
            txtConfirmarContra.TabIndex = 2;
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(195, 60);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.PasswordChar = '*';
            txtNuevaContra.Size = new Size(259, 23);
            txtNuevaContra.TabIndex = 1;
            // 
            // lblConfirmarContra
            // 
            lblConfirmarContra.AutoSize = true;
            lblConfirmarContra.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lblConfirmarContra.Location = new Point(7, 101);
            lblConfirmarContra.Name = "lblConfirmarContra";
            lblConfirmarContra.Size = new Size(182, 22);
            lblConfirmarContra.TabIndex = 7;
            lblConfirmarContra.Text = "Confirmar contraseña:";
            // 
            // lblNuevaContra
            // 
            lblNuevaContra.AutoSize = true;
            lblNuevaContra.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lblNuevaContra.Location = new Point(38, 58);
            lblNuevaContra.Name = "lblNuevaContra";
            lblNuevaContra.Size = new Size(151, 22);
            lblNuevaContra.TabIndex = 6;
            lblNuevaContra.Text = "Nueva contraseña:";
            // 
            // lblRecuperarContra
            // 
            lblRecuperarContra.AutoSize = true;
            lblRecuperarContra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecuperarContra.Location = new Point(110, 34);
            lblRecuperarContra.Name = "lblRecuperarContra";
            lblRecuperarContra.Size = new Size(288, 30);
            lblRecuperarContra.TabIndex = 1;
            lblRecuperarContra.Text = "Recuperacion de contraseña";
            // 
            // frmRecuperarContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(516, 322);
            Controls.Add(lblRecuperarContra);
            Controls.Add(gbxRecuperarContra);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmRecuperarContra";
            Text = "frmRecuperarContra";
            gbxRecuperarContra.ResumeLayout(false);
            gbxRecuperarContra.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbxRecuperarContra;
        private System.Windows.Forms.Label lblRecuperarContra;
        private System.Windows.Forms.Button btnCancelarRecuperarContra;
        private System.Windows.Forms.Button btnAceptarRecuperarContra;
        private System.Windows.Forms.TextBox txtConfirmarContra;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.Label lblConfirmarContra;
        private System.Windows.Forms.Label lblNuevaContra;
    }
}