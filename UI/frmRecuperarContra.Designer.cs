namespace UI
{
    partial class frmRecuperarContra
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
<<<<<<< HEAD
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "frmRecuperarContra";
        }

        #endregion
=======
            gbxRecuperarContra = new GroupBox();
            lblRecuperarContra = new Label();
            btnCancelarRecuperarContra = new Button();
            btnAceptarRecuperarContra = new Button();
            txtConfirmarContra = new TextBox();
            txtNuevaContra = new TextBox();
            lblConfirmarContra = new Label();
            lblNuevaContra = new Label();
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
            gbxRecuperarContra.Location = new Point(12, 61);
            gbxRecuperarContra.Name = "gbxRecuperarContra";
            gbxRecuperarContra.Size = new Size(469, 186);
            gbxRecuperarContra.TabIndex = 0;
            gbxRecuperarContra.TabStop = false;
            // 
            // lblRecuperarContra
            // 
            lblRecuperarContra.AutoSize = true;
            lblRecuperarContra.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecuperarContra.Location = new Point(103, 18);
            lblRecuperarContra.Name = "lblRecuperarContra";
            lblRecuperarContra.Size = new Size(288, 30);
            lblRecuperarContra.TabIndex = 1;
            lblRecuperarContra.Text = "Recuperacion de contraseña";
            lblRecuperarContra.Click += label1_Click;
            // 
            // btnCancelarRecuperarContra
            // 
            btnCancelarRecuperarContra.BackColor = Color.AliceBlue;
            btnCancelarRecuperarContra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelarRecuperarContra.Location = new Point(210, 127);
            btnCancelarRecuperarContra.Name = "btnCancelarRecuperarContra";
            btnCancelarRecuperarContra.Size = new Size(112, 34);
            btnCancelarRecuperarContra.TabIndex = 11;
            btnCancelarRecuperarContra.Text = "Cancelar";
            btnCancelarRecuperarContra.UseVisualStyleBackColor = false;
            btnCancelarRecuperarContra.Click += btnCancelar_Click;
            // 
            // btnAceptarRecuperarContra
            // 
            btnAceptarRecuperarContra.BackColor = Color.AliceBlue;
            btnAceptarRecuperarContra.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAceptarRecuperarContra.Location = new Point(341, 127);
            btnAceptarRecuperarContra.Name = "btnAceptarRecuperarContra";
            btnAceptarRecuperarContra.Size = new Size(112, 34);
            btnAceptarRecuperarContra.TabIndex = 10;
            btnAceptarRecuperarContra.Text = "Aceptar";
            btnAceptarRecuperarContra.UseVisualStyleBackColor = false;
            btnAceptarRecuperarContra.Click += this.btnAceptar_Click;
            // 
            // txtConfirmarContra
            // 
            txtConfirmarContra.Location = new Point(194, 88);
            txtConfirmarContra.Name = "txtConfirmarContra";
            txtConfirmarContra.Size = new Size(259, 23);
            txtConfirmarContra.TabIndex = 9;
            txtConfirmarContra.TextChanged += this.txtPassword_TextChanged;
            // 
            // txtNuevaContra
            // 
            txtNuevaContra.Location = new Point(194, 48);
            txtNuevaContra.Name = "txtNuevaContra";
            txtNuevaContra.Size = new Size(259, 23);
            txtNuevaContra.TabIndex = 8;
            txtNuevaContra.TextChanged += this.txtUusario_TextChanged;
            // 
            // lblConfirmarContra
            // 
            lblConfirmarContra.AutoSize = true;
            lblConfirmarContra.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lblConfirmarContra.Location = new Point(6, 89);
            lblConfirmarContra.Name = "lblConfirmarContra";
            lblConfirmarContra.Size = new Size(182, 22);
            lblConfirmarContra.TabIndex = 7;
            lblConfirmarContra.Text = "Confirmar contraseña:";
            lblConfirmarContra.Click += this.label2_Click;
            // 
            // lblNuevaContra
            // 
            lblNuevaContra.AutoSize = true;
            lblNuevaContra.Font = new Font("Trebuchet MS", 12F, FontStyle.Bold);
            lblNuevaContra.Location = new Point(37, 46);
            lblNuevaContra.Name = "lblNuevaContra";
            lblNuevaContra.Size = new Size(151, 22);
            lblNuevaContra.TabIndex = 6;
            lblNuevaContra.Text = "Nueva contraseña:";
            lblNuevaContra.Click += this.label1_Click_1;
            // 
            // frmRecuperarContra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(493, 269);
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

        private GroupBox gbxRecuperarContra;
        private Label lblRecuperarContra;
        private Button btnCancelarRecuperarContra;
        private Button btnAceptarRecuperarContra;
        private TextBox txtConfirmarContra;
        private TextBox txtNuevaContra;
        private Label lblConfirmarContra;
        private Label lblNuevaContra;
>>>>>>> develop
    }
}