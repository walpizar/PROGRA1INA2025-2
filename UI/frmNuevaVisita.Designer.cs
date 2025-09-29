namespace UI
{
    partial class frmNuevaVisita
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
            label2 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            textBox5 = new TextBox();
            label8 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            label7 = new Label();
            richTextBox1 = new RichTextBox();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 23);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(152, 15);
            label2.Name = "label2";
            label2.Size = new Size(229, 25);
            label2.TabIndex = 1;
            label2.Text = "Nueva visita Domiciliaria";
            // 
            // button1
            // 
            button1.Location = new Point(411, 15);
            button1.Name = "button1";
            button1.Size = new Size(95, 43);
            button1.TabIndex = 10;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(502, 366);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Visita";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(140, 127);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(140, 23);
            textBox5.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 127);
            label8.Name = "label8";
            label8.Size = new Size(121, 15);
            label8.TabIndex = 21;
            label8.Text = "Numero del Paciente:";
            // 
            // button2
            // 
            button2.Location = new Point(409, 96);
            button2.Name = "button2";
            button2.Size = new Size(85, 55);
            button2.TabIndex = 20;
            button2.Text = "Obtene Datos del Paciente";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 164);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(342, 23);
            textBox4.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 164);
            label7.Name = "label7";
            label7.Size = new Size(127, 15);
            label7.TabIndex = 18;
            label7.Text = "Direccion del Paciente:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 213);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(490, 139);
            richTextBox1.TabIndex = 17;
            richTextBox1.Text = "";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 93);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(202, 23);
            textBox3.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(202, 23);
            textBox2.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 195);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 13;
            label6.Text = "Detalles de la Visita:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 25);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 12;
            label5.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(172, 15);
            label4.TabIndex = 11;
            label4.Text = "Nombre completo de Paciente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 57);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 10;
            label3.Text = "Nombre comleto de Visitante:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(59, 22);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 23;
            // 
            // frmNuevaVisita
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 450);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmNuevaVisita";
            Text = "frmNuevaVisita";
            Load += frmNuevaVisita_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private GroupBox groupBox1;
        private RichTextBox richTextBox1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBox4;
        private Label label7;
        private Button button2;
        private TextBox textBox5;
        private Label label8;
        private DateTimePicker dateTimePicker1;
    }
}