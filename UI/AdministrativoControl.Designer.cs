namespace UI
{
    public partial class AdministrativoControl: UserControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            grpAsigancionPuesto = new GroupBox();
            txtDescripcion = new RichTextBox();
            comboPuesto = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            grpAsigancionPuesto.SuspendLayout();
            SuspendLayout();
            // 
            // grpAsigancionPuesto
            // 
            grpAsigancionPuesto.Controls.Add(txtDescripcion);
            grpAsigancionPuesto.Controls.Add(comboPuesto);
            grpAsigancionPuesto.Controls.Add(label2);
            grpAsigancionPuesto.Controls.Add(label1);
            grpAsigancionPuesto.Location = new Point(14, 42);
            grpAsigancionPuesto.Margin = new Padding(2, 2, 2, 2);
            grpAsigancionPuesto.Name = "grpAsigancionPuesto";
            grpAsigancionPuesto.Padding = new Padding(2, 2, 2, 2);
            grpAsigancionPuesto.Size = new Size(547, 245);
            grpAsigancionPuesto.TabIndex = 0;
            grpAsigancionPuesto.TabStop = false;
            grpAsigancionPuesto.Text = "Asignación Puesto";
            grpAsigancionPuesto.Enter += groupBox1_Enter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(164, 133);
            txtDescripcion.Margin = new Padding(2, 2, 2, 2);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(187, 88);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.Text = "";
            // 
            // comboPuesto
            // 
            comboPuesto.FormattingEnabled = true;
            comboPuesto.Location = new Point(158, 67);
            comboPuesto.Margin = new Padding(2, 2, 2, 2);
            comboPuesto.Name = "comboPuesto";
            comboPuesto.Size = new Size(194, 23);
            comboPuesto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 133);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Puesto";
            label1.Click += label1_Click;
            // 
            // AdministrativoControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpAsigancionPuesto);
            Margin = new Padding(2, 2, 2, 2);
            Name = "AdministrativoControl";
            Size = new Size(580, 304);
            grpAsigancionPuesto.ResumeLayout(false);
            grpAsigancionPuesto.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpAsigancionPuesto;
        public ComboBox comboPuesto;
        private Label label2;
        private Label label1;
        public RichTextBox txtDescripcion;
    }
}
