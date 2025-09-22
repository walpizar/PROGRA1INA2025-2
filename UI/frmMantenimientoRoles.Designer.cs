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
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            ListViewItem listViewItem5 = new ListViewItem("");
            ListViewItem listViewItem6 = new ListViewItem("");
            ListViewItem listViewItem7 = new ListViewItem("");
            ListViewItem listViewItem8 = new ListViewItem("");
            ListViewItem listViewItem9 = new ListViewItem("");
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button5 = new Button();
            comboBox2 = new ComboBox();
            label6 = new Label();
            groupBox1 = new GroupBox();
            chkEliminar = new CheckBox();
            chkEditar = new CheckBox();
            chkCrear = new CheckBox();
            guardarPermiso = new Button();
            chkConsultar = new CheckBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            listView1 = new ListView();
            Nombre = new ColumnHeader();
            Descripcion = new ColumnHeader();
            label2 = new Label();
            tabPage3 = new TabPage();
            buttonCrearRol = new Button();
            richTextBoxDescripcionRol = new RichTextBox();
            textBoxNombreRol = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tabPage4 = new TabPage();
            listView2 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnModulo = new ColumnHeader();
            tabPage5 = new TabPage();
            listView3 = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
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
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(27, 67);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(700, 354);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightBlue;
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(comboBox2);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage1.Location = new Point(4, 30);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(680, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Editar Permisos";
            // 
            // button5
            // 
            button5.Location = new Point(285, 97);
            button5.Name = "button5";
            button5.Size = new Size(140, 41);
            button5.TabIndex = 11;
            button5.Text = "Mostrar Permisos";
            button5.UseVisualStyleBackColor = true;
            button5.Click += buscarPermiso_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(207, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(218, 29);
            comboBox2.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 65);
            label6.Name = "label6";
            label6.Size = new Size(166, 21);
            label6.TabIndex = 9;
            label6.Text = "Seleccione un Modulo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(chkEliminar);
            groupBox1.Controls.Add(chkEditar);
            groupBox1.Controls.Add(chkCrear);
            groupBox1.Controls.Add(guardarPermiso);
            groupBox1.Controls.Add(chkConsultar);
            groupBox1.Location = new Point(20, 154);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(631, 139);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Permisos Asignados";
            // 
            // chkEliminar
            // 
            chkEliminar.AutoSize = true;
            chkEliminar.Location = new Point(486, 43);
            chkEliminar.Name = "chkEliminar";
            chkEliminar.Size = new Size(86, 25);
            chkEliminar.TabIndex = 20;
            chkEliminar.Text = "Eliminar";
            chkEliminar.UseVisualStyleBackColor = true;
            // 
            // chkEditar
            // 
            chkEditar.AccessibleRole = AccessibleRole.Indicator;
            chkEditar.AutoSize = true;
            chkEditar.Location = new Point(328, 43);
            chkEditar.Name = "chkEditar";
            chkEditar.Size = new Size(95, 25);
            chkEditar.TabIndex = 16;
            chkEditar.Text = "Modificar";
            chkEditar.UseVisualStyleBackColor = true;
            // 
            // chkCrear
            // 
            chkCrear.AutoSize = true;
            chkCrear.Location = new Point(197, 43);
            chkCrear.Name = "chkCrear";
            chkCrear.Size = new Size(67, 25);
            chkCrear.TabIndex = 12;
            chkCrear.Text = "Crear";
            chkCrear.UseVisualStyleBackColor = true;
            // 
            // guardarPermiso
            // 
            guardarPermiso.Location = new Point(266, 74);
            guardarPermiso.Name = "guardarPermiso";
            guardarPermiso.Size = new Size(101, 40);
            guardarPermiso.TabIndex = 8;
            guardarPermiso.Text = "Guardar";
            guardarPermiso.UseVisualStyleBackColor = true;
            guardarPermiso.Click += buttonCrearPermiso_Click;
            // 
            // chkConsultar
            // 
            chkConsultar.AutoSize = true;
            chkConsultar.Location = new Point(49, 43);
            chkConsultar.Name = "chkConsultar";
            chkConsultar.Size = new Size(96, 25);
            chkConsultar.TabIndex = 0;
            chkConsultar.Text = "Consultar";
            chkConsultar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(176, 24);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(218, 29);
            comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 27);
            label3.Name = "label3";
            label3.Size = new Size(135, 21);
            label3.TabIndex = 0;
            label3.Text = "Seleccione un Rol:";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.PowderBlue;
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(label2);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage2.Location = new Point(4, 30);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(692, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Lista de Roles";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(181, 294);
            label7.Name = "label7";
            label7.Size = new Size(294, 21);
            label7.TabIndex = 2;
            label7.Text = "*Para editar haga doble click sobre un rol";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { Nombre, Descripcion });
            listView1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3 });
            listView1.Location = new Point(27, 17);
            listView1.Name = "listView1";
            listView1.Size = new Size(630, 274);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.MouseDoubleClick += dobleClickEliminarEditar;
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre Rol";
            Nombre.Width = 160;
            // 
            // Descripcion
            // 
            Descripcion.Text = "Descripcion de Rol";
            Descripcion.Width = 430;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 17);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.PowderBlue;
            tabPage3.Controls.Add(buttonCrearRol);
            tabPage3.Controls.Add(richTextBoxDescripcionRol);
            tabPage3.Controls.Add(textBoxNombreRol);
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(label4);
            tabPage3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tabPage3.Location = new Point(4, 30);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(680, 320);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Crear un nuevo rol";
            // 
            // buttonCrearRol
            // 
            buttonCrearRol.Location = new Point(240, 226);
            buttonCrearRol.Name = "buttonCrearRol";
            buttonCrearRol.Size = new Size(130, 59);
            buttonCrearRol.TabIndex = 6;
            buttonCrearRol.Text = "Crear Rol";
            buttonCrearRol.UseVisualStyleBackColor = true;
            buttonCrearRol.Click += buttonCrearRol_Click;
            // 
            // richTextBoxDescripcionRol
            // 
            richTextBoxDescripcionRol.Location = new Point(120, 96);
            richTextBoxDescripcionRol.Name = "richTextBoxDescripcionRol";
            richTextBoxDescripcionRol.Size = new Size(520, 96);
            richTextBoxDescripcionRol.TabIndex = 5;
            richTextBoxDescripcionRol.Text = "";
            // 
            // textBoxNombreRol
            // 
            textBoxNombreRol.Location = new Point(188, 37);
            textBoxNombreRol.Name = "textBoxNombreRol";
            textBoxNombreRol.Size = new Size(182, 29);
            textBoxNombreRol.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 99);
            label5.Name = "label5";
            label5.Size = new Size(94, 21);
            label5.TabIndex = 1;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 40);
            label4.Name = "label4";
            label4.Size = new Size(162, 21);
            label4.TabIndex = 0;
            label4.Text = "Nombre de nuevo rol:";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.PowderBlue;
            tabPage4.Controls.Add(listView2);
            tabPage4.Location = new Point(4, 30);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(692, 320);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Lista de Modulos";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnModulo });
            listView2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView2.Items.AddRange(new ListViewItem[] { listViewItem4, listViewItem5, listViewItem6 });
            listView2.Location = new Point(32, 13);
            listView2.Name = "listView2";
            listView2.Size = new Size(636, 290);
            listView2.TabIndex = 2;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Nombre Modulo";
            columnHeader1.Width = 200;
            // 
            // columnModulo
            // 
            columnModulo.Text = "Descripcion de Modulo";
            columnModulo.Width = 430;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.PowderBlue;
            tabPage5.Controls.Add(listView3);
            tabPage5.Location = new Point(4, 30);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(692, 320);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Lista de Permisos";
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7 });
            listView3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listView3.Items.AddRange(new ListViewItem[] { listViewItem7, listViewItem8, listViewItem9 });
            listView3.Location = new Point(32, 13);
            listView3.Name = "listView3";
            listView3.Size = new Size(623, 293);
            listView3.TabIndex = 3;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "El rol tiene permiso";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "sobre el modulo";
            columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Consultar";
            columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Crear";
            columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Editar";
            columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Eliminar";
            columnHeader7.Width = 80;
            // 
            // frmMantenimientoRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 451);
            Controls.Add(tabControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmMantenimientoRoles";
            Text = "frmMantenimientoRoles";
            Load += frmMantenimientoRoles_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
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
        private ColumnHeader Nombre;
        private ColumnHeader Descripcion;
        private Label label4;
        private Label label5;
        private TextBox textBoxNombreRol;
        private RichTextBox richTextBoxDescripcionRol;
        private Button buttonCrearRol;
        private ComboBox comboBox1;
        private Button guardarPermiso;
        private GroupBox groupBox1;
        private CheckBox chkEliminar;
        private CheckBox chkEditar;
        private CheckBox chkCrear;
        private CheckBox chkConsultar;
        private ComboBox comboBox2;
        private Label label6;
        private Button button5;
        private Label label7;
        private TabPage tabPage4;
        private ListView listView2;
        private ColumnHeader columnModulo;
        private ColumnHeader columnHeader1;
        private TabPage tabPage5;
        private ListView listView3;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
    }
}