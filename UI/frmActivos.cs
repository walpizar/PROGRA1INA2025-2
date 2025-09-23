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
        // private readonly CategoriaActivosServices _categoriaActivosService;

        public frmActivos()
        {
            InitializeComponent();
            _activoService = new ActivosServices();
            // _categoriaActivosService = new CategoriaActivosServices();
        }

        private void frmActivos_Load(object sender, EventArgs e)
        {
            llenarCategoriasPrueba(); // Llenar categorías de prueba
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

        private void llenarCategoriasPrueba()
        {
            // No cargar categorías de prueba, dejar vacío para que se carguen desde la base de datos
            cbxCategorias.DataSource = null;
            cbxCategorias.Items.Clear();
        }

        private void limpiarForm()
        {
            txtIdActivo.ResetText(); // Ahora el usuario debe ingresar el ID
            txtNombre.ResetText();
            txtDescripcion.ResetText();
            cbxEstadoUso.SelectedIndex = 0;
            txtfecha.ResetText();
            txtProveedor.ResetText();
            txtUbicacion.ResetText();
            cbxCategorias.SelectedIndex = -1;
            dtpFechaDesecho.Value = DateTime.Now;
            dtpFechaDesecho.Visible = false;
            lblFechaDesecho.Visible = false;
            txtObservacionDesecho.ResetText();
            txtObservacionDesecho.Visible = false;
            lblObservacionDesecho.Visible = false;
        }

        private void cargarForm()
        {
            if (activosSelected != null)
            {
                txtIdActivo.Text = activosSelected.idActivo.ToString();
                txtNombre.Text = activosSelected.nombreActivo;
                txtDescripcion.Text = activosSelected.descripcion;
                cbxEstadoUso.SelectedIndex = activosSelected.estadoUso;
                txtfecha.Text = activosSelected.fechaAdquisicion.ToString("yyyy-MM-dd");
                txtProveedor.Text = activosSelected.proveedor;
                txtUbicacion.Text = activosSelected.ubicacion;
                cbxCategorias.SelectedValue = activosSelected.idCategoria;
                if (activosSelected.estadoUso == 2) // Desechado
                {
                    dtpFechaDesecho.Visible = true;
                    lblFechaDesecho.Visible = true;
                    txtObservacionDesecho.Visible = true;
                    lblObservacionDesecho.Visible = true;
                    if (activosSelected.fechaDesecho.HasValue)
                        dtpFechaDesecho.Value = activosSelected.fechaDesecho.Value;
                    txtObservacionDesecho.Text = activosSelected.observacionDesecho;
                }
                else
                {
                    dtpFechaDesecho.Visible = false;
                    lblFechaDesecho.Visible = false;
                    txtObservacionDesecho.Visible = false;
                    lblObservacionDesecho.Visible = false;
                }
            }
        }

        //private void cargarCombos()
        // {
        // Cargar el combo de categorías desde la base de datos
        /* var listaCat = _categoriaActivosService.consultarTodos();
         cbxCategorias.DataSource = listaCat;
         cbxCategorias.DisplayMember = "nombreCategoriaActivo"; // Propiedad que muestra el nombre
         cbxCategorias.ValueMember = "idCategoriaActivo";        // Propiedad de ID
         cbxCategorias.SelectedIndex = -1; // Opcional: para que no seleccione nada al inicio*/

        // --- Código anterior de ejemplo (comentado) ---
        /*
        //List<clsCategoriaActivos> listaCat = _categoriaActivosService.consultarTodos();
        cbxCategorias.DataSource = listaCat;
        cbxCategorias.DisplayMember = "Nombre"; // Ajusta según la propiedad que muestre el nombre
        cbxCategorias.ValueMember = "Id"; // Ajusta según la propiedad de ID
        */
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    if (activosSelected == null) // CREAR
                    {
                        clsActivos activo = new clsActivos();
                        activo.idActivo = int.Parse(txtIdActivo.Text); // El usuario debe ingresar el ID
                        activo.nombreActivo = txtNombre.Text;
                        activo.descripcion = txtDescripcion.Text;
                        activo.estado = true;
                        activo.estadoUso = cbxEstadoUso.SelectedIndex;
                        activo.fechaAdquisicion = DateTime.Parse(txtfecha.Text);
                        activo.proveedor = txtProveedor.Text;
                        activo.ubicacion = txtUbicacion.Text;
                        activo.idCategoria = (int)cbxCategorias.SelectedValue;
                        activo.usuarioCreacion = "sistema";
                        activo.fechaCreacion = DateTime.Now;
                        activo.usuarioModificacion = "";
                        activo.fechaModificacion = null;
                        if (activo.estadoUso == 2)
                        {
                            activo.fechaDesecho = dtpFechaDesecho.Value;
                            activo.observacionDesecho = txtObservacionDesecho.Text;
                        }
                        else
                        {
                            activo.fechaDesecho = null;
                            activo.observacionDesecho = null;
                        }
                        _activoService.crear(activo);
                        MessageBox.Show("Activo creado correctamente");
                    }
                    else // MODIFICAR
                    {
                        var activo = _activoService.consultarPorID(activosSelected.idActivo);
                        if (activo == null)
                        {
                            MessageBox.Show("No se encontró el activo a modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        activo.nombreActivo = txtNombre.Text;
                        activo.descripcion = txtDescripcion.Text;
                        activo.estadoUso = cbxEstadoUso.SelectedIndex;
                        activo.fechaAdquisicion = DateTime.Parse(txtfecha.Text);
                        activo.proveedor = txtProveedor.Text;
                        activo.ubicacion = txtUbicacion.Text;
                        activo.idCategoria = (int)cbxCategorias.SelectedValue;
                        activo.usuarioModificacion = "sistema";
                        activo.fechaModificacion = DateTime.Now;
                        if (activo.estadoUso == 2)
                        {
                            activo.fechaDesecho = dtpFechaDesecho.Value;
                            activo.observacionDesecho = txtObservacionDesecho.Text;
                        }
                        else
                        {
                            activo.fechaDesecho = null;
                            activo.observacionDesecho = null;
                        }
                        _activoService.modificar(activo);
                        MessageBox.Show("Activo modificado correctamente");
                    }
                    limpiarForm();
                    this.Close();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error de formato: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidCastException ex)
            {
                MessageBox.Show($"Error de conversión de datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Referencia nula: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error desconocido: {ex.Message}\n\nInner: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // Mostrar/ocultar controles de desecho según estadoUso
        private void cbxEstadoUso_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEstadoUso.SelectedIndex == 2) // Desechado
            {
                dtpFechaDesecho.Visible = true;
                lblFechaDesecho.Visible = true;
                txtObservacionDesecho.Visible = true;
                lblObservacionDesecho.Visible = true;
            }
            else
            {
                dtpFechaDesecho.Visible = false;
                lblFechaDesecho.Visible = false;
                txtObservacionDesecho.Visible = false;
                lblObservacionDesecho.Visible = false;
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            var frmLista = new frmListaActivos();
            frmLista.ShowDialog();
        }
    }
}