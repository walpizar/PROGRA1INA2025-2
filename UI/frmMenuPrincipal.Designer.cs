namespace UI
{
    partial class frmMenuVertical
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuVertical));
            pnlMenuPrincipal = new Panel();
            ptbLogo = new PictureBox();
            pnlPanelTop = new Panel();
            pnlContenedor = new Panel();
            ptbRestaurar = new PictureBox();
            ptbMinimizar = new PictureBox();
            ptbMaximizar = new PictureBox();
            ptbSalir = new PictureBox();
            ptbslider = new PictureBox();
            pnlMenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            pnlPanelTop.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbslider).BeginInit();
            SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            pnlMenuPrincipal.BackColor = Color.RoyalBlue;
            pnlMenuPrincipal.Controls.Add(ptbLogo);
            pnlMenuPrincipal.Dock = DockStyle.Left;
            pnlMenuPrincipal.Location = new Point(0, 0);
            pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            pnlMenuPrincipal.Size = new Size(250, 753);
            pnlMenuPrincipal.TabIndex = 0;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.logo_asociacion_cdcp1;
            ptbLogo.Location = new Point(0, 26);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(250, 158);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            // 
            // pnlPanelTop
            // 
            pnlPanelTop.BackColor = SystemColors.ButtonFace;
            pnlPanelTop.Controls.Add(pnlContenedor);
            pnlPanelTop.Dock = DockStyle.Top;
            pnlPanelTop.Location = new Point(250, 0);
            pnlPanelTop.Name = "pnlPanelTop";
            pnlPanelTop.Size = new Size(1441, 50);
            pnlPanelTop.TabIndex = 1;
            // 
            // pnlContenedor
            // 
            pnlContenedor.BackColor = SystemColors.ControlLight;
            pnlContenedor.Controls.Add(ptbRestaurar);
            pnlContenedor.Controls.Add(ptbMinimizar);
            pnlContenedor.Controls.Add(ptbMaximizar);
            pnlContenedor.Controls.Add(ptbSalir);
            pnlContenedor.Controls.Add(ptbslider);
            pnlContenedor.Dock = DockStyle.Top;
            pnlContenedor.Location = new Point(0, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1441, 50);
            pnlContenedor.TabIndex = 2;
            pnlContenedor.MouseDown += pnlContenedor_MouseDown;
            // 
            // ptbRestaurar
            // 
            ptbRestaurar.Cursor = Cursors.Hand;
            ptbRestaurar.Dock = DockStyle.Right;
            ptbRestaurar.Image = (Image)resources.GetObject("ptbRestaurar.Image");
            ptbRestaurar.Location = new Point(1349, 0);
            ptbRestaurar.Name = "ptbRestaurar";
            ptbRestaurar.Size = new Size(23, 50);
            ptbRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbRestaurar.TabIndex = 4;
            ptbRestaurar.TabStop = false;
            ptbRestaurar.Visible = false;
            ptbRestaurar.Click += ptbRestaurar_Click_1;
            // 
            // ptbMinimizar
            // 
            ptbMinimizar.Cursor = Cursors.Hand;
            ptbMinimizar.Dock = DockStyle.Right;
            ptbMinimizar.Image = (Image)resources.GetObject("ptbMinimizar.Image");
            ptbMinimizar.Location = new Point(1372, 0);
            ptbMinimizar.Name = "ptbMinimizar";
            ptbMinimizar.Size = new Size(23, 50);
            ptbMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMinimizar.TabIndex = 3;
            ptbMinimizar.TabStop = false;
            ptbMinimizar.Click += ptbMinimizar_Click;
            // 
            // ptbMaximizar
            // 
            ptbMaximizar.Cursor = Cursors.Hand;
            ptbMaximizar.Dock = DockStyle.Right;
            ptbMaximizar.Image = (Image)resources.GetObject("ptbMaximizar.Image");
            ptbMaximizar.Location = new Point(1395, 0);
            ptbMaximizar.Name = "ptbMaximizar";
            ptbMaximizar.Size = new Size(23, 50);
            ptbMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            ptbMaximizar.TabIndex = 2;
            ptbMaximizar.TabStop = false;
            ptbMaximizar.Click += ptbMaximizar_Click;
            // 
            // ptbSalir
            // 
            ptbSalir.Cursor = Cursors.Hand;
            ptbSalir.Dock = DockStyle.Right;
            ptbSalir.Image = Properties.Resources.icons8_eliminar_50;
            ptbSalir.Location = new Point(1418, 0);
            ptbSalir.Name = "ptbSalir";
            ptbSalir.Size = new Size(23, 50);
            ptbSalir.SizeMode = PictureBoxSizeMode.Zoom;
            ptbSalir.TabIndex = 1;
            ptbSalir.TabStop = false;
            ptbSalir.Click += ptbSalir_Click;
            // 
            // ptbslider
            // 
            ptbslider.Cursor = Cursors.Hand;
            ptbslider.Image = Properties.Resources.icons8_menu_50;
            ptbslider.Location = new Point(6, 12);
            ptbslider.Name = "ptbslider";
            ptbslider.Size = new Size(32, 33);
            ptbslider.SizeMode = PictureBoxSizeMode.Zoom;
            ptbslider.TabIndex = 0;
            ptbslider.TabStop = false;
            ptbslider.Click += ptbslider_Click;
            // 
            // frmMenuVertical
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 753);
            Controls.Add(pnlPanelTop);
            Controls.Add(pnlMenuPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenuVertical";
            Text = "frmMenuPrincipal";
            pnlMenuPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            pnlPanelTop.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbslider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenuPrincipal;
        private Panel pnlPanelTop;
        private PictureBox ptbslider;
        private Panel pnlContenedor;
        private PictureBox ptbLogo;
        private PictureBox ptbSalir;
        private PictureBox ptbRestaurar;
        private PictureBox ptbMinimizar;
        private PictureBox ptbMaximizar;
    }
}