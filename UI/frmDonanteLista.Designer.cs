namespace UI
{
    partial class frmDonanteLista
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
            lblMantDonante = new Label();
            SuspendLayout();
            // 
            // lblMantDonante
            // 
            lblMantDonante.AutoSize = true;
            lblMantDonante.Location = new Point(187, 18);
            lblMantDonante.Name = "lblMantDonante";
            lblMantDonante.Size = new Size(202, 20);
            lblMantDonante.TabIndex = 1;
            lblMantDonante.Text = "MANTENIMIENTO DONANTE";
            lblMantDonante.Click += label1_Click;
            // 
            // frmDonanteLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 499);
            Controls.Add(lblMantDonante);
            Name = "frmDonanteLista";
            Text = "frmDonanteLista";
            Load += frmDonanteLista_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblMantDonante;
    }
}