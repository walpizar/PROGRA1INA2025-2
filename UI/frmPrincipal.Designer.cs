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
            mnuPrincipal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, mantenimientosToolStripMenuItem, procesosToolStripMenuItem, consultasToolStripMenuItem, reportesToolStripMenuItem });
            mnuPrincipal.Location = new Point(0, 0);
            mnuPrincipal.Name = "mnuPrincipal";
            mnuPrincipal.Size = new Size(1285, 24);
            mnuPrincipal.TabIndex = 2;
            mnuPrincipal.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(60, 20);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // mantenimientosToolStripMenuItem
            // 
            mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            mantenimientosToolStripMenuItem.Size = new Size(106, 20);
            mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // procesosToolStripMenuItem
            // 
            procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            procesosToolStripMenuItem.Size = new Size(66, 20);
            procesosToolStripMenuItem.Text = "Procesos";
            // 
            // consultasToolStripMenuItem
            // 
            consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            consultasToolStripMenuItem.Size = new Size(71, 20);
            consultasToolStripMenuItem.Text = "Consultas";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1285, 678);
            Controls.Add(mnuPrincipal);
            Enabled = false;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mnuPrincipal;
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
