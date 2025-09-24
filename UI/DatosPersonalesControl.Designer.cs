namespace UI
{
    public partial class DatosPersonalesControl : UserControl
    {
        // Renamed the field 'Identificacion' to 'lblIdentificacion' to resolve ambiguity
        private Label lblIdentificacion;

        private void InitializeComponent()
        {
            gbrDatosPersonales = new GroupBox();
            combTipoId = new ComboBox();
            label7 = new Label();
            txtIdentificacion = new TextBox();
            lblIdentificacion = new Label();
            dateFecha = new DateTimePicker();
            label1 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txtSegundoApellido = new TextBox();
            label3 = new Label();
            txtApellido1 = new TextBox();
            lblApellido1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            gbrDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // gbrDatosPersonales
            // 
            gbrDatosPersonales.Controls.Add(combTipoId);
            gbrDatosPersonales.Controls.Add(label7);
            gbrDatosPersonales.Controls.Add(txtIdentificacion);
            gbrDatosPersonales.Controls.Add(lblIdentificacion);
            gbrDatosPersonales.Controls.Add(dateFecha);
            gbrDatosPersonales.Controls.Add(label1);
            gbrDatosPersonales.Controls.Add(txtEmail);
            gbrDatosPersonales.Controls.Add(label6);
            gbrDatosPersonales.Controls.Add(txtTelefono);
            gbrDatosPersonales.Controls.Add(txtDireccion);
            gbrDatosPersonales.Controls.Add(label5);
            gbrDatosPersonales.Controls.Add(label4);
            gbrDatosPersonales.Controls.Add(txtSegundoApellido);
            gbrDatosPersonales.Controls.Add(label3);
            gbrDatosPersonales.Controls.Add(txtApellido1);
            gbrDatosPersonales.Controls.Add(lblApellido1);
            gbrDatosPersonales.Controls.Add(txtNombre);
            gbrDatosPersonales.Controls.Add(lblNombre);
            gbrDatosPersonales.Location = new Point(16, 55);
            gbrDatosPersonales.Name = "gbrDatosPersonales";
            gbrDatosPersonales.Size = new Size(649, 537);
            gbrDatosPersonales.TabIndex = 0;
            gbrDatosPersonales.TabStop = false;
            gbrDatosPersonales.Text = "Datos Personales";
            // 
            // combTipoId
            // 
            combTipoId.Location = new Point(182, 52);
            combTipoId.Name = "combTipoId";
            combTipoId.Size = new Size(236, 33);
            combTipoId.TabIndex = 0;
            combTipoId.SelectedIndexChanged += combTipoId_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 55);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 1;
            label7.Text = "Tipo Identificación:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(160, 105);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(258, 31);
            txtIdentificacion.TabIndex = 2;
            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(20, 108);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(121, 25);
            lblIdentificacion.TabIndex = 3;
            lblIdentificacion.Text = "Identificación:";
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(182, 454);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(236, 31);
            dateFecha.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 459);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 5;
            label1.Text = "Fecha Nacimiento:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 405);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(258, 31);
            txtEmail.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 408);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 7;
            label6.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 355);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(258, 31);
            txtTelefono.TabIndex = 8;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 303);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(258, 31);
            txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 358);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 10;
            label5.Text = "Teléfono:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 306);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 11;
            label4.Text = "Dirección:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(182, 257);
            txtSegundoApellido.Name = "txtSegundoApellido";
            txtSegundoApellido.Size = new Size(236, 31);
            txtSegundoApellido.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 260);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 13;
            label3.Text = "Segundo Apellido:";
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(160, 209);
            txtApellido1.Name = "txtApellido1";
            txtApellido1.Size = new Size(258, 31);
            txtApellido1.TabIndex = 14;
            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(22, 212);
            lblApellido1.Name = "lblApellido1";
            lblApellido1.Size = new Size(138, 25);
            lblApellido1.TabIndex = 15;
            lblApellido1.Text = "Primer Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 156);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(258, 31);
            txtNombre.TabIndex = 16;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 159);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 17;
            lblNombre.Text = "Nombre:";
            // 
            // DatosPersonalesControl
            // 
            Controls.Add(gbrDatosPersonales);
            Name = "DatosPersonalesControl";
            Size = new Size(682, 666);
            gbrDatosPersonales.ResumeLayout(false);
            gbrDatosPersonales.PerformLayout();
            ResumeLayout(false);
        }


        #region Fields
        private GroupBox gbrDatosPersonales;
        private TextBox txtEmail;
        private Label label6;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label5;
        private Label label4;
        private TextBox txtSegundoApellido;
        private Label label3;
        private TextBox txtApellido1;
        private Label lblApellido1;
        private TextBox txtNombre;
        private Label lblNombre;
        private DateTimePicker dateFecha;
        private Label label1;
        public TextBox txtIdentificacion;
        private Label label7;
        private ComboBox combTipoId;
        #endregion
    }
}
