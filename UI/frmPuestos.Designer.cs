namespace UI
{
    partial class frmPuestos
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
            gbxDatosPuesto = new GroupBox();
            cboDepartamento = new ComboBox();
            lblElegirDept = new Label();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            btnActivar = new Button();
            btnInactivar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblTitulo = new Label();
            gbxDatosPuesto.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosPuesto
            // 
            gbxDatosPuesto.Controls.Add(cboDepartamento);
            gbxDatosPuesto.Controls.Add(lblElegirDept);
            gbxDatosPuesto.Controls.Add(txtDescripcion);
            gbxDatosPuesto.Controls.Add(lblDescripcion);
            gbxDatosPuesto.Controls.Add(txtNombre);
            gbxDatosPuesto.Controls.Add(lblNombre);
            gbxDatosPuesto.Controls.Add(txtCodigo);
            gbxDatosPuesto.Controls.Add(lblCodigo);
            gbxDatosPuesto.Location = new Point(53, 79);
            gbxDatosPuesto.Name = "gbxDatosPuesto";
            gbxDatosPuesto.Size = new Size(426, 203);
            gbxDatosPuesto.TabIndex = 10;
            gbxDatosPuesto.TabStop = false;
            gbxDatosPuesto.Text = "Datos del Puesto";
            // 
            // cboDepartamento
            // 
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDepartamento.FormattingEnabled = true;
            cboDepartamento.Location = new Point(119, 145);
            cboDepartamento.Name = "cboDepartamento";
            cboDepartamento.Size = new Size(221, 23);
            cboDepartamento.TabIndex = 13;
            // 
            // lblElegirDept
            // 
            lblElegirDept.AutoSize = true;
            lblElegirDept.Location = new Point(27, 148);
            lblElegirDept.Name = "lblElegirDept";
            lblElegirDept.Size = new Size(86, 15);
            lblElegirDept.TabIndex = 12;
            lblElegirDept.Text = "Departamento:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(119, 104);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(238, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(41, 107);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 66);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 69);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(124, 29);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 23);
            txtCodigo.TabIndex = 1;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(64, 32);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(49, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // btnActivar
            // 
            btnActivar.Location = new Point(182, 312);
            btnActivar.Name = "btnActivar";
            btnActivar.Size = new Size(113, 36);
            btnActivar.TabIndex = 24;
            btnActivar.Text = "Activar";
            btnActivar.UseVisualStyleBackColor = true;
            btnActivar.Click += btnActivar_Click_1;
            // 
            // btnInactivar
            // 
            btnInactivar.Location = new Point(420, 37);
            btnInactivar.Name = "btnInactivar";
            btnInactivar.Size = new Size(113, 36);
            btnInactivar.TabIndex = 23;
            btnInactivar.Text = "Inactivar";
            btnInactivar.UseVisualStyleBackColor = true;
            btnInactivar.Click += btnInactivar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(420, 312);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 36);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(301, 312);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 36);
            btnGuardar.TabIndex = 21;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(195, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(137, 30);
            lblTitulo.TabIndex = 25;
            lblTitulo.Text = "Crear Puesto";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // frmPuestos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 360);
            Controls.Add(lblTitulo);
            Controls.Add(btnActivar);
            Controls.Add(btnInactivar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(gbxDatosPuesto);
            Name = "frmPuestos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPuestos";
            Load += frmPuestos_Load;
            gbxDatosPuesto.ResumeLayout(false);
            gbxDatosPuesto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosPuesto;
        private ComboBox cboDepartamento;
        private Label lblElegirDept;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Button btnActivar;
        private Button btnInactivar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblTitulo;
    }
}