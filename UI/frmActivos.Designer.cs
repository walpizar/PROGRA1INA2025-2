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
            btnLista = new Button();
            cbxCategorias = new ComboBox();
            label6 = new Label();
            txtUbicacion = new TextBox();
            label5 = new Label();
            txtProveedor = new TextBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtfecha = new TextBox();
            label4 = new Label();
            txtDescripcion = new TextBox();
            lblApellido1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtIdActivo = new TextBox();
            lblId = new Label();
            lblEstadoUso = new Label();
            cbxEstadoUso = new ComboBox();
            lblFechaDesecho = new Label();
            dtpFechaDesecho = new DateTimePicker();
            lblObservacionDesecho = new Label();
            txtObservacionDesecho = new TextBox();
            lblTitulo = new Label();
            gbxClientes.SuspendLayout();
            SuspendLayout();
            // 
            // gbxClientes
            // 
            gbxClientes.Controls.Add(btnLista);
            gbxClientes.Controls.Add(cbxCategorias);
            gbxClientes.Controls.Add(label6);
            gbxClientes.Controls.Add(txtUbicacion);
            gbxClientes.Controls.Add(label5);
            gbxClientes.Controls.Add(txtProveedor);
            gbxClientes.Controls.Add(label1);
            gbxClientes.Controls.Add(btnEliminar);
            gbxClientes.Controls.Add(btnGuardar);
            gbxClientes.Controls.Add(btnCancelar);
            gbxClientes.Controls.Add(txtfecha);
            gbxClientes.Controls.Add(label4);
            gbxClientes.Controls.Add(txtDescripcion);
            gbxClientes.Controls.Add(lblApellido1);
            gbxClientes.Controls.Add(txtNombre);
            gbxClientes.Controls.Add(lblNombre);
            gbxClientes.Controls.Add(txtIdActivo);
            gbxClientes.Controls.Add(lblId);
            gbxClientes.Controls.Add(lblEstadoUso);
            gbxClientes.Controls.Add(cbxEstadoUso);
            gbxClientes.Controls.Add(lblFechaDesecho);
            gbxClientes.Controls.Add(dtpFechaDesecho);
            gbxClientes.Controls.Add(lblObservacionDesecho);
            gbxClientes.Controls.Add(txtObservacionDesecho);
            gbxClientes.Font = new Font("Segoe UI Variable Display Semib", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxClientes.Location = new Point(28, 55);
            gbxClientes.Name = "gbxClientes";
            gbxClientes.Size = new Size(600, 482);
            gbxClientes.TabIndex = 5;
            gbxClientes.TabStop = false;
            gbxClientes.Text = "Datos Activos:";
            // 
            // btnLista
            // 
            btnLista.Location = new Point(400, 280);
            btnLista.Name = "btnLista";
            btnLista.Size = new Size(150, 40);
            btnLista.TabIndex = 38;
            btnLista.Text = "Listar Activos";
            btnLista.UseVisualStyleBackColor = true;
            btnLista.Click += btnLista_Click;
            // 
            // cbxCategorias
            // 
            cbxCategorias.FormattingEnabled = true;
            cbxCategorias.Location = new Point(150, 317);
            cbxCategorias.Name = "cbxCategorias";
            cbxCategorias.Size = new Size(180, 29);
            cbxCategorias.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F);
            label6.Location = new Point(40, 320);
            label6.Name = "label6";
            label6.Size = new Size(74, 17);
            label6.TabIndex = 29;
            label6.Text = "Categorias:";
            // 
            // txtUbicacion
            // 
            txtUbicacion.Font = new Font("Segoe UI", 9.75F);
            txtUbicacion.Location = new Point(150, 277);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(180, 25);
            txtUbicacion.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.Location = new Point(51, 277);
            label5.Name = "label5";
            label5.Size = new Size(68, 17);
            label5.TabIndex = 27;
            label5.Text = "Ubicacion:";
            // 
            // txtProveedor
            // 
            txtProveedor.Font = new Font("Segoe UI", 9.75F);
            txtProveedor.Location = new Point(150, 230);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(180, 25);
            txtProveedor.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.Location = new Point(42, 233);
            label1.Name = "label1";
            label1.Size = new Size(72, 17);
            label1.TabIndex = 25;
            label1.Text = "Proveedor:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(400, 160);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(150, 40);
            btnEliminar.TabIndex = 36;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(400, 100);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 35;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(400, 220);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 40);
            btnCancelar.TabIndex = 37;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtfecha
            // 
            txtfecha.Font = new Font("Segoe UI", 9.75F);
            txtfecha.Location = new Point(150, 187);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(180, 25);
            txtfecha.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.Location = new Point(6, 190);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 20;
            label4.Text = "Fecha adquisicion:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 9.75F);
            txtDescripcion.Location = new Point(150, 107);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(180, 25);
            txtDescripcion.TabIndex = 13;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Font = new Font("Segoe UI", 9.75F);
            lblApellido1.Location = new Point(40, 110);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(79, 17);
            lblApellido1.TabIndex = 12;
            lblApellido1.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(150, 72);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 25);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(40, 75);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdActivo
            // 
            txtIdActivo.Font = new Font("Segoe UI", 9.75F);
            txtIdActivo.Location = new Point(150, 37);
            txtIdActivo.Name = "txtIdActivo";
            txtIdActivo.Size = new Size(180, 25);
            txtIdActivo.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F);
            lblId.Location = new Point(40, 40);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 17);
            lblId.TabIndex = 8;
            lblId.Text = "ID:";
            // 
            // lblEstadoUso
            // 
            lblEstadoUso.Font = new Font("Segoe UI", 9.75F);
            lblEstadoUso.Location = new Point(23, 144);
            lblEstadoUso.Name = "lblEstadoUso";
            lblEstadoUso.Size = new Size(110, 17);
            lblEstadoUso.TabIndex = 15;
            lblEstadoUso.Text = "Estado de Uso:";
            // 
            // cbxEstadoUso
            // 
            cbxEstadoUso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxEstadoUso.Items.AddRange(new object[] { "Disponible", "Prestado", "Desechado", "En uso" });
            cbxEstadoUso.Location = new Point(150, 138);
            cbxEstadoUso.Name = "cbxEstadoUso";
            cbxEstadoUso.Size = new Size(180, 29);
            cbxEstadoUso.TabIndex = 16;
            cbxEstadoUso.SelectedIndexChanged += cbxEstadoUso_SelectedIndexChanged;
            // 
            // lblFechaDesecho
            // 
            lblFechaDesecho.Font = new Font("Segoe UI", 9.75F);
            lblFechaDesecho.Location = new Point(40, 355);
            lblFechaDesecho.Name = "lblFechaDesecho";
            lblFechaDesecho.Size = new Size(110, 17);
            lblFechaDesecho.TabIndex = 31;
            lblFechaDesecho.Text = "Fecha Desecho:";
            lblFechaDesecho.Visible = false;
            // 
            // dtpFechaDesecho
            // 
            dtpFechaDesecho.Format = DateTimePickerFormat.Short;
            dtpFechaDesecho.Location = new Point(150, 352);
            dtpFechaDesecho.Name = "dtpFechaDesecho";
            dtpFechaDesecho.Size = new Size(180, 29);
            dtpFechaDesecho.TabIndex = 32;
            dtpFechaDesecho.Visible = false;
            // 
            // lblObservacionDesecho
            // 
            lblObservacionDesecho.Font = new Font("Segoe UI", 9.75F);
            lblObservacionDesecho.Location = new Point(40, 390);
            lblObservacionDesecho.Name = "lblObservacionDesecho";
            lblObservacionDesecho.Size = new Size(130, 17);
            lblObservacionDesecho.TabIndex = 33;
            lblObservacionDesecho.Text = "Observación Desecho:";
            lblObservacionDesecho.Visible = false;
            // 
            // txtObservacionDesecho
            // 
            txtObservacionDesecho.Location = new Point(150, 390);
            txtObservacionDesecho.Multiline = true;
            txtObservacionDesecho.Name = "txtObservacionDesecho";
            txtObservacionDesecho.Size = new Size(180, 66);
            txtObservacionDesecho.TabIndex = 34;
            txtObservacionDesecho.Visible = false;
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
            // frmActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 540);
            Controls.Add(gbxClientes);
            Controls.Add(lblTitulo);
            Name = "frmActivos";
            Text = "Mantenimiento: Activos";
            Load += frmActivos_Load;
            gbxClientes.ResumeLayout(false);
            gbxClientes.PerformLayout();
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
        private ComboBox cbxEstadoUso;
        private Label lblEstadoUso;
        private DateTimePicker dtpFechaDesecho;
        private Label lblFechaDesecho;
        private TextBox txtObservacionDesecho;
        private Label lblObservacionDesecho;
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
        private TextBox txtUbicacion;
        private Label label5;
        private Button btnLista;
    }
}