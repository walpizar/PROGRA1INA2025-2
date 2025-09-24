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
            cboEstadoCivil = new ComboBox();
            cboTipoId = new ComboBox();
            lblTipoId = new Label();
            dtpFechaNacimiento = new DateTimePicker();
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
            btnReactivar = new Button();
            gbxDatosPaciente.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.Location = new Point(382, 439);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(113, 36);
            btnEliminarPaciente.TabIndex = 15;
            btnEliminarPaciente.Text = "Eliminar";
            btnEliminarPaciente.UseVisualStyleBackColor = true;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // btnCancelarPaciente
            // 
            btnCancelarPaciente.Location = new Point(146, 439);
            btnCancelarPaciente.Name = "btnCancelarPaciente";
            btnCancelarPaciente.Size = new Size(113, 36);
            btnCancelarPaciente.TabIndex = 14;
            btnCancelarPaciente.Text = "Cancelar";
            btnCancelarPaciente.UseVisualStyleBackColor = true;
            btnCancelarPaciente.Click += btnCancelarPaciente_Click;
            // 
            // btnGuardarPaciente
            // 
            btnGuardarPaciente.Location = new Point(263, 439);
            btnGuardarPaciente.Name = "btnGuardarPaciente";
            btnGuardarPaciente.Size = new Size(113, 36);
            btnGuardarPaciente.TabIndex = 13;
            btnGuardarPaciente.Text = "Guardar";
            btnGuardarPaciente.UseVisualStyleBackColor = true;
            btnGuardarPaciente.Click += btnGuardarPaciente_Click;
            // 
            // lblTituloPaciente
            // 
            lblTituloPaciente.AutoSize = true;
            lblTituloPaciente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloPaciente.Location = new Point(193, 21);
            lblTituloPaciente.Name = "lblTituloPaciente";
            lblTituloPaciente.Size = new Size(152, 30);
            lblTituloPaciente.TabIndex = 9;
            lblTituloPaciente.Text = "Crear Paciente";
            // 
            // gbxDatosPaciente
            // 
            gbxDatosPaciente.Controls.Add(cboEstadoCivil);
            gbxDatosPaciente.Controls.Add(cboTipoId);
            gbxDatosPaciente.Controls.Add(lblTipoId);
            gbxDatosPaciente.Controls.Add(dtpFechaNacimiento);
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
            gbxDatosPaciente.Size = new Size(470, 354);
            gbxDatosPaciente.TabIndex = 8;
            gbxDatosPaciente.TabStop = false;
            gbxDatosPaciente.Text = "Datos de paciente";
            // 
            // cboEstadoCivil
            // 
            cboEstadoCivil.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoCivil.FormattingEnabled = true;
            cboEstadoCivil.Location = new Point(168, 303);
            cboEstadoCivil.Name = "cboEstadoCivil";
            cboEstadoCivil.Size = new Size(218, 23);
            cboEstadoCivil.TabIndex = 24;
            // 
            // cboTipoId
            // 
            cboTipoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoId.FormattingEnabled = true;
            cboTipoId.Location = new Point(168, 69);
            cboTipoId.Name = "cboTipoId";
            cboTipoId.Size = new Size(218, 23);
            cboTipoId.TabIndex = 2;
            // 
            // lblTipoId
            // 
            lblTipoId.AutoSize = true;
            lblTipoId.Location = new Point(98, 72);
            lblTipoId.Name = "lblTipoId";
            lblTipoId.Size = new Size(64, 15);
            lblTipoId.TabIndex = 22;
            lblTipoId.Text = "Tipo de ID:";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(168, 184);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(218, 23);
            dtpFechaNacimiento.TabIndex = 6;
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Location = new Point(85, 303);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(71, 15);
            lblEstadoCivil.TabIndex = 16;
            lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(168, 271);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(218, 23);
            txtTelefono.TabIndex = 9;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(100, 274);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 14;
            lblTelefono.Text = "Telefono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(168, 242);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(218, 23);
            txtDireccion.TabIndex = 8;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(96, 245);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 12;
            lblDireccion.Text = "Direccion:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(168, 213);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(218, 23);
            txtEmail.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(117, 216);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(50, 187);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(106, 15);
            lblFechaNacimiento.TabIndex = 8;
            lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // txtApellido2
            // 
            txtApellido2.Location = new Point(168, 155);
            txtApellido2.Name = "txtApellido2";
            txtApellido2.Size = new Size(218, 23);
            txtApellido2.TabIndex = 5;
            // 
            // lblApellido2
            // 
            lblApellido2.AutoSize = true;
            lblApellido2.Location = new Point(93, 163);
            lblApellido2.Name = "lblApellido2";
            lblApellido2.Size = new Size(63, 15);
            lblApellido2.TabIndex = 6;
            lblApellido2.Text = "Apellido 2:";
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(168, 126);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(218, 23);
            txtApellido1.TabIndex = 4;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(93, 134);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(63, 15);
            lblApellido1.TabIndex = 4;
            lblApellido1.Text = "Apellido 1:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(168, 97);
            txtNombre.MaxLength = 50;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(218, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(102, 100);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtIdPaciente
            // 
            txtIdPaciente.Location = new Point(168, 40);
            txtIdPaciente.Name = "txtIdPaciente";
            txtIdPaciente.Size = new Size(218, 23);
            txtIdPaciente.TabIndex = 1;
            // 
            // lblIdPaciente
            // 
            lblIdPaciente.AutoSize = true;
            lblIdPaciente.Location = new Point(135, 43);
            lblIdPaciente.Name = "lblIdPaciente";
            lblIdPaciente.Size = new Size(21, 15);
            lblIdPaciente.TabIndex = 0;
            lblIdPaciente.Text = "ID:";
            // 
            // btnReactivar
            // 
            btnReactivar.Location = new Point(27, 439);
            btnReactivar.Name = "btnReactivar";
            btnReactivar.Size = new Size(113, 36);
            btnReactivar.TabIndex = 16;
            btnReactivar.Text = "Reactivar";
            btnReactivar.UseVisualStyleBackColor = true;
            btnReactivar.Click += btnReactivar_Click;
            // 
            // frmPaciente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 496);
            Controls.Add(btnReactivar);
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
        private Label lblEstadoCivil;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private DateTimePicker dtpFechaNacimiento;
        private Label lblTipoId;
        private ComboBox cboEstadoCivil;
        private ComboBox cboTipoId;
        private Button btnReactivar;
    }
}