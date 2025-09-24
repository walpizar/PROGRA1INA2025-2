namespace UI
{
    partial class frmPacienteLista
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
            btnNuevo = new Button();
            gbxListaPacientes = new GroupBox();
            rdBtnInactivos = new RadioButton();
            rdBtnActivos = new RadioButton();
            lblEstadoPacientes = new Label();
            lblBusqueda = new Label();
            txtBusqueda = new TextBox();
            lstvListaPaciente = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colApellido1 = new ColumnHeader();
            colApellido2 = new ColumnHeader();
            colTelefono = new ColumnHeader();
            lblTitulo = new Label();
            gbxListaPacientes.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.Red;
            btnNuevo.FlatAppearance.BorderSize = 3;
            btnNuevo.Location = new Point(759, 30);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = " Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gbxListaPacientes
            // 
            gbxListaPacientes.Controls.Add(rdBtnInactivos);
            gbxListaPacientes.Controls.Add(rdBtnActivos);
            gbxListaPacientes.Controls.Add(lblEstadoPacientes);
            gbxListaPacientes.Controls.Add(lblBusqueda);
            gbxListaPacientes.Controls.Add(txtBusqueda);
            gbxListaPacientes.Controls.Add(lstvListaPaciente);
            gbxListaPacientes.Location = new Point(14, 76);
            gbxListaPacientes.Name = "gbxListaPacientes";
            gbxListaPacientes.Size = new Size(865, 498);
            gbxListaPacientes.TabIndex = 5;
            gbxListaPacientes.TabStop = false;
            gbxListaPacientes.Text = "Pacientes";
            // 
            // rdBtnInactivos
            // 
            rdBtnInactivos.AutoSize = true;
            rdBtnInactivos.Location = new Point(721, 50);
            rdBtnInactivos.Name = "rdBtnInactivos";
            rdBtnInactivos.Size = new Size(72, 19);
            rdBtnInactivos.TabIndex = 4;
            rdBtnInactivos.TabStop = true;
            rdBtnInactivos.Text = "Inactivos";
            rdBtnInactivos.UseVisualStyleBackColor = true;
            rdBtnInactivos.CheckedChanged += rdBtnInactivos_CheckedChanged;
            // 
            // rdBtnActivos
            // 
            rdBtnActivos.AutoSize = true;
            rdBtnActivos.Location = new Point(640, 50);
            rdBtnActivos.Name = "rdBtnActivos";
            rdBtnActivos.Size = new Size(64, 19);
            rdBtnActivos.TabIndex = 8;
            rdBtnActivos.TabStop = true;
            rdBtnActivos.Text = "Activos";
            rdBtnActivos.UseVisualStyleBackColor = true;
            rdBtnActivos.CheckedChanged += rdBtnActivos_CheckedChanged;
            // 
            // lblEstadoPacientes
            // 
            lblEstadoPacientes.AutoSize = true;
            lblEstadoPacientes.Location = new Point(669, 27);
            lblEstadoPacientes.Name = "lblEstadoPacientes";
            lblEstadoPacientes.Size = new Size(100, 15);
            lblEstadoPacientes.TabIndex = 7;
            lblEstadoPacientes.Text = "Lista de Pacientes";
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Location = new Point(19, 27);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(62, 15);
            lblBusqueda.TabIndex = 4;
            lblBusqueda.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(18, 50);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(554, 23);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lstvListaPaciente
            // 
            lstvListaPaciente.Columns.AddRange(new ColumnHeader[] { colId, colNombre, colApellido1, colApellido2, colTelefono });
            lstvListaPaciente.FullRowSelect = true;
            lstvListaPaciente.GridLines = true;
            lstvListaPaciente.Location = new Point(15, 88);
            lstvListaPaciente.MultiSelect = false;
            lstvListaPaciente.Name = "lstvListaPaciente";
            lstvListaPaciente.Size = new Size(838, 394);
            lstvListaPaciente.TabIndex = 3;
            lstvListaPaciente.UseCompatibleStateImageBehavior = false;
            lstvListaPaciente.View = View.Details;
            lstvListaPaciente.MouseDoubleClick += lstvListaPaciente_MouseDoubleClick;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 80;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 200;
            // 
            // colApellido1
            // 
            colApellido1.Text = "Apellido 1";
            colApellido1.Width = 200;
            // 
            // colApellido2
            // 
            colApellido2.Text = "Apellido 2";
            colApellido2.Width = 200;
            // 
            // colTelefono
            // 
            colTelefono.Text = "Telefono";
            colTelefono.Width = 150;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(311, 30);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(262, 30);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Mantenimiento Pacientes";
            // 
            // frmPacienteLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(895, 586);
            Controls.Add(btnNuevo);
            Controls.Add(gbxListaPacientes);
            Controls.Add(lblTitulo);
            Name = "frmPacienteLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento: Pacientes";
            Load += frmPacienteLista_Load;
            gbxListaPacientes.ResumeLayout(false);
            gbxListaPacientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private GroupBox gbxListaPacientes;
        private Label lblBusqueda;
        private TextBox txtBusqueda;
        private ListView lstvListaPaciente;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colApellido1;
        private Label lblTitulo;
        private ColumnHeader colApellido2;
        private ColumnHeader colTelefono;
        private Label lblEstadoPacientes;
        private RadioButton rdBtnInactivos;
        private RadioButton rdBtnActivos;
    }
}