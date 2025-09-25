namespace UI
{
    partial class frmPagoAfiliado
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
            lblNombre = new Label();
            listBoxMeses = new ListBox();
            btnPagar = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(12, 73);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(38, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "label1";
            // 
            // listBoxMeses
            // 
            listBoxMeses.FormattingEnabled = true;
            listBoxMeses.ItemHeight = 15;
            listBoxMeses.Location = new Point(12, 125);
            listBoxMeses.Name = "listBoxMeses";
            listBoxMeses.Size = new Size(776, 199);
            listBoxMeses.TabIndex = 1;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(660, 332);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(128, 45);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "pagar";
            btnPagar.UseVisualStyleBackColor = true;
       
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(386, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // frmPagoAfiliado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnPagar);
            Controls.Add(listBoxMeses);
            Controls.Add(lblNombre);
            Name = "frmPagoAfiliado";
            Text = "frmPagoAfiliado";
      
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private ListBox listBoxMeses;
        private Button btnPagar;
        private Label label1;
    }
}