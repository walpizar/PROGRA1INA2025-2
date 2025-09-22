namespace UI
{
    public partial class CredencialesControl : UserControl
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            combRol = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(combRol);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(20, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(881, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Credenciales";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 100);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(196, 97);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(264, 31);
            txtUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 178);
            label2.Name = "label2";
            label2.Size = new Size(101, 25);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(207, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(253, 31);
            textBox2.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 238);
            label3.Name = "label3";
            label3.Size = new Size(37, 25);
            label3.TabIndex = 4;
            label3.Text = "Rol";
            // 
            // combRol
            // 
            combRol.FormattingEnabled = true;
            combRol.Location = new Point(196, 235);
            combRol.Name = "combRol";
            combRol.Size = new Size(264, 33);
            combRol.TabIndex = 5;
            // 
            // CredencialesControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox1);
            Name = "CredencialesControl";
            Size = new Size(926, 513);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private ComboBox combRol;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox txtUsuario;
    }
}
