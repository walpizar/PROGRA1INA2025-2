using Entities;
using Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmActivos : Form
    {
        public clsActivos activosSelected { get; set; }
        private readonly ActivosServices _activoService;
        private readonly CategoriaActivosService _categoriaActivosService;

        public frmActivos()
        {
            InitializeComponent();
            _activoService = new ActivosServices();
            _categoriaActivosService = new CategoriaActivosService(new DAO.CategoriaActivosDAO(new DAO.dbContextINA()));
        }

        private void frmActivos_Load(object sender, EventArgs e)
        {
            try
            {
                cargarCombos();

                if (activosSelected != null) // acción de modificar
                {
                    this.lblTitulo.Text = "Modificar Activos";
                    this.Text = "Modificar Activos";
                    this.txtIdActivo.Enabled = false;
                    btnGuardar.Text = "Modificar";
                    btnEliminar.Visible = true;
                    cargarForm();
                }
                else // acción crear
                {
                    this.lblTitulo.Text = "Crear Activos";
                    this.Text = "Crear Activos";
                    this.txtIdActivo.Enabled = false;
                    btnGuardar.Text = "Guardar";
                    btnEliminar.Visible = false;

                    limpiarForm();
                    // No asignar ID manualmente si la base de datos lo genera
                    txtIdActivo.Text = ""; // O dejarlo vacío si no necesitas mostrarlo
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarForm()
        {
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
                    else
                        dtpFechaDesecho.Value = DateTime.Now;

                    txtObservacionDesecho.Text = activosSelected.observacionDesecho ?? "";
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

        private void cargarCombos()
        {
            try
            {
                var listaCat = _categoriaActivosService.consultarTodos();
                if (listaCat == null || !listaCat.Any())
                {
                    MessageBox.Show("No se encontraron categorías en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cbxCategorias.DataSource = null;
                }
                else
                {
                    cbxCategorias.DataSource = listaCat;
                    cbxCategorias.DisplayMember = "nombre";
                    cbxCategorias.ValueMember = "Id";
                    cbxCategorias.SelectedIndex = -1;
                }

                cbxEstadoUso.Items.Clear();
                cbxEstadoUso.Items.AddRange(new object[] { "Disponible", "Prestado", "Desechado", "En uso" });
                cbxEstadoUso.SelectedIndex = 0;

                cbxEstadoUso.SelectedIndexChanged += cbxEstadoUso_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxCategorias.DataSource = null;
            }
        }

        private void cbxEstadoUso_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool esDesechado = cbxEstadoUso.SelectedIndex == 2;

            dtpFechaDesecho.Visible = esDesechado;
            lblFechaDesecho.Visible = esDesechado;
            txtObservacionDesecho.Visible = esDesechado;
            lblObservacionDesecho.Visible = esDesechado;

            if (esDesechado)
            {
                dtpFechaDesecho.Value = DateTime.Now;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    clsActivos activo;
                    int id = 0;

                    if (activosSelected == null) // Crear nuevo activo
                    {
                        activo = new clsActivos
                        {
                            nombreActivo = txtNombre.Text,
                            descripcion = txtDescripcion.Text,
                            fechaAdquisicion = DateTime.Parse(txtfecha.Text),
                            proveedor = txtProveedor.Text,
                            ubicacion = txtUbicacion.Text,
                            idCategoria = (int)cbxCategorias.SelectedValue,
                            estadoUso = cbxEstadoUso.SelectedIndex,
                            estado = true, // Establecer explícitamente a true
                            fechaCreacion = DateTime.Now, // Asegúrate de que esto se establezca
                            usuarioCreacion = "sistema",
                            observacionDesecho = null
                        };

                        if (cbxEstadoUso.SelectedIndex == 2) // Desechado
                        {
                            activo.fechaDesecho = dtpFechaDesecho.Value;
                            activo.observacionDesecho = string.IsNullOrWhiteSpace(txtObservacionDesecho.Text) ? null : txtObservacionDesecho.Text;
                        }

                        using (var service = new ActivosServices())
                        {
                            service.crear(activo);
                        }
                        MessageBox.Show("Activo creado correctamente");
                        this.DialogResult = DialogResult.OK;
                    }
                    else // Modificar activo existente
                    {
                        id = int.Parse(txtIdActivo.Text);
                        activo = _activoService.consultarPorID(id);
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

                        if (activo.estadoUso == 2) // Desechado
                        {
                            activo.fechaDesecho = dtpFechaDesecho.Value;
                            activo.observacionDesecho = string.IsNullOrWhiteSpace(txtObservacionDesecho.Text) ? null : txtObservacionDesecho.Text;
                        }
                        else
                        {
                            activo.fechaDesecho = null;
                            activo.observacionDesecho = null;
                        }

                        using (var service = new ActivosServices())
                        {
                            service.modificar(activo);
                        }
                        MessageBox.Show("Activo modificado correctamente");
                        this.DialogResult = DialogResult.OK;
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}\n\nDetalles: {ex.InnerException?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtfecha.Text) || !DateTime.TryParse(txtfecha.Text, out DateTime fecha))
            {
                MessageBox.Show("La fecha de adquisición es obligatoria y debe ser válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfecha.Focus();
                return false;
            }

            if (fecha > DateTime.Now)
            {
                MessageBox.Show("La fecha de adquisición no puede ser futura", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtfecha.Focus();
                return false;
            }

            if (cbxCategorias.SelectedValue == null || cbxCategorias.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una categoría válida", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbxCategorias.Focus();
                return false;
            }

            if (cbxEstadoUso.SelectedIndex == 2) // Desechado
            {
                if (dtpFechaDesecho.Value < fecha)
                {
                    MessageBox.Show("La fecha de desecho no puede ser anterior a la fecha de adquisición", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpFechaDesecho.Focus();
                    return false;
                }
            }

            return true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (activosSelected != null)
            {
                DialogResult resp = MessageBox.Show("¿Está seguro que desea eliminar el activo?", "Confirmación",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    try
                    {
                        _activoService.eliminarLogico(activosSelected.idActivo);
                        MessageBox.Show("Activo eliminado correctamente");
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            try
            {
                var frmLista = new frmListaActivos();
                frmLista.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir la lista: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gbxClientes_Enter(object sender, EventArgs e)
        {

        }
    }
}
