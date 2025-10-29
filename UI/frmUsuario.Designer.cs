

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




        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblUsuario = new Label();
            gbxUsuario = new GroupBox();
            dtpFechaNac = new DateTimePicker();
            txtNombre = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            cboPersona = new ComboBox();
            txtConfirmarContraseña = new TextBox();
            cboRol = new ComboBox();
            lblRol = new Label();
            lblConfirmar = new Label();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            lblUusario = new Label();
            lblPersona = new Label();
            lblNombrePersona = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblFechaNac = new Label();
            btnEliminar = new Button();
            button2 = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            lblContraseña = new Label();
            lblApellido1 = new Label();
            lblNombre = new Label();
            txtIdUsuario = new TextBox();
            lblId = new Label();
            gbxUsuario.SuspendLayout();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(119, 7);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(145, 30);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Crear Usuario";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbxUsuario
            // 
            gbxUsuario.Controls.Add(dtpFechaNac);
            gbxUsuario.Controls.Add(txtNombre);
            gbxUsuario.Controls.Add(txtDireccion);
            gbxUsuario.Controls.Add(txtTelefono);
            gbxUsuario.Controls.Add(txtEmail);
            gbxUsuario.Controls.Add(cboPersona);
            gbxUsuario.Controls.Add(txtConfirmarContraseña);
            gbxUsuario.Controls.Add(cboRol);
            gbxUsuario.Controls.Add(lblRol);
            gbxUsuario.Controls.Add(lblConfirmar);
            gbxUsuario.Controls.Add(txtPassword);
            gbxUsuario.Controls.Add(lblPassword);
            gbxUsuario.Controls.Add(txtUsuario);
            gbxUsuario.Controls.Add(lblUusario);
            gbxUsuario.Controls.Add(lblPersona);
            gbxUsuario.Controls.Add(lblNombrePersona);
            gbxUsuario.Controls.Add(lblEmail);
            gbxUsuario.Controls.Add(lblTelefono);
            gbxUsuario.Controls.Add(lblDireccion);
            gbxUsuario.Controls.Add(lblFechaNac);
            gbxUsuario.Location = new Point(1, 40);
            gbxUsuario.Name = "gbxUsuario";
            gbxUsuario.Size = new Size(396, 422);
            gbxUsuario.TabIndex = 6;
            gbxUsuario.TabStop = false;
            gbxUsuario.Text = "Datos Usuarios";
            // 
            // dtpFechaNac
            // 
            dtpFechaNac.Location = new Point(118, 213);
            dtpFechaNac.Name = "dtpFechaNac";
            dtpFechaNac.Size = new Size(263, 23);
            dtpFechaNac.TabIndex = 32;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(82, 81);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(298, 23);
            txtNombre.TabIndex = 31;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(77, 176);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(303, 23);
            txtDireccion.TabIndex = 29;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(81, 142);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(300, 23);
            txtTelefono.TabIndex = 28;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(81, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(300, 23);
            txtEmail.TabIndex = 27;
            // 
            // cboPersona
            // 
            cboPersona.FormattingEnabled = true;
            cboPersona.Location = new Point(81, 46);
            cboPersona.Name = "cboPersona";
            cboPersona.Size = new Size(300, 23);
            cboPersona.TabIndex = 12;
            cboPersona.SelectionChangeCommitted += cboPersona_SelectionChangeCommitted;
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Location = new Point(82, 296);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.PasswordChar = '*';
            txtConfirmarContraseña.Size = new Size(299, 23);
            txtConfirmarContraseña.TabIndex = 8;
            txtConfirmarContraseña.TextChanged += txtConfirmarContraseña_TextChanged;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(87, 381);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(145, 23);
            cboRol.TabIndex = 11;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(37, 384);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol:";
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(11, 340);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(64, 15);
            lblConfirmar.TabIndex = 9;
            lblConfirmar.Text = "Confirmar:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 337);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(299, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 299);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(77, 256);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 23);
            txtUsuario.TabIndex = 4;
            // 
            // lblUusario
            // 
            lblUusario.AutoSize = true;
            lblUusario.Location = new Point(11, 256);
            lblUusario.Name = "lblUusario";
            lblUusario.Size = new Size(50, 15);
            lblUusario.TabIndex = 3;
            lblUusario.Text = "Usuario:";
            // 
            // lblPersona
            // 
            lblPersona.AutoSize = true;
            lblPersona.Location = new Point(37, 19);
            lblPersona.Name = "lblPersona";
            lblPersona.Size = new Size(49, 15);
            lblPersona.TabIndex = 0;
            lblPersona.Text = "Persona";
            // 
            // lblNombrePersona
            // 
            lblNombrePersona.AutoSize = true;
            lblNombrePersona.Location = new Point(22, 84);
            lblNombrePersona.Name = "lblNombrePersona";
            lblNombrePersona.Size = new Size(54, 15);
            lblNombrePersona.TabIndex = 20;
            lblNombrePersona.Text = "Nombre:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(26, 112);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(12, 141);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(56, 15);
            lblTelefono.TabIndex = 22;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(11, 179);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(60, 15);
            lblDireccion.TabIndex = 23;
            lblDireccion.Text = "Dirección:";
            // 
            // lblFechaNac
            // 
            lblFechaNac.AutoSize = true;
            lblFechaNac.Location = new Point(6, 213);
            lblFechaNac.Name = "lblFechaNac";
            lblFechaNac.Size = new Size(106, 15);
            lblFechaNac.TabIndex = 24;
            lblFechaNac.Text = "Fecha Nacimiento:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(196, 471);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(298, 471);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 16;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(88, 468);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(85, 32);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
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
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Font = new Font("Segoe UI", 9.75F);
            lblApellido1.Location = new Point(42, 130);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(0, 17);
            lblApellido1.TabIndex = 12;
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
<<<<<<< HEAD
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

           // btnBuscarPersona.Image = UI._Designer.lupa;

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
=======
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 503);
            Controls.Add(lblUsuario);
            Controls.Add(gbxUsuario);
            Controls.Add(btnEliminar);
            Controls.Add(button2);
            Controls.Add(btnGuardar);
            Name = "frmUsuario";
            Text = "Mantenimiento de Usuarios";
            Load += frmUsuario_Load;
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
        private TextBox txtfecha;
        private Label label4;
        private TextBox txtEstado;
        private Label lblUusario;
        private Label label7;
        private TextBox txtDescripcion;
        private Label lblApellido1;
        private Label lblNombre;
        private TextBox txtIdUsuario;
        private Label lblId;
        private GroupBox gbxUsuario;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConfirmarContraseña;
        private Label lblConfirmar;
        private ComboBox cboRol;
        private Label lblRol;
        private Button button2;
        private Button btnGuardar;
        private Button btnEliminar;
        private Label lblNombrePersona;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblFechaNac;
        private ComboBox cboPersona;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtNombre;
        private DateTimePicker dtpFechaNac;
    }
}