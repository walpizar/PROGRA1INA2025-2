namespace UI
{
    partial class frmActivos
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
            gbxClientes = new GroupBox();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtfecha = new TextBox();
            label4 = new Label();
            txtEstado = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtDescripcion = new TextBox();
            lblApellido1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtIdActivo = new TextBox();
            lblId = new Label();
            lblTitulo = new Label();
            txtProveedor = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cbxCategorias = new ComboBox();
            txtCantidad = new NumericUpDown();
            gbxClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // gbxClientes
            // 
            gbxClientes.Controls.Add(txtCantidad);
            gbxClientes.Controls.Add(cbxCategorias);
            gbxClientes.Controls.Add(label6);
            gbxClientes.Controls.Add(textBox1);
            gbxClientes.Controls.Add(label5);
            gbxClientes.Controls.Add(txtProveedor);
            gbxClientes.Controls.Add(label1);
            gbxClientes.Controls.Add(btnEliminar);
            gbxClientes.Controls.Add(btnGuardar);
            gbxClientes.Controls.Add(btnCancelar);
            gbxClientes.Controls.Add(txtfecha);
            gbxClientes.Controls.Add(label4);
            gbxClientes.Controls.Add(txtEstado);
            gbxClientes.Controls.Add(label3);
            gbxClientes.Controls.Add(label2);
            gbxClientes.Controls.Add(txtDescripcion);
            gbxClientes.Controls.Add(lblApellido1);
            gbxClientes.Controls.Add(txtNombre);
            gbxClientes.Controls.Add(lblNombre);
            gbxClientes.Controls.Add(txtIdActivo);
            gbxClientes.Controls.Add(lblId);
            gbxClientes.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxClientes.Location = new Point(28, 55);
            gbxClientes.Name = "gbxClientes";
            gbxClientes.Size = new Size(539, 414);
            gbxClientes.TabIndex = 5;
            gbxClientes.TabStop = false;
            gbxClientes.Text = "Datos Activos:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(410, 207);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(99, 39);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(410, 146);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 39);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(410, 64);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(99, 39);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // txtfecha
            // 
            txtfecha.Font = new Font("Segoe UI", 9.75F);
            txtfecha.Location = new Point(121, 237);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(256, 25);
            txtfecha.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(7, 240);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 20;
            label4.Text = "Fecha adquisicion:";
            // 
            // txtEstado
            // 
            txtEstado.Font = new Font("Segoe UI", 9.75F);
            txtEstado.Location = new Point(119, 201);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(258, 25);
            txtEstado.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F);
            label3.Location = new Point(60, 201);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 18;
            label3.Text = "Estado:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.Location = new Point(42, 163);
            label2.Name = "label2";
            label2.Size = new Size(63, 17);
            label2.TabIndex = 16;
            label2.Text = "Cantidad:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9.75F);
            txtDescripcion.Location = new Point(119, 127);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(258, 25);
            txtDescripcion.TabIndex = 13;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Font = new Font("Segoe UI", 9.75F);
            lblApellido1.Location = new Point(42, 130);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(79, 17);
            lblApellido1.TabIndex = 12;
            lblApellido1.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(119, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 25);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(52, 89);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdActivo
            // 
            txtIdActivo.Font = new Font("Segoe UI", 9.75F);
            txtIdActivo.Location = new Point(119, 52);
            txtIdActivo.Name = "txtIdActivo";
            txtIdActivo.Size = new Size(258, 25);
            txtIdActivo.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F);
            lblId.Location = new Point(76, 55);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 17);
            lblId.TabIndex = 8;
            lblId.Text = "ID:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(203, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(142, 30);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Crear Activos";
            lblTitulo.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 9.75F);
            txtProveedor.Location = new Point(121, 279);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(256, 25);
            txtProveedor.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(42, 282);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 25;
            label1.Text = "Proveedor:";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9.75F);
            textBox1.Location = new Point(121, 323);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 25);
            textBox1.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(42, 326);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 27;
            label5.Text = "Ubicacion:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(36, 378);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 29;
            label6.Text = "Categorias:";
            // 
            // cbxCategorias
            // 
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Location = new Point(121, 372);
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(256, 29);
            cbxCategorias.TabIndex = 30;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(121, 163);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(256, 29);
            txtCantidad.TabIndex = 31;
            // 
            // frmActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 495);
            Controls.Add(gbxClientes);
            Controls.Add(lblTitulo);
            Name = "frmActivos";
            Text = "Mantenimiento: Activos";
            Load += frmActivos_Load;
            gbxClientes.ResumeLayout(false);
            gbxClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxClientes;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtfecha;
        private Label label4;
        private TextBox txtEstado;
        private Label label3;
        private Label label2;
        private TextBox txtDescripcion;
        private Label lblApellido1;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtIdActivo;
        private Label lblId;
        private Label lblTitulo;
        private TextBox txtProveedor;
        private Label label1;
        private ComboBox cbxCategorias;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private NumericUpDown txtCantidad;
    }
}