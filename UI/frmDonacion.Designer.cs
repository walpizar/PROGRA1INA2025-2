namespace UI
{
    partial class frmDonacion
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
            btnModificarDonacion = new Button();
            btnCancelar = new Button();
            btnGuardarDonacion = new Button();
            gbxDatosDonacion = new GroupBox();
            btnDonacionSelectIdDonante = new Button();
            cboxDonacionTipoMoneda = new ComboBox();
            cboxDonacionTipoTrans = new ComboBox();
            cboxDoancionFrecuencia = new ComboBox();
            textBox3 = new TextBox();
            label3 = new Label();
            lblDonacionMoneda = new Label();
            lblDonacionFrecuencia = new Label();
            lblDonacionTipoTrans = new Label();
            cboxDoancionIdTipoDonacion = new ComboBox();
            datepkDonacionFecha = new DateTimePicker();
            txtbxDonacionObservaciones = new TextBox();
            lblDonacionObserv = new Label();
            txtbxDonacionMonto = new TextBox();
            lblDonacionMonto = new Label();
            lblDonacionFecha = new Label();
            lblDonacionIdTipoDonacion = new Label();
            txtbxDonacionDonanteID = new TextBox();
            lblDonacionDonanteID = new Label();
            txtbxDonacionID = new TextBox();
            lblDonacionID = new Label();
            lblCrearDonante = new Label();
            lblCrearDonacion = new Label();
            gbxDatosDonacion.SuspendLayout();
            SuspendLayout();
            // 
            // btnModificarDonacion
            // 
            btnModificarDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarDonacion.Location = new Point(12, 553);
            btnModificarDonacion.Name = "btnModificarDonacion";
            btnModificarDonacion.Size = new Size(121, 50);
            btnModificarDonacion.TabIndex = 25;
            btnModificarDonacion.Text = "MODIFICAR";
            btnModificarDonacion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(147, 553);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 50);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDonacion
            // 
            btnGuardarDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDonacion.Location = new Point(288, 553);
            btnGuardarDonacion.Name = "btnGuardarDonacion";
            btnGuardarDonacion.Size = new Size(121, 50);
            btnGuardarDonacion.TabIndex = 23;
            btnGuardarDonacion.Text = "GUARDAR";
            btnGuardarDonacion.UseVisualStyleBackColor = true;
            // 
            // gbxDatosDonacion
            // 
            gbxDatosDonacion.Controls.Add(btnDonacionSelectIdDonante);
            gbxDatosDonacion.Controls.Add(cboxDonacionTipoMoneda);
            gbxDatosDonacion.Controls.Add(cboxDonacionTipoTrans);
            gbxDatosDonacion.Controls.Add(cboxDoancionFrecuencia);
            gbxDatosDonacion.Controls.Add(textBox3);
            gbxDatosDonacion.Controls.Add(label3);
            gbxDatosDonacion.Controls.Add(lblDonacionMoneda);
            gbxDatosDonacion.Controls.Add(lblDonacionFrecuencia);
            gbxDatosDonacion.Controls.Add(lblDonacionTipoTrans);
            gbxDatosDonacion.Controls.Add(cboxDoancionIdTipoDonacion);
            gbxDatosDonacion.Controls.Add(datepkDonacionFecha);
            gbxDatosDonacion.Controls.Add(txtbxDonacionObservaciones);
            gbxDatosDonacion.Controls.Add(lblDonacionObserv);
            gbxDatosDonacion.Controls.Add(txtbxDonacionMonto);
            gbxDatosDonacion.Controls.Add(lblDonacionMonto);
            gbxDatosDonacion.Controls.Add(lblDonacionFecha);
            gbxDatosDonacion.Controls.Add(lblDonacionIdTipoDonacion);
            gbxDatosDonacion.Controls.Add(txtbxDonacionDonanteID);
            gbxDatosDonacion.Controls.Add(lblDonacionDonanteID);
            gbxDatosDonacion.Controls.Add(txtbxDonacionID);
            gbxDatosDonacion.Controls.Add(lblDonacionID);
            gbxDatosDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbxDatosDonacion.Location = new Point(12, 93);
            gbxDatosDonacion.Name = "gbxDatosDonacion";
            gbxDatosDonacion.Size = new Size(397, 454);
            gbxDatosDonacion.TabIndex = 22;
            gbxDatosDonacion.TabStop = false;
            gbxDatosDonacion.Text = "DATOS DONACION";
            // 
            // btnDonacionSelectIdDonante
            // 
            btnDonacionSelectIdDonante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonacionSelectIdDonante.Location = new Point(276, 84);
            btnDonacionSelectIdDonante.Name = "btnDonacionSelectIdDonante";
            btnDonacionSelectIdDonante.Size = new Size(80, 27);
            btnDonacionSelectIdDonante.TabIndex = 27;
            btnDonacionSelectIdDonante.Text = "SELECT";
            btnDonacionSelectIdDonante.UseVisualStyleBackColor = true;
            btnDonacionSelectIdDonante.Click += btnDonacionSelectIdDonante_Click;
            // 
            // cboxDonacionTipoMoneda
            // 
            cboxDonacionTipoMoneda.FormattingEnabled = true;
            cboxDonacionTipoMoneda.Location = new Point(171, 373);
            cboxDonacionTipoMoneda.Name = "cboxDonacionTipoMoneda";
            cboxDonacionTipoMoneda.Size = new Size(185, 31);
            cboxDonacionTipoMoneda.TabIndex = 30;
            // 
            // cboxDonacionTipoTrans
            // 
            cboxDonacionTipoTrans.FormattingEnabled = true;
            cboxDonacionTipoTrans.Location = new Point(171, 299);
            cboxDonacionTipoTrans.Name = "cboxDonacionTipoTrans";
            cboxDonacionTipoTrans.Size = new Size(185, 31);
            cboxDonacionTipoTrans.TabIndex = 29;
            // 
            // cboxDoancionFrecuencia
            // 
            cboxDoancionFrecuencia.FormattingEnabled = true;
            cboxDoancionFrecuencia.Location = new Point(171, 336);
            cboxDoancionFrecuencia.Name = "cboxDoancionFrecuencia";
            cboxDoancionFrecuencia.Size = new Size(185, 31);
            cboxDoancionFrecuencia.TabIndex = 28;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(171, 410);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(185, 27);
            textBox3.TabIndex = 27;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 411);
            label3.Name = "label3";
            label3.Size = new Size(114, 23);
            label3.TabIndex = 26;
            label3.Text = "PROX. PAGO";
            // 
            // lblDonacionMoneda
            // 
            lblDonacionMoneda.AutoSize = true;
            lblDonacionMoneda.Location = new Point(79, 377);
            lblDonacionMoneda.Name = "lblDonacionMoneda";
            lblDonacionMoneda.Size = new Size(86, 23);
            lblDonacionMoneda.TabIndex = 24;
            lblDonacionMoneda.Text = "MONEDA";
            // 
            // lblDonacionFrecuencia
            // 
            lblDonacionFrecuencia.AutoSize = true;
            lblDonacionFrecuencia.Location = new Point(51, 339);
            lblDonacionFrecuencia.Name = "lblDonacionFrecuencia";
            lblDonacionFrecuencia.Size = new Size(113, 23);
            lblDonacionFrecuencia.TabIndex = 22;
            lblDonacionFrecuencia.Text = "FRECUENCIA";
            // 
            // lblDonacionTipoTrans
            // 
            lblDonacionTipoTrans.AutoSize = true;
            lblDonacionTipoTrans.Location = new Point(32, 302);
            lblDonacionTipoTrans.Name = "lblDonacionTipoTrans";
            lblDonacionTipoTrans.Size = new Size(133, 23);
            lblDonacionTipoTrans.TabIndex = 20;
            lblDonacionTipoTrans.Text = "TIPO TRANSAC";
            // 
            // cboxDoancionIdTipoDonacion
            // 
            cboxDoancionIdTipoDonacion.FormattingEnabled = true;
            cboxDoancionIdTipoDonacion.Location = new Point(171, 117);
            cboxDoancionIdTipoDonacion.Name = "cboxDoancionIdTipoDonacion";
            cboxDoancionIdTipoDonacion.Size = new Size(185, 31);
            cboxDoancionIdTipoDonacion.TabIndex = 19;
            // 
            // datepkDonacionFecha
            // 
            datepkDonacionFecha.Font = new Font("Bell MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datepkDonacionFecha.Format = DateTimePickerFormat.Short;
            datepkDonacionFecha.Location = new Point(171, 154);
            datepkDonacionFecha.Name = "datepkDonacionFecha";
            datepkDonacionFecha.Size = new Size(185, 27);
            datepkDonacionFecha.TabIndex = 11;
            // 
            // txtbxDonacionObservaciones
            // 
            txtbxDonacionObservaciones.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonacionObservaciones.Location = new Point(171, 189);
            txtbxDonacionObservaciones.Multiline = true;
            txtbxDonacionObservaciones.Name = "txtbxDonacionObservaciones";
            txtbxDonacionObservaciones.Size = new Size(185, 71);
            txtbxDonacionObservaciones.TabIndex = 17;
            // 
            // lblDonacionObserv
            // 
            lblDonacionObserv.AutoSize = true;
            lblDonacionObserv.Location = new Point(18, 189);
            lblDonacionObserv.Name = "lblDonacionObserv";
            lblDonacionObserv.Size = new Size(147, 23);
            lblDonacionObserv.TabIndex = 16;
            lblDonacionObserv.Text = "OBSERVACIONES";
            // 
            // txtbxDonacionMonto
            // 
            txtbxDonacionMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonacionMonto.Location = new Point(171, 266);
            txtbxDonacionMonto.Name = "txtbxDonacionMonto";
            txtbxDonacionMonto.Size = new Size(185, 27);
            txtbxDonacionMonto.TabIndex = 15;
            // 
            // lblDonacionMonto
            // 
            lblDonacionMonto.AutoSize = true;
            lblDonacionMonto.Location = new Point(90, 267);
            lblDonacionMonto.Name = "lblDonacionMonto";
            lblDonacionMonto.Size = new Size(75, 23);
            lblDonacionMonto.TabIndex = 14;
            lblDonacionMonto.Text = "MONTO";
            // 
            // lblDonacionFecha
            // 
            lblDonacionFecha.AutoSize = true;
            lblDonacionFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDonacionFecha.Location = new Point(21, 158);
            lblDonacionFecha.Name = "lblDonacionFecha";
            lblDonacionFecha.Size = new Size(144, 20);
            lblDonacionFecha.TabIndex = 10;
            lblDonacionFecha.Text = "FECHA DONACION";
            // 
            // lblDonacionIdTipoDonacion
            // 
            lblDonacionIdTipoDonacion.AutoSize = true;
            lblDonacionIdTipoDonacion.Location = new Point(16, 120);
            lblDonacionIdTipoDonacion.Name = "lblDonacionIdTipoDonacion";
            lblDonacionIdTipoDonacion.Size = new Size(149, 23);
            lblDonacionIdTipoDonacion.TabIndex = 6;
            lblDonacionIdTipoDonacion.Text = "TIPO DONACION";
            // 
            // txtbxDonacionDonanteID
            // 
            txtbxDonacionDonanteID.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonacionDonanteID.Location = new Point(171, 84);
            txtbxDonacionDonanteID.Name = "txtbxDonacionDonanteID";
            txtbxDonacionDonanteID.Size = new Size(99, 27);
            txtbxDonacionDonanteID.TabIndex = 3;
            // 
            // lblDonacionDonanteID
            // 
            lblDonacionDonanteID.AutoSize = true;
            lblDonacionDonanteID.Location = new Point(47, 88);
            lblDonacionDonanteID.Name = "lblDonacionDonanteID";
            lblDonacionDonanteID.Size = new Size(118, 23);
            lblDonacionDonanteID.TabIndex = 2;
            lblDonacionDonanteID.Text = "ID DONANTE";
            // 
            // txtbxDonacionID
            // 
            txtbxDonacionID.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonacionID.Location = new Point(171, 48);
            txtbxDonacionID.Name = "txtbxDonacionID";
            txtbxDonacionID.Size = new Size(185, 27);
            txtbxDonacionID.TabIndex = 1;
            // 
            // lblDonacionID
            // 
            lblDonacionID.AutoSize = true;
            lblDonacionID.Location = new Point(37, 49);
            lblDonacionID.Name = "lblDonacionID";
            lblDonacionID.Size = new Size(128, 23);
            lblDonacionID.TabIndex = 0;
            lblDonacionID.Text = "ID DONACION";
            // 
            // lblCrearDonante
            // 
            lblCrearDonante.AutoSize = true;
            lblCrearDonante.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearDonante.Location = new Point(348, -90);
            lblCrearDonante.Name = "lblCrearDonante";
            lblCrearDonante.Size = new Size(164, 25);
            lblCrearDonante.TabIndex = 21;
            lblCrearDonante.Text = "CREAR DONANTE";
            // 
            // lblCrearDonacion
            // 
            lblCrearDonacion.AutoSize = true;
            lblCrearDonacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearDonacion.Location = new Point(137, 47);
            lblCrearDonacion.Name = "lblCrearDonacion";
            lblCrearDonacion.Size = new Size(174, 25);
            lblCrearDonacion.TabIndex = 26;
            lblCrearDonacion.Text = "CREAR DONACION";
            lblCrearDonacion.Click += label1_Click;
            // 
            // frmDonacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 652);
            Controls.Add(lblCrearDonacion);
            Controls.Add(btnModificarDonacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarDonacion);
            Controls.Add(gbxDatosDonacion);
            Controls.Add(lblCrearDonante);
            Name = "frmDonacion";
            Text = "MANTENIMIENTO DONACION";
            gbxDatosDonacion.ResumeLayout(false);
            gbxDatosDonacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnModificarDonacion;
        private Button btnCancelar;
        private Button btnGuardarDonacion;
        private GroupBox gbxDatosDonacion;
        private DateTimePicker datepkDonacionFecha;
        private DateTimePicker datepkDonanteFechaNac;
        private TextBox txtbxDonacionObservaciones;
        private Label lblDonacionObserv;
        private TextBox txtbxDonacionMonto;
        private Label lblDonacionMonto;
        private Label lblDonateDireccion;
        private TextBox txtbxDonanteTelefono;
        private Label lblDonateTelefono;
        private TextBox txtbxDonanteEmail;
        private Label lblDonateEmail;
        private Label lblDonacionFecha;
        private TextBox textBox1;
        private Label lblDonateAp2;
        private Label lblDonacionIdTipoDonacion;
        private TextBox txtbxDonacionID;
        private Label lblDonacionID;
        private Label lblCrearDonante;
        private TextBox txtbxDonacionDonanteID;
        private Label lblDonacionDonanteID;
        private Label lblCrearDonacion;
        private ComboBox cboxDoancionIdTipoDonacion;
        private TextBox textBox3;
        private Label label3;
        private Label lblDonacionMoneda;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private Label lblDonacionTipoTrans;
        private Label lblDonacionFrecuencia;
        private ComboBox cboxDoancionFrecuencia;
        private ComboBox cboxDonacionTipoMoneda;
        private ComboBox cboxDonacionTipoTrans;
        private Button btnDonacionSelectIdDonante;
    }
}