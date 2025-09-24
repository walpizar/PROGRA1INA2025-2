namespace UI
{
    partial class FrmPersonalAdministrativo
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
            listAdministradores = new ListView();
            colNombre = new ColumnHeader();
            ColApellido = new ColumnHeader();
            ColCorreo = new ColumnHeader();
            ColPuesto = new ColumnHeader();
            btnAnadir = new Button();
            gblista.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(269, 45);
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
            gblista.Controls.Add(listAdministradores);
            gblista.Location = new Point(61, 130);
            gblista.Margin = new Padding(4, 3, 4, 3);
            gblista.Name = "gblista";
            gblista.Padding = new Padding(4, 3, 4, 3);
            gblista.Size = new Size(817, 618);
            gblista.TabIndex = 3;
            gblista.TabStop = false;
            gblista.Text = "Lista Admin";
            // 
            // listAdministradores
            // 
            listAdministradores.Columns.AddRange(new ColumnHeader[] { colNombre, ColApellido, ColCorreo, ColPuesto });
            listAdministradores.FullRowSelect = true;
            listAdministradores.GridLines = true;
            listAdministradores.Location = new Point(37, 82);
            listAdministradores.Margin = new Padding(4, 3, 4, 3);
            listAdministradores.MultiSelect = false;
            listAdministradores.Name = "listAdministradores";
            listAdministradores.Size = new Size(743, 506);
            listAdministradores.TabIndex = 0;
            listAdministradores.UseCompatibleStateImageBehavior = false;
            listAdministradores.View = View.Details;
            //listAdministradores.SelectedIndexChanged += listAdministradores_SelectedIndexChanged;
            listAdministradores.MouseDoubleClick += listAdministradores_MouseDoubleClick;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 150;
            // 
            // ColApellido
            // 
            ColApellido.Text = "Apellidos";
            ColApellido.Width = 150;
            // 
            // ColCorreo
            // 
            ColCorreo.Text = "Correo Electrónico";
            ColCorreo.Width = 200;
            // 
            // ColPuesto
            // 
            ColPuesto.Text = "Puesto";
            ColPuesto.Width = 150;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(713, 38);
            btnAnadir.Margin = new Padding(4, 3, 4, 3);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(166, 55);
            btnAnadir.TabIndex = 4;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += button1_Click;
            // 
            // FrmPersonalAdministrativo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 763);
            Controls.Add(btnAnadir);
            Controls.Add(gblista);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmPersonalAdministrativo";
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
        private ListView listAdministradores;
        private ColumnHeader colNombre;
        private ColumnHeader ColApellido;
        private ColumnHeader ColCorreo;
        private ColumnHeader ColPuesto;
        private Button btnAnadir;
    }
}