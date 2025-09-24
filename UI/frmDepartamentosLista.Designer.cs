namespace UI
{
    partial class frmDepartamentosLista
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
            gbxListaDept = new GroupBox();
            lblBusqueda = new Label();
            txtBusqueda = new TextBox();
            lstvListaDept = new ListView();
            ColId = new ColumnHeader();
            ColNombre = new ColumnHeader();
            ColDescripción = new ColumnHeader();
            btnNuevo = new Button();
            lblTitulo = new Label();
            gbxListaDept.SuspendLayout();
            SuspendLayout();
            // 
            // gbxListaDept
            // 
            gbxListaDept.Controls.Add(lblBusqueda);
            gbxListaDept.Controls.Add(txtBusqueda);
            gbxListaDept.Controls.Add(lstvListaDept);
            gbxListaDept.Location = new Point(31, 92);
            gbxListaDept.Name = "gbxListaDept";
            gbxListaDept.Size = new Size(744, 450);
            gbxListaDept.TabIndex = 8;
            gbxListaDept.TabStop = false;
            gbxListaDept.Text = "Lista Departamento";
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
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lstvListaDept
            // 
            lstvListaDept.Columns.AddRange(new ColumnHeader[] { ColId, ColNombre, ColDescripción });
            lstvListaDept.FullRowSelect = true;
            lstvListaDept.GridLines = true;
            lstvListaDept.Location = new Point(26, 75);
            lstvListaDept.MultiSelect = false;
            lstvListaDept.Name = "lstvListaDept";
            lstvListaDept.Size = new Size(691, 355);
            lstvListaDept.TabIndex = 1;
            lstvListaDept.UseCompatibleStateImageBehavior = false;
            lstvListaDept.View = View.Details;
            lstvListaDept.MouseDoubleClick += lstvListaDept_MouseDoubleClick_1;
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
            ColDescripción.Width = 387;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(641, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(134, 53);
            btnNuevo.TabIndex = 9;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(226, 34);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(313, 30);
            lblTitulo.TabIndex = 10;
            lblTitulo.Text = "Mantenimiento Departamento";
            // 
            // frmDepartamentosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(798, 554);
            Controls.Add(lblTitulo);
            Controls.Add(btnNuevo);
            Controls.Add(gbxListaDept);
            Name = "frmDepartamentosLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento: Departamentos";
            Load += frmDepartamentosLista_Load;
            gbxListaDept.ResumeLayout(false);
            gbxListaDept.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxListaDept;
        private Label lblBusqueda;
        private TextBox txtBusqueda;
        private ListView lstvListaDept;
        private ColumnHeader ColId;
        private ColumnHeader ColNombre;
        private ColumnHeader ColDescripción;
        private Button btnNuevo;
        private Label lblTitulo;
    }
}