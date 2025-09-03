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
            gbxLogin = new GroupBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listView1 = new ListView();
            label7 = new Label();
            gbxLogin.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(149, 9);
            label1.Name = "label1";
            label1.Size = new Size(520, 45);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiente Categoria Activos";
            label1.Click += label1_Click;
            // 
            // gbxLogin
            // 
            gbxLogin.Controls.Add(label6);
            gbxLogin.Controls.Add(textBox1);
            gbxLogin.Controls.Add(richTextBox1);
            gbxLogin.Controls.Add(label5);
            gbxLogin.Controls.Add(label4);
            gbxLogin.Controls.Add(label3);
            gbxLogin.Controls.Add(label2);
            gbxLogin.Controls.Add(button1);
            gbxLogin.Controls.Add(checkBox1);
            gbxLogin.Location = new Point(12, 57);
            gbxLogin.Name = "gbxLogin";
            gbxLogin.Size = new Size(219, 381);
            gbxLogin.TabIndex = 1;
            gbxLogin.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(103, 79);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(96, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "estado activo";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.Location = new Point(10, 352);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 79);
            label2.Name = "label2";
            label2.Size = new Size(24, 15);
            label2.TabIndex = 2;
            label2.Text = "ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 79);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 117);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 4;
            label4.Text = "nombre :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 202);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 5;
            label5.Text = "descripcion :";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 220);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(193, 96);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 135);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(4, 33);
            label6.Name = "label6";
            label6.Size = new Size(198, 20);
            label6.TabIndex = 2;
            label6.Text = "Creador Categorias Activos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Location = new Point(237, 215);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(551, 223);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(470, 63);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(470, 92);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "modificar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(470, 121);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 8;
            button4.Text = "actualizar";
            button4.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 61);
            listView1.Name = "listView1";
            listView1.Size = new Size(458, 156);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(6, 19);
            label7.Name = "label7";
            label7.Size = new Size(169, 20);
            label7.TabIndex = 6;
            label7.Text = "Lista Categoria Activos";
            label7.Click += label7_Click;
            // 
            // frmMantenimientoCategoriasActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(gbxLogin);
            Controls.Add(label1);
            Name = "frmMantenimientoCategoriasActivos";
            Text = "frmMantenimientoCategoriasActivos";
            gbxLogin.ResumeLayout(false);
            gbxLogin.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox gbxLogin;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button1;
        private Label label6;
        private TextBox textBox1;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private ListView listView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Label label7;
    }
}