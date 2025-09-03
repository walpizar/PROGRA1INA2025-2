namespace UI
{
    partial class frmEnfermeroLista
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
            btnNuevo = new Button();
            gbxListaEnfermeros = new GroupBox();
            lstvLista = new ListView();
            Id = new ColumnHeader();
            Nombre = new ColumnHeader();
            PrimerApellido = new ColumnHeader();
            SegundoApellido = new ColumnHeader();
            Area = new ColumnHeader();
            txtBusqueda = new TextBox();
            lblBusqueda = new Label();
            gbxListaEnfermeros.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(282, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Mantenimiento Enfermeros";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(408, 9);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 30);
            btnNuevo.TabIndex = 3;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // gbxListaEnfermeros
            // 
            gbxListaEnfermeros.Controls.Add(lstvLista);
            gbxListaEnfermeros.Controls.Add(txtBusqueda);
            gbxListaEnfermeros.Controls.Add(lblBusqueda);
            gbxListaEnfermeros.Location = new Point(12, 45);
            gbxListaEnfermeros.Name = "gbxListaEnfermeros";
            gbxListaEnfermeros.Size = new Size(496, 377);
            gbxListaEnfermeros.TabIndex = 4;
            gbxListaEnfermeros.TabStop = false;
            gbxListaEnfermeros.Text = "Lista Enfermeros";
            // 
            // lstvLista
            // 
            lstvLista.Columns.AddRange(new ColumnHeader[] { Id, Nombre, PrimerApellido, SegundoApellido, Area });
            lstvLista.FullRowSelect = true;
            lstvLista.GridLines = true;
            lstvLista.Location = new Point(6, 76);
            lstvLista.MultiSelect = false;
            lstvLista.Name = "lstvLista";
            lstvLista.Size = new Size(476, 295);
            lstvLista.TabIndex = 5;
            lstvLista.UseCompatibleStateImageBehavior = false;
            lstvLista.View = View.Details;
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
            // Area
            // 
            Area.Text = "Area";
            Area.Width = 100;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(6, 47);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PlaceholderText = "Escriba datos para buscar...";
            txtBusqueda.Size = new Size(341, 23);
            txtBusqueda.TabIndex = 4;
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
            // frmEnfermeroLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 432);
            Controls.Add(gbxListaEnfermeros);
            Controls.Add(btnNuevo);
            Controls.Add(lblTitulo);
            Name = "frmEnfermeroLista";
            Text = "Mantenimiento: Enfermeros";
            Load += frmEnfermeroLista_Load;
            gbxListaEnfermeros.ResumeLayout(false);
            gbxListaEnfermeros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnNuevo;
        private GroupBox gbxListaEnfermeros;
        private ListView lstvLista;
        private ColumnHeader Id;
        private ColumnHeader Nombre;
        private ColumnHeader PrimerApellido;
        private ColumnHeader SegundoApellido;
        private ColumnHeader Area;
        private TextBox txtBusqueda;
        private Label lblBusqueda;
    }
}