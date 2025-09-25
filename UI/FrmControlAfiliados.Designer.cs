namespace UI
{
    partial class FrmControlAfiliados
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
            label1 = new Label();
            lvAfiliados = new ListView();
            ID = new ColumnHeader();
            Nombre = new ColumnHeader();
            Apellido = new ColumnHeader();
            Apellido2 = new ColumnHeader();
            Correo = new ColumnHeader();
            textBox1 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(213, 9);
            label1.Name = "label1";
            label1.Size = new Size(352, 37);
            label1.TabIndex = 0;
            label1.Text = "Control Aportes de Afiliados";
            // 
            // lvAfiliados
            // 
            lvAfiliados.Columns.AddRange(new ColumnHeader[] { ID, Nombre, Apellido, Apellido2, Correo });
            lvAfiliados.Location = new Point(12, 172);
            lvAfiliados.Name = "lvAfiliados";
            lvAfiliados.Size = new Size(776, 266);
            lvAfiliados.TabIndex = 1;
            lvAfiliados.UseCompatibleStateImageBehavior = false;
            lvAfiliados.View = View.Details;

            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 150;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 150;
            // 
            // Apellido
            // 
            Apellido.Text = "Apellido";
            Apellido.Width = 150;
            // 
            // Apellido2
            // 
            Apellido2.Text = "Apellido 2";
            Apellido2.Width = 150;
            // 
            // Correo
            // 
            Correo.Text = "Correo";
            Correo.Width = 200;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 143);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(379, 23);
            textBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(397, 143);
            button2.Name = "button2";
            button2.Size = new Size(54, 23);
            button2.TabIndex = 4;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // FrmControlAfiliados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox1);
            Controls.Add(lvAfiliados);
            Controls.Add(label1);
            Name = "FrmControlAfiliados";
            Text = "FrmControlAfiliados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvAfiliados;
        private TextBox textBox1;
        private Button button2;
        private ColumnHeader ID;
        private ColumnHeader Nombre;
        private ColumnHeader Apellido;
        private ColumnHeader Apellido2;
        private ColumnHeader Correo;
    }
}