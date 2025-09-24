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
            label2 = new Label();
            cboRol = new ComboBox();
            lblRol = new Label();
            lblConfirmar = new Label();
            txtConfirmarContraseña = new TextBox();
            txtPassword = new TextBox();
            lblPassword = new Label();
            txtUsuario = new TextBox();
            cboPersona = new ComboBox();
            lblPersona = new Label();
            btnEliminar = new Button();
            button2 = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            lblContraseña = new Label();
            lblApellido1 = new Label();
            txtNombre = new TextBox();
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
            lblUsuario.Location = new Point(139, 7);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(145, 30);
            lblUsuario.TabIndex = 5;
            lblUsuario.Text = "Crear Usuario";
            lblUsuario.TextAlign = ContentAlignment.TopCenter;
            // 
            // gbxUsuario
            // 
            gbxUsuario.Controls.Add(label2);
            gbxUsuario.Controls.Add(cboRol);
            gbxUsuario.Controls.Add(lblRol);
            gbxUsuario.Controls.Add(lblConfirmar);
            gbxUsuario.Controls.Add(txtConfirmarContraseña);
            gbxUsuario.Controls.Add(txtPassword);
            gbxUsuario.Controls.Add(lblPassword);
            gbxUsuario.Controls.Add(txtUsuario);
            gbxUsuario.Controls.Add(cboPersona);
            gbxUsuario.Controls.Add(lblPersona);
            gbxUsuario.Location = new Point(3, 40);
            gbxUsuario.Name = "gbxUsuario";
            gbxUsuario.Size = new Size(403, 252);
            gbxUsuario.TabIndex = 6;
            gbxUsuario.TabStop = false;
            gbxUsuario.Text = "Datos Usuarios";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 79);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 14;
            label2.Text = "Usuario:";
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(82, 216);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(145, 23);
            cboRol.TabIndex = 11;
            // 
            // lblRol
            // 
            lblRol.AutoSize = true;
            lblRol.Location = new Point(37, 219);
            lblRol.Name = "lblRol";
            lblRol.Size = new Size(27, 15);
            lblRol.TabIndex = 10;
            lblRol.Text = "Rol:";
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Location = new Point(6, 166);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(64, 15);
            lblConfirmar.TabIndex = 9;
            lblConfirmar.Text = "Confirmar:";
            // 
            // txtConfirmarContraseña
            // 
            txtConfirmarContraseña.Location = new Point(82, 166);
            txtConfirmarContraseña.Name = "txtConfirmarContraseña";
            txtConfirmarContraseña.Size = new Size(299, 23);
            txtConfirmarContraseña.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(82, 119);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(299, 23);
            txtPassword.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(6, 122);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(70, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(82, 79);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(299, 23);
            txtUsuario.TabIndex = 4;
            // 
            // cboPersona
            // 
            cboPersona.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPersona.FormattingEnabled = true;
            cboPersona.Location = new Point(57, 37);
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
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(85, 299);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(88, 29);
            btnEliminar.TabIndex = 17;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(285, 302);
            button2.Name = "button2";
            button2.Size = new Size(99, 29);
            button2.TabIndex = 16;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(188, 299);
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
            // frmUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(418, 340);
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
            // 

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
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtIdUsuario;
        private Label lblId;
        private GroupBox gbxUsuario;
        private ComboBox cboPersona;
        private TextBox txtPassword;
        private Label lblPassword;
        private TextBox txtConfirmarContraseña;
        private Label lblConfirmar;
        private ComboBox cboRol;
        private Label lblRol;
        private Label label2;
        private Button button2;
        private Button btnGuardar;
        private Button btnEliminar;
    }
}