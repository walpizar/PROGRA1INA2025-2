using Entities;
using Services;
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
    public partial class frmActivos : Form
    {
        public clsActivos activosSelected { get; set; }
        private readonly ActivosServices _activoService;
        // private readonly CategoriaActivosService _catActivosService;
        // private readonly devolucionesService _devolucionesService;

        public frmActivos()
        {
            InitializeComponent();
            _activoService = new ActivosServices();
            //_catActivosService = new CategoriaActivosService();
            //_devolucionesService = new devolucionesService();
        }

        private void frmActivos_Load(object sender, EventArgs e)
        {
            cargarCombos();
            if (activosSelected != null) // acción de modificar
            {
                this.lblTitulo.Text = "Modificar Activos";
                this.Text = "Modificar Activos";
                this.txtIdActivo.Enabled = false; // no se puede modificar el id
                btnGuardar.Text = "Modificar";
                btnEliminar.Visible = true; // muestro el botón de eliminar
                cargarForm();
            }
            else // producto es null, acción es crear
            {
                this.lblTitulo.Text = "Crear Activos";
                this.Text = "Crear Activos";
                this.txtIdActivo.Enabled = true; // se puede ingresar el id
                btnGuardar.Text = "Guardar";
                btnEliminar.Visible = false; // oculto el botón de eliminar
                limpiarForm();
            }
        }

        private void limpiarForm()
        {
            throw new NotImplementedException();
        }

        private void cargarForm()
        {
            throw new NotImplementedException();
        }

        private void cargarCombos()
        {
            throw new NotImplementedException();
        }
    }
}
