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
            gbrDatosPersonales.Location = new Point(14, 14);
            gbrDatosPersonales.Name = "gbrDatosPersonales";
            gbrDatosPersonales.Size = new Size(564, 352);
            gbrDatosPersonales.TabIndex = 0;
            gbrDatosPersonales.TabStop = false;
            gbrDatosPersonales.Text = "Datos Personales";

            // 
            // label7 (Tipo ID)
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 35);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.Text = "Tipo Identificación:";
            // 
            // combTipoId
            // 
            combTipoId.Location = new Point(160, 30);
            combTipoId.Name = "combTipoId";
            combTipoId.Size = new Size(200, 23);

            // 
            // lblIdentificacion
            // 
            lblIdentificacion.AutoSize = true;
            lblIdentificacion.Location = new Point(20, 70);
            lblIdentificacion.Name = "lblIdentificacion";
            lblIdentificacion.Size = new Size(82, 15);
            lblIdentificacion.Text = "Identificación:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(160, 65);
            txtIdentificacion.Size = new Size(200, 23);

            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(20, 105);
            lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(160, 100);
            txtNombre.Size = new Size(200, 23);

            // 
            // lblApellido1
            // 
            lblApellido1.AutoSize = true;
            lblApellido1.Location = new Point(20, 140);
            lblApellido1.Text = "Primer Apellido:";
            // 
            // txtApellido1
            // 
            txtApellido1.Location = new Point(160, 135);
            txtApellido1.Size = new Size(200, 23);

            // 
            // label3 (Segundo Apellido)
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 175);
            label3.Text = "Segundo Apellido:";
            // 
            // txtSegundoApellido
            // 
            txtSegundoApellido.Location = new Point(160, 170);
            txtSegundoApellido.Size = new Size(200, 23);

            // 
            // label4 (Dirección)
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 210);
            label4.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(160, 205);
            txtDireccion.Size = new Size(350, 23);

            // 
            // label5 (Teléfono)
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 245);
            label5.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(160, 240);
            txtTelefono.Size = new Size(200, 23);

            // 
            // label6 (Email)
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 280);
            label6.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(160, 275);
            txtEmail.Size = new Size(250, 23);

            // 
            // label1 (Fecha Nacimiento)
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 315);
            label1.Text = "Fecha Nacimiento:";
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(160, 310);
            dateFecha.Size = new Size(200, 23);

            // 
            // DatosPersonalesControl
            // 
            Controls.Add(gbrDatosPersonales);
            Name = "DatosPersonalesControl";
            Size = new Size(600, 400);

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
