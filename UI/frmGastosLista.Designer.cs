namespace UI
{
    partial class frmGastosLista
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
            groupBox1 = new GroupBox();
            lstvListaGastos = new ListView();
            colCompra = new ColumnHeader();
            colResponsable = new ColumnHeader();
            colMonto = new ColumnHeader();
            colNumFactura = new ColumnHeader();
            colFechaCompra = new ColumnHeader();
            label3 = new Label();
            btnNuevo = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstvListaGastos);
            groupBox1.Location = new Point(12, 77);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(888, 486);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista Gastos";
            // 
            // lstvListaGastos
            // 
            lstvListaGastos.Columns.AddRange(new ColumnHeader[] { colCompra, colResponsable, colMonto, colNumFactura, colFechaCompra });
            lstvListaGastos.FullRowSelect = true;
            lstvListaGastos.GridLines = true;
            lstvListaGastos.Location = new Point(21, 33);
            lstvListaGastos.MultiSelect = false;
            lstvListaGastos.Name = "lstvListaGastos";
            lstvListaGastos.Size = new Size(841, 427);
            lstvListaGastos.TabIndex = 0;
            lstvListaGastos.UseCompatibleStateImageBehavior = false;
            lstvListaGastos.View = View.Details;
            lstvListaGastos.SelectedIndexChanged += lstvListaGastos_SelectedIndexChanged;
            lstvListaGastos.MouseDoubleClick += lstvListaGastos_MouseDoubleClick;
            // 
            // colCompra
            // 
            colCompra.Text = "Compra";
            colCompra.Width = 150;
            // 
            // colResponsable
            // 
            colResponsable.Text = "Responsable";
            colResponsable.Width = 200;
            // 
            // colMonto
            // 
            colMonto.Text = "Monto";
            colMonto.Width = 115;
            // 
            // colNumFactura
            // 
            colNumFactura.Text = "N° Factura";
            colNumFactura.Width = 250;
            // 
            // colFechaCompra
            // 
            colFechaCompra.Text = "Fecha Compra";
            colFechaCompra.Width = 120;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(376, 26);
            label3.Name = "label3";
            label3.Size = new Size(149, 32);
            label3.TabIndex = 16;
            label3.Text = "Lista Gastos";
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(756, 18);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(134, 53);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // frmGastosLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 586);
            Controls.Add(btnNuevo);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "frmGastosLista";
            Text = "Mantenimiento: Gastos";
            Load += frmGastosLista_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView lstvListaGastos;
        private ColumnHeader colCompra;
        private ColumnHeader colResponsable;
        private ColumnHeader colMonto;
        private Label label3;
        private ColumnHeader colNumFactura;
        private ColumnHeader colFechaCompra;
        private Button btnNuevo;
    }
}