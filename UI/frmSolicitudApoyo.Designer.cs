

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
            lblPacienteEncontrado = new Label();
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
            btnEliminar = new Button();
            gbxDatosSolicitud.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitulo.Location = new Point(210, 12);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 30);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Solicitud de apoyo";
            // 
            // gbxDatosSolicitud
            // 
            gbxDatosSolicitud.Controls.Add(lblPacienteEncontrado);
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
            gbxDatosSolicitud.Location = new Point(18, 53);
            gbxDatosSolicitud.Margin = new Padding(2);
            gbxDatosSolicitud.Name = "gbxDatosSolicitud";
            gbxDatosSolicitud.Padding = new Padding(2);
            gbxDatosSolicitud.Size = new Size(568, 323);
            gbxDatosSolicitud.TabIndex = 0;
            gbxDatosSolicitud.TabStop = false;
            gbxDatosSolicitud.Text = "Datos de Solicitud";
            // 
            // lblPacienteEncontrado
            // 
            lblPacienteEncontrado.AutoSize = true;
            lblPacienteEncontrado.ForeColor = Color.Black;
            lblPacienteEncontrado.Location = new Point(440, 64);
            lblPacienteEncontrado.Margin = new Padding(2, 0, 2, 0);
            lblPacienteEncontrado.Name = "lblPacienteEncontrado";
            lblPacienteEncontrado.Size = new Size(0, 15);
            lblPacienteEncontrado.TabIndex = 13;
            // 
            // txtIdSolicitud
            // 
            txtIdSolicitud.Location = new Point(113, 28);
            txtIdSolicitud.Margin = new Padding(2);
            txtIdSolicitud.Name = "txtIdSolicitud";
            txtIdSolicitud.Size = new Size(106, 23);
            txtIdSolicitud.TabIndex = 0;
            // 
            // lblIdSolicitud
            // 
            lblIdSolicitud.AutoSize = true;
            lblIdSolicitud.Location = new Point(27, 30);
            lblIdSolicitud.Margin = new Padding(2, 0, 2, 0);
            lblIdSolicitud.Name = "lblIdSolicitud";
            lblIdSolicitud.Size = new Size(70, 15);
            lblIdSolicitud.TabIndex = 1;
            lblIdSolicitud.Text = "ID Solicitud:";
            // 
            // txtIDPaciente
            // 
            txtIDPaciente.Location = new Point(113, 61);
            txtIDPaciente.Margin = new Padding(2);
            txtIDPaciente.Name = "txtIDPaciente";
            txtIDPaciente.Size = new Size(246, 23);
            txtIDPaciente.TabIndex = 2;
            // 
            // lblPaciente
            // 
            lblPaciente.AutoSize = true;
            lblPaciente.Location = new Point(27, 64);
            lblPaciente.Margin = new Padding(2, 0, 2, 0);
            lblPaciente.Name = "lblPaciente";
            lblPaciente.Size = new Size(69, 15);
            lblPaciente.TabIndex = 3;
            lblPaciente.Text = "ID Paciente:";
            // 
            // btnBuscarPaciente
            // 
            btnBuscarPaciente.Location = new Point(368, 60);
            btnBuscarPaciente.Margin = new Padding(2);
            btnBuscarPaciente.Name = "btnBuscarPaciente";
            btnBuscarPaciente.Size = new Size(62, 23);
            btnBuscarPaciente.TabIndex = 4;
            btnBuscarPaciente.Text = "Buscar";
            btnBuscarPaciente.UseVisualStyleBackColor = true;
            btnBuscarPaciente.Click += btnBuscarPaciente_Click;
            // 
            // lblReferencia
            // 
            lblReferencia.AutoSize = true;
            lblReferencia.Location = new Point(27, 97);
            lblReferencia.Margin = new Padding(2, 0, 2, 0);
            lblReferencia.Name = "lblReferencia";
            lblReferencia.Size = new Size(96, 15);
            lblReferencia.TabIndex = 5;
            lblReferencia.Text = "Referencia CCSS:";
            // 
            // btnAdjuntarReferencia
            // 
            btnAdjuntarReferencia.Location = new Point(158, 94);
            btnAdjuntarReferencia.Margin = new Padding(2);
            btnAdjuntarReferencia.Name = "btnAdjuntarReferencia";
            btnAdjuntarReferencia.Size = new Size(78, 23);
            btnAdjuntarReferencia.TabIndex = 6;
            btnAdjuntarReferencia.Text = "Adjuntar";
            btnAdjuntarReferencia.UseVisualStyleBackColor = true;
            // 
            // lblEstudio
            // 
            lblEstudio.AutoSize = true;
            lblEstudio.Location = new Point(27, 131);
            lblEstudio.Margin = new Padding(2, 0, 2, 0);
            lblEstudio.Name = "lblEstudio";
            lblEstudio.Size = new Size(141, 15);
            lblEstudio.TabIndex = 7;
            lblEstudio.Text = "Estudio Socioeconómico:";
            // 
            // btnAdjuntarEstudio
            // 
            btnAdjuntarEstudio.Location = new Point(202, 127);
            btnAdjuntarEstudio.Margin = new Padding(2);
            btnAdjuntarEstudio.Name = "btnAdjuntarEstudio";
            btnAdjuntarEstudio.Size = new Size(78, 23);
            btnAdjuntarEstudio.TabIndex = 8;
            btnAdjuntarEstudio.Text = "Adjuntar";
            btnAdjuntarEstudio.UseVisualStyleBackColor = true;
            // 
            // lblJustificacion
            // 
            lblJustificacion.AutoSize = true;
            lblJustificacion.Location = new Point(27, 165);
            lblJustificacion.Margin = new Padding(2, 0, 2, 0);
            lblJustificacion.Name = "lblJustificacion";
            lblJustificacion.Size = new Size(75, 15);
            lblJustificacion.TabIndex = 9;
            lblJustificacion.Text = "Justificación:";
            // 
            // txtJustificacion
            // 
            txtJustificacion.Location = new Point(132, 165);
            txtJustificacion.Margin = new Padding(2);
            txtJustificacion.Multiline = true;
            txtJustificacion.Name = "txtJustificacion";
            txtJustificacion.Size = new Size(368, 53);
            txtJustificacion.TabIndex = 10;
            // 
            // lblEquipos
            // 
            lblEquipos.AutoSize = true;
            lblEquipos.Location = new Point(27, 233);
            lblEquipos.Margin = new Padding(2, 0, 2, 0);
            lblEquipos.Name = "lblEquipos";
            lblEquipos.Size = new Size(111, 15);
            lblEquipos.TabIndex = 11;
            lblEquipos.Text = "Equipos requeridos:";
            // 
            // txtEquipos
            // 
            txtEquipos.Location = new Point(167, 233);
            txtEquipos.Margin = new Padding(2);
            txtEquipos.Multiline = true;
            txtEquipos.Name = "txtEquipos";
            txtEquipos.Size = new Size(333, 53);
            txtEquipos.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(158, 390);
            btnGuardar.Margin = new Padding(2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(122, 34);
            btnGuardar.TabIndex = 0;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Orange;
            btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(298, 390);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(122, 34);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(438, 390);
            btnEliminar.Margin = new Padding(2);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(122, 34);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmSolicitudApoyo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosSolicitud);
            Margin = new Padding(2);
            Name = "frmSolicitudApoyo";
            Text = "Solicitud de Apoyo";
            Load += frmSolicitudApoyo_Load;
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
        private Button btnEliminar;
        private Label lblPacienteEncontrado;
    }
}
