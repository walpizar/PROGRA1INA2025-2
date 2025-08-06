namespace UI
{
    partial class frmProducto
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
            gbxDatosProducto = new GroupBox();
            txtCantidad = new NumericUpDown();
            lblCantidad = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            gbxDatosProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).BeginInit();
            SuspendLayout();
            // 
            // gbxDatosProducto
            // 
            gbxDatosProducto.Controls.Add(txtCantidad);
            gbxDatosProducto.Controls.Add(lblCantidad);
            gbxDatosProducto.Controls.Add(txtPrecio);
            gbxDatosProducto.Controls.Add(lblPrecio);
            gbxDatosProducto.Controls.Add(txtNombre);
            gbxDatosProducto.Controls.Add(lblNombre);
            gbxDatosProducto.Controls.Add(txtId);
            gbxDatosProducto.Controls.Add(lblId);
            gbxDatosProducto.Location = new Point(12, 46);
            gbxDatosProducto.Name = "gbxDatosProducto";
            gbxDatosProducto.Size = new Size(395, 197);
            gbxDatosProducto.TabIndex = 0;
            gbxDatosProducto.TabStop = false;
            gbxDatosProducto.Text = "Datos de producto";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(78, 124);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(85, 23);
            txtCantidad.TabIndex = 7;
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(14, 126);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(58, 15);
            lblCantidad.TabIndex = 6;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(78, 94);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 23);
            txtPrecio.TabIndex = 5;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(29, 97);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(43, 15);
            lblPrecio.TabIndex = 4;
            lblPrecio.Text = "Precio:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 65);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(301, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 23);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(51, 39);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(136, 13);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(161, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Crear Producto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(294, 249);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 36);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(172, 249);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 36);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 293);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosProducto);
            Name = "frmProducto";
            Text = "Matentenimiento: Crear Producto";
            gbxDatosProducto.ResumeLayout(false);
            gbxDatosProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtCantidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosProducto;
        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblCantidad;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
        private NumericUpDown txtCantidad;
    }
}