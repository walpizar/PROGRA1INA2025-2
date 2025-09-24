namespace UI
{
    partial class frmGastos
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
            gbxGastos = new GroupBox();
            txtJustificacion = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            label3 = new Label();
            txtResponsable = new TextBox();
            txtMonto = new TextBox();
            txtProductoComprado = new TextBox();
            txtNumFactura = new TextBox();
            dtmCompra = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            lblJustificacion = new Label();
            lblProductoComprado = new Label();
            lblCompra = new Label();
            lblFactura = new Label();
            lblFechaCompra = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            btnEliminar = new Button();
            gbxGastos.SuspendLayout();
            SuspendLayout();
            // 
            // gbxGastos
            // 
            gbxGastos.Controls.Add(btnEliminar);
            gbxGastos.Controls.Add(txtJustificacion);
            gbxGastos.Controls.Add(btnGuardar);
            gbxGastos.Controls.Add(btnCancelar);
            gbxGastos.Controls.Add(label3);
            gbxGastos.Controls.Add(txtResponsable);
            gbxGastos.Controls.Add(txtMonto);
            gbxGastos.Controls.Add(txtProductoComprado);
            gbxGastos.Controls.Add(txtNumFactura);
            gbxGastos.Controls.Add(dtmCompra);
            gbxGastos.Controls.Add(label2);
            gbxGastos.Controls.Add(label1);
            gbxGastos.Controls.Add(lblJustificacion);
            gbxGastos.Controls.Add(lblProductoComprado);
            gbxGastos.Controls.Add(lblCompra);
            gbxGastos.Controls.Add(lblFactura);
            gbxGastos.Controls.Add(lblFechaCompra);
            gbxGastos.Location = new Point(12, 12);
            gbxGastos.Name = "gbxGastos";
            gbxGastos.Size = new Size(669, 410);
            gbxGastos.TabIndex = 0;
            gbxGastos.TabStop = false;
            gbxGastos.Text = "Mantenimiento Gastos";
            // 
            // txtJustificacion
            // 
            txtJustificacion.Location = new Point(202, 264);
            txtJustificacion.Name = "txtJustificacion";
            txtJustificacion.Size = new Size(330, 23);
            txtJustificacion.TabIndex = 5;
            txtJustificacion.WordWrap = false;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(397, 352);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 36);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(516, 352);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 36);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(252, 38);
            label3.Name = "label3";
            label3.Size = new Size(162, 30);
            label3.TabIndex = 15;
            label3.Text = "Registrar Gasto";
            // 
            // txtResponsable
            // 
            txtResponsable.Location = new Point(203, 145);
            txtResponsable.Name = "txtResponsable";
            txtResponsable.Size = new Size(268, 23);
            txtResponsable.TabIndex = 2;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(203, 180);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(169, 23);
            txtMonto.TabIndex = 3;
            // 
            // txtProductoComprado
            // 
            txtProductoComprado.Location = new Point(203, 101);
            txtProductoComprado.Name = "txtProductoComprado";
            txtProductoComprado.Size = new Size(199, 23);
            txtProductoComprado.TabIndex = 1;
            // 
            // txtNumFactura
            // 
            txtNumFactura.Location = new Point(202, 222);
            txtNumFactura.Name = "txtNumFactura";
            txtNumFactura.Size = new Size(199, 23);
            txtNumFactura.TabIndex = 4;
            // 
            // dtmCompra
            // 
            dtmCompra.Location = new Point(203, 302);
            dtmCompra.Name = "dtmCompra";
            dtmCompra.Size = new Size(221, 23);
            dtmCompra.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(111, 145);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 7;
            label2.Text = "Responsable:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(147, 181);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 6;
            label1.Text = "Monto:";
            // 
            // lblJustificacion
            // 
            lblJustificacion.AutoSize = true;
            lblJustificacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblJustificacion.Location = new Point(117, 265);
            lblJustificacion.Name = "lblJustificacion";
            lblJustificacion.Size = new Size(80, 17);
            lblJustificacion.TabIndex = 5;
            lblJustificacion.Text = "Justificación:";
            // 
            // lblProductoComprado
            // 
            lblProductoComprado.AutoSize = true;
            lblProductoComprado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProductoComprado.Location = new Point(71, 102);
            lblProductoComprado.Name = "lblProductoComprado";
            lblProductoComprado.Size = new Size(129, 17);
            lblProductoComprado.TabIndex = 4;
            lblProductoComprado.Text = "Producto comprado:";
            // 
            // lblCompra
            // 
            lblCompra.AutoSize = true;
            lblCompra.Location = new Point(19, 196);
            lblCompra.Name = "lblCompra";
            lblCompra.Size = new Size(0, 15);
            lblCompra.TabIndex = 3;
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFactura.Location = new Point(76, 222);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(124, 17);
            lblFactura.TabIndex = 2;
            lblFactura.Text = "Numero de Factura:";
            // 
            // lblFechaCompra
            // 
            lblFechaCompra.AutoSize = true;
            lblFechaCompra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaCompra.Location = new Point(86, 306);
            lblFechaCompra.Name = "lblFechaCompra";
            lblFechaCompra.Size = new Size(114, 17);
            lblFechaCompra.TabIndex = 1;
            lblFechaCompra.Text = "Fecha de Compra:";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(278, 352);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 36);
            btnEliminar.TabIndex = 16;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmGastos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 434);
            Controls.Add(gbxGastos);
            Name = "frmGastos";
            Text = "Mantenimiento: Gastos";
            Load += frmGastos_Load;
            gbxGastos.ResumeLayout(false);
            gbxGastos.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxGastos;
        private Label lblFechaCompra;
        private Label label1;
        private Label lblJustificacion;
        private Label lblProductoComprado;
        private Label lblCompra;
        private Label lblFactura;
        private TextBox txtResponsable;
        private TextBox txtMonto;
        private TextBox txtProductoComprado;
        private TextBox txtNumFactura;
        private DateTimePicker dtmCompra;
        private Label label2;
        private Label label3;
        private Button btnCancelar;
        private Button btnGuardar;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox txtJustificacion;
        private Button btnEliminar;
    }
}