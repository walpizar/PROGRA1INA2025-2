namespace UI
{
    partial class frmProductoLista
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
            gbxLista = new GroupBox();
            label1 = new Label();
            txtBusqueda = new TextBox();
            lstvLista = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colPrecio = new ColumnHeader();
            gbxLista.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(159, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(271, 30);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Mantenimiento Productos";
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.Red;
            btnNuevo.FlatAppearance.BorderSize = 3;
            btnNuevo.Location = new Point(485, 21);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(120, 40);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = " Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // gbxLista
            // 
            gbxLista.Controls.Add(label1);
            gbxLista.Controls.Add(txtBusqueda);
            gbxLista.Controls.Add(lstvLista);
            gbxLista.Location = new Point(12, 67);
            gbxLista.Name = "gbxLista";
            gbxLista.Size = new Size(593, 387);
            gbxLista.TabIndex = 2;
            gbxLista.TabStop = false;
            gbxLista.Text = "Lista Productos";
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
            txtBusqueda.Size = new Size(554, 23);
            txtBusqueda.TabIndex = 3;
            // 
            // lstvLista
            // 
            lstvLista.Columns.AddRange(new ColumnHeader[] { colId, colNombre, colPrecio });
            lstvLista.FullRowSelect = true;
            lstvLista.GridLines = true;
            lstvLista.Location = new Point(18, 88);
            lstvLista.MultiSelect = false;
            lstvLista.Name = "lstvLista";
            lstvLista.Size = new Size(557, 293);
            lstvLista.TabIndex = 0;
            lstvLista.UseCompatibleStateImageBehavior = false;
            lstvLista.View = View.Details;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 100;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 300;
            // 
            // colPrecio
            // 
            colPrecio.Text = "Precio";
            colPrecio.Width = 150;
            // 
            // frmProductoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 465);
            Controls.Add(btnNuevo);
            Controls.Add(gbxLista);
            Controls.Add(lblTitulo);
            Name = "frmProductoLista";
            Text = "Mantenimiento: Productos";
            Load += frmProductoLista_Load;
            gbxLista.ResumeLayout(false);
            gbxLista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnNuevo;
        private GroupBox gbxLista;
        private ListView lstvLista;
        private TextBox txtBusqueda;
        private Label label1;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colPrecio;
    }
}