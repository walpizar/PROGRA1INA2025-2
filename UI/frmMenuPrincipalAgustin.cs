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

        //Abre el formulario de Activos
        private void btnActivos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmActivos());
        }

        //Abre el formulario de la Lista de Departamentos
        private void btnDepartamentos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDepartamentosLista());
        }

        //Abre el formulario de la Lista de Especialidades
        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEspecialidadLista());
        }

        //Abre el formulario de la Lista de Puestos
        private void btnPuestos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPuestosLista());
        }

        //Abre el formulario de Devoluciones
        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDevolucion());
        }

        //Abre el formulario de Categorias de Activos
        private void btnCategorias_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmMantenimientoCategoriasActivos());
        }

        //Abre el formulario de Usuarios
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmUsuario());
        }

        //AAbre el formulario de Inicio de Sesion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmLogin());
        }

        //Abre el formulario de Recuperar Contraseña
        private void btnRecuperarContra_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmRecuperarContra());
        }

        //Abre el formulario de Lista de Pacientes
        private void btnPacientesLista_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmPacienteLista());
        }

        //Abre el formulario de Lista de Medicos
        private void btnMedicosLista_Click(object sender, EventArgs e)
        {
            //No implementado
        }

        //Abre el formulario de Lista de Enfermeros
        private void btnEnfermerosLista_Click(object sender, EventArgs e)
        {
            //No implementado
        }

        //Ir a inicio
        //Cierra el formulario que este abierto en el panel de contenido
        private void lblTitulo_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();
        }

        //Metodo para abrir formularios dentro del panel de contenido
        private void AbrirFormulario(Form formulario)
        {
            // Limpiar panel de contenido
            panelContenido.Controls.Clear();

            // Configurar el formulario a mostrar
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar al panel
            panelContenido.Controls.Add(formulario);
            formulario.Show();
        }
    }
}
