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
        //private readonly CategoriaActivosServices _categoriaActivosService;

        public frmActivos()
        {
            InitializeComponent();
            _activoService = new ActivosServices();
           // _categoriaActivosService = new CategoriaActivosServices();
        }

        private void frmActivos_Load(object sender, EventArgs e)
        {
           // cargarCombos();
            if (activosSelected != null) // acción de modificar
            {
                this.lblTitulo.Text = "Modificar Activos";
                this.Text = "Modificar Activos";
                this.txtIdActivo.Enabled = false; // no se puede modificar el id
                btnGuardar.Text = "Modificar";
                btnEliminar.Visible = true; // muestro el botón de eliminar
                cargarForm();
            }
            else // activo es null, acción es crear
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
            txtIdActivo.ResetText();
            txtNombre.ResetText();
            txtDescripcion.ResetText();
            txtCantidad.Value = 0;
            txtEstado.ResetText();
            txtfecha.ResetText();
            txtProveedor.ResetText();
            txtUbicacion.ResetText();
            cbxCategorias.SelectedIndex = -1;
        }

        private void cargarForm()
        {
            if (activosSelected != null)
            {
                txtIdActivo.Text = activosSelected.idActivo.ToString();
                txtNombre.Text = activosSelected.nombreActivo;
                txtDescripcion.Text = activosSelected.descripcion;
                txtCantidad.Value = activosSelected.cantidadDisponible;
                txtEstado.Text = activosSelected.estado;
                txtfecha.Text = activosSelected.fechaAdquisicion.ToString("yyyy-MM-dd");
                txtProveedor.Text = activosSelected.proveedor;
                txtUbicacion.Text = activosSelected.ubicacion;
                cbxCategorias.SelectedValue = activosSelected.idCategoria;
            }
        }

       /* private void cargarCombos()
        {
            // Cargar el combo de categorías desde la base de datos
            //List<clsCategoriaActivos> listaCat = _categoriaActivosService.consultarTodos();
            cbxCategorias.DataSource = listaCat;
            cbxCategorias.DisplayMember = "Nombre"; // Ajusta según la propiedad que muestre el nombre
            cbxCategorias.ValueMember = "Id"; // Ajusta según la propiedad de ID
        }*/
       
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    clsActivos activo = activosSelected ?? new clsActivos();

                    activo.idActivo = Convert.ToInt32(txtIdActivo.Text);
                    activo.nombreActivo = txtNombre.Text;
                    activo.descripcion = txtDescripcion.Text;
                    activo.cantidadDisponible = (int)txtCantidad.Value;
                    activo.estado = txtEstado.Text;
                    activo.fechaAdquisicion = DateTime.Parse(txtfecha.Text);
                    activo.proveedor = txtProveedor.Text;
                    activo.ubicacion = txtUbicacion.Text;
                    activo.idCategoria = (int)cbxCategorias.SelectedValue;

                    if (activosSelected == null)
                    {
                        _activoService.crear(activo);
                        MessageBox.Show("Activo creado correctamente");
                    }
                    else
                    {
                        _activoService.modificar(activo);
                        MessageBox.Show("Activo modificado correctamente");
                    }

                    limpiarForm();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error desconocido. Contacte con el administrador.");
            }
        }

        private bool validarDatos()
        {
            if (string.IsNullOrEmpty(txtIdActivo.Text))
            {
                MessageBox.Show("El ID es obligatorio");
                txtIdActivo.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio");
                txtNombre.Focus();
                return false;
            }
            if (txtCantidad.Value < 0)
            {
                MessageBox.Show("La cantidad debe ser mayor o igual a 0");
                txtCantidad.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtfecha.Text) || !DateTime.TryParse(txtfecha.Text, out _))
            {
                MessageBox.Show("La fecha de adquisición es obligatoria y debe ser válida");
                txtfecha.Focus();
                return false;
            }
            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (activosSelected != null)
                {
                    DialogResult resp = MessageBox.Show("¿Está seguro que desea eliminar el activo?", "Confirmación",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resp == DialogResult.Yes)
                    {
                        _activoService.eliminar(activosSelected.idActivo);
                        MessageBox.Show("Activo eliminado correctamente");
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar el activo.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}