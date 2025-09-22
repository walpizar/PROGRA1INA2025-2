namespace UI
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            mnuPrincipal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            mantenimientosToolStripMenuItem = new ToolStripMenuItem();
            procesosToolStripMenuItem = new ToolStripMenuItem();
            consultasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            mnuPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // mnuPrincipal
            // 
            mnuPrincipal.ImageScalingSize = new Size(24, 24);
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenimientosToolStripMenuItem, procesosToolStripMenuItem, consultasToolStripMenuItem, reportesToolStripMenuItem });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Padding = new Padding(9, 3, 0, 3);
            mnuPrincipal.Size = new Size(1836, 35);
            mnuPrincipal.TabIndex = 2;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(156, 29);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(99, 29);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(105, 29);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(98, 29);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1836, 1046);
            Controls.Add(mnuPrincipal);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mnuPrincipal;
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmPrincipal";
            Text = "Sistema de Clase INA";
            WindowState = FormWindowState.Maximized;
            Load += frmPrincipal_Load;
            mnuPrincipal.ResumeLayout(false);
            mnuPrincipal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuPrincipal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem mantenimientosToolStripMenuItem;
        private ToolStripMenuItem procesosToolStripMenuItem;
        private ToolStripMenuItem consultasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
    }
}
