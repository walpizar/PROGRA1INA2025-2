
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
            gbBusqueda = new GroupBox();
            lstvLista = new ListView();
            colnombreUsuario = new ColumnHeader();
            colcontraseña = new ColumnHeader();
            colidRol = new ColumnHeader();
            txtBusqueda = new TextBox();
            label2 = new Label();
            label1 = new Label();
            gbBusqueda.SuspendLayout();
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
            // gbBusqueda
            // 
            gbBusqueda.Controls.Add(lstvLista);
            gbBusqueda.Controls.Add(txtBusqueda);
            gbBusqueda.Controls.Add(label2);
            gbBusqueda.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBusqueda.Location = new Point(1, 46);
            gbBusqueda.Name = "gbBusqueda";
            gbBusqueda.Size = new Size(581, 336);
            gbBusqueda.TabIndex = 2;
            gbBusqueda.TabStop = false;
            gbBusqueda.Text = "Lista Usuarios";
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
            this.lstvLista.DoubleClick += new System.EventHandler(this.lstvLista_DoubleClick);
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
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(6, 37);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(569, 22);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TextChanged += txtBusqueda_TextChanged;
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
            label2.Text = "Búsqueda:";
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
            Controls.Add(gbBusqueda);
            Controls.Add(btnNuevo);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ButtonShadow;
            Name = "frmUsuarioLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mantenimiento de Usuarios";
            Load += frmUsuarioLista_Load;
            gbBusqueda.ResumeLayout(false);
            gbBusqueda.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void lstvLista_DoubleClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnNuevo;
        private GroupBox gbBusqueda;
        private Label label1;
        private Label label2;
        private ListView lstvLista;
        private TextBox txtBusqueda;
        private ColumnHeader colnombreUsuario;
        private ColumnHeader colcontraseña;
        private ColumnHeader colidRol;
    }
}