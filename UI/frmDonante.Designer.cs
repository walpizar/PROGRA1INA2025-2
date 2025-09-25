namespace UI
{
    partial class frmDonante
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
            lblCrearDonante = new Label();
            gbxDatosDonante = new GroupBox();
            cboxDonanteTipoID = new ComboBox();
            cboxDonanteTipo = new ComboBox();
            lblDonanteTipoDon = new Label();
            datepkDonanteFechaNac = new DateTimePicker();
            txtbxDonanteDireccion = new TextBox();
            lblDonateDireccion = new Label();
            txtbxDonanteTelefono = new TextBox();
            lblDonateTelefono = new Label();
            txtbxDonanteEmail = new TextBox();
            lblDonateEmail = new Label();
            lblDonateFechaNac = new Label();
            txtbxDonanteAp2 = new TextBox();
            lblDonateAp2 = new Label();
            txtbxDonanteAp1 = new TextBox();
            lblDonateAp1 = new Label();
            txtbxDonanteNombre = new TextBox();
            lblDonateNombre = new Label();
            lblDonateTipoID = new Label();
            txtbxDonanteID = new TextBox();
            lblDonanteID = new Label();
            btnGuardarDonante = new Button();
            btnCancelar = new Button();
            btnEliminarDonante = new Button();
            gbxDatosDonante.SuspendLayout();
            SuspendLayout();
            // 
            // lblCrearDonante
            // 
            lblCrearDonante.AutoSize = true;
            lblCrearDonante.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearDonante.Location = new Point(158, 24);
            lblCrearDonante.Name = "lblCrearDonante";
            lblCrearDonante.Size = new Size(164, 25);
            lblCrearDonante.TabIndex = 0;
            lblCrearDonante.Text = "CREAR DONANTE";
            // 
            // gbxDatosDonante
            // 
            gbxDatosDonante.Controls.Add(cboxDonanteTipoID);
            gbxDatosDonante.Controls.Add(cboxDonanteTipo);
            gbxDatosDonante.Controls.Add(lblDonanteTipoDon);
            gbxDatosDonante.Controls.Add(datepkDonanteFechaNac);
            gbxDatosDonante.Controls.Add(txtbxDonanteDireccion);
            gbxDatosDonante.Controls.Add(lblDonateDireccion);
            gbxDatosDonante.Controls.Add(txtbxDonanteTelefono);
            gbxDatosDonante.Controls.Add(lblDonateTelefono);
            gbxDatosDonante.Controls.Add(txtbxDonanteEmail);
            gbxDatosDonante.Controls.Add(lblDonateEmail);
            gbxDatosDonante.Controls.Add(lblDonateFechaNac);
            gbxDatosDonante.Controls.Add(txtbxDonanteAp2);
            gbxDatosDonante.Controls.Add(lblDonateAp2);
            gbxDatosDonante.Controls.Add(txtbxDonanteAp1);
            gbxDatosDonante.Controls.Add(lblDonateAp1);
            gbxDatosDonante.Controls.Add(txtbxDonanteNombre);
            gbxDatosDonante.Controls.Add(lblDonateNombre);
            gbxDatosDonante.Controls.Add(lblDonateTipoID);
            gbxDatosDonante.Controls.Add(txtbxDonanteID);
            gbxDatosDonante.Controls.Add(lblDonanteID);
            gbxDatosDonante.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbxDatosDonante.Location = new Point(12, 89);
            gbxDatosDonante.Name = "gbxDatosDonante";
            gbxDatosDonante.Size = new Size(397, 509);
            gbxDatosDonante.TabIndex = 1;
            gbxDatosDonante.TabStop = false;
            gbxDatosDonante.Text = "DATOS DONANTE";
            // 
            // cboxDonanteTipoID
            // 
            cboxDonanteTipoID.FormattingEnabled = true;
            cboxDonanteTipoID.Location = new Point(162, 118);
            cboxDonanteTipoID.Name = "cboxDonanteTipoID";
            cboxDonanteTipoID.Size = new Size(185, 31);
            cboxDonanteTipoID.TabIndex = 20;
            // 
            // cboxDonanteTipo
            // 
            cboxDonanteTipo.FormattingEnabled = true;
            cboxDonanteTipo.Location = new Point(162, 447);
            cboxDonanteTipo.Name = "cboxDonanteTipo";
            cboxDonanteTipo.Size = new Size(185, 31);
            cboxDonanteTipo.TabIndex = 19;
            // 
            // lblDonanteTipoDon
            // 
            lblDonanteTipoDon.AutoSize = true;
            lblDonanteTipoDon.Location = new Point(17, 450);
            lblDonanteTipoDon.Name = "lblDonanteTipoDon";
            lblDonanteTipoDon.Size = new Size(139, 23);
            lblDonanteTipoDon.TabIndex = 18;
            lblDonanteTipoDon.Text = "TIPO DONANTE";
            // 
            // datepkDonanteFechaNac
            // 
            datepkDonanteFechaNac.Font = new Font("Bell MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datepkDonanteFechaNac.Format = DateTimePickerFormat.Short;
            datepkDonanteFechaNac.Location = new Point(162, 262);
            datepkDonanteFechaNac.Name = "datepkDonanteFechaNac";
            datepkDonanteFechaNac.Size = new Size(185, 27);
            datepkDonanteFechaNac.TabIndex = 11;
            // 
            // txtbxDonanteDireccion
            // 
            txtbxDonanteDireccion.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonanteDireccion.Location = new Point(162, 370);
            txtbxDonanteDireccion.Multiline = true;
            txtbxDonanteDireccion.Name = "txtbxDonanteDireccion";
            txtbxDonanteDireccion.Size = new Size(185, 71);
            txtbxDonanteDireccion.TabIndex = 17;
            // 
            // lblDonateDireccion
            // 
            lblDonateDireccion.AutoSize = true;
            lblDonateDireccion.Location = new Point(55, 373);
            lblDonateDireccion.Name = "lblDonateDireccion";
            lblDonateDireccion.Size = new Size(102, 23);
            lblDonateDireccion.TabIndex = 16;
            lblDonateDireccion.Text = "DIRECCION";
            // 
            // txtbxDonanteTelefono
            // 
            txtbxDonanteTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonanteTelefono.Location = new Point(162, 334);
            txtbxDonanteTelefono.Name = "txtbxDonanteTelefono";
            txtbxDonanteTelefono.Size = new Size(185, 27);
            txtbxDonanteTelefono.TabIndex = 15;
            // 
            // lblDonateTelefono
            // 
            lblDonateTelefono.AutoSize = true;
            lblDonateTelefono.Location = new Point(73, 337);
            lblDonateTelefono.Name = "lblDonateTelefono";
            lblDonateTelefono.Size = new Size(96, 23);
            lblDonateTelefono.TabIndex = 14;
            lblDonateTelefono.Text = "TELEFONO";
            // 
            // txtbxDonanteEmail
            // 
            txtbxDonanteEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonanteEmail.Location = new Point(162, 298);
            txtbxDonanteEmail.Name = "txtbxDonanteEmail";
            txtbxDonanteEmail.Size = new Size(185, 27);
            txtbxDonanteEmail.TabIndex = 13;
            // 
            // lblDonateEmail
            // 
            lblDonateEmail.AutoSize = true;
            lblDonateEmail.Location = new Point(84, 301);
            lblDonateEmail.Name = "lblDonateEmail";
            lblDonateEmail.Size = new Size(60, 23);
            lblDonateEmail.TabIndex = 12;
            lblDonateEmail.Text = "EMAIL";
            // 
            // lblDonateFechaNac
            // 
            lblDonateFechaNac.AutoSize = true;
            lblDonateFechaNac.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDonateFechaNac.Location = new Point(-1, 267);
            lblDonateFechaNac.Name = "lblDonateFechaNac";
            lblDonateFechaNac.Size = new Size(157, 20);
            lblDonateFechaNac.TabIndex = 10;
            lblDonateFechaNac.Text = "FECHA NACIMIENTO";
            // 
            // txtbxDonanteAp2
            // 
            txtbxDonanteAp2.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonanteAp2.Location = new Point(162, 226);
            txtbxDonanteAp2.Name = "txtbxDonanteAp2";
            txtbxDonanteAp2.Size = new Size(185, 27);
            txtbxDonanteAp2.TabIndex = 9;
            // 
            // lblDonateAp2
            // 
            lblDonateAp2.AutoSize = true;
            lblDonateAp2.Location = new Point(55, 229);
            lblDonateAp2.Name = "lblDonateAp2";
            lblDonateAp2.Size = new Size(101, 23);
            lblDonateAp2.TabIndex = 8;
            lblDonateAp2.Text = "APELLIDO2";
            // 
            // txtbxDonanteAp1
            // 
            txtbxDonanteAp1.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonanteAp1.Location = new Point(162, 190);
            txtbxDonanteAp1.Name = "txtbxDonanteAp1";
            txtbxDonanteAp1.Size = new Size(185, 27);
            txtbxDonanteAp1.TabIndex = 7;
            // 
            // lblDonateAp1
            // 
            lblDonateAp1.AutoSize = true;
            lblDonateAp1.Location = new Point(55, 193);
            lblDonateAp1.Name = "lblDonateAp1";
            lblDonateAp1.Size = new Size(101, 23);
            lblDonateAp1.TabIndex = 6;
            lblDonateAp1.Text = "APELLIDO1";
            // 
            // txtbxDonanteNombre
            // 
            txtbxDonanteNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonanteNombre.Location = new Point(162, 154);
            txtbxDonanteNombre.Name = "txtbxDonanteNombre";
            txtbxDonanteNombre.Size = new Size(185, 27);
            txtbxDonanteNombre.TabIndex = 5;
            // 
            // lblDonateNombre
            // 
            lblDonateNombre.AutoSize = true;
            lblDonateNombre.Location = new Point(73, 157);
            lblDonateNombre.Name = "lblDonateNombre";
            lblDonateNombre.Size = new Size(83, 23);
            lblDonateNombre.TabIndex = 4;
            lblDonateNombre.Text = "NOMBRE";
            // 
            // lblDonateTipoID
            // 
            lblDonateTipoID.AutoSize = true;
            lblDonateTipoID.Location = new Point(84, 121);
            lblDonateTipoID.Name = "lblDonateTipoID";
            lblDonateTipoID.Size = new Size(72, 23);
            lblDonateTipoID.TabIndex = 2;
            lblDonateTipoID.Text = "TIPO ID";
            // 
            // txtbxDonanteID
            // 
            txtbxDonanteID.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonanteID.Location = new Point(162, 82);
            txtbxDonanteID.Name = "txtbxDonanteID";
            txtbxDonanteID.Size = new Size(185, 27);
            txtbxDonanteID.TabIndex = 1;
            // 
            // lblDonanteID
            // 
            lblDonanteID.AutoSize = true;
            lblDonanteID.Location = new Point(128, 85);
            lblDonanteID.Name = "lblDonanteID";
            lblDonanteID.Size = new Size(28, 23);
            lblDonanteID.TabIndex = 0;
            lblDonanteID.Text = "ID";
            // 
            // btnGuardarDonante
            // 
            btnGuardarDonante.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDonante.Location = new Point(288, 604);
            btnGuardarDonante.Name = "btnGuardarDonante";
            btnGuardarDonante.Size = new Size(121, 50);
            btnGuardarDonante.TabIndex = 18;
            btnGuardarDonante.Text = "GUARDAR";
            btnGuardarDonante.UseVisualStyleBackColor = true;
            btnGuardarDonante.Click += btnGuardarDonante_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(147, 604);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 50);
            btnCancelar.TabIndex = 19;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminarDonante
            // 
            btnEliminarDonante.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarDonante.Location = new Point(12, 604);
            btnEliminarDonante.Name = "btnEliminarDonante";
            btnEliminarDonante.Size = new Size(121, 50);
            btnEliminarDonante.TabIndex = 20;
            btnEliminarDonante.Text = "ELIMINAR";
            btnEliminarDonante.UseVisualStyleBackColor = true;
            btnEliminarDonante.Click += btnEliminarDonante_Click;
            // 
            // frmDonante
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 663);
            Controls.Add(btnEliminarDonante);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarDonante);
            Controls.Add(gbxDatosDonante);
            Controls.Add(lblCrearDonante);
            Name = "frmDonante";
            Text = "MANTENIMIENTO DONANTES";
            Load += frmDonante_Load;
            gbxDatosDonante.ResumeLayout(false);
            gbxDatosDonante.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrearDonante;
        private GroupBox gbxDatosDonante;
        private Button btnGuardarDonante;
        private Button btnCancelar;
        private Button btnEliminarDonante;
        private Label lblDonanteID;
        private TextBox txtbxDonanteID;
        private Label lblDonateTipoID;
        private TextBox txtbxDonanteNombre;
        private Label lblDonateNombre;
        private TextBox txtbxDonanteAp2;
        private Label lblDonateAp2;
        private TextBox txtbxDonanteAp1;
        private Label lblDonateAp1;
        private TextBox textBox3;
        private Label label1;
        private TextBox txtbxDonanteDireccion;
        private Label lblDonateDireccion;
        private TextBox txtbxDonanteTelefono;
        private Label lblDonateTelefono;
        private TextBox txtbxDonanteEmail;
        private Label lblDonateEmail;
        private Label lblDonateFechaNac;
        private DateTimePicker datepkDonanteFechaNac;
        private ComboBox cboxDonanteTipo;
        private Label lblDonanteTipoDon;
        private ComboBox cboxDonanteTipoID;
    }
}