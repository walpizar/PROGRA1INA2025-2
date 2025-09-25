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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button2 = new Button();
            button1 = new Button();
            tabPage2 = new TabPage();
            button3 = new Button();
            button4 = new Button();
            textBox2 = new TextBox();
            LvDonantes = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(492, 37);
            label1.TabIndex = 0;
            label1.Text = "Control Aportes de Afiliados y Donantes";
            // 
            // lvAfiliados
            // 
            lvAfiliados.Columns.AddRange(new ColumnHeader[] { ID, Nombre, Apellido, Apellido2, Correo });
            lvAfiliados.Location = new Point(11, 40);
            lvAfiliados.Name = "lvAfiliados";
            lvAfiliados.Size = new Size(743, 266);
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
            textBox1.Location = new Point(11, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 62);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 376);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(lvAfiliados);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 348);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Afiliados";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(645, 10);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 5;
            button2.Text = "Agregar pago";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(524, 10);
            button1.Name = "button1";
            button1.Size = new Size(115, 23);
            button1.TabIndex = 4;
            button1.Text = "Detalles de pago";
            button1.UseVisualStyleBackColor = true;
     
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(LvDonantes);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 348);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Donantes";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(645, 10);
            button3.Name = "button3";
            button3.Size = new Size(109, 23);
            button3.TabIndex = 8;
            button3.Text = "Agregar pago";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(524, 10);
            button4.Name = "button4";
            button4.Size = new Size(115, 23);
            button4.TabIndex = 7;
            button4.Text = "Detalles de pago";
            button4.UseVisualStyleBackColor = true;
      
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 11);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 23);
            textBox2.TabIndex = 6;
            // 
            // LvDonantes
            // 
            LvDonantes.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            LvDonantes.Location = new Point(11, 40);
            LvDonantes.Name = "LvDonantes";
            LvDonantes.Size = new Size(743, 266);
            LvDonantes.TabIndex = 5;
            LvDonantes.UseCompatibleStateImageBehavior = false;
            LvDonantes.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Apellido";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Apellido 2";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Correo";
            columnHeader5.Width = 200;
            // 
            // FrmControlAfiliados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "FrmControlAfiliados";
            Text = "FrmControlAfiliados";
    
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView lvAfiliados;
        private TextBox textBox1;
        private ColumnHeader ID;
        private ColumnHeader Nombre;
        private ColumnHeader Apellido;
        private ColumnHeader Apellido2;
        private ColumnHeader Correo;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox textBox2;
        private ListView LvDonantes;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}