namespace UI
{
    partial class frmUsuario
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
            label1 = new Label();
            lblUsuario = new Label();
            btnModificar = new Button();
            lblContraseña = new Label();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblApellido1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtIdUsuario = new TextBox();
            lblId = new Label();
            gbxUsuario = new GroupBox();
            buttonCancelar = new Button();
            buttonGuardar = new Button();
            lblEstado = new Label();
            chkEstado = new CheckBox();
            cboRol = new ComboBox();
            lblRol = new Label();
            lblConfirmar = new Label();
            txtConfirmar = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            lblUusario = new Label();
            btnBuscarPersona = new Button();
            cboPersona = new ComboBox();
            lblPersona = new Label();
            gbxUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(139, 7);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(154, 30);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Crear Usuarios";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(226, 325);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(89, 39);
            btnModificar.TabIndex = 31;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 9.75F);
            lblContraseña.Location = new Point(58, 196);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(77, 17);
            lblContraseña.TabIndex = 27;
            lblContraseña.Text = "Contraseña:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(321, 325);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(76, 39);
            btnEliminar.TabIndex = 24;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(141, 325);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(79, 39);
            btnGuardar.TabIndex = 23;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(403, 325);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(81, 39);
            btnCancelar.TabIndex = 22;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Font = new Font("Segoe UI", 9.75F);
            lblApellido1.Location = new Point(42, 130);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(0, 17);
            lblApellido1.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 9.75F);
            txtNombre.Location = new Point(141, 133);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(343, 25);
            txtNombre.TabIndex = 11;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9.75F);
            lblNombre.Location = new Point(26, 136);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(109, 17);
            lblNombre.TabIndex = 10;
            lblNombre.Text = "Nombre Usuario:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Font = new Font("Segoe UI", 9.75F);
            txtIdUsuario.Location = new Point(141, 86);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(343, 25);
            txtIdUsuario.TabIndex = 9;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 9.75F);
            lblId.Location = new Point(112, 86);
            lblId.Name = "lblId";
            lblId.Size = new Size(23, 17);
            lblId.TabIndex = 8;
            lblId.Text = "ID:";
            // 
            // gbxUsuario
            // 
            gbxUsuario.Controls.Add(buttonCancelar);
            gbxUsuario.Controls.Add(buttonGuardar);
            gbxUsuario.Controls.Add(lblEstado);
            gbxUsuario.Controls.Add(chkEstado);
            gbxUsuario.Controls.Add(cboRol);
            gbxUsuario.Controls.Add(lblRol);
            gbxUsuario.Controls.Add(lblConfirmar);
            gbxUsuario.Controls.Add(txtConfirmar);
            gbxUsuario.Controls.Add(txtPassword);
            gbxUsuario.Controls.Add(lblPassword);
            gbxUsuario.Controls.Add(txtUsuario);
            gbxUsuario.Controls.Add(lblUusario);
            gbxUsuario.Controls.Add(btnBuscarPersona);
            gbxUsuario.Controls.Add(cboPersona);
            gbxUsuario.Controls.Add(lblPersona);
            gbxUsuario.Location = new Point(12, 40);
            gbxUsuario.Name = "gbxUsuario";
            gbxUsuario.Size = new Size(427, 314);
            gbxUsuario.TabIndex = 6;
            gbxUsuario.TabStop = false;
            gbxUsuario.Text = "Datos Usuarios";
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(206, 275);
            buttonCancelar.Name = "buttonCancelar";
            buttonCancelar.Size = new Size(75, 23);
            buttonCancelar.TabIndex = 15;
            buttonCancelar.Text = "Cancelar";
            buttonCancelar.UseVisualStyleBackColor = true;
            buttonCancelar.Click += buttonCancelar_Click;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(98, 275);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(75, 23);
            buttonGuardar.TabIndex = 14;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(26, 241);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado:";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkEstado.Location = new Point(77, 238);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(66, 21);
            chkEstado.TabIndex = 12;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(73, 195);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(145, 23);
            cboRol.TabIndex = 11;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(37, 195);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol:";
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(6, 158);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(64, 15);
            lblConfirmar.TabIndex = 9;
            lblConfirmar.Text = "Confirmar:";
            // 
            // txtConfirmar
            // 
            txtConfirmar.Location = new Point(76, 158);
            txtConfirmar.Name = "txtConfirmar";
            txtConfirmar.PasswordChar = '*';
            txtConfirmar.Size = new Size(299, 23);
            txtConfirmar.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(73, 114);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(0, 114);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(70, 75);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 23);
            txtUsuario.TabIndex = 4;
            // 
            // lblUusario
            // 
            lblUusario.AutoSize = true;
            lblUusario.Location = new Point(14, 75);
            lblUusario.Name = "lblUusario";
            lblUusario.Size = new Size(50, 15);
            lblUusario.TabIndex = 3;
            lblUusario.Text = "Usuario:";
            // 
            // btnBuscarPersona
            // 
            btnBuscarPersona.BackColor = Color.BurlyWood;
            btnBuscarPersona.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscarPersona.ForeColor = SystemColors.MenuHighlight;
            btnBuscarPersona.ImageAlign = ContentAlignment.BottomCenter;
            btnBuscarPersona.Location = new Point(378, 30);
            btnBuscarPersona.Name = "btnBuscarPersona";
            btnBuscarPersona.Size = new Size(43, 35);
            btnBuscarPersona.TabIndex = 2;
            btnBuscarPersona.UseVisualStyleBackColor = false;
            // 
            // cboPersona
            // 
            cboPersona.FormattingEnabled = true;
            cboPersona.Location = new Point(37, 42);
            cboPersona.Name = "cboPersona";
            cboPersona.Size = new Size(335, 23);
            cboPersona.TabIndex = 1;
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(37, 19);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(49, 15);
            lblPersona.TabIndex = 0;
            lblPersona.Text = "Persona";
            lblPersona.Click += label2_Click;
            // 
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(441, 366);
            Controls.Add(gbxUsuario);
            Controls.Add(lblUsuario);
            Controls.Add(label1);
            Name = "frmUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento: Usuario";
            gbxUsuario.ResumeLayout(false);
            gbxUsuario.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblUsuario;
        private GroupBox gbxClientes;
        private NumericUpDown txtCantidad;
        private ComboBox cbxCategorias;
        private Label label6;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TextBox txtProveedor;
        private Label lblPersona;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtfecha;
        private Label label4;
        private TextBox txtEstado;
        private Label lblUusario;
        private Label label7;
        private TextBox txtDescripcion;
        private Label lblApellido1;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtIdUsuario;
        private Label lblId;
        private Button btnModificar;
        private GroupBox gbxUsuario;
        private ComboBox cboPersona;
        private Button btnBuscarPersona;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConfirmar;
        private Label lblConfirmar;
        private Label lblEstado;
        private CheckBox chkEstado;
        private ComboBox cboRol;
        private Label lblRol;
        private Button buttonCancelar;
        private Button buttonGuardar;
    }
}