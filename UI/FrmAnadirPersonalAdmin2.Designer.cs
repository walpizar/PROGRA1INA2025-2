using System.Windows.Forms;
using System.Drawing;

namespace UI
{
    partial class FrmAnadirPersonalAdmin2
    {
        private System.ComponentModel.IContainer components = null;

        private MenuStrip menuStrip1;
        private ToolStripMenuItem datosPersonalesToolStripMenuItem;
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { datosPersonalesToolStripMenuItem, adminToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(934, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // datosPersonalesToolStripMenuItem
            // 
            datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            datosPersonalesToolStripMenuItem.Size = new Size(163, 29);
            datosPersonalesToolStripMenuItem.Text = "Datos Personales";
            datosPersonalesToolStripMenuItem.Click += btnDatosPersonales_Click;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(174, 29);
            adminToolStripMenuItem.Text = "Asignación Puesto";
            adminToolStripMenuItem.Click += btnAdministrativo_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 33);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(934, 444);
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
            panelBotones.Location = new Point(0, 477);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(934, 63);
            panelBotones.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(811, 7);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(111, 47);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button3_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(554, 7);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(111, 47);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Añadir";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(684, 7);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(111, 47);
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
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 540);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            Controls.Add(panelBotones);
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
