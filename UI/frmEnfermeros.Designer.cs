namespace UI
{
    partial class frmEnfermeros
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
            lblTitulo = new Label();
            gbxDatosMedico = new GroupBox();
            txtTipoId = new TextBox();
            lblTipoId = new Label();
            txtArea = new TextBox();
            lblArea = new Label();
            txtEstado = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtEmail = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtSegundoApellido = new TextBox();
            txtPrimerApellido = new TextBox();
            txtNombre = new TextBox();
            txtId = new TextBox();
            lblEstado = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblEmail = new Label();
            lblFechaNacimiento = new Label();
            lblSegundoApellido = new Label();
            lblPrimerApellido = new Label();
            lblNombre = new Label();
            lblId = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            gbxDatosMedico.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(236, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Creacion de Enfermero";
            // 
            // gbxDatosMedico
            // 
            gbxDatosMedico.Controls.Add(txtTipoId);
            gbxDatosMedico.Controls.Add(lblTipoId);
            gbxDatosMedico.Controls.Add(txtArea);
            gbxDatosMedico.Controls.Add(lblArea);
            gbxDatosMedico.Controls.Add(txtEstado);
            gbxDatosMedico.Controls.Add(txtTelefono);
            gbxDatosMedico.Controls.Add(txtDireccion);
            gbxDatosMedico.Controls.Add(txtEmail);
            gbxDatosMedico.Controls.Add(dtpFechaNacimiento);
            gbxDatosMedico.Controls.Add(txtSegundoApellido);
            gbxDatosMedico.Controls.Add(txtPrimerApellido);
            gbxDatosMedico.Controls.Add(txtNombre);
            gbxDatosMedico.Controls.Add(txtId);
            gbxDatosMedico.Controls.Add(lblEstado);
            gbxDatosMedico.Controls.Add(lblTelefono);
            gbxDatosMedico.Controls.Add(lblDireccion);
            gbxDatosMedico.Controls.Add(lblEmail);
            gbxDatosMedico.Controls.Add(lblFechaNacimiento);
            gbxDatosMedico.Controls.Add(lblSegundoApellido);
            gbxDatosMedico.Controls.Add(lblPrimerApellido);
            gbxDatosMedico.Controls.Add(lblNombre);
            gbxDatosMedico.Controls.Add(lblId);
            gbxDatosMedico.Location = new Point(12, 42);
            gbxDatosMedico.Name = "gbxDatosMedico";
            gbxDatosMedico.Size = new Size(390, 355);
            gbxDatosMedico.TabIndex = 3;
            gbxDatosMedico.TabStop = false;
            gbxDatosMedico.Text = "Datos de Enfermero";
            // 
            // txtTipoId
            // 
            txtTipoId.Location = new Point(141, 57);
            txtTipoId.Name = "txtTipoId";
            txtTipoId.Size = new Size(232, 23);
            txtTipoId.TabIndex = 24;
            // 
            // lblTipoId
            // 
            lblTipoId.AutoSize = true;
            lblTipoId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTipoId.Location = new Point(83, 63);
            lblTipoId.Name = "lblTipoId";
            lblTipoId.Size = new Size(52, 17);
            lblTipoId.TabIndex = 23;
            lblTipoId.Text = "Tipo Id:";
            // 
            // txtArea
            // 
            txtArea.Location = new Point(141, 173);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(232, 23);
            txtArea.TabIndex = 22;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblArea.Location = new Point(97, 179);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(38, 17);
            lblArea.TabIndex = 21;
            lblArea.Text = "Area:";
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(141, 318);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(232, 23);
            txtEstado.TabIndex = 20;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(141, 289);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(232, 23);
            txtTelefono.TabIndex = 19;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(141, 260);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(232, 23);
            txtDireccion.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 231);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(232, 23);
            txtEmail.TabIndex = 17;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(141, 202);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(232, 23);
            dtpFechaNacimiento.TabIndex = 16;
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(141, 144);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(232, 23);
            txtSegundoApellido.TabIndex = 15;
            // 
            // txtPrimerApellido
            // 
            txtPrimerApellido.Location = new Point(141, 115);
            txtPrimerApellido.Name = "txtPrimerApellido";
            txtPrimerApellido.Size = new Size(232, 23);
            txtPrimerApellido.TabIndex = 14;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(141, 86);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(232, 23);
            txtNombre.TabIndex = 13;
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 28);
            txtId.Name = "txtId";
            txtId.Size = new Size(232, 23);
            txtId.TabIndex = 12;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(84, 324);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(51, 17);
            lblEstado.TabIndex = 11;
            lblEstado.Text = "Estado:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTelefono.Location = new Point(74, 295);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(61, 17);
            lblTelefono.TabIndex = 10;
            lblTelefono.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDireccion.Location = new Point(70, 266);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(65, 17);
            lblDireccion.TabIndex = 9;
            lblDireccion.Text = "Direccion:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(93, 237);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 17);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaNacimiento.Location = new Point(21, 208);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(114, 17);
            lblFechaNacimiento.TabIndex = 7;
            lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // lblSegundoApellido
            // 
            lblSegundoApellido.AutoSize = true;
            lblSegundoApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSegundoApellido.Location = new Point(20, 150);
            lblSegundoApellido.Name = "lblSegundoApellido";
            lblSegundoApellido.Size = new Size(115, 17);
            lblSegundoApellido.TabIndex = 6;
            lblSegundoApellido.Text = "Segundo Apellido:";
            // 
            // lblPrimerApellido
            // 
            lblPrimerApellido.AutoSize = true;
            lblPrimerApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrimerApellido.Location = new Point(34, 121);
            lblPrimerApellido.Name = "lblPrimerApellido";
            lblPrimerApellido.Size = new Size(101, 17);
            lblPrimerApellido.TabIndex = 5;
            lblPrimerApellido.Text = "Primer Apellido:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(75, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 4;
            lblNombre.Text = "Nombre:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(113, 29);
            lblId.Name = "lblId";
            lblId.Size = new Size(22, 17);
            lblId.TabIndex = 3;
            lblId.Text = "Id:";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(302, 403);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(196, 403);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 30);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(90, 403);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEnfermeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 440);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(gbxDatosMedico);
            Controls.Add(lblTitulo);
            Name = "frmEnfermeros";
            Text = "Mantenimiento: Creacion Enfermeros";
            Load += frmEnfermeros_Load;
            gbxDatosMedico.ResumeLayout(false);
            gbxDatosMedico.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private GroupBox gbxDatosMedico;
        private TextBox txtArea;
        private Label lblArea;
        private TextBox txtEstado;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtEmail;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtSegundoApellido;
        private TextBox txtPrimerApellido;
        private TextBox txtNombre;
        private TextBox txtId;
        private Label lblEstado;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblEmail;
        private Label lblFechaNacimiento;
        private Label lblSegundoApellido;
        private Label lblPrimerApellido;
        private Label lblNombre;
        private Label lblId;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnEliminar;
        private TextBox txtTipoId;
        private Label lblTipoId;
    }
}