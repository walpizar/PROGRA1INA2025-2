using System.Windows.Forms;

namespace UI
{
    partial class frmEspecialidad
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

        /// <summary>
        ///  No modificar con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            gbxDatosEspecialidad = new GroupBox();
            txtDescripcion = new TextBox();
            lblDescripcion = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            txtId = new TextBox();
            lblId = new Label();
            lblTitulo = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            btnEliminar = new Button();
            gbxDatosEspecialidad.SuspendLayout();
            SuspendLayout();
            // 
            // gbxDatosEspecialidad
            // 
            gbxDatosEspecialidad.Controls.Add(txtDescripcion);
            gbxDatosEspecialidad.Controls.Add(lblDescripcion);
            gbxDatosEspecialidad.Controls.Add(txtNombre);
            gbxDatosEspecialidad.Controls.Add(lblNombre);
            gbxDatosEspecialidad.Controls.Add(txtId);
            gbxDatosEspecialidad.Controls.Add(lblId);
            gbxDatosEspecialidad.Location = new Point(17, 83);
            gbxDatosEspecialidad.Margin = new Padding(4, 5, 4, 5);
            gbxDatosEspecialidad.Name = "gbxDatosEspecialidad";
            gbxDatosEspecialidad.Padding = new Padding(4, 5, 4, 5);
            gbxDatosEspecialidad.Size = new Size(600, 367);
            gbxDatosEspecialidad.TabIndex = 0;
            gbxDatosEspecialidad.TabStop = false;
            gbxDatosEspecialidad.Text = "Datos de Especialidad Médica";
            gbxDatosEspecialidad.Enter += gbxDatosEspecialidad_Enter;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(111, 158);
            txtDescripcion.Margin = new Padding(4, 5, 4, 5);
            txtDescripcion.MaxLength = 250;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(441, 97);
            txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(9, 163);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(108, 25);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 108);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(441, 31);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 113);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 25);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(111, 60);
            txtId.Margin = new Padding(4, 5, 4, 5);
            txtId.Name = "txtId";
            txtId.Size = new Size(177, 31);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(73, 65);
            lblId.Margin = new Padding(4, 0, 4, 0);
            lblId.Name = "lblId";
            lblId.Size = new Size(34, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            lblTitulo.Location = new Point(128, 24);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(411, 45);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Crear Especialidad Médica";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(271, 483);
            btnGuardar.Margin = new Padding(4, 5, 4, 5);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(161, 60);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(255, 128, 0);
            btnCancelar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(441, 483);
            btnCancelar.Margin = new Padding(4, 5, 4, 5);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(161, 60);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.Control;
            btnEliminar.Location = new Point(101, 483);
            btnEliminar.Margin = new Padding(4, 5, 4, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(161, 60);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEspecialidad
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 567);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosEspecialidad);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmEspecialidad";
            Text = "Mantenimiento: Especialidades Médicas";
            Load += frmEspecialidades_Load;
            gbxDatosEspecialidad.ResumeLayout(false);
            gbxDatosEspecialidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private GroupBox gbxDatosEspecialidad;
        private Label lblTitulo;
        private Button btnGuardar;
        private Button btnCancelar;
        private Button btnEliminar;
        private TextBox txtDescripcion;
        private Label lblDescripcion;
        private TextBox txtNombre;
        private Label lblNombre;
        private TextBox txtId;
        private Label lblId;
    }
}
