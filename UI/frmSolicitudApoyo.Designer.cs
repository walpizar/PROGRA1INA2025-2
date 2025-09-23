
namespace UI
{
    partial class frmSolicitudApoyo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Limpiar recursos usados.
        /// </summary>
        /// <param name="disposing">true si se deben liberar los recursos; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            gbxDatosSolicitud = new GroupBox();
            txtIdSolicitud = new TextBox();
            lblIdSolicitud = new Label();
            txtIDPaciente = new TextBox();
            lblPaciente = new Label();
            btnBuscarPaciente = new Button();
            lblReferencia = new Label();
            btnAdjuntarReferencia = new Button();
            lblEstudio = new Label();
            btnAdjuntarEstudio = new Button();
            lblJustificacion = new Label();
            txtJustificacion = new TextBox();
            lblEquipos = new Label();
            txtEquipos = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            gbxDatosSolicitud.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitulo.Location = new Point(300, 20);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(300, 45);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Solicitud de apoyo";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // gbxDatosSolicitud
            // 
            gbxDatosSolicitud.Controls.Add(txtIdSolicitud);
            gbxDatosSolicitud.Controls.Add(lblIdSolicitud);
            gbxDatosSolicitud.Controls.Add(txtIDPaciente);
            gbxDatosSolicitud.Controls.Add(lblPaciente);
            gbxDatosSolicitud.Controls.Add(btnBuscarPaciente);
            gbxDatosSolicitud.Controls.Add(lblReferencia);
            gbxDatosSolicitud.Controls.Add(btnAdjuntarReferencia);
            gbxDatosSolicitud.Controls.Add(lblEstudio);
            gbxDatosSolicitud.Controls.Add(btnAdjuntarEstudio);
            gbxDatosSolicitud.Controls.Add(lblJustificacion);
            gbxDatosSolicitud.Controls.Add(txtJustificacion);
            gbxDatosSolicitud.Controls.Add(lblEquipos);
            gbxDatosSolicitud.Controls.Add(txtEquipos);
            gbxDatosSolicitud.Location = new Point(25, 88);
            gbxDatosSolicitud.Margin = new Padding(4, 4, 4, 4);
            gbxDatosSolicitud.Name = "gbxDatosSolicitud";
            gbxDatosSolicitud.Padding = new Padding(4, 4, 4, 4);
            gbxDatosSolicitud.Size = new Size(812, 538);
            gbxDatosSolicitud.TabIndex = 0;
            gbxDatosSolicitud.TabStop = false;
            gbxDatosSolicitud.Text = "Datos de Solicitud";
            // 
            // txtIdSolicitud
            // 
            txtIdSolicitud.Location = new Point(162, 46);
            txtIdSolicitud.Margin = new Padding(4, 4, 4, 4);
            txtIdSolicitud.Name = "txtIdSolicitud";
            txtIdSolicitud.Size = new Size(149, 31);
            txtIdSolicitud.TabIndex = 0;
            // 
            // lblIdSolicitud
            // 
            lblIdSolicitud.AutoSize = true;
            lblIdSolicitud.Location = new Point(38, 50);
            lblIdSolicitud.Margin = new Padding(4, 0, 4, 0);
            lblIdSolicitud.Name = "lblIdSolicitud";
            lblIdSolicitud.Size = new Size(107, 25);
            lblIdSolicitud.TabIndex = 1;
            lblIdSolicitud.Text = "ID Solicitud:";
            // 
            // txtIDPaciente
            // 
            txtIDPaciente.Location = new Point(162, 102);
            txtIDPaciente.Margin = new Padding(4, 4, 4, 4);
            txtIDPaciente.Name = "txtIDPaciente";
            txtIDPaciente.Size = new Size(349, 31);
            txtIDPaciente.TabIndex = 2;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(38, 106);
            lblPaciente.Margin = new Padding(4, 0, 4, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(103, 25);
            lblPaciente.TabIndex = 3;
            lblPaciente.Text = "ID Paciente:";
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Location = new Point(525, 100);
            btnBuscarPaciente.Margin = new Padding(4, 4, 4, 4);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(88, 38);
            btnBuscarPaciente.TabIndex = 4;
            btnBuscarPaciente.Text = "Buscar";
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Location = new Point(38, 162);
            lblReferencia.Margin = new Padding(4, 0, 4, 0);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(143, 25);
            lblReferencia.TabIndex = 5;
            lblReferencia.Text = "Referencia CCSS:";
            // 
            // btnAdjuntarReferencia
            // 
            btnAdjuntarReferencia.Location = new Point(225, 156);
            btnAdjuntarReferencia.Margin = new Padding(4, 4, 4, 4);
            btnAdjuntarReferencia.Name = "btnAdjuntarReferencia";
            btnAdjuntarReferencia.Size = new Size(112, 38);
            btnAdjuntarReferencia.TabIndex = 6;
            btnAdjuntarReferencia.Text = "Adjuntar";
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.Location = new Point(38, 219);
            lblEstudio.Margin = new Padding(4, 0, 4, 0);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(212, 25);
            lblEstudio.TabIndex = 7;
            lblEstudio.Text = "Estudio Socioeconómico:";
            // 
            // btnAdjuntarEstudio
            // 
            btnAdjuntarEstudio.Location = new Point(288, 212);
            btnAdjuntarEstudio.Margin = new Padding(4, 4, 4, 4);
            btnAdjuntarEstudio.Name = "btnAdjuntarEstudio";
            btnAdjuntarEstudio.Size = new Size(112, 38);
            btnAdjuntarEstudio.TabIndex = 8;
            btnAdjuntarEstudio.Text = "Adjuntar";
            // 
            // lblJustificacion
            // 
            lblJustificacion.AutoSize = true;
            lblJustificacion.Location = new Point(38, 275);
            lblJustificacion.Margin = new Padding(4, 0, 4, 0);
            lblJustificacion.Name = "lblJustificacion";
            lblJustificacion.Size = new Size(110, 25);
            lblJustificacion.TabIndex = 9;
            lblJustificacion.Text = "Justificación:";
            // 
            // txtJustificacion
            // 
            txtJustificacion.Location = new Point(188, 275);
            txtJustificacion.Margin = new Padding(4, 4, 4, 4);
            txtJustificacion.Multiline = true;
            txtJustificacion.Name = "txtJustificacion";
            txtJustificacion.Size = new Size(524, 86);
            txtJustificacion.TabIndex = 10;
            // 
            // lblEquipos
            // 
            lblEquipos.AutoSize = true;
            lblEquipos.Location = new Point(38, 388);
            lblEquipos.Margin = new Padding(4, 0, 4, 0);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(170, 25);
            lblEquipos.TabIndex = 11;
            lblEquipos.Text = "Equipos requeridos:";
            // 
            // txtEquipos
            // 
            txtEquipos.Location = new Point(238, 388);
            txtEquipos.Margin = new Padding(4, 4, 4, 4);
            txtEquipos.Multiline = true;
            txtEquipos.Name = "txtEquipos";
            txtEquipos.Size = new Size(474, 86);
            txtEquipos.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(225, 650);
            btnGuardar.Margin = new Padding(4, 4, 4, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(175, 56);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Orange;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(425, 650);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(175, 56);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmSolicitudApoyo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 750);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosSolicitud);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmSolicitudApoyo";
            Text = "Solicitud de Apoyo";
            gbxDatosSolicitud.ResumeLayout(false);
            gbxDatosSolicitud.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lblTitulo;
        private GroupBox gbxDatosSolicitud;

        private Label lblIdSolicitud;
        private TextBox txtIdSolicitud;

        private Label lblPaciente;
        private TextBox txtIDPaciente;
        private Button btnBuscarPaciente;

        private Label lblReferencia;
        private Button btnAdjuntarReferencia;

        private Label lblEstudio;
        private Button btnAdjuntarEstudio;

        private Label lblJustificacion;
        private TextBox txtJustificacion;

        private Label lblEquipos;
        private TextBox txtEquipos;

        private Button btnGuardar;
        private Button btnCancelar;
    }
}
