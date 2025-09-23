namespace UI
{
    partial class frmListaActivos
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
            gbxLista = new GroupBox();
            label1 = new Label();
            txtBusqueda = new TextBox();
            lstvListaActivos = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colDescripcion = new ColumnHeader();
            colIdCategoria = new ColumnHeader();
            lblTitulo = new Label();
            gbxLista.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.Red;
            btnNuevo.FlatAppearance.BorderSize = 3;
            btnNuevo.Location = new Point(459, 16);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 4;
            btnNuevo.Text = "Salir";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += (s, e) => this.Close();
            // 
            // gbxLista
            // 
            gbxLista.Controls.Add(label1);
            gbxLista.Controls.Add(txtBusqueda);
            gbxLista.Controls.Add(lstvListaActivos);
            gbxLista.Location = new Point(12, 61);
            gbxLista.Name = "gbxLista";
            gbxLista.Size = new Size(637, 387);
            gbxLista.TabIndex = 5;
            gbxLista.TabStop = false;
            gbxLista.Text = "Lista Activos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 27);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(18, 50);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(600, 23);
            txtBusqueda.TabIndex = 3;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lstvListaActivos
            // 
            lstvListaActivos.Columns.AddRange(new ColumnHeader[] { colId, colNombre, colDescripcion, colIdCategoria });
            lstvListaActivos.FullRowSelect = true;
            lstvListaActivos.GridLines = true;
            lstvListaActivos.Location = new Point(15, 88);
            lstvListaActivos.MultiSelect = false;
            lstvListaActivos.Name = "lstvListaActivos";
            lstvListaActivos.Size = new Size(603, 293);
            lstvListaActivos.TabIndex = 0;
            lstvListaActivos.UseCompatibleStateImageBehavior = false;
            lstvListaActivos.View = View.Details;
            lstvListaActivos.MouseDoubleClick += lstvListaActivos_MouseDoubleClick;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 100;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 200;
            // 
            // colDescripcion
            // 
            colDescripcion.Text = "Descripcion";
            colDescripcion.Width = 150;
            // 
            // colIdCategoria
            // 
            colIdCategoria.Text = "ID Categoria";
            colIdCategoria.Width = 150;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(169, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(243, 30);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Mantenimiento Activos\r\n";
            // 
            // frmListaActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 489);
            Controls.Add(btnNuevo);
            Controls.Add(gbxLista);
            Controls.Add(lblTitulo);
            Name = "frmListaActivos";
            Text = "Mantenimiento: Lista Activos";
            Load += frmListaActivos_Load;
            gbxLista.ResumeLayout(false);
            gbxLista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevo;
        private GroupBox gbxLista;
        private Label label1;
        private TextBox txtBusqueda;
        private ListView lstvListaActivos;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colDescripcion;
        private Label lblTitulo;
        private ColumnHeader colIdCategoria;
    }
}