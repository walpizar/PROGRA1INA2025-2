using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace UI
{
    public partial class frmMenuVertical : Form
    {
        public frmMenuVertical()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ptbslider_Click(object sender, EventArgs e)
        {
            if (pnlMenuPrincipal.Width == 250)
            {
                pnlMenuPrincipal.Width = 70;
                ptbLogo.Size = new Size(50, 50);
                ptbLogo.Location = new Point(12, 19);
                panelSubmenuActivos.Visible = false;

            }
            else
            {
                pnlMenuPrincipal.Width = 250;
                ptbLogo.Size = new Size(250, 158);
                ptbLogo.Location = new Point(0, 12);
            }
            pnlContiene.BackColor = Color.White;

        }

        private void ptbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ptbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            ptbMaximizar.Visible = false;
            ptbRestaurar.Visible = true;
        }

        private void frmMenuVertical_Load(object sender, EventArgs e)
        {

        }

        private void ptbRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void ptbRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            ptbRestaurar.Visible = false;
            ptbMaximizar.Visible = true;


        }

        private void ptbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void pnlContenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panelSubMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = true;
            panelSubmenuActivos.Visible = false;

        }

        private void btnTipoAyuda_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void btnFormularioAyuda_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
        }

        private void bntActivos_Click(object sender, EventArgs e)
        {
            panelSubMenu.Visible = false;
            panelSubmenuActivos.Visible = true;



            if (pnlMenuPrincipal.Width != 250)
            {
                panelSubmenuActivos.Visible = false;
                pnlContiene.BackColor = Color.White;

            }
            else
            {
                pnlContiene.BackColor = Color.Gainsboro;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSubmenuActivos.Visible = false;
            pnlContiene.BackColor = Color.White;
            new frmActivos().ShowDialog();
        }

        private void btnDevolucion_Click(object sender, EventArgs e)
        {
            panelSubmenuActivos.Visible = false;
            pnlContiene.BackColor = Color.White;
            new frmDevolucion().ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelSubmenuActivos.Visible = false;
            pnlContiene.BackColor = Color.White;
            new frmMantenimientoCategoriasActivos().ShowDialog();
        }

        private void frmMenuVertical_Load_1(object sender, EventArgs e)
        {

        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void SalirSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
