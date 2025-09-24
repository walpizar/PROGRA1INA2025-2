
namespace UI
{
    partial class FrmAnadirPersonalAdministrativo
    {
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
            gbDatosPersonales = new GroupBox();
            dateFecha = new DateTimePicker();
            txtDescripcion = new RichTextBox();
            combPuesto = new ComboBox();
            label12 = new Label();
            label10 = new Label();
            label11 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label9 = new Label();
            txtTelefono = new TextBox();
            label7 = new Label();
            txtDireccion = new TextBox();
            label6 = new Label();
            txt2Apellido = new TextBox();
            label5 = new Label();
            txt1Apellido = new TextBox();
            label4 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtIdentificacion = new TextBox();
            combTipoIdent = new ComboBox();
            label1 = new Label();
            btnEliminar = new Button();
            btnAnadir = new Button();
            btnCancelar = new Button();
            lblTitulo = new Label();
            gbDatosPersonales.SuspendLayout();
            SuspendLayout();
            // 
            // gbDatosPersonales
            // 
            gbDatosPersonales.Controls.Add(dateFecha);
            gbDatosPersonales.Controls.Add(txtDescripcion);
            gbDatosPersonales.Controls.Add(combPuesto);
            gbDatosPersonales.Controls.Add(label12);
            gbDatosPersonales.Controls.Add(label10);
            gbDatosPersonales.Controls.Add(label11);
            gbDatosPersonales.Controls.Add(label8);
            gbDatosPersonales.Controls.Add(txtEmail);
            gbDatosPersonales.Controls.Add(label9);
            gbDatosPersonales.Controls.Add(txtTelefono);
            gbDatosPersonales.Controls.Add(label7);
            gbDatosPersonales.Controls.Add(txtDireccion);
            gbDatosPersonales.Controls.Add(label6);
            gbDatosPersonales.Controls.Add(txt2Apellido);
            gbDatosPersonales.Controls.Add(label5);
            gbDatosPersonales.Controls.Add(txt1Apellido);
            gbDatosPersonales.Controls.Add(label4);
            gbDatosPersonales.Controls.Add(txtNombre);
            gbDatosPersonales.Controls.Add(label3);
            gbDatosPersonales.Controls.Add(label2);
            gbDatosPersonales.Controls.Add(txtIdentificacion);
            gbDatosPersonales.Controls.Add(combTipoIdent);
            gbDatosPersonales.Controls.Add(label1);
            gbDatosPersonales.Location = new Point(12, 108);
            gbDatosPersonales.Name = "gbDatosPersonales";
            gbDatosPersonales.Size = new Size(547, 427);
            gbDatosPersonales.TabIndex = 0;
            gbDatosPersonales.TabStop = false;
            gbDatosPersonales.Text = "Asignación Personal Adminitrativo";
            // 
            // dateFecha
            // 
            dateFecha.Location = new Point(190, 272);
            dateFecha.Name = "dateFecha";
            dateFecha.Size = new Size(265, 31);
            dateFecha.TabIndex = 25;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(190, 330);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(265, 81);
            txtDescripcion.TabIndex = 24;
            txtDescripcion.Text = "";
            // 
            // combPuesto
            // 
            combPuesto.FormattingEnabled = true;
            combPuesto.Location = new Point(190, 301);
            combPuesto.Name = "combPuesto";
            combPuesto.Size = new Size(265, 33);
            combPuesto.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 333);
            label12.Name = "label12";
            label12.Size = new Size(108, 25);
            label12.TabIndex = 22;
            label12.Text = "Descripción:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(24, 304);
            label10.Name = "label10";
            label10.Size = new Size(70, 25);
            label10.TabIndex = 20;
            label10.Text = "Puesto:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(24, 275);
            label11.Name = "label11";
            label11.Size = new Size(156, 25);
            label11.TabIndex = 18;
            label11.Text = "Fecha Nacimiento:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(23, 347);
            label8.Name = "label8";
            label8.Size = new Size(0, 25);
            label8.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(190, 243);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(265, 31);
            txtEmail.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(24, 246);
            label9.Name = "label9";
            label9.Size = new Size(58, 25);
            label9.TabIndex = 14;
            label9.Text = "Email:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(190, 214);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(265, 31);
            txtTelefono.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 217);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 12;
            label7.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(190, 185);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(265, 31);
            txtDireccion.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 188);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 10;
            label6.Text = "Dirrección:";
            // 
            // txt2Apellido
            // 
            txt2Apellido.Location = new Point(190, 156);
            txt2Apellido.Name = "txt2Apellido";
            txt2Apellido.Size = new Size(265, 31);
            txt2Apellido.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 159);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 8;
            label5.Text = "Segundo Apellido:";
            // 
            // txt1Apellido
            // 
            txt1Apellido.Location = new Point(190, 127);
            txt1Apellido.Name = "txt1Apellido";
            txt1Apellido.Size = new Size(265, 31);
            txt1Apellido.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 130);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 6;
            label4.Text = "Primer Apellido:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(190, 98);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(265, 31);
            txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 101);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(121, 25);
            label2.TabIndex = 3;
            label2.Text = "Identificación:";
            // 
            // txtIdentificacion
            // 
            txtIdentificacion.Location = new Point(190, 69);
            txtIdentificacion.Name = "txtIdentificacion";
            txtIdentificacion.Size = new Size(265, 31);
            txtIdentificacion.TabIndex = 2;
            // 
            // combTipoIdent
            // 
            combTipoIdent.FormattingEnabled = true;
            combTipoIdent.Location = new Point(190, 40);
            combTipoIdent.Name = "combTipoIdent";
            combTipoIdent.Size = new Size(265, 33);
            combTipoIdent.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 43);
            label1.Name = "label1";
            label1.Size = new Size(161, 25);
            label1.TabIndex = 0;
            label1.Text = "Tipo Identificación:";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(237, 554);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 1;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(355, 554);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(112, 34);
            btnAnadir.TabIndex = 2;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            btnAnadir.Click += btnAnadir_Click_1;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(473, 554);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(100, 53);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(612, 37);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Mantenimento Personal Administrativo";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAnadirPersonalAdministrativo
            // 
            ClientSize = new Size(595, 611);
            Controls.Add(lblTitulo);
            Controls.Add(btnCancelar);
            Controls.Add(btnAnadir);
            Controls.Add(btnEliminar);
            Controls.Add(gbDatosPersonales);
            Name = "FrmAnadirPersonalAdministrativo";
            Load += FrmAnadirPersonalAdministrativo_Load;
            gbDatosPersonales.ResumeLayout(false);
            gbDatosPersonales.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void combTipoId_SelectedIndexChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private GroupBox gbDatosPersonales;
        private Label label1;
        private Label label12;
        private Label label10;
        private Label label11;
        private Label label8;
        private TextBox txtEmail;
        private Label label9;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private Label label6;
        private TextBox txt2Apellido;
        private Label label5;
        private TextBox txt1Apellido;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private Label label2;
        private TextBox txtIdentificacion;
        private ComboBox combTipoIdent;
        private Label label7;
        private RichTextBox txtDescripcion;
        private ComboBox combPuesto;
        private Button btnEliminar;
        private Button btnAnadir;
        private Button btnCancelar;
        private Label lblTitulo;
        private DateTimePicker dateFecha;
    }
}