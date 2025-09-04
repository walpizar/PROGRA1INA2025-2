namespace UI
{
    partial class frmMedicosLista
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
            lblTitulo = new Label();
            gbxListaMedicos = new GroupBox();
            lstvLista = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            PrimerApellido = new ColumnHeader();
            SegundoApellido = new ColumnHeader();
            Especialidad = new ColumnHeader();
            txtBusqueda = new TextBox();
            lblBusqueda = new Label();
            btnNuevo = new Button();
            gbxListaMedicos.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(253, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenimiento Medicos";
            // 
            // gbxListaMedicos
            // 
            gbxListaMedicos.Controls.Add(lstvLista);
            gbxListaMedicos.Controls.Add(txtBusqueda);
            gbxListaMedicos.Controls.Add(lblBusqueda);
            gbxListaMedicos.Location = new Point(12, 48);
            gbxListaMedicos.Name = "gbxListaMedicos";
            gbxListaMedicos.Size = new Size(496, 377);
            gbxListaMedicos.TabIndex = 1;
            gbxListaMedicos.TabStop = false;
            gbxListaMedicos.Text = "Lista Medicos";
            // 
            // lstvLista
            // 
            lstvLista.Columns.AddRange(new ColumnHeader[] { Id, Nombre, PrimerApellido, SegundoApellido, Especialidad });
            lstvLista.FullRowSelect = true;
            lstvLista.GridLines = true;
            lstvLista.Location = new Point(6, 76);
            lstvLista.MultiSelect = false;
            lstvLista.Name = "lstvLista";
            lstvLista.Size = new Size(476, 295);
            lstvLista.TabIndex = 5;
            lstvLista.UseCompatibleStateImageBehavior = false;
            lstvLista.View = View.Details;
            lstvLista.SelectedIndexChanged += lstvLista_SelectedIndexChanged;
            lstvLista.MouseDoubleClick += lstvLista_MouseDoubleClick;
            // 
            // Id
            // 
            Id.Text = "Id";
            // 
            // Nombre
            // 
            Nombre.Text = "Nombre";
            Nombre.Width = 100;
            // 
            // PrimerApellido
            // 
            PrimerApellido.Text = "Primer Apellido";
            PrimerApellido.Width = 100;
            // 
            // SegundoApellido
            // 
            SegundoApellido.Text = "Segundo Apellido";
            SegundoApellido.Width = 110;
            // 
            // Especialidad
            // 
            Especialidad.Text = "Especialidad";
            Especialidad.Width = 100;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(6, 47);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Escriba datos para buscar...";
            txtBusqueda.Size = new Size(341, 23);
            txtBusqueda.TabIndex = 4;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBusqueda.Location = new Point(6, 29);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(62, 15);
            lblBusqueda.TabIndex = 3;
            lblBusqueda.Text = "Busqueda:";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(408, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 30);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmMedicosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 432);
            Controls.Add(btnNuevo);
            Controls.Add(gbxListaMedicos);
            Controls.Add(lblTitulo);
            Name = "frmMedicosLista";
            Text = "Mantenimiento: Medicos";
            Load += frmMedicosLista_Load;
            gbxListaMedicos.ResumeLayout(false);
            gbxListaMedicos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gbxListaMedicos;
        private Button btnNuevo;
        private Label lblBusqueda;
        private TextBox txtBusqueda;
        private ListView lstvLista;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader PrimerApellido;
        private ColumnHeader SegundoApellido;
        private ColumnHeader Especialidad;
    }
}