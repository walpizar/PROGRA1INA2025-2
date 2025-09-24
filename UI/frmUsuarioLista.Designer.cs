namespace UI
{
    partial class frmUsuarioLista
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
            btnNuevo = new Button();
            txtBusqueda = new GroupBox();
            lstvLista = new ListView();
            colnombreUsuario = new ColumnHeader();
            colcontraseña = new ColumnHeader();
            colidRol = new ColumnHeader();
            textBusqueda = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtBusqueda.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.ForeColor = SystemColors.ActiveCaptionText;
            btnNuevo.Location = new Point(483, 12);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(93, 31);
            btnNuevo.TabIndex = 1;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // txtBusqueda
            // 
            txtBusqueda.Controls.Add(lstvLista);
            txtBusqueda.Controls.Add(textBusqueda);
            txtBusqueda.Controls.Add(label2);
            txtBusqueda.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBusqueda.Location = new Point(1, 46);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(581, 336);
            txtBusqueda.TabIndex = 2;
            txtBusqueda.TabStop = false;
            txtBusqueda.Text = "Lista Usuarios";
            // 
            // lstvLista
            // 
            lstvLista.Columns.AddRange(new ColumnHeader[] { colnombreUsuario, colcontraseña, colidRol });
            lstvLista.FullRowSelect = true;
            lstvLista.GridLines = true;
            lstvLista.Location = new Point(0, 65);
            lstvLista.Name = "lstvLista";
            lstvLista.Size = new Size(575, 265);
            lstvLista.TabIndex = 2;
            lstvLista.UseCompatibleStateImageBehavior = false;
            lstvLista.View = View.Details;
            lstvLista.SelectedIndexChanged += lstvLista_SelectedIndexChanged;
            // 
            // colnombreUsuario
            // 
            colnombreUsuario.Text = "Nombre Usuario";
            colnombreUsuario.Width = 150;
            // 
            // colcontraseña
            // 
            colcontraseña.Text = "Contraseña";
            colcontraseña.TextAlign = HorizontalAlignment.Center;
            colcontraseña.Width = 250;
            // 
            // colidRol
            // 
            colidRol.Text = "Id Rol";
            colidRol.TextAlign = HorizontalAlignment.Center;
            colidRol.Width = 250;
            // 
            // textBusqueda
            // 
            textBusqueda.Location = new Point(6, 37);
            textBusqueda.Name = "textBusqueda";
            textBusqueda.Size = new Size(569, 22);
            textBusqueda.TabIndex = 1;
            textBusqueda.TextChanged += textBusqueda_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(11, 18);
            label2.Name = "label2";
            label2.Size = new Size(76, 16);
            label2.TabIndex = 0;
            label2.Text = "Busqueda:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(159, 18);
            label1.Name = "label1";
            label1.Size = new Size(250, 25);
            label1.TabIndex = 3;
            label1.Text = "Mantenimientos Usuarios";
            // 
            // frmUsuarioLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 394);
            Controls.Add(label1);
            Controls.Add(txtBusqueda);
            Controls.Add(btnNuevo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonShadow;
            Name = "frmUsuarioLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Usuarios";
            Load += frmUsuarioLista_Load;
            txtBusqueda.ResumeLayout(false);
            txtBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnNuevo;
        private GroupBox txtBusqueda;
        private Label label1;
        private Label label2;
        private ListView lstvLista;
        private TextBox textBusqueda;
        private ColumnHeader colnombreUsuario;
        private ColumnHeader colcontraseña;
        private ColumnHeader colidRol;
    }
}