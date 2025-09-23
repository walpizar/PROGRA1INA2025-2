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
            gbxLista = new GroupBox();
            label1 = new Label();
            txtBusqueda = new TextBox();
            lstvListaActivos = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colDescripcion = new ColumnHeader();
            colIdCategoria = new ColumnHeader();
            lblTitulo = new Label();
            btnCrear = new Button();
            gbxLista.SuspendLayout();
            SuspendLayout();
            // 
            // gbxLista
            // 
            gbxLista.Controls.Add(label1);
            gbxLista.Controls.Add(txtBusqueda);
            gbxLista.Controls.Add(lstvListaActivos);
            gbxLista.Location = new Point(12, 61);
            gbxLista.Name = "gbxLista";
            gbxLista.Size = new Size(638, 387);
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
            // btnCrear
            // 
            btnCrear.FlatAppearance.BorderColor = Color.Red;
            btnCrear.FlatAppearance.BorderSize = 3;
            btnCrear.Location = new Point(487, 16);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(120, 40);
            btnCrear.TabIndex = 4;
            btnCrear.Text = "Nuevo";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // frmListaActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 489);
            Controls.Add(btnCrear);
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
        private GroupBox gbxLista;
        private Label label1;
        private TextBox txtBusqueda;
        private ListView lstvListaActivos;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colDescripcion;
        private Label lblTitulo;
        private ColumnHeader colIdCategoria;
        private Button btnCrear;
    }
}