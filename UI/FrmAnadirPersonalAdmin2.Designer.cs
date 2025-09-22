using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    partial class FrmAnadirPersonalAdmin2
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private ToolStripMenuItem credencialesToolStripMenuItem;
        private ToolStripMenuItem adminToolStripMenuItem;
        private Panel panelContenedor;

        /// <summary>
        /// Limpiar recursos
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            datosPersonalesToolStripMenuItem = new ToolStripMenuItem();
            credencialesToolStripMenuItem = new ToolStripMenuItem();
            adminToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            panelBotones = new Panel();
            btnCancel = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            btnCancelar = new Button();
            btnAnadir = new Button();
            btnEliminar = new Button();
            menuStrip1.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { datosPersonalesToolStripMenuItem, credencialesToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(654, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // datosPersonalesToolStripMenuItem
            // 
            datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            datosPersonalesToolStripMenuItem.Size = new Size(108, 22);
            datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            datosPersonalesToolStripMenuItem.Click += btnDatosPersonales_Click;
            // 
            // credencialesToolStripMenuItem
            // 
            credencialesToolStripMenuItem.Name = "credencialesToolStripMenuItem";
            credencialesToolStripMenuItem.Size = new Size(86, 22);
            credencialesToolStripMenuItem.Text = "Credenciales";
            credencialesToolStripMenuItem.Click += btnCredenciales_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(55, 22);
            adminToolStripMenuItem.Text = "Admin";
            adminToolStripMenuItem.Click += btnAdministrativo_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 24);
            panelContenedor.Margin = new Padding(2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(654, 262);
            panelContenedor.TabIndex = 1;
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.Transparent;
            panelBotones.Controls.Add(btnCancel);
            panelBotones.Controls.Add(btnCreate);
            panelBotones.Controls.Add(btnDelete);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.ForeColor = Color.Black;
            panelBotones.Location = new Point(0, 286);
            panelBotones.Margin = new Padding(2);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(654, 38);
            panelBotones.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(568, 4);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(78, 28);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button3_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(388, 4);
            btnCreate.Margin = new Padding(2);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(78, 28);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Añadir";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(479, 4);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(78, 28);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "Eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(800, 458);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 46);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAnadir
            // 
            btnAnadir.Location = new Point(672, 458);
            btnAnadir.Name = "btnAnadir";
            btnAnadir.Size = new Size(112, 46);
            btnAnadir.TabIndex = 1;
            btnAnadir.Text = "Añadir";
            btnAnadir.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(541, 458);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 46);
            btnEliminar.TabIndex = 0;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // FrmAnadirPersonalAdmin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(654, 324);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            Controls.Add(panelBotones);
            Margin = new Padding(2);
            Name = "FrmAnadirPersonalAdmin2";
            Text = "Añadir Personal Administrativo";
            Load += FrmAnadirPersonalAdmin2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button btnAnadir;
        private Button btnEliminar;
        private Panel panelBotones;
        private Button btnCancel;
        private Button btnCreate;
        private Button btnDelete;
    }
}
