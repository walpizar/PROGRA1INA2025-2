namespace UI
{
    partial class frmTipoDonacion
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
            lblCrearTipoDonacion = new Label();
            btnModificarDonacion = new Button();
            btnCancelar = new Button();
            btnGuardarDonacion = new Button();
            gbxDatosTipoDonacion = new GroupBox();
            txtbxTipoDonacionDescripcion = new TextBox();
            lblTipoDonacionDesc = new Label();
            this.lblTipoDonacionNombre = new Label();
            txtbxTipoDonacionID = new TextBox();
            lblTipoDonacionID = new Label();
            txtbxTipoDonacionNombre = new TextBox();
            gbxDatosTipoDonacion.SuspendLayout();
            SuspendLayout();
            // 
            // lblCrearTipoDonacion
            // 
            lblCrearTipoDonacion.AutoSize = true;
            lblCrearTipoDonacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCrearTipoDonacion.Location = new Point(110, 44);
            lblCrearTipoDonacion.Name = "lblCrearTipoDonacion";
            lblCrearTipoDonacion.Size = new Size(221, 25);
            lblCrearTipoDonacion.TabIndex = 27;
            lblCrearTipoDonacion.Text = "CREAR TIPO DONACION";
            // 
            // btnModificarDonacion
            // 
            btnModificarDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModificarDonacion.Location = new Point(32, 317);
            btnModificarDonacion.Name = "btnModificarDonacion";
            btnModificarDonacion.Size = new Size(121, 50);
            btnModificarDonacion.TabIndex = 31;
            btnModificarDonacion.Text = "MODIFICAR";
            btnModificarDonacion.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(168, 317);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(121, 50);
            btnCancelar.TabIndex = 30;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarDonacion
            // 
            btnGuardarDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardarDonacion.Location = new Point(308, 317);
            btnGuardarDonacion.Name = "btnGuardarDonacion";
            btnGuardarDonacion.Size = new Size(121, 50);
            btnGuardarDonacion.TabIndex = 29;
            btnGuardarDonacion.Text = "GUARDAR";
            btnGuardarDonacion.UseVisualStyleBackColor = true;
            // 
            // gbxDatosTipoDonacion
            // 
            gbxDatosTipoDonacion.Controls.Add(txtbxTipoDonacionNombre);
            gbxDatosTipoDonacion.Controls.Add(txtbxTipoDonacionDescripcion);
            gbxDatosTipoDonacion.Controls.Add(lblTipoDonacionDesc);
            gbxDatosTipoDonacion.Controls.Add(this.lblTipoDonacionNombre);
            gbxDatosTipoDonacion.Controls.Add(txtbxTipoDonacionID);
            gbxDatosTipoDonacion.Controls.Add(lblTipoDonacionID);
            gbxDatosTipoDonacion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            gbxDatosTipoDonacion.Location = new Point(32, 97);
            gbxDatosTipoDonacion.Name = "gbxDatosTipoDonacion";
            gbxDatosTipoDonacion.Size = new Size(397, 214);
            gbxDatosTipoDonacion.TabIndex = 28;
            gbxDatosTipoDonacion.TabStop = false;
            gbxDatosTipoDonacion.Text = "DATOS TIPO DONACION";
            // 
            // txtbxTipoDonacionDescripcion
            // 
            txtbxTipoDonacionDescripcion.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxTipoDonacionDescripcion.Location = new Point(206, 115);
            txtbxTipoDonacionDescripcion.Multiline = true;
            txtbxTipoDonacionDescripcion.Name = "txtbxTipoDonacionDescripcion";
            txtbxTipoDonacionDescripcion.Size = new Size(185, 71);
            txtbxTipoDonacionDescripcion.TabIndex = 17;
            // 
            // lblTipoDonacionDesc
            // 
            lblTipoDonacionDesc.AutoSize = true;
            lblTipoDonacionDesc.Location = new Point(78, 115);
            lblTipoDonacionDesc.Name = "lblTipoDonacionDesc";
            lblTipoDonacionDesc.Size = new Size(122, 23);
            lblTipoDonacionDesc.TabIndex = 16;
            lblTipoDonacionDesc.Text = "DESCRIPCION";
            // 
            // lblTipoDonacionNombre
            // 
            this.lblTipoDonacionNombre.AutoSize = true;
            this.lblTipoDonacionNombre.Location = new Point(117, 86);
            this.lblTipoDonacionNombre.Name = "lblTipoDonacionNombre";
            this.lblTipoDonacionNombre.Size = new Size(83, 23);
            this.lblTipoDonacionNombre.TabIndex = 6;
            this.lblTipoDonacionNombre.Text = "NOMBRE";
            // 
            // txtbxTipoDonacionID
            // 
            txtbxTipoDonacionID.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxTipoDonacionID.Location = new Point(206, 49);
            txtbxTipoDonacionID.Name = "txtbxTipoDonacionID";
            txtbxTipoDonacionID.Size = new Size(185, 27);
            txtbxTipoDonacionID.TabIndex = 1;
            // 
            // lblTipoDonacionID
            // 
            lblTipoDonacionID.AutoSize = true;
            lblTipoDonacionID.Location = new Point(28, 50);
            lblTipoDonacionID.Name = "lblTipoDonacionID";
            lblTipoDonacionID.Size = new Size(172, 23);
            lblTipoDonacionID.TabIndex = 0;
            lblTipoDonacionID.Text = "ID TIPO DONACION";
            // 
            // txtbxTipoDonacionNombre
            // 
            txtbxTipoDonacionNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxTipoDonacionNombre.Location = new Point(206, 82);
            txtbxTipoDonacionNombre.Name = "txtbxTipoDonacionNombre";
            txtbxTipoDonacionNombre.Size = new Size(185, 27);
            txtbxTipoDonacionNombre.TabIndex = 31;
            // 
            // frmTipoDonacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 391);
            Controls.Add(btnModificarDonacion);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardarDonacion);
            Controls.Add(gbxDatosTipoDonacion);
            Controls.Add(lblCrearTipoDonacion);
            Name = "frmTipoDonacion";
            Text = "MANTENIMIENTO TIPO DONACION";
            gbxDatosTipoDonacion.ResumeLayout(false);
            gbxDatosTipoDonacion.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCrearTipoDonacion;
        private Button btnModificarDonacion;
        private Button btnCancelar;
        private Button btnGuardarDonacion;
        private GroupBox gbxDatosTipoDonacion;
        private Button btnDonacionSelectIdDonante;
        private TextBox txtbxTipoDonacionDescripcion;
        private Label lblTipoDonacionDesc;
        private Label lblTipoDonacionNombre;
        private Label lblDonacionIdTipoDonacion;
        private TextBox txtbxDonacionDonanteID;
        private Label lblDonacionDonanteID;
        private TextBox txtbxTipoDonacionID;
        private Label lblTipoDonacionID;
        private TextBox txtbxTipoDonacionNombre;
    }
}