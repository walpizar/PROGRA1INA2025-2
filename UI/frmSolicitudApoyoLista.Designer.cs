
namespace UI
{
    partial class frmSolicitudApoyoLista
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            btnNuevaSolicitud = new Button();
            gbxListaSolicitudes = new GroupBox();
            lblBusqueda = new Label();
            txtBusqueda = new TextBox();
            lstvSolicitudes = new ListView();
            colId = new ColumnHeader();
            colPaciente = new ColumnHeader();
            colJustificacion = new ColumnHeader();
            colEquipos = new ColumnHeader();
            colEstado = new ColumnHeader();
            colFecha = new ColumnHeader(); // NUEVA COLUMNA
            lblTitulo = new Label();
            gbxListaSolicitudes.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevaSolicitud
            // 
            btnNuevaSolicitud.BackColor = SystemColors.ActiveCaption;
            btnNuevaSolicitud.ForeColor = Color.White;
            btnNuevaSolicitud.Location = new Point(504, 24);
            btnNuevaSolicitud.Name = "btnNuevaSolicitud";
            btnNuevaSolicitud.Size = new Size(119, 36);
            btnNuevaSolicitud.Text = "Nueva solicitud";
            btnNuevaSolicitud.UseVisualStyleBackColor = false;
            btnNuevaSolicitud.Click += btnNuevaSolicitud_Click;
            // 
            // gbxListaSolicitudes
            // 
            gbxListaSolicitudes.BackColor = SystemColors.Control;
            gbxListaSolicitudes.Controls.Add(lblBusqueda);
            gbxListaSolicitudes.Controls.Add(txtBusqueda);
            gbxListaSolicitudes.Controls.Add(lstvSolicitudes);
            gbxListaSolicitudes.Location = new Point(21, 72);
            gbxListaSolicitudes.Name = "gbxListaSolicitudes";
            gbxListaSolicitudes.Size = new Size(750, 360);
            gbxListaSolicitudes.TabStop = false;
            gbxListaSolicitudes.Text = "Lista de Solicitudes de Apoyo";
            // 
            // lblBusqueda
            // 
            lblBusqueda.AutoSize = true;
            lblBusqueda.Location = new Point(14, 24);
            lblBusqueda.Name = "lblBusqueda";
            lblBusqueda.Text = "Búsqueda:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(14, 42);
            txtBusqueda.Size = new Size(720, 23);
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
            // 
            // lstvSolicitudes
            // 
            lstvSolicitudes.Columns.AddRange(new ColumnHeader[] {
        colId, colPaciente, colJustificacion, colEquipos, colEstado, colFecha
    });
            lstvSolicitudes.FullRowSelect = true;
            lstvSolicitudes.GridLines = true;
            lstvSolicitudes.Location = new Point(14, 72);
            lstvSolicitudes.MultiSelect = false;
            lstvSolicitudes.Size = new Size(720, 278);
            lstvSolicitudes.UseCompatibleStateImageBehavior = false;
            lstvSolicitudes.View = View.Details;
            lstvSolicitudes.MouseDoubleClick += lstvSolicitudes_MouseDoubleClick;
            // 
            // Columnas
            // 
            colId.Text = "ID Solicitud";
            colId.Width = 100;
            colPaciente.Text = "Paciente";
            colPaciente.Width = 150;
            colJustificacion.Text = "Justificación";
            colJustificacion.Width = 200;
            colEquipos.Text = "Equipos Necesarios";
            colEquipos.Width = 150;
            colEstado.Text = "Estado";
            colEstado.Width = 100;
            colFecha.Text = "Fecha de creación";
            colFecha.Width = 120;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(21, 24);
            lblTitulo.Text = "Administración de solicitudes";
            // 
            // frmSolicitudApoyoLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNuevaSolicitud);
            Controls.Add(gbxListaSolicitudes);
            Controls.Add(lblTitulo);
            Name = "frmSolicitudApoyoLista";
            Text = "Lista de Solicitudes de Apoyo";
            Load += frmSolicitudApoyoLista_Load;
            gbxListaSolicitudes.ResumeLayout(false);
            gbxListaSolicitudes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Button btnNuevaSolicitud;
        private GroupBox gbxListaSolicitudes;
        private Label lblBusqueda;
        private TextBox txtBusqueda;
        private ListView lstvSolicitudes;
        private ColumnHeader colId;
        private ColumnHeader colPaciente;
        private ColumnHeader colJustificacion;
        private ColumnHeader colEquipos;
        private ColumnHeader colEstado;
        private ColumnHeader colFecha;
        private Label lblTitulo;
    }
}
