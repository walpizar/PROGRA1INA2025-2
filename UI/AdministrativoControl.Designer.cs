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
            grpAsigancionPuesto.Location = new Point(20, 70);
            grpAsigancionPuesto.Name = "grpAsigancionPuesto";
            grpAsigancionPuesto.Size = new Size(781, 408);
            grpAsigancionPuesto.TabIndex = 0;
            grpAsigancionPuesto.TabStop = false;
            grpAsigancionPuesto.Text = "Asignación Puesto";
            grpAsigancionPuesto.Enter += groupBox1_Enter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(234, 171);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(265, 144);
            txtDescripcion.TabIndex = 4;
            txtDescripcion.Text = "";
            // 
            // comboPuesto
            // 
            comboPuesto.FormattingEnabled = true;
            comboPuesto.Location = new Point(234, 81);
            comboPuesto.Name = "comboPuesto";
            comboPuesto.Size = new Size(275, 33);
            comboPuesto.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 171);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 2;
            label2.Text = "Descripción";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 89);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 0;
            label1.Text = "Puesto";
            label1.Click += label1_Click;
            // 
            // AdministrativoControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grpAsigancionPuesto);
            Name = "AdministrativoControl";
            Size = new Size(829, 507);
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
