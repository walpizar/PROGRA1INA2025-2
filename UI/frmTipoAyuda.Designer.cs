namespace UI
{
    partial class fmrTipoAyuda
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
            grbAgregarTipoAyuda = new GroupBox();
            cboResponsable = new ComboBox();
            label2 = new Label();
            txtDescripcion = new TextBox();
            label1 = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            lblCrearTipoAyuda = new Label();
            btnCancelar = new Button();
            grbAgregarTipoAyuda.SuspendLayout();
            // 
            // grbAgregarTipoAyuda
            // 
            grbAgregarTipoAyuda.BackColor = SystemColors.Control;
            grbAgregarTipoAyuda.Controls.Add(cboResponsable);
            grbAgregarTipoAyuda.Controls.Add(label2);
            grbAgregarTipoAyuda.Controls.Add(txtDescripcion);
            grbAgregarTipoAyuda.Controls.Add(label1);
            grbAgregarTipoAyuda.Controls.Add(txtNombre);
            grbAgregarTipoAyuda.Controls.Add(lblNombre);
            grbAgregarTipoAyuda.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grbAgregarTipoAyuda.ForeColor = SystemColors.ActiveCaptionText;
            grbAgregarTipoAyuda.Location = new Point(12, 75);
            grbAgregarTipoAyuda.Name = "grbAgregarTipoAyuda";
            grbAgregarTipoAyuda.Size = new Size(378, 186);
            grbAgregarTipoAyuda.TabIndex = 0;
            grbAgregarTipoAyuda.TabStop = false;
            grbAgregarTipoAyuda.Text = "Agregar Tipo Ayuda";
            // 
            // cboResponsable
            // 
            cboResponsable.BackColor = SystemColors.Window;
            cboResponsable.DropDownStyle = ComboBoxStyle.DropDownList;
            cboResponsable.ForeColor = SystemColors.WindowFrame;
            cboResponsable.FormattingEnabled = true;
            cboResponsable.Location = new Point(103, 139);
            cboResponsable.Name = "cboResponsable";
            cboResponsable.Size = new Size(160, 25);
            cboResponsable.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 142);
            label2.Name = "label2";
            label2.Size = new Size(86, 17);
            label2.TabIndex = 4;
            label2.Text = "Responsable:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(103, 92);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(244, 25);
            txtDescripcion.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 95);
            label1.Name = "label1";
            label1.Size = new Size(79, 17);
            label1.TabIndex = 2;
            label1.Text = "Descripción:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(103, 42);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(160, 25);
            txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(32, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(60, 17);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardar
            // 
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.Green;
            btnGuardar.Location = new Point(298, 290);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(92, 33);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // lblCrearTipoAyuda
            // 
            lblCrearTipoAyuda.AutoSize = true;
            lblCrearTipoAyuda.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearTipoAyuda.Location = new Point(76, 27);
            lblCrearTipoAyuda.Name = "lblCrearTipoAyuda";
            lblCrearTipoAyuda.Size = new Size(248, 32);
            lblCrearTipoAyuda.TabIndex = 4;
            lblCrearTipoAyuda.Text = "Crear Tipo de Ayuda";
            // 
            // btnCancelar
            // 
            btnCancelar.FlatStyle = FlatStyle.Popup;
            btnCancelar.ForeColor = Color.FromArgb(192, 0, 0);
            btnCancelar.Location = new Point(183, 290);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 33);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // fmrTipoAyuda
            // 
        }

        #endregion

        private GroupBox grbAgregarTipoAyuda;
        private Label lblNombre;
        private TextBox txtNombre;
        private Button btnGuardar;
        private Label lblCrearTipoAyuda;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private TextBox txtDescripcion;
        private ComboBox cboResponsable;
    }
}