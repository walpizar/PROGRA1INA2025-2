namespace UI
{
    partial class frmDonacionLista
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
            btnNuevaDonacion = new Button();
            gbxDonacionLista = new GroupBox();
            txtbxBuscarDonacion = new TextBox();
            lstvwDonacionLista = new ListView();
            donacionID = new ColumnHeader();
            donacionDonanteID = new ColumnHeader();
            donacionTipo = new ColumnHeader();
            donacionFecha = new ColumnHeader();
            donacionObserv = new ColumnHeader();
            lblBuscarDonacion = new Label();
            lblMantDonacion = new Label();
            btnDonacionDetalle = new Button();
            gbxDonacionLista.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevaDonacion
            // 
            btnNuevaDonacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevaDonacion.Location = new Point(750, 49);
            btnNuevaDonacion.Name = "btnNuevaDonacion";
            btnNuevaDonacion.Size = new Size(151, 29);
            btnNuevaDonacion.TabIndex = 6;
            btnNuevaDonacion.Text = "NUEVA";
            btnNuevaDonacion.UseVisualStyleBackColor = true;
            btnNuevaDonacion.Click += btnNuevaDonacion_Click;
            // 
            // gbxDonacionLista
            // 
            gbxDonacionLista.Controls.Add(txtbxBuscarDonacion);
            gbxDonacionLista.Controls.Add(lstvwDonacionLista);
            gbxDonacionLista.Controls.Add(lblBuscarDonacion);
            gbxDonacionLista.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbxDonacionLista.Location = new Point(9, 84);
            gbxDonacionLista.Name = "gbxDonacionLista";
            gbxDonacionLista.Size = new Size(889, 347);
            gbxDonacionLista.TabIndex = 5;
            gbxDonacionLista.TabStop = false;
            gbxDonacionLista.Text = "LISTA DONACIONES";
            gbxDonacionLista.Enter += gbxDonacionLista_Enter;
            // 
            // txtbxBuscarDonacion
            // 
            txtbxBuscarDonacion.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtbxBuscarDonacion.Location = new Point(81, 31);
            txtbxBuscarDonacion.Name = "txtbxBuscarDonacion";
            txtbxBuscarDonacion.Size = new Size(563, 30);
            txtbxBuscarDonacion.TabIndex = 2;
            // 
            // lstvwDonacionLista
            // 
            lstvwDonacionLista.Columns.AddRange(new ColumnHeader[] { donacionID, donacionDonanteID, donacionTipo, donacionFecha, donacionObserv });
            lstvwDonacionLista.FullRowSelect = true;
            lstvwDonacionLista.GridLines = true;
            lstvwDonacionLista.Location = new Point(6, 69);
            lstvwDonacionLista.MultiSelect = false;
            lstvwDonacionLista.Name = "lstvwDonacionLista";
            lstvwDonacionLista.Size = new Size(879, 272);
            lstvwDonacionLista.TabIndex = 0;
            lstvwDonacionLista.UseCompatibleStateImageBehavior = false;
            lstvwDonacionLista.View = View.Details;
            // 
            // donacionID
            // 
            donacionID.Text = "ID";
            donacionID.Width = 100;
            // 
            // donacionDonanteID
            // 
            donacionDonanteID.Text = "ID DONANTE";
            donacionDonanteID.Width = 175;
            // 
            // donacionTipo
            // 
            donacionTipo.Text = "TIPO";
            donacionTipo.Width = 175;
            // 
            // donacionFecha
            // 
            donacionFecha.Text = "FECHA";
            donacionFecha.Width = 175;
            // 
            // donacionObserv
            // 
            donacionObserv.Text = "OBSERVACIONES";
            donacionObserv.Width = 250;
            // 
            // lblBuscarDonacion
            // 
            lblBuscarDonacion.AutoSize = true;
            lblBuscarDonacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblBuscarDonacion.Location = new Point(6, 36);
            lblBuscarDonacion.Name = "lblBuscarDonacion";
            lblBuscarDonacion.Size = new Size(69, 20);
            lblBuscarDonacion.TabIndex = 0;
            lblBuscarDonacion.Text = "BUSCAR";
            // 
            // lblMantDonacion
            // 
            lblMantDonacion.AutoSize = true;
            lblMantDonacion.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMantDonacion.Location = new Point(273, 21);
            lblMantDonacion.Name = "lblMantDonacion";
            lblMantDonacion.Size = new Size(292, 25);
            lblMantDonacion.TabIndex = 4;
            lblMantDonacion.Text = "MANTENIMIENTO DONACIONES";
            lblMantDonacion.Click += lblMantDonacion_Click;
            // 
            // btnDonacionDetalle
            // 
            btnDonacionDetalle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDonacionDetalle.Location = new Point(593, 49);
            btnDonacionDetalle.Name = "btnDonacionDetalle";
            btnDonacionDetalle.Size = new Size(151, 29);
            btnDonacionDetalle.TabIndex = 7;
            btnDonacionDetalle.Text = "DETALLE";
            btnDonacionDetalle.UseVisualStyleBackColor = true;
            btnDonacionDetalle.Click += btnDonacionDetalle_Click;
            // 
            // frmDonacionLista
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 441);
            Controls.Add(btnDonacionDetalle);
            Controls.Add(btnNuevaDonacion);
            Controls.Add(gbxDonacionLista);
            Controls.Add(lblMantDonacion);
            Name = "frmDonacionLista";
            Text = "LISTA DONACION";
            gbxDonacionLista.ResumeLayout(false);
            gbxDonacionLista.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNuevaDonacion;
        private GroupBox gbxDonacionLista;
        private TextBox txtbxBuscarDonacion;
        private ListView lstvwDonacionLista;
        private ColumnHeader donacionID;
        private ColumnHeader donacionDonanteID;
        private ColumnHeader donacionTipo;
        private ColumnHeader donacionFecha;
        private Label lblBuscarDonacion;
        private Label lblMantDonacion;
        private ColumnHeader donacionObserv;
        private Button btnDonacionDetalle;
    }
}