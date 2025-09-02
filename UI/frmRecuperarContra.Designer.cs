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
            this.gbxRecuperarContra = new System.Windows.Forms.GroupBox();
            this.btnCancelarRecuperarContra = new System.Windows.Forms.Button();
            this.btnAceptarRecuperarContra = new System.Windows.Forms.Button();
            this.txtConfirmarContra = new System.Windows.Forms.TextBox();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.lblConfirmarContra = new System.Windows.Forms.Label();
            this.lblNuevaContra = new System.Windows.Forms.Label();
            this.lblRecuperarContra = new System.Windows.Forms.Label();
            this.gbxRecuperarContra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxRecuperarContra
            // 
            this.gbxRecuperarContra.Controls.Add(this.btnCancelarRecuperarContra);
            this.gbxRecuperarContra.Controls.Add(this.btnAceptarRecuperarContra);
            this.gbxRecuperarContra.Controls.Add(this.txtConfirmarContra);
            this.gbxRecuperarContra.Controls.Add(this.txtNuevaContra);
            this.gbxRecuperarContra.Controls.Add(this.lblConfirmarContra);
            this.gbxRecuperarContra.Controls.Add(this.lblNuevaContra);
            this.gbxRecuperarContra.Location = new System.Drawing.Point(12, 61);
            this.gbxRecuperarContra.Name = "gbxRecuperarContra";
            this.gbxRecuperarContra.Size = new System.Drawing.Size(469, 186);
            this.gbxRecuperarContra.TabIndex = 0;
            this.gbxRecuperarContra.TabStop = false;
            // 
            // btnCancelarRecuperarContra
            // 
            this.btnCancelarRecuperarContra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCancelarRecuperarContra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancelarRecuperarContra.Location = new System.Drawing.Point(210, 127);
            this.btnCancelarRecuperarContra.Name = "btnCancelarRecuperarContra";
            this.btnCancelarRecuperarContra.Size = new System.Drawing.Size(112, 34);
            this.btnCancelarRecuperarContra.TabIndex = 11;
            this.btnCancelarRecuperarContra.Text = "Cancelar";
            this.btnCancelarRecuperarContra.UseVisualStyleBackColor = false;
            this.btnCancelarRecuperarContra.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptarRecuperarContra
            // 
            this.btnAceptarRecuperarContra.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAceptarRecuperarContra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAceptarRecuperarContra.Location = new System.Drawing.Point(341, 127);
            this.btnAceptarRecuperarContra.Name = "btnAceptarRecuperarContra";
            this.btnAceptarRecuperarContra.Size = new System.Drawing.Size(112, 34);
            this.btnAceptarRecuperarContra.TabIndex = 10;
            this.btnAceptarRecuperarContra.Text = "Aceptar";
            this.btnAceptarRecuperarContra.UseVisualStyleBackColor = false;
            // 
            // txtConfirmarContra
            // 
            this.txtConfirmarContra.Location = new System.Drawing.Point(194, 88);
            this.txtConfirmarContra.Name = "txtConfirmarContra";
            this.txtConfirmarContra.Size = new System.Drawing.Size(259, 23);
            this.txtConfirmarContra.TabIndex = 9;
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.Location = new System.Drawing.Point(194, 48);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(259, 23);
            this.txtNuevaContra.TabIndex = 8;
            // 
            // lblConfirmarContra
            // 
            this.lblConfirmarContra.AutoSize = true;
            this.lblConfirmarContra.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblConfirmarContra.Location = new System.Drawing.Point(6, 89);
            this.lblConfirmarContra.Name = "lblConfirmarContra";
            this.lblConfirmarContra.Size = new System.Drawing.Size(182, 22);
            this.lblConfirmarContra.TabIndex = 7;
            this.lblConfirmarContra.Text = "Confirmar contraseña:";
            // 
            // lblNuevaContra
            // 
            this.lblNuevaContra.AutoSize = true;
            this.lblNuevaContra.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.lblNuevaContra.Location = new System.Drawing.Point(37, 46);
            this.lblNuevaContra.Name = "lblNuevaContra";
            this.lblNuevaContra.Size = new System.Drawing.Size(151, 22);
            this.lblNuevaContra.TabIndex = 6;
            this.lblNuevaContra.Text = "Nueva contraseña:";
            // 
            // lblRecuperarContra
            // 
            this.lblRecuperarContra.AutoSize = true;
            this.lblRecuperarContra.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecuperarContra.Location = new System.Drawing.Point(103, 18);
            this.lblRecuperarContra.Name = "lblRecuperarContra";
            this.lblRecuperarContra.Size = new System.Drawing.Size(288, 30);
            this.lblRecuperarContra.TabIndex = 1;
            this.lblRecuperarContra.Text = "Recuperacion de contraseña";
            // 
            // frmRecuperarContra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(493, 269);
            this.Controls.Add(this.lblRecuperarContra);
            this.Controls.Add(this.gbxRecuperarContra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecuperarContra";
            this.Text = "frmRecuperarContra";
            this.gbxRecuperarContra.ResumeLayout(false);
            this.gbxRecuperarContra.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();           
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