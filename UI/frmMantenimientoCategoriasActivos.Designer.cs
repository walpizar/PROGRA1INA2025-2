namespace UI
{
    partial class frmMantenimientoCategoriasActivos
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
            label7 = new Label();
            listView1 = new ListView();
            columnid = new ColumnHeader();
            columnnombre = new ColumnHeader();
            columndescripcion = new ColumnHeader();
            button3 = new Button();
            button2 = new Button();
            button4 = new Button();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label12 = new Label();
            textBox2 = new TextBox();
            richTextBox2 = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 3);
            label1.Name = "label1";
            label1.Size = new Size(520, 45);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiente Categoria Activos";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(247, 11);
            label7.Name = "label7";
            label7.Size = new Size(312, 37);
            label7.TabIndex = 6;
            label7.Text = "Lista Categoria Activos";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnid, columnnombre, columndescripcion });
            listView1.Location = new Point(15, 70);
            listView1.Name = "listView1";
            listView1.Size = new Size(749, 205);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnid
            // 
            columnid.Text = "id";
            // 
            // columnnombre
            // 
            columnnombre.Text = "nombre";
            columnnombre.Width = 150;
            // 
            // columndescripcion
            // 
            columndescripcion.Text = "descripcion";
            columndescripcion.Width = 550;
            // 
            // button3
            // 
            button3.Location = new Point(274, 281);
            button3.Name = "button3";
            button3.Size = new Size(264, 40);
            button3.TabIndex = 7;
            button3.Text = "modificar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 281);
            button2.Name = "button2";
            button2.Size = new Size(254, 40);
            button2.TabIndex = 6;
            button2.Text = "eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Location = new Point(11, 284);
            button4.Name = "button4";
            button4.Size = new Size(345, 34);
            button4.TabIndex = 8;
            button4.Text = "actualizar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(14, 281);
            button1.Name = "button1";
            button1.Size = new Size(345, 34);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 64);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 64);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 96);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "nombre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 151);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 5;
            label5.Text = "descripcion :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(14, 169);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(345, 106);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 114);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(195, 3);
            label6.Name = "label6";
            label6.Size = new Size(367, 37);
            label6.TabIndex = 2;
            label6.Text = "Creador Categorias Activos";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(16, 63);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(788, 361);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(richTextBox1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(780, 333);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Creador";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(button2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(780, 333);
            tabPage2.TabIndex = 0;
            tabPage2.Text = "Lista";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(richTextBox2);
            tabPage3.Controls.Add(label8);
            tabPage3.Controls.Add(label9);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(label11);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(780, 333);
            tabPage3.TabIndex = 1;
            tabPage3.Text = "Modificar";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(172, 4);
            label12.Name = "label12";
            label12.Size = new Size(420, 37);
            label12.TabIndex = 12;
            label12.Text = "Modificacion Categoria Activos";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(14, 115);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 23);
            textBox2.TabIndex = 6;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(11, 170);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(345, 106);
            richTextBox2.TabIndex = 7;
            richTextBox2.Text = "";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 152);
            label8.Name = "label8";
            label8.Size = new Size(74, 15);
            label8.TabIndex = 11;
            label8.Text = "descripcion :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 97);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 10;
            label9.Text = "nombre :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 65);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 9;
            label10.Text = "numero";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 65);
            label11.Name = "label11";
            label11.Size = new Size(24, 15);
            label11.TabIndex = 8;
            label11.Text = "ID :";
            // 
            // frmMantenimientoCategoriasActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 450);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            Name = "frmMantenimientoCategoriasActivos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmMantenimientoCategoriasActivos";
            Load += frmMantenimientoCategoriasActivos_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private ListView listView1;
        private Button button3;
        private Button button2;
        private Label label7;
        private ColumnHeader columnid;
        private ColumnHeader columnnombre;
        private ColumnHeader columndescripcion;
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBox1;
        private Button button4;
        private TextBox textBox1;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label12;
        private TextBox textBox2;
        private RichTextBox richTextBox2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}