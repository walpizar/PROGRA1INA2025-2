namespace UI
{
    partial class frmAsignacionActivos
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacionActivos));
            gbxPaciente = new GroupBox();
            btnLupaPaciente = new Button();
            txtPacienteAsig = new TextBox();
            lblPacienteAsig = new Label();
            lblAsigActivosTitulo = new Label();
            gbxActivoAsig = new GroupBox();
            btnAgregarActivo = new Button();
            btnLupaActivo = new Button();
            txtActivoAsig = new TextBox();
            lblActivoAsig = new Label();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            lblFechaAsignacion = new Label();
            btnQuitar = new Button();
            dgvActivosAsig = new DataGridView();
            colIdActivo = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColDescripcioon = new DataGridViewTextBoxColumn();
            btnCancelar = new Button();
            btnAceptar = new Button();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            toolTip3 = new ToolTip(components);
            gbxPaciente.SuspendLayout();
            gbxActivoAsig.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivosAsig).BeginInit();
            SuspendLayout();
            // 
            // gbxPaciente
            // 
            gbxPaciente.Controls.Add(btnLupaPaciente);
            gbxPaciente.Controls.Add(txtPacienteAsig);
            gbxPaciente.Controls.Add(lblPacienteAsig);
            gbxPaciente.Location = new Point(13, 59);
            gbxPaciente.Name = "gbxPaciente";
            gbxPaciente.Size = new Size(500, 70);
            gbxPaciente.TabIndex = 0;
            gbxPaciente.TabStop = false;
            gbxPaciente.Text = "Paciente Asignado";
            // 
            // btnLupaPaciente
            // 
            btnLupaPaciente.FlatAppearance.BorderColor = SystemColors.Control;
            btnLupaPaciente.FlatStyle = FlatStyle.Flat;
            btnLupaPaciente.Image = (Image)resources.GetObject("btnLupaPaciente.Image");
            btnLupaPaciente.Location = new Point(433, 31);
            btnLupaPaciente.Name = "btnLupaPaciente";
            btnLupaPaciente.Size = new Size(23, 23);
            btnLupaPaciente.TabIndex = 2;
            toolTip1.SetToolTip(btnLupaPaciente, "Buscar Paciente");
            btnLupaPaciente.UseVisualStyleBackColor = true;
            btnLupaPaciente.Click += btnLupaPaciente_Click;
            // 
            // txtPacienteAsig
            // 
            txtPacienteAsig.Location = new Point(72, 31);
            txtPacienteAsig.Name = "txtPacienteAsig";
            txtPacienteAsig.ReadOnly = true;
            txtPacienteAsig.Size = new Size(355, 23);
            txtPacienteAsig.TabIndex = 1;
            // 
            // lblPacienteAsig
            // 
            lblPacienteAsig.AutoSize = true;
            lblPacienteAsig.Location = new Point(11, 34);
            lblPacienteAsig.Name = "lblPacienteAsig";
            lblPacienteAsig.Size = new Size(55, 15);
            lblPacienteAsig.TabIndex = 0;
            lblPacienteAsig.Text = "Paciente:";
            // 
            // lblAsigActivosTitulo
            // 
            lblAsigActivosTitulo.AutoSize = true;
            lblAsigActivosTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsigActivosTitulo.Location = new Point(169, 9);
            lblAsigActivosTitulo.Name = "lblAsigActivosTitulo";
            lblAsigActivosTitulo.Size = new Size(200, 30);
            lblAsigActivosTitulo.TabIndex = 1;
            lblAsigActivosTitulo.Text = "Asignacion Activos";
            // 
            // gbxActivoAsig
            // 
            gbxActivoAsig.Controls.Add(btnAgregarActivo);
            gbxActivoAsig.Controls.Add(btnLupaActivo);
            gbxActivoAsig.Controls.Add(txtActivoAsig);
            gbxActivoAsig.Controls.Add(lblActivoAsig);
            gbxActivoAsig.Location = new Point(13, 135);
            gbxActivoAsig.Name = "gbxActivoAsig";
            gbxActivoAsig.Size = new Size(500, 70);
            gbxActivoAsig.TabIndex = 2;
            gbxActivoAsig.TabStop = false;
            gbxActivoAsig.Text = "Activo Asignado";
            // 
            // btnAgregarActivo
            // 
            btnAgregarActivo.FlatAppearance.BorderColor = SystemColors.Control;
            btnAgregarActivo.FlatStyle = FlatStyle.Flat;
            btnAgregarActivo.Image = (Image)resources.GetObject("btnAgregarActivo.Image");
            btnAgregarActivo.Location = new Point(462, 32);
            btnAgregarActivo.Name = "btnAgregarActivo";
            btnAgregarActivo.Size = new Size(23, 23);
            btnAgregarActivo.TabIndex = 3;
            toolTip3.SetToolTip(btnAgregarActivo, "Agregar Activo");
            btnAgregarActivo.UseVisualStyleBackColor = true;
            // 
            // btnLupaActivo
            // 
            btnLupaActivo.FlatAppearance.BorderColor = SystemColors.Control;
            btnLupaActivo.FlatStyle = FlatStyle.Flat;
            btnLupaActivo.Image = (Image)resources.GetObject("btnLupaActivo.Image");
            btnLupaActivo.Location = new Point(433, 32);
            btnLupaActivo.Name = "btnLupaActivo";
            btnLupaActivo.Size = new Size(23, 23);
            btnLupaActivo.TabIndex = 2;
            toolTip2.SetToolTip(btnLupaActivo, "Buscar Activo");
            btnLupaActivo.UseVisualStyleBackColor = true;
            // 
            // txtActivoAsig
            // 
            txtActivoAsig.Location = new Point(72, 32);
            txtActivoAsig.Name = "txtActivoAsig";
            txtActivoAsig.ReadOnly = true;
            txtActivoAsig.Size = new Size(355, 23);
            txtActivoAsig.TabIndex = 1;
            // 
            // lblActivoAsig
            // 
            lblActivoAsig.AutoSize = true;
            lblActivoAsig.Location = new Point(22, 36);
            lblActivoAsig.Name = "lblActivoAsig";
            lblActivoAsig.Size = new Size(44, 15);
            lblActivoAsig.TabIndex = 0;
            lblActivoAsig.Text = "Activo:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(lblFechaAsignacion);
            groupBox1.Controls.Add(btnQuitar);
            groupBox1.Controls.Add(dgvActivosAsig);
            groupBox1.Location = new Point(13, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 264);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Activos Asignados";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(115, 31);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(312, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // lblFechaAsignacion
            // 
            lblFechaAsignacion.AutoSize = true;
            lblFechaAsignacion.Location = new Point(6, 35);
            lblFechaAsignacion.Name = "lblFechaAsignacion";
            lblFechaAsignacion.Size = new Size(103, 15);
            lblFechaAsignacion.TabIndex = 2;
            lblFechaAsignacion.Text = "Fecha Asignacion:";
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(11, 219);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(113, 36);
            btnQuitar.TabIndex = 1;
            btnQuitar.Text = "Quitar";
            btnQuitar.UseVisualStyleBackColor = true;
            // 
            // dgvActivosAsig
            // 
            dgvActivosAsig.BackgroundColor = SystemColors.Window;
            dgvActivosAsig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivosAsig.Columns.AddRange(new DataGridViewColumn[] { colIdActivo, ColNombre, ColDescripcioon });
            dgvActivosAsig.Location = new Point(11, 67);
            dgvActivosAsig.MultiSelect = false;
            dgvActivosAsig.Name = "dgvActivosAsig";
            dgvActivosAsig.ReadOnly = true;
            dgvActivosAsig.Size = new Size(477, 146);
            dgvActivosAsig.TabIndex = 0;
            // 
            // colIdActivo
            // 
            colIdActivo.HeaderText = "ID Activo";
            colIdActivo.Name = "colIdActivo";
            colIdActivo.ReadOnly = true;
            colIdActivo.Resizable = DataGridViewTriState.False;
            colIdActivo.Width = 78;
            // 
            // ColNombre
            // 
            ColNombre.HeaderText = "Nombre";
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            ColNombre.Width = 120;
            // 
            // ColDescripcioon
            // 
            ColDescripcioon.HeaderText = "Descripcion";
            ColDescripcioon.Name = "ColDescripcioon";
            ColDescripcioon.ReadOnly = true;
            ColDescripcioon.Width = 235;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(234, 494);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 36);
            btnCancelar.TabIndex = 16;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(377, 494);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(124, 36);
            btnAceptar.TabIndex = 15;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAsignacionActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(525, 542);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBox1);
            Controls.Add(gbxActivoAsig);
            Controls.Add(lblAsigActivosTitulo);
            Controls.Add(gbxPaciente);
            Name = "frmAsignacionActivos";
            Text = "Asignacion: Activos";
            Load += frmAsignacionActivos_Load;
            gbxPaciente.ResumeLayout(false);
            gbxPaciente.PerformLayout();
            gbxActivoAsig.ResumeLayout(false);
            gbxActivoAsig.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivosAsig).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbxPaciente;
        private Button btnLupaPaciente;
        private TextBox txtPacienteAsig;
        private Label lblPacienteAsig;
        private Label lblAsigActivosTitulo;
        private GroupBox gbxActivoAsig;
        private Button btnLupaActivo;
        private TextBox txtActivoAsig;
        private Label lblActivoAsig;
        private Button btnAgregarActivo;
        private GroupBox groupBox1;
        private Button btnQuitar;
        private DataGridView dgvActivosAsig;
        private Button btnCancelar;
        private Button btnAceptar;
        private ToolTip toolTip1;
        private ToolTip toolTip3;
        private ToolTip toolTip2;
        private DataGridViewTextBoxColumn colIdActivo;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColDescripcioon;
        private Label lblFechaAsignacion;
        private DateTimePicker dateTimePicker1;
    }
}