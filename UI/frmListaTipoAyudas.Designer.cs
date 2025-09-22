namespace UI
{
    partial class frmListaTipoAyudas
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
            lvtCatalogoTipoAyuda = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtBusqueda = new TextBox();
            groupBox1 = new GroupBox();
            lblTitulo = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = SystemColors.Control;
            btnNuevo.FlatStyle = FlatStyle.Popup;
            btnNuevo.ForeColor = SystemColors.ControlText;
            btnNuevo.Location = new Point(491, 46);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(110, 42);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // lvtCatalogoTipoAyuda
            // 
            lvtCatalogoTipoAyuda.Activation = ItemActivation.TwoClick;
            lvtCatalogoTipoAyuda.BackColor = SystemColors.ScrollBar;
            lvtCatalogoTipoAyuda.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvtCatalogoTipoAyuda.FullRowSelect = true;
            lvtCatalogoTipoAyuda.GridLines = true;
            lvtCatalogoTipoAyuda.Location = new Point(15, 58);
            lvtCatalogoTipoAyuda.MultiSelect = false;
            lvtCatalogoTipoAyuda.Name = "lvtCatalogoTipoAyuda";
            lvtCatalogoTipoAyuda.Size = new Size(558, 236);
            lvtCatalogoTipoAyuda.TabIndex = 1;
            lvtCatalogoTipoAyuda.UseCompatibleStateImageBehavior = false;
            lvtCatalogoTipoAyuda.View = View.Details;
            lvtCatalogoTipoAyuda.SelectedIndexChanged += lvtCatalogoTipoAyuda_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Responsable";
            columnHeader3.Width = 110;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(15, 29);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(558, 23);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtBusqueda);
            groupBox1.Controls.Add(lvtCatalogoTipoAyuda);
            groupBox1.Location = new Point(12, 94);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(589, 312);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Tipos de Ayudas";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(154, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(332, 30);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Mantenimiento Tipos de Ayudas";
            // 
            // frmListaTipoAyudas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(613, 420);
            Controls.Add(lblTitulo);
            Controls.Add(btnNuevo);
            Controls.Add(groupBox1);
            Name = "frmListaTipoAyudas";
            Text = "Mantenimientos Tipos de Ayudas";
            Load += frmListaTipoAyudas_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Button btnNuevo;
        private ListView lvtCatalogoTipoAyuda;
        private TextBox txtBusqueda;
        private GroupBox groupBox1;
        private Label lblTitulo;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}