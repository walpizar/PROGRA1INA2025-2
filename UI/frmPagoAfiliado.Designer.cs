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
            btnPagar = new Button();
            label1 = new Label();
            listViewMeses = new ListView();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(147, 82);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(48, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "label1";
            // 
            // btnPagar
            // 
            btnPagar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPagar.Location = new Point(660, 393);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(128, 45);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "pagar";
            btnPagar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 9);
            label1.Name = "label1";
            label1.Size = new Size(257, 40);
            label1.TabIndex = 3;
            label1.Text = "Sistema de pagos";
            // 
            // listViewMeses
            // 
            listViewMeses.Location = new Point(12, 123);
            listViewMeses.Name = "listViewMeses";
            listViewMeses.Size = new Size(776, 264);
            listViewMeses.TabIndex = 4;
            listViewMeses.UseCompatibleStateImageBehavior = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(129, 20);
            label2.TabIndex = 5;
            label2.Text = "Nombre afiliado :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(259, 390);
            label3.Name = "label3";
            label3.Size = new Size(313, 20);
            label3.TabIndex = 6;
            label3.Text = "* Se le notificara al correo despues del pago *";
            // 
            // frmPagoAfiliado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listViewMeses);
            Controls.Add(label1);
            Controls.Add(btnPagar);
            Controls.Add(lblNombre);
            Name = "frmPagoAfiliado";
            Text = "frmPagoAfiliado";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Button btnPagar;
        private Label label1;
        private ListView listViewMeses;
        private Label label2;
        private Label label3;
    }
}