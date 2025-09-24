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
            button2 = new Button();
            panel3 = new Panel();
            ptbLogo = new PictureBox();
            button1 = new Button();
            bntActivos = new Button();
            pnlPanelTop = new Panel();
            pnlContenedor = new Panel();
            ptbRestaurar = new PictureBox();
            ptbMinimizar = new PictureBox();
            ptbMaximizar = new PictureBox();
            ptbSalir = new PictureBox();
            ptbslider = new PictureBox();
            panel1 = new Panel();
            button3 = new Button();
            panel4 = new Panel();
            button4 = new Button();
            panel2 = new Panel();
            pnlMenuPrincipal.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
            pnlPanelTop.SuspendLayout();
            pnlContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbslider).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuPrincipal
            // 
            pnlMenuPrincipal.BackColor = Color.RoyalBlue;
            pnlMenuPrincipal.Controls.Add(button2);
            pnlMenuPrincipal.Controls.Add(panel3);
            pnlMenuPrincipal.Controls.Add(button1);
            pnlMenuPrincipal.Controls.Add(bntActivos);
            pnlMenuPrincipal.Dock = DockStyle.Left;
            pnlMenuPrincipal.Location = new Point(0, 0);
            pnlMenuPrincipal.Name = "pnlMenuPrincipal";
            pnlMenuPrincipal.Size = new Size(250, 753);
            pnlMenuPrincipal.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 307);
            button2.Name = "button2";
            button2.Size = new Size(251, 69);
            button2.TabIndex = 4;
            button2.Text = "Ayudas";
            button2.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MidnightBlue;
            panel3.Controls.Add(ptbLogo);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(251, 180);
            panel3.TabIndex = 2;
            // 
            // ptbLogo
            // 
            ptbLogo.Image = Properties.Resources.logo_asociacion_cdcp1;
            ptbLogo.Location = new Point(0, 10);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(250, 158);
            ptbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            ptbLogo.TabIndex = 0;
            ptbLogo.TabStop = false;
            ptbLogo.Click += ptbLogo_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-1, 241);
            button1.Name = "button1";
            button1.Size = new Size(251, 69);
            button1.TabIndex = 3;
            button1.Text = "Donaciones";
            button1.UseVisualStyleBackColor = false;
            // 
            // bntActivos
            // 
            bntActivos.BackColor = Color.RoyalBlue;
            bntActivos.FlatAppearance.BorderSize = 0;
            bntActivos.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            bntActivos.FlatStyle = FlatStyle.Flat;
            bntActivos.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bntActivos.ForeColor = Color.White;
            bntActivos.Image = Properties.Resources.icons8_trolley_501;
            bntActivos.ImageAlign = ContentAlignment.MiddleLeft;
            bntActivos.Location = new Point(-1, 176);
            bntActivos.Name = "bntActivos";
            bntActivos.Size = new Size(251, 69);
            bntActivos.TabIndex = 1;
            bntActivos.Text = "Activos";
            bntActivos.UseVisualStyleBackColor = false;
            bntActivos.Click += bntActivos_Click;
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
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button4);
            panel1.Location = new Point(250, 307);
            panel1.Name = "panel1";
            panel1.Size = new Size(194, 100);
            panel1.TabIndex = 2;
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(7, 0);
            button3.Name = "button3";
            button3.Size = new Size(187, 50);
            button3.TabIndex = 7;
            button3.Text = "Tipo de Ayuda";
            button3.TextAlign = ContentAlignment.MiddleRight;
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MidnightBlue;
            panel4.Location = new Point(0, 50);
            panel4.Name = "panel4";
            panel4.Size = new Size(11, 50);
            panel4.TabIndex = 4;
            panel4.Paint += panel4_Paint;
            // 
            // button4
            // 
            button4.BackColor = Color.RoyalBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseOverBackColor = Color.MidnightBlue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(7, 50);
            button4.Name = "button4";
            button4.Size = new Size(187, 50);
            button4.TabIndex = 6;
            button4.Text = "Solicitud Ayuda";
            button4.TextAlign = ContentAlignment.MiddleRight;
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Location = new Point(250, 307);
            panel2.Name = "panel2";
            panel2.Size = new Size(11, 53);
            panel2.TabIndex = 3;
            // 
            // frmMenuVertical
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 753);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlPanelTop);
            Controls.Add(pnlMenuPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMenuVertical";
            Text = "frmMenuPrincipal";
            pnlMenuPrincipal.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            pnlPanelTop.ResumeLayout(false);
            pnlContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMinimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbSalir).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbslider).EndInit();
            panel1.ResumeLayout(false);
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
        private Button bntActivos;
        private Button button1;
        private Panel panel3;
        private Button button2;
        private Panel panel1;
        private Button button4;
        private Panel panel2;
        private Panel panel4;
        private Button button3;
    }
}