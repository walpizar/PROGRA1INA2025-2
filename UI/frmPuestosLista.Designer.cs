namespace UI
{
    partial class frmPuestosLista
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
            gbxListaPuesto = new GroupBox();
            lblBusqueda = new Label();
            txtBusqueda = new TextBox();
            lstvListaPuestos = new ListView();
            ColId = new ColumnHeader();
            ColNombre = new ColumnHeader();
            ColDescripción = new ColumnHeader();
            colEstado = new ColumnHeader();
            btnNuevo = new Button();
            lblTitulo = new Label();
            gbxListaPuesto.SuspendLayout();
            SuspendLayout();
            // 
            // gbxListaPuesto
            // 
            gbxListaPuesto.Controls.Add(lblBusqueda);
            gbxListaPuesto.Controls.Add(txtBusqueda);
            gbxListaPuesto.Controls.Add(lstvListaPuestos);
            gbxListaPuesto.Location = new Point(27, 92);
            gbxListaPuesto.Name = "gbxListaPuesto";
            gbxListaPuesto.Size = new Size(744, 450);
            gbxListaPuesto.TabIndex = 10;
            gbxListaPuesto.TabStop = false;
            gbxListaPuesto.Text = "Lista Puestos";
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Location = new Point(26, 28);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Size = new Size(62, 15);
            lblBusqueda.TabIndex = 3;
            lblBusqueda.Text = "Busqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(26, 46);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(552, 23);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged_1;
            // 
            // lstvListaPuestos
            // 
            lstvListaPuestos.Columns.AddRange(new ColumnHeader[] { ColId, ColNombre, ColDescripción, colEstado });
            lstvListaPuestos.FullRowSelect = true;
            lstvListaPuestos.GridLines = true;
            lstvListaPuestos.Location = new Point(26, 84);
            lstvListaPuestos.MultiSelect = false;
            lstvListaPuestos.Name = "lstvListaPuestos";
            lstvListaPuestos.Size = new Size(691, 351);
            lstvListaPuestos.TabIndex = 1;
            lstvListaPuestos.UseCompatibleStateImageBehavior = false;
            lstvListaPuestos.View = View.Details;
            lstvListaPuestos.MouseDoubleClick += lstvListaPuestos_MouseDoubleClick_1;
            // 
            // ColId
            // 
            ColId.Text = "ID";
            ColId.Width = 100;
            // 
            // ColNombre
            // 
            ColNombre.Text = "Nombre";
            ColNombre.Width = 200;
            // 
            // ColDescripción
            // 
            ColDescripción.Text = "Descripción";
            ColDescripción.Width = 300;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 87;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(637, 33);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(134, 53);
            btnNuevo.TabIndex = 11;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(272, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(238, 30);
            lblTitulo.TabIndex = 12;
            lblTitulo.Text = "Mantenimiento Puesto";
            // 
            // frmPuestosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(798, 554);
            Controls.Add(lblTitulo);
            Controls.Add(btnNuevo);
            Controls.Add(gbxListaPuesto);
            Name = "frmPuestosLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento: Puestos";
            Load += frmPuestosLista_Load;
            gbxListaPuesto.ResumeLayout(false);
            gbxListaPuesto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxListaPuesto;
        private Label lblBusqueda;
        private TextBox txtBusqueda;
        private ListView lstvListaPuestos;
        private ColumnHeader ColId;
        private ColumnHeader ColNombre;
        private ColumnHeader ColDescripción;
        private ColumnHeader colEstado;
        private Button btnNuevo;
        private Label lblTitulo;
    }
}