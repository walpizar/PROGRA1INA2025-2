namespace UI
{
    partial class frmPaciente
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
            btnEliminarPaciente = new Button();
            btnCancelarPaciente = new Button();
            btnGuardarPaciente = new Button();
            lblTituloPaciente = new Label();
            gbxDatosPaciente = new GroupBox();
            txtTipoId = new TextBox();
            lblTipoId = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            txtEstado = new TextBox();
            lblEstado = new Label();
            txtReferencia = new TextBox();
            lblReferencia = new Label();
            txtEstadoCivil = new TextBox();
            lblEstadoCivil = new Label();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            txtDireccion = new TextBox();
            lblDireccion = new Label();
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblFechaNacimiento = new Label();
            txtApellido2 = new TextBox();
            lblApellido2 = new Label();
            txtApellido1 = new TextBox();
            lblApellido1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtIdPaciente = new TextBox();
            lblIdPaciente = new Label();
            gbxDatosPaciente.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Location = new Point(49, 479);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(113, 36);
            btnEliminarPaciente.TabIndex = 14;
            btnEliminarPaciente.Text = "Eliminar";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // btnCancelarPaciente
            // 
            btnCancelarPaciente.Location = new Point(287, 479);
            btnCancelarPaciente.Name = "btnCancelarPaciente";
            btnCancelarPaciente.Size = new Size(113, 36);
            btnCancelarPaciente.TabIndex = 13;
            btnCancelarPaciente.Text = "Cancelar";
            btnCancelarPaciente.UseVisualStyleBackColor = true;
            btnCancelarPaciente.Click += btnCancelarPaciente_Click;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.Location = new Point(168, 479);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(113, 36);
            btnGuardarPaciente.TabIndex = 12;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = true;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // lblTituloPaciente
            // 
            lblTituloPaciente.AutoSize = true;
            lblTituloPaciente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPaciente.Location = new Point(138, 22);
            lblTituloPaciente.Name = "lblTituloPaciente";
            lblTituloPaciente.Size = new Size(152, 30);
            lblTituloPaciente.TabIndex = 9;
            lblTituloPaciente.Text = "Crear Paciente";
            // 
            // gbxDatosPaciente
            // 
            gbxDatosPaciente.Controls.Add(txtTipoId);
            gbxDatosPaciente.Controls.Add(lblTipoId);
            gbxDatosPaciente.Controls.Add(dtpFechaNacimiento);
            gbxDatosPaciente.Controls.Add(txtEstado);
            gbxDatosPaciente.Controls.Add(lblEstado);
            gbxDatosPaciente.Controls.Add(txtReferencia);
            gbxDatosPaciente.Controls.Add(lblReferencia);
            gbxDatosPaciente.Controls.Add(txtEstadoCivil);
            gbxDatosPaciente.Controls.Add(lblEstadoCivil);
            gbxDatosPaciente.Controls.Add(txtTelefono);
            gbxDatosPaciente.Controls.Add(lblTelefono);
            gbxDatosPaciente.Controls.Add(txtDireccion);
            gbxDatosPaciente.Controls.Add(lblDireccion);
            gbxDatosPaciente.Controls.Add(txtEmail);
            gbxDatosPaciente.Controls.Add(lblEmail);
            gbxDatosPaciente.Controls.Add(lblFechaNacimiento);
            gbxDatosPaciente.Controls.Add(txtApellido2);
            gbxDatosPaciente.Controls.Add(lblApellido2);
            gbxDatosPaciente.Controls.Add(txtApellido1);
            gbxDatosPaciente.Controls.Add(lblApellido1);
            gbxDatosPaciente.Controls.Add(txtNombre);
            gbxDatosPaciente.Controls.Add(lblNombre);
            gbxDatosPaciente.Controls.Add(txtIdPaciente);
            gbxDatosPaciente.Controls.Add(lblIdPaciente);
            gbxDatosPaciente.Location = new Point(25, 65);
            gbxDatosPaciente.Name = "gbxDatosPaciente";
            gbxDatosPaciente.Size = new Size(375, 408);
            gbxDatosPaciente.TabIndex = 8;
            gbxDatosPaciente.TabStop = false;
            gbxDatosPaciente.Text = "Datos de paciente";
            // 
            // txtTipoId
            // 
            txtTipoId.Location = new Point(133, 60);
            txtTipoId.MaxLength = 50;
            txtTipoId.Name = "txtTipoId";
            txtTipoId.Size = new Size(218, 23);
            txtTipoId.TabIndex = 21;
            // 
            // lblTipoId
            // 
            lblTipoId.AutoSize = true;
            lblTipoId.Location = new Point(63, 68);
            lblTipoId.Name = "lblTipoId";
            lblTipoId.Size = new Size(64, 15);
            lblTipoId.TabIndex = 22;
            lblTipoId.Text = "Tipo de ID:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(133, 180);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(218, 23);
            dtpFechaNacimiento.TabIndex = 5;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(133, 354);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(218, 23);
            txtEstado.TabIndex = 11;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(73, 357);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 20;
            lblEstado.Text = "Estado:";
            // 
            // txtReferencia
            // 
            txtReferencia.Location = new Point(133, 325);
            txtReferencia.Name = "txtReferencia";
            txtReferencia.Size = new Size(218, 23);
            txtReferencia.TabIndex = 10;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Location = new Point(53, 328);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(65, 15);
            lblReferencia.TabIndex = 18;
            lblReferencia.Text = "Referencia:";
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.Location = new Point(133, 296);
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(218, 23);
            txtEstadoCivil.TabIndex = 9;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(50, 299);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(71, 15);
            lblEstadoCivil.TabIndex = 16;
            lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(133, 267);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(218, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(65, 270);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(133, 238);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 23);
            txtDireccion.TabIndex = 7;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(61, 241);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Direccion:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(133, 209);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 6;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(82, 212);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(15, 183);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(106, 15);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(133, 151);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(218, 23);
            txtApellido2.TabIndex = 4;
            // 
            // lblApellido2
            // 
            lblApellido2.AutoSize = true;
            lblApellido2.Location = new Point(58, 159);
            lblApellido2.Name = "lblApellido2";
            lblApellido2.Size = new Size(63, 15);
            lblApellido2.TabIndex = 6;
            lblApellido2.Text = "Apellido 2:";
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(133, 122);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(218, 23);
            txtApellido1.TabIndex = 3;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(58, 130);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(63, 15);
            lblApellido1.TabIndex = 4;
            lblApellido1.Text = "Apellido 1:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(133, 93);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(67, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Location = new Point(133, 31);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(218, 23);
            txtIdPaciente.TabIndex = 1;
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Location = new Point(100, 39);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(21, 15);
            lblIdPaciente.TabIndex = 0;
            lblIdPaciente.Text = "ID:";
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 527);
            Controls.Add(btnEliminarPaciente);
            Controls.Add(btnCancelarPaciente);
            Controls.Add(btnGuardarPaciente);
            Controls.Add(lblTituloPaciente);
            Controls.Add(gbxDatosPaciente);
            Name = "frmPaciente";
            Text = "Mantenimiento: Crear Paciente";
            Load += frmPaciente_Load;
            gbxDatosPaciente.ResumeLayout(false);
            gbxDatosPaciente.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarPaciente;
        private Button btnCancelarPaciente;
        private Button btnGuardarPaciente;
        private Label lblTituloPaciente;
        private GroupBox gbxDatosPaciente;
        private TextBox txtApellido1;
        private Label lblApellido1;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtIdPaciente;
        private Label lblIdPaciente;
        private TextBox txtApellido2;
        private Label lblApellido2;
        private TextBox txtDireccion;
        private Label lblDireccion;
        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblFechaNacimiento;
        private TextBox txtEstadoCivil;
        private Label lblEstadoCivil;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private TextBox txtEstado;
        private Label lblEstado;
        private TextBox txtReferencia;
        private Label lblReferencia;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtTipoId;
        private Label lblTipoId;
    }
}