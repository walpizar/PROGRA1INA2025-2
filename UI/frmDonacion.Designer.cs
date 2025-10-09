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
            btnEliminarDonacion = new Button();
            btnCancelar = new Button();
            btnGuardarDonacion = new Button();
            gbxDatosDonacion = new GroupBox();
            lblTipoIdDonante = new Label();
            btnDonacionSelectIdDonante = new Button();
            cboxDonacionTipoMoneda = new ComboBox();
            cboxDonacionTipoTrans = new ComboBox();
            cboxDonacionFrecuencia = new ComboBox();
            lblDonacionMoneda = new Label();
            lblDonacionFrecuencia = new Label();
            lblDonacionTipoTrans = new Label();
            cboxDonacionIdTipoDonacion = new ComboBox();
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
            txtbxDonacionTipoIdDonante = new TextBox();
            gbxDatosDonacion.SuspendLayout();
            SuspendLayout();
            // 
            // btnEliminarDonacion
            // 
            btnEliminarDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminarDonacion.Location = new Point(12, 577);
            btnEliminarDonacion.Name = "btnEliminarDonacion";
            btnEliminarDonacion.Size = new Size(121, 50);
            btnEliminarDonacion.TabIndex = 25;
            btnEliminarDonacion.Text = "ELIMINAR";
            btnEliminarDonacion.UseVisualStyleBackColor = true;
            btnEliminarDonacion.Click += btnEliminarDonacion_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(147, 577);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 50);
            btnCancelar.TabIndex = 24;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardarDonacion
            // 
            btnGuardarDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDonacion.Location = new Point(288, 577);
            btnGuardarDonacion.Name = "btnGuardarDonacion";
            btnGuardarDonacion.Size = new Size(121, 50);
            btnGuardarDonacion.TabIndex = 23;
            btnGuardarDonacion.Text = "GUARDAR";
            btnGuardarDonacion.UseVisualStyleBackColor = true;
            btnGuardarDonacion.Click += btnGuardarDonacion_Click_1;
            // 
            // gbxDatosDonacion
            // 
            gbxDatosDonacion.Controls.Add(txtbxDonacionTipoIdDonante);
            gbxDatosDonacion.Controls.Add(lblTipoIdDonante);
            gbxDatosDonacion.Controls.Add(btnDonacionSelectIdDonante);
            gbxDatosDonacion.Controls.Add(cboxDonacionTipoMoneda);
            gbxDatosDonacion.Controls.Add(cboxDonacionTipoTrans);
            gbxDatosDonacion.Controls.Add(cboxDonacionFrecuencia);
            gbxDatosDonacion.Controls.Add(lblDonacionMoneda);
            gbxDatosDonacion.Controls.Add(lblDonacionFrecuencia);
            gbxDatosDonacion.Controls.Add(lblDonacionTipoTrans);
            gbxDatosDonacion.Controls.Add(cboxDonacionIdTipoDonacion);
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
            gbxDatosDonacion.Size = new Size(397, 478);
            gbxDatosDonacion.TabIndex = 22;
            gbxDatosDonacion.TabStop = false;
            gbxDatosDonacion.Text = "DATOS DONACION";
            // 
            // lblTipoIdDonante
            // 
            lblTipoIdDonante.AutoSize = true;
            lblTipoIdDonante.Location = new Point(3, 118);
            lblTipoIdDonante.Name = "lblTipoIdDonante";
            lblTipoIdDonante.Size = new Size(162, 23);
            lblTipoIdDonante.TabIndex = 31;
            lblTipoIdDonante.Text = "TIPO ID DONANTE";
            // 
            // btnDonacionSelectIdDonante
            // 
            btnDonacionSelectIdDonante.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonacionSelectIdDonante.Location = new Point(291, 84);
            btnDonacionSelectIdDonante.Name = "btnDonacionSelectIdDonante";
            btnDonacionSelectIdDonante.Size = new Size(65, 27);
            btnDonacionSelectIdDonante.TabIndex = 27;
            btnDonacionSelectIdDonante.Text = "SELECT";
            btnDonacionSelectIdDonante.UseVisualStyleBackColor = true;
            btnDonacionSelectIdDonante.Click += btnDonacionSelectIdDonante_Click;
            // 
            // cboxDonacionTipoMoneda
            // 
            cboxDonacionTipoMoneda.FormattingEnabled = true;
            cboxDonacionTipoMoneda.Location = new Point(171, 438);
            cboxDonacionTipoMoneda.Name = "cboxDonacionTipoMoneda";
            cboxDonacionTipoMoneda.Size = new Size(185, 31);
            cboxDonacionTipoMoneda.TabIndex = 30;
            // 
            // cboxDonacionTipoTrans
            // 
            cboxDonacionTipoTrans.FormattingEnabled = true;
            cboxDonacionTipoTrans.Location = new Point(171, 364);
            cboxDonacionTipoTrans.Name = "cboxDonacionTipoTrans";
            cboxDonacionTipoTrans.Size = new Size(185, 31);
            cboxDonacionTipoTrans.TabIndex = 29;
            // 
            // cboxDonacionFrecuencia
            // 
            cboxDonacionFrecuencia.FormattingEnabled = true;
            cboxDonacionFrecuencia.Location = new Point(171, 401);
            cboxDonacionFrecuencia.Name = "cboxDonacionFrecuencia";
            cboxDonacionFrecuencia.Size = new Size(185, 31);
            cboxDonacionFrecuencia.TabIndex = 28;
            // 
            // lblDonacionMoneda
            // 
            lblDonacionMoneda.AutoSize = true;
            lblDonacionMoneda.Location = new Point(79, 442);
            lblDonacionMoneda.Name = "lblDonacionMoneda";
            lblDonacionMoneda.Size = new Size(86, 23);
            lblDonacionMoneda.TabIndex = 24;
            lblDonacionMoneda.Text = "MONEDA";
            // 
            // lblDonacionFrecuencia
            // 
            lblDonacionFrecuencia.AutoSize = true;
            lblDonacionFrecuencia.Location = new Point(51, 404);
            lblDonacionFrecuencia.Name = "lblDonacionFrecuencia";
            lblDonacionFrecuencia.Size = new Size(113, 23);
            lblDonacionFrecuencia.TabIndex = 22;
            lblDonacionFrecuencia.Text = "FRECUENCIA";
            // 
            // lblDonacionTipoTrans
            // 
            lblDonacionTipoTrans.AutoSize = true;
            lblDonacionTipoTrans.Location = new Point(32, 367);
            lblDonacionTipoTrans.Name = "lblDonacionTipoTrans";
            lblDonacionTipoTrans.Size = new Size(133, 23);
            lblDonacionTipoTrans.TabIndex = 20;
            lblDonacionTipoTrans.Text = "TIPO TRANSAC";
            // 
            // cboxDonacionIdTipoDonacion
            // 
            cboxDonacionIdTipoDonacion.FormattingEnabled = true;
            cboxDonacionIdTipoDonacion.Location = new Point(171, 182);
            cboxDonacionIdTipoDonacion.Name = "cboxDonacionIdTipoDonacion";
            cboxDonacionIdTipoDonacion.Size = new Size(185, 31);
            cboxDonacionIdTipoDonacion.TabIndex = 19;
            cboxDonacionIdTipoDonacion.SelectedIndexChanged += cboxDonacionIdTipoDonacion_SelectedIndexChanged;
            // 
            // datepkDonacionFecha
            // 
            datepkDonacionFecha.Font = new Font("Bell MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            datepkDonacionFecha.Format = DateTimePickerFormat.Short;
            datepkDonacionFecha.Location = new Point(171, 219);
            datepkDonacionFecha.Name = "datepkDonacionFecha";
            datepkDonacionFecha.Size = new Size(185, 27);
            datepkDonacionFecha.TabIndex = 11;
            // 
            // txtbxDonacionObservaciones
            // 
            txtbxDonacionObservaciones.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonacionObservaciones.Location = new Point(171, 254);
            txtbxDonacionObservaciones.Multiline = true;
            txtbxDonacionObservaciones.Name = "txtbxDonacionObservaciones";
            txtbxDonacionObservaciones.Size = new Size(185, 71);
            txtbxDonacionObservaciones.TabIndex = 17;
            // 
            // lblDonacionObserv
            // 
            lblDonacionObserv.AutoSize = true;
            lblDonacionObserv.Location = new Point(18, 254);
            lblDonacionObserv.Name = "lblDonacionObserv";
            lblDonacionObserv.Size = new Size(147, 23);
            lblDonacionObserv.TabIndex = 16;
            lblDonacionObserv.Text = "OBSERVACIONES";
            // 
            // txtbxDonacionMonto
            // 
            txtbxDonacionMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonacionMonto.Location = new Point(171, 331);
            txtbxDonacionMonto.Name = "txtbxDonacionMonto";
            txtbxDonacionMonto.Size = new Size(185, 27);
            txtbxDonacionMonto.TabIndex = 15;
            // 
            // lblDonacionMonto
            // 
            lblDonacionMonto.AutoSize = true;
            lblDonacionMonto.Location = new Point(90, 332);
            lblDonacionMonto.Name = "lblDonacionMonto";
            lblDonacionMonto.Size = new Size(75, 23);
            lblDonacionMonto.TabIndex = 14;
            lblDonacionMonto.Text = "MONTO";
            // 
            // lblDonacionFecha
            // 
            lblDonacionFecha.AutoSize = true;
            lblDonacionFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDonacionFecha.Location = new Point(21, 223);
            lblDonacionFecha.Name = "lblDonacionFecha";
            lblDonacionFecha.Size = new Size(144, 20);
            lblDonacionFecha.TabIndex = 10;
            lblDonacionFecha.Text = "FECHA DONACION";
            // 
            // lblDonacionIdTipoDonacion
            // 
            lblDonacionIdTipoDonacion.AutoSize = true;
            lblDonacionIdTipoDonacion.Location = new Point(16, 185);
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
            txtbxDonacionDonanteID.Size = new Size(114, 27);
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
            // 
            // txtbxDonacionTipoIdDonante
            // 
            txtbxDonacionTipoIdDonante.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxDonacionTipoIdDonante.Location = new Point(171, 118);
            txtbxDonacionTipoIdDonante.Name = "txtbxDonacionTipoIdDonante";
            txtbxDonacionTipoIdDonante.Size = new Size(185, 27);
            txtbxDonacionTipoIdDonante.TabIndex = 32;
            // 
            // frmDonacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 639);
            Controls.Add(lblCrearDonacion);
            Controls.Add(btnEliminarDonacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarDonacion);
            Controls.Add(gbxDatosDonacion);
            Controls.Add(lblCrearDonante);
            Name = "frmDonacion";
            Text = "MANTENIMIENTO DONACION";
            Load += frmDonacion_Load;
            gbxDatosDonacion.ResumeLayout(false);
            gbxDatosDonacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEliminarDonacion;
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
        private Label lblDonateAp2;
        private Label lblDonacionIdTipoDonacion;
        private TextBox txtbxDonacionID;
        private Label lblDonacionID;
        private Label lblCrearDonante;
        private TextBox txtbxDonacionDonanteID;
        private Label lblDonacionDonanteID;
        private Label lblCrearDonacion;
        private ComboBox cboxDonacionIdTipoDonacion;
        private Label lblDonacionMoneda;
        private Label label4;
        private TextBox textBox2;
        private Label label2;
        private Label lblDonacionTipoTrans;
        private Label lblDonacionFrecuencia;
        private ComboBox cboxDonacionFrecuencia;
        private ComboBox cboxDonacionTipoMoneda;
        private ComboBox cboxDonacionTipoTrans;
        private Button btnDonacionSelectIdDonante;
        private Label lblTipoIdDonante;
        private TextBox txtbxDonacionTipoIdDonante;
    }
}