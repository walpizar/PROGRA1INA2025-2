

namespace UI
{
    partial class frmEspecialidadLista
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
            btnNuevaEspecialidad = new Button();
            gbxListaEspecialidad = new GroupBox();
            label1 = new Label();
            txtBusquedaEspecialidad = new TextBox();
            lstvListaEspecialidad = new ListView();
            colId = new ColumnHeader();
            colNombre = new ColumnHeader();
            colDescripcion = new ColumnHeader();
            colEstado = new ColumnHeader();
            lblTitulo = new Label();
            gbxListaEspecialidad.SuspendLayout();
            SuspendLayout();
            // 
            // btnNuevaEspecialidad
            // 
            btnNuevaEspecialidad.BackColor = SystemColors.ActiveCaption;
            btnNuevaEspecialidad.FlatAppearance.BorderColor = Color.Red;
            btnNuevaEspecialidad.FlatAppearance.BorderSize = 3;
            btnNuevaEspecialidad.ForeColor = Color.Cornsilk;
            btnNuevaEspecialidad.Location = new Point(522, 23);
            btnNuevaEspecialidad.Name = "btnNuevaEspecialidad";
            btnNuevaEspecialidad.Size = new Size(120, 40);
            btnNuevaEspecialidad.TabIndex = 4;
            btnNuevaEspecialidad.Text = "Nueva";
            btnNuevaEspecialidad.UseVisualStyleBackColor = false;
            btnNuevaEspecialidad.TextChanged += btnNuevaEspecialidad_TextChanged;
            btnNuevaEspecialidad.Click += btnNuevaEspecialidad_Click;
            // 
            // gbxListaEspecialidad
            // 
            gbxListaEspecialidad.BackColor = SystemColors.Control;
            gbxListaEspecialidad.Controls.Add(label1);
            gbxListaEspecialidad.Controls.Add(txtBusquedaEspecialidad);
            gbxListaEspecialidad.Controls.Add(lstvListaEspecialidad);
            gbxListaEspecialidad.Location = new Point(48, 70);
            gbxListaEspecialidad.Name = "gbxListaEspecialidad";
            gbxListaEspecialidad.Size = new Size(593, 387);
            gbxListaEspecialidad.TabIndex = 5;
            gbxListaEspecialidad.TabStop = false;
            gbxListaEspecialidad.Text = "Lista Especialidades";
            gbxListaEspecialidad.Enter += gbxListaEspecialidad_Enter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 28);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Busqueda:";
            // 
            // txtBusquedaEspecialidad
            // 
            txtBusquedaEspecialidad.Location = new Point(18, 50);
            txtBusquedaEspecialidad.Name = "txtBusquedaEspecialidad";
            txtBusquedaEspecialidad.Size = new Size(554, 23);
            txtBusquedaEspecialidad.TabIndex = 3;
            txtBusquedaEspecialidad.TextChanged += txtBusquedaEspecialidad_TextChanged;
            // 
            // lstvListaEspecialidad
            // 
            lstvListaEspecialidad.Columns.AddRange(new ColumnHeader[] { colId, colNombre, colDescripcion, colEstado });
            lstvListaEspecialidad.FullRowSelect = true;
            lstvListaEspecialidad.GridLines = true;
            lstvListaEspecialidad.Location = new Point(18, 88);
            lstvListaEspecialidad.MultiSelect = false;
            lstvListaEspecialidad.Name = "lstvListaEspecialidad";
            lstvListaEspecialidad.Size = new Size(557, 293);
            lstvListaEspecialidad.TabIndex = 0;
            lstvListaEspecialidad.UseCompatibleStateImageBehavior = false;
            lstvListaEspecialidad.View = View.Details;
            lstvListaEspecialidad.SelectedIndexChanged += lstvListaEspecialidad_SelectedIndexChanged;
            lstvListaEspecialidad.MouseDoubleClick += lstvListaEspecialidad_MouseDoubleClick;
            // 
            // colId
            // 
            colId.Text = "ID";
            colId.Width = 100;
            // 
            // colNombre
            // 
            colNombre.Text = "Nombre";
            colNombre.Width = 200;
            // 
            // colDescripcion
            // 
            colDescripcion.Text = "Descripción";
            colDescripcion.Width = 350;
            // 
            // colEstado
            // 
            colEstado.Text = "Estado";
            colEstado.Width = 100;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(48, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(339, 30);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Administración de especialidades";
            lblTitulo.TextChanged += lblTitulo_TextChanged;
            // 
            // frmEspecialidadLista
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(693, 412);
            Controls.Add(btnNuevaEspecialidad);
            Controls.Add(gbxListaEspecialidad);
            Controls.Add(lblTitulo);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmEspecialidadLista";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración de especialidades";
            Load += frmEspecialidadLista_Load;
            gbxListaEspecialidad.ResumeLayout(false);
            gbxListaEspecialidad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnNuevaEspecialidad;
        private GroupBox gbxListaEspecialidad;
        private Label label1;
        private TextBox txtBusquedaEspecialidad;
        private ListView lstvListaEspecialidad;
        private ColumnHeader colId;
        private ColumnHeader colNombre;
        private ColumnHeader colDescripcion;
        private ColumnHeader colEstado;
        private Label lblTitulo;

    }
}