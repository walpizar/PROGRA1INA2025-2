using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMenuPrincipalAgustin : Form
    {
        public frmMenuPrincipalAgustin()
        {
            InitializeComponent();
        }

        private void frmMenuPrincipalAgustin_Load(object sender, EventArgs e)
        {

        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmActivos());
        }

        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDepartamentosLista());
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEspecialidadLista());
        }

        private void btnPuestos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPuestosLista());
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDevolucion());
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMantenimientoCategoriasActivos());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuario());
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLogin());
        }

        private void btnRecuperarContra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRecuperarContra());
        }

        private void btnPacientesLista_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPacienteLista());
        }

        private void btnMedicosLista_Click(object sender, EventArgs e)
        {
            //No implementado
        }

        private void btnEnfermerosLista_Click(object sender, EventArgs e)
        {
            //No implementado
        }

        private void AbrirFormulario(Form formulario)
        {
            // Limpiar panel de contenido
            panelContenido.Controls.Clear();

            // Configurar el formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar al panel
            panelContenido.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
