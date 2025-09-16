namespace UI
{
    partial class FrmMantenimientoAdmin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            gblista = new GroupBox();
            listView1 = new ListView();
            colNombre = new ColumnHeader();
            ColApellido = new ColumnHeader();
            ColCorreo = new ColumnHeader();
            ColRol = new ColumnHeader();
            ColEstado = new ColumnHeader();
            btnAnadir = new Button();
            gblista.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(293, 30);
            label1.Name = "label1";
            label1.Size = new Size(229, 38);
            label1.TabIndex = 0;
            label1.Text = "Mantenimiento ";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // gblista
            // 
            gblista.Controls.Add(listView1);
            gblista.Location = new Point(50, 104);
            gblista.Name = "gblista";
            gblista.Size = new Size(712, 495);
            gblista.TabIndex = 3;
            gblista.TabStop = false;
            gblista.Text = "Lista Admin";
            gblista.Enter += groupBox1_Enter;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colNombre, ColApellido, ColCorreo, ColEstado, ColRol });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(41, 68);
            listView1.Name = "listView1";
            listView1.Size = new Size(647, 405);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 200;
            // 
            // ColApellido
            // 
            ColApellido.Text = "Apellido";
            ColApellido.Width = 200;
            // 
            // ColCorreo
            // 
            ColCorreo.Text = "Correo Electrónico";
            ColCorreo.Width = 140;
            // 
            // ColRol
            // 
            ColRol.DisplayIndex = 3;
            ColRol.Text = "Rol";
            ColRol.Width = 50;
            // 
            // ColEstado
            // 
            ColEstado.DisplayIndex = 4;
            ColEstado.Text = "Estado";
            ColEstado.Width = 50;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(630, 40);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(132, 44);
            btnAnadir.TabIndex = 4;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += button1_Click;
            // 
            // FrmMantenimientoAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 611);
            Controls.Add(btnAnadir);
            Controls.Add(gblista);
            Controls.Add(label1);
            Name = "FrmMantenimientoAdmin";
            Text = "Mantenimiento de Administradores";
            Load += FrmMantenimientoAdmin_Load;
            gblista.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox gblista;
        private ListView listView1;
        private ColumnHeader colNombre;
        private ColumnHeader ColApellido;
        private ColumnHeader ColCorreo;
        private ColumnHeader ColRol;
        private ColumnHeader ColEstado;
        private Button btnAnadir;
    }
}