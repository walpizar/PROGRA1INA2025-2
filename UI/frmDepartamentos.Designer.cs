namespace UI
{
    partial class frmDepartamentos
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
            gbxDatosDept = new GroupBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtCodigo = new TextBox();
            lblId = new Label();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnGuardar = new Button();
            lblTitulo = new Label();
            gbxDatosDept.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosDept
            // 
            gbxDatosDept.Controls.Add(txtDescripcion);
            gbxDatosDept.Controls.Add(lblDescripcion);
            gbxDatosDept.Controls.Add(txtNombre);
            gbxDatosDept.Controls.Add(lblNombre);
            gbxDatosDept.Controls.Add(txtCodigo);
            gbxDatosDept.Controls.Add(lblId);
            gbxDatosDept.Location = new Point(44, 72);
            gbxDatosDept.Name = "gbxDatosDept";
            gbxDatosDept.Size = new Size(441, 216);
            gbxDatosDept.TabIndex = 15;
            gbxDatosDept.TabStop = false;
            gbxDatosDept.Text = "Datos del Departamento";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(119, 143);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(238, 23);
            txtDescripcion.TabIndex = 5;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(41, 146);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(72, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripcion:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(119, 101);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(238, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 101);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(119, 56);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 23);
            txtCodigo.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(64, 59);
            lblId.Name = "lblId";
            lblId.Size = new Size(49, 15);
            lblId.TabIndex = 0;
            lblId.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(145, 319);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 36);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(383, 319);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 36);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click_1;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(264, 319);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 36);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(145, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(212, 30);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "Crear Departamento";
            // 
            // frmDepartamentos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 371);
            Controls.Add(lblTitulo);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(gbxDatosDept);
            Name = "frmDepartamentos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmDepartamentos";
            Load += frmDepartamentos_Load;
            gbxDatosDept.ResumeLayout(false);
            gbxDatosDept.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxDatosDept;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtCodigo;
        private Label lblId;
        private Button btnEliminar;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblTitulo;
    }
}