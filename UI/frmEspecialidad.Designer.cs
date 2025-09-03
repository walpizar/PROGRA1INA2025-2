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
            chkEstado = new CheckBox();
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
            gbxDatosEspecialidad.Controls.Add(chkEstado);
            gbxDatosEspecialidad.Controls.Add(txtDescripcion);
            gbxDatosEspecialidad.Controls.Add(lblDescripcion);
            gbxDatosEspecialidad.Controls.Add(txtNombre);
            gbxDatosEspecialidad.Controls.Add(lblNombre);
            gbxDatosEspecialidad.Controls.Add(txtId);
            gbxDatosEspecialidad.Controls.Add(lblId);
            gbxDatosEspecialidad.Location = new Point(12, 50);
            gbxDatosEspecialidad.Name = "gbxDatosEspecialidad";
            gbxDatosEspecialidad.Size = new Size(420, 220);
            gbxDatosEspecialidad.TabIndex = 0;
            gbxDatosEspecialidad.TabStop = false;
            gbxDatosEspecialidad.Text = "Datos de Especialidad Médica";
            // 
            // chkEstado
            // 
            chkEstado.AutoSize = true;
            chkEstado.Location = new Point(78, 170);
            chkEstado.Name = "chkEstado";
            chkEstado.Size = new Size(62, 19);
            chkEstado.TabIndex = 6;
            chkEstado.Text = "Activo";
            chkEstado.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(78, 95);
            txtDescripcion.MaxLength = 250;
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(310, 60);
            txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(6, 98);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(69, 15);
            lblDescripcion.TabIndex = 4;
            lblDescripcion.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(78, 65);
            txtNombre.MaxLength = 100;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(310, 23);
            txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(18, 68);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(54, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(78, 36);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 23);
            txtId.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(51, 39);
            lblId.Name = "lblId";
            lblId.Size = new Size(21, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(100, 10);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(249, 30);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Crear Especialidad Médica";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(190, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(113, 36);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(309, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(113, 36);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(71, 290);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(113, 36);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmEspecialidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 340);
            Controls.Add(btnEliminar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblTitulo);
            Controls.Add(gbxDatosEspecialidad);
            Name = "frmEspecialidades";
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
        private CheckBox chkEstado;
    }
}
