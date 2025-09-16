namespace UI
{
    partial class frmMantenimientoRoles
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
            ListViewItem listViewItem40 = new ListViewItem("");
            ListViewItem listViewItem41 = new ListViewItem("");
            ListViewItem listViewItem42 = new ListViewItem("");
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            label2 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            ID = new ColumnHeader();
            Nombre = new ColumnHeader();
            Descripcion = new ColumnHeader();
            Estado = new ColumnHeader();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            richTextBox1 = new RichTextBox();
            button1 = new Button();
            button2 = new Button();
            comboBox1 = new ComboBox();
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            button3 = new Button();
            button4 = new Button();
            checkBox5 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox13 = new CheckBox();
            checkBox14 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox10 = new CheckBox();
            checkBox11 = new CheckBox();
            checkBox12 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(252, 25);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento de Roles";
            label1.Click += label1_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(27, 79);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(688, 423);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightBlue;
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(680, 389);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Permisos";
            tabPage1.Click += tabPage1_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PowderBlue;
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(680, 389);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista de Roles";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightBlue;
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(button1);
            tabPage3.Controls.Add(richTextBox1);
            tabPage3.Controls.Add(textBox2);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(680, 389);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Crear un nuevo rol";
            tabPage3.Click += tabPage3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 17);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 0;
            label2.Click += label2_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(28, 34);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 0;
            label3.Text = "Seleccione un Rol:";
            label3.Click += label3_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ID, Nombre, Descripcion, Estado });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem40, listViewItem41, listViewItem42 });
            listView1.Location = new Point(27, 28);
            listView1.Name = "listView1";
            listView1.Size = new Size(620, 335);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ID
            // 
            ID.Text = "ID Rol";
            ID.Width = 70;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre Rol";
            Nombre.Width = 190;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion de Rol";
            Descripcion.Width = 260;
            // 
            // Estado
            // 
            Estado.Text = "Estado Rol";
            Estado.Width = 90;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 65);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 0;
            label4.Text = "Nombre de nuevo rol:";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 143);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 1;
            label5.Text = "Descripcion:";
            label5.Click += label5_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(184, 62);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 29);
            textBox2.TabIndex = 3;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(116, 140);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(520, 96);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(184, 290);
            button1.Name = "button1";
            button1.Size = new Size(130, 59);
            button1.TabIndex = 6;
            button1.Text = "Crear Rol";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(347, 290);
            button2.Name = "button2";
            button2.Size = new Size(125, 59);
            button2.TabIndex = 7;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(169, 31);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 29);
            comboBox1.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox11);
            groupBox1.Controls.Add(checkBox12);
            groupBox1.Controls.Add(checkBox15);
            groupBox1.Controls.Add(checkBox16);
            groupBox1.Controls.Add(checkBox7);
            groupBox1.Controls.Add(checkBox8);
            groupBox1.Controls.Add(checkBox9);
            groupBox1.Controls.Add(checkBox10);
            groupBox1.Controls.Add(checkBox5);
            groupBox1.Controls.Add(checkBox6);
            groupBox1.Controls.Add(checkBox13);
            groupBox1.Controls.Add(checkBox14);
            groupBox1.Controls.Add(checkBox4);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(18, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 251);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Permisos Asignados";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(21, 51);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(102, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(21, 100);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(102, 25);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(21, 151);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(102, 25);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(21, 203);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(102, 25);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(357, 335);
            button3.Name = "button3";
            button3.Size = new Size(101, 48);
            button3.TabIndex = 7;
            button3.Text = "Cancelar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(209, 335);
            button4.Name = "button4";
            button4.Size = new Size(101, 48);
            button4.TabIndex = 8;
            button4.Text = "Guardar";
            button4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(167, 203);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(102, 25);
            checkBox5.TabIndex = 15;
            checkBox5.Text = "checkBox5";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(167, 151);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(102, 25);
            checkBox6.TabIndex = 14;
            checkBox6.Text = "checkBox6";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            checkBox13.AutoSize = true;
            checkBox13.Location = new Point(167, 100);
            checkBox13.Name = "checkBox13";
            checkBox13.Size = new Size(111, 25);
            checkBox13.TabIndex = 13;
            checkBox13.Text = "checkBox13";
            checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            checkBox14.AutoSize = true;
            checkBox14.Location = new Point(167, 51);
            checkBox14.Name = "checkBox14";
            checkBox14.Size = new Size(111, 25);
            checkBox14.TabIndex = 12;
            checkBox14.Text = "checkBox14";
            checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(329, 203);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(102, 25);
            checkBox7.TabIndex = 19;
            checkBox7.Text = "checkBox7";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.Location = new Point(329, 151);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(102, 25);
            checkBox8.TabIndex = 18;
            checkBox8.Text = "checkBox8";
            checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.Location = new Point(329, 100);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(102, 25);
            checkBox9.TabIndex = 17;
            checkBox9.Text = "checkBox9";
            checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.Location = new Point(329, 51);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(111, 25);
            checkBox10.TabIndex = 16;
            checkBox10.Text = "checkBox10";
            checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            checkBox11.AutoSize = true;
            checkBox11.Location = new Point(474, 203);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(111, 25);
            checkBox11.TabIndex = 23;
            checkBox11.Text = "checkBox11";
            checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            checkBox12.AutoSize = true;
            checkBox12.Location = new Point(474, 151);
            checkBox12.Name = "checkBox12";
            checkBox12.Size = new Size(111, 25);
            checkBox12.TabIndex = 22;
            checkBox12.Text = "checkBox12";
            checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            checkBox15.AutoSize = true;
            checkBox15.Location = new Point(474, 100);
            checkBox15.Name = "checkBox15";
            checkBox15.Size = new Size(111, 25);
            checkBox15.TabIndex = 21;
            checkBox15.Text = "checkBox15";
            checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            checkBox16.AutoSize = true;
            checkBox16.Location = new Point(474, 51);
            checkBox16.Name = "checkBox16";
            checkBox16.Size = new Size(111, 25);
            checkBox16.TabIndex = 20;
            checkBox16.Text = "checkBox16";
            checkBox16.UseVisualStyleBackColor = true;
            // 
            // frmMantenimientoRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(739, 514);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmMantenimientoRoles";
            Text = "frmMantenimientoRoles";
            Load += frmMantenimientoRoles_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label3;
        private ListView listView1;
        private ColumnHeader ID;
        private ColumnHeader Nombre;
        private ColumnHeader Descripcion;
        private ColumnHeader Estado;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private RichTextBox richTextBox1;
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private GroupBox groupBox1;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button button3;
        private Button button4;
        private CheckBox checkBox5;
        private CheckBox checkBox6;
        private CheckBox checkBox13;
        private CheckBox checkBox14;
        private CheckBox checkBox11;
        private CheckBox checkBox12;
        private CheckBox checkBox15;
        private CheckBox checkBox16;
        private CheckBox checkBox7;
        private CheckBox checkBox8;
        private CheckBox checkBox9;
        private CheckBox checkBox10;
    }
}