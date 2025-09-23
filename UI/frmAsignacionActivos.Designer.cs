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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignacionActivos));
            gbxPaciente = new GroupBox();
            lblAsigActivosTitulo = new Label();
            lblPacienteAsig = new Label();
            txtPacienteAsig = new TextBox();
            btnLupaPaciente = new Button();
            gbxActivoAsig = new GroupBox();
            btnLupaActivo = new Button();
            txtActivoAsig = new TextBox();
            lblActivoAsig = new Label();
            btnAgregarActivo = new Button();
            groupBox1 = new GroupBox();
            ColEstado = new DataGridViewTextBoxColumn();
            ColDescripcioon = new DataGridViewTextBoxColumn();
            colIdActivo = new DataGridViewTextBoxColumn();
            dgvActivosAsig = new DataGridView();
            button1 = new Button();
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
            gbxPaciente.Location = new Point(12, 59);
            gbxPaciente.Name = "gbxPaciente";
            gbxPaciente.Size = new Size(488, 70);
            gbxPaciente.TabIndex = 0;
            gbxPaciente.TabStop = false;
            gbxPaciente.Text = "Paciente Asignado";
            // 
            // lblAsigActivosTitulo
            // 
            lblAsigActivosTitulo.AutoSize = true;
            lblAsigActivosTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsigActivosTitulo.Location = new Point(168, 9);
            lblAsigActivosTitulo.Name = "lblAsigActivosTitulo";
            lblAsigActivosTitulo.Size = new Size(200, 30);
            lblAsigActivosTitulo.TabIndex = 1;
            lblAsigActivosTitulo.Text = "Asignacion Activos";
            // 
            // lblPacienteAsig
            // 
            lblPacienteAsig.AutoSize = true;
            lblPacienteAsig.Location = new Point(19, 30);
            lblPacienteAsig.Name = "lblPacienteAsig";
            lblPacienteAsig.Size = new Size(55, 15);
            lblPacienteAsig.TabIndex = 0;
            lblPacienteAsig.Text = "Paciente:";
            // 
            // txtPacienteAsig
            // 
            txtPacienteAsig.Location = new Point(80, 27);
            txtPacienteAsig.Name = "txtPacienteAsig";
            txtPacienteAsig.ReadOnly = true;
            txtPacienteAsig.Size = new Size(331, 23);
            txtPacienteAsig.TabIndex = 1;
            // 
            // btnLupaPaciente
            // 
            btnLupaPaciente.FlatStyle = FlatStyle.Flat;
            btnLupaPaciente.Image = (Image)resources.GetObject("btnLupaPaciente.Image");
            btnLupaPaciente.Location = new Point(417, 27);
            btnLupaPaciente.Name = "btnLupaPaciente";
            btnLupaPaciente.Size = new Size(23, 23);
            btnLupaPaciente.TabIndex = 2;
            btnLupaPaciente.UseVisualStyleBackColor = true;
            // 
            // gbxActivoAsig
            // 
            gbxActivoAsig.Controls.Add(btnAgregarActivo);
            gbxActivoAsig.Controls.Add(btnLupaActivo);
            gbxActivoAsig.Controls.Add(txtActivoAsig);
            gbxActivoAsig.Controls.Add(lblActivoAsig);
            gbxActivoAsig.Location = new Point(12, 135);
            gbxActivoAsig.Name = "gbxActivoAsig";
            gbxActivoAsig.Size = new Size(488, 70);
            gbxActivoAsig.TabIndex = 2;
            gbxActivoAsig.TabStop = false;
            gbxActivoAsig.Text = "Activo Asignado";
            // 
            // btnLupaActivo
            // 
            btnLupaActivo.FlatStyle = FlatStyle.Flat;
            btnLupaActivo.Image = (Image)resources.GetObject("btnLupaActivo.Image");
            btnLupaActivo.Location = new Point(417, 27);
            btnLupaActivo.Name = "btnLupaActivo";
            btnLupaActivo.Size = new Size(23, 23);
            btnLupaActivo.TabIndex = 2;
            btnLupaActivo.UseVisualStyleBackColor = true;
            // 
            // txtActivoAsig
            // 
            txtActivoAsig.Location = new Point(80, 27);
            txtActivoAsig.Name = "txtActivoAsig";
            txtActivoAsig.ReadOnly = true;
            txtActivoAsig.Size = new Size(331, 23);
            txtActivoAsig.TabIndex = 1;
            // 
            // lblActivoAsig
            // 
            lblActivoAsig.AutoSize = true;
            lblActivoAsig.Location = new Point(30, 31);
            lblActivoAsig.Name = "lblActivoAsig";
            lblActivoAsig.Size = new Size(44, 15);
            lblActivoAsig.TabIndex = 0;
            lblActivoAsig.Text = "Activo:";
            // 
            // btnAgregarActivo
            // 
            btnAgregarActivo.FlatStyle = FlatStyle.Flat;
            btnAgregarActivo.Image = (Image)resources.GetObject("btnAgregarActivo.Image");
            btnAgregarActivo.Location = new Point(449, 27);
            btnAgregarActivo.Name = "btnAgregarActivo";
            btnAgregarActivo.Size = new Size(23, 23);
            btnAgregarActivo.TabIndex = 3;
            btnAgregarActivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dgvActivosAsig);
            groupBox1.Location = new Point(12, 211);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 212);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Activos Asignados";
            // 
            // ColEstado
            // 
            ColEstado.HeaderText = "Estado";
            ColEstado.Name = "ColEstado";
            ColEstado.Width = 120;
            // 
            // ColDescripcioon
            // 
            ColDescripcioon.HeaderText = "Descripcion";
            ColDescripcioon.Name = "ColDescripcioon";
            ColDescripcioon.Width = 235;
            // 
            // colIdActivo
            // 
            colIdActivo.HeaderText = "ID Activo";
            colIdActivo.Name = "colIdActivo";
            colIdActivo.Width = 78;
            // 
            // dgvActivosAsig
            // 
            dgvActivosAsig.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivosAsig.Columns.AddRange(new DataGridViewColumn[] { colIdActivo, ColDescripcioon, ColEstado });
            dgvActivosAsig.Location = new Point(6, 22);
            dgvActivosAsig.MultiSelect = false;
            dgvActivosAsig.Name = "dgvActivosAsig";
            dgvActivosAsig.Size = new Size(476, 150);
            dgvActivosAsig.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(307, 179);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // frmAsignacionActivos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 513);
            Controls.Add(groupBox1);
            Controls.Add(gbxActivoAsig);
            Controls.Add(lblAsigActivosTitulo);
            Controls.Add(gbxPaciente);
            Name = "frmAsignacionActivos";
            Text = "Asignacion: Activos";
            gbxPaciente.ResumeLayout(false);
            gbxPaciente.PerformLayout();
            gbxActivoAsig.ResumeLayout(false);
            gbxActivoAsig.PerformLayout();
            groupBox1.ResumeLayout(false);
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
        private Button button1;
        private DataGridView dgvActivosAsig;
        private DataGridViewTextBoxColumn colIdActivo;
        private DataGridViewTextBoxColumn ColDescripcioon;
        private DataGridViewTextBoxColumn ColEstado;
    }
}