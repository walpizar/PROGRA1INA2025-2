namespace UI
{
    partial class FrmAnadirPersonalAdministrativo
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
            txtDescripcion = new GroupBox();
            comboRol = new ComboBox();
            txtFecha = new DateTimePicker();
            label9 = new Label();
            txtContra = new TextBox();
            label8 = new Label();
            txtUsuario = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label4 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            btnEliminar = new Button();
            btnAnadir = new Button();
            btnCancelar = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label10 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            credencialesToolStripMenuItem = new ToolStripMenuItem();
            administrativoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripTextBox();
            txtDescripcion.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(415, 61);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(234, 45);
            label1.TabIndex = 0;
            label1.Text = "Añadir Admin";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = SystemColors.Control;
            txtDescripcion.Controls.Add(comboBox1);
            txtDescripcion.Controls.Add(textBox2);
            txtDescripcion.Controls.Add(label11);
            txtDescripcion.Controls.Add(label10);
            txtDescripcion.Controls.Add(comboRol);
            txtDescripcion.Controls.Add(txtFecha);
            txtDescripcion.Controls.Add(label9);
            txtDescripcion.Controls.Add(txtContra);
            txtDescripcion.Controls.Add(label8);
            txtDescripcion.Controls.Add(txtUsuario);
            txtDescripcion.Controls.Add(label7);
            txtDescripcion.Controls.Add(label6);
            txtDescripcion.Controls.Add(txtTelefono);
            txtDescripcion.Controls.Add(label5);
            txtDescripcion.Controls.Add(txtDireccion);
            txtDescripcion.Controls.Add(label4);
            txtDescripcion.Controls.Add(txtEmail);
            txtDescripcion.Controls.Add(label3);
            txtDescripcion.Controls.Add(txtNombre);
            txtDescripcion.Controls.Add(label2);
            txtDescripcion.Location = new Point(52, 149);
            txtDescripcion.Margin = new Padding(4);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Padding = new Padding(4);
            txtDescripcion.Size = new Size(966, 531);
            txtDescripcion.TabIndex = 1;
            txtDescripcion.TabStop = false;
            txtDescripcion.Text = "Datos";
            // 
            // comboRol
            // 
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(606, 352);
            comboRol.Margin = new Padding(4);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(319, 33);
            comboRol.TabIndex = 17;
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(198, 256);
            txtFecha.Margin = new Padding(4);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(260, 31);
            txtFecha.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(524, 355);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(41, 25);
            label9.TabIndex = 14;
            label9.Text = "Rol:";
            // 
            // txtContra
            // 
            txtContra.Location = new Point(139, 352);
            txtContra.Margin = new Padding(4);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(319, 31);
            txtContra.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 355);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(105, 25);
            label8.TabIndex = 12;
            label8.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(606, 256);
            txtUsuario.Margin = new Padding(4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(319, 31);
            txtUsuario.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(514, 259);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 25);
            label7.TabIndex = 10;
            label7.Text = "Usuario:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 256);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(156, 25);
            label6.TabIndex = 8;
            label6.Text = "Fecha Nacimiento:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(606, 157);
            txtTelefono.Margin = new Padding(4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(319, 31);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(514, 157);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 6;
            label5.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(139, 154);
            txtDireccion.Margin = new Padding(4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(319, 31);
            txtDireccion.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 157);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 4;
            label4.Text = "Dirreción:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(606, 75);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 31);
            txtEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(532, 81);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(58, 25);
            label3.TabIndex = 2;
            label3.Text = "Email:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(139, 78);
            txtNombre.Margin = new Padding(4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(319, 31);
            txtNombre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 81);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(595, 712);
            btnEliminar.Margin = new Padding(4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(156, 50);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(776, 712);
            btnAnadir.Margin = new Padding(4);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(118, 50);
            btnAnadir.TabIndex = 3;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Snow;
            btnCancelar.Location = new Point(914, 712);
            btnCancelar.Margin = new Padding(4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(118, 50);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 437);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(66, 25);
            label10.TabIndex = 18;
            label10.Text = "Puesto";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(497, 434);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(104, 25);
            label11.TabIndex = 20;
            label11.Text = "Descripcion";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(606, 431);
            textBox2.Margin = new Padding(4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(319, 31);
            textBox2.TabIndex = 21;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(139, 429);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(319, 33);
            comboBox1.TabIndex = 22;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, credencialesToolStripMenuItem, administrativoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1062, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(163, 29);
            toolStripMenuItem1.Text = "Datos Personales";
            // 
            // credencialesToolStripMenuItem
            // 
            credencialesToolStripMenuItem.Name = "credencialesToolStripMenuItem";
            credencialesToolStripMenuItem.Size = new Size(126, 29);
            credencialesToolStripMenuItem.Text = "Credenciales";
            // 
            // administrativoToolStripMenuItem
            // 
            administrativoToolStripMenuItem.Name = "administrativoToolStripMenuItem";
            administrativoToolStripMenuItem.Size = new Size(144, 29);
            administrativoToolStripMenuItem.Text = "Administrativo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 31);
            // 
            // FrmAnadirPersonalAdministrativo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 772);
            Controls.Add(btnCancelar);
            Controls.Add(btnAnadir);
            Controls.Add(btnEliminar);
            Controls.Add(txtDescripcion);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "FrmAnadirPersonalAdministrativo";
            Text = "Añadir Admin";
            Load += FrmAnadirAdmin_Load;
            txtDescripcion.ResumeLayout(false);
            txtDescripcion.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox txtDescripcion;
        private TextBox txtDireccion;
        private Label label4;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtNombre;
        private Label label2;
        private Label label7;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private Label label9;
        private TextBox txtContra;
        private Label label8;
        private TextBox txtUsuario;
        private Button btnEliminar;
        private Button btnAnadir;
        private Button btnCancelar;
        private ComboBox comboRol;
        private DateTimePicker txtFecha;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox textBox2;
        private Label label11;
        private Label label10;
        private ComboBox comboBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripTextBox toolStripSeparator1;
        private ToolStripMenuItem credencialesToolStripMenuItem;
        private ToolStripMenuItem administrativoToolStripMenuItem;
    }
}