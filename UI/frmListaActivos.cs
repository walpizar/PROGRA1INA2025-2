using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class frmListaActivos : Form
    {
        List<clsActivos> lista;
        private readonly ActivosServices _activoService;

        public frmListaActivos()
        {
            InitializeComponent();
            InicializarColumnasListView();
            _activoService = new ActivosServices();
        }

        private void frmListaActivos_Load(object sender, EventArgs e)
        {
            try
            {
                //Verificar conexión primero
                if (!VerificarConexion())
                {
                    MessageBox.Show("No se puede conectar a la base de datos.",
                                  "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Cargar lista con manejo detallado de errores
                CargarListaConManejo();
                //this.lista = _activoService.consultarTodos();
               // cargarLista(lista);

            }
            catch (Exception ex)
            {
                MostrarErrorDetallado("Error al inicializar el formulario", ex);
                // Inicializar lista vacía para evitar errores posteriores
                //lista = new List<clsActivos>();
                //cargarLista(lista);
            }
        }

        private void CargarListaConManejo()
        {
            try
            {
                // Intentar cargar datos
                this.lista = _activoService.consultarTodos();

                if (lista == null)
                {
                    MessageBox.Show("La consulta no devolvió datos. Inicializando lista vacía.",
                                  "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lista = new List<clsActivos>();
                }

                cargarLista(lista);
            }
            catch (System.Data.Common.DbException dbEx)
            {
                MessageBox.Show($"Error de base de datos: {dbEx.Message}\n\n" +
                              "Verifique:\n" +
                              "- La conexión a la base de datos\n" +
                              "- Los permisos de usuario\n" +
                              "- La estructura de las tablas",
                              "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lista = new List<clsActivos>();
                cargarLista(lista);
            }
            catch (System.InvalidOperationException invEx)
            {
                MessageBox.Show($"Error de operación: {invEx.Message}\n\n" +
                              "Esto puede indicar:\n" +
                              "- Datos inconsistentes en la base de datos\n" +
                              "- Referencias rotas entre tablas\n" +
                              "- Campos con valores NULL inesperados",
                              "Error de Datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lista = new List<clsActivos>();
                cargarLista(lista);
            }
            catch (Exception ex)
            {
                MostrarErrorDetallado("Error al consultar activos", ex);
                lista = new List<clsActivos>();
                cargarLista(lista);
            }
        }

        private bool VerificarConexion()
        {
            try
            {
                using (var context = new DAO.dbContextINA())
                {
                    return context.Database.CanConnect();
                }
            }
            catch
            {
                return false;
            }
        }

        private void MostrarErrorDetallado(string titulo, Exception ex)
        {
            string mensaje = $"{titulo}:\n\n" +
                           $"Tipo: {ex.GetType().Name}\n" +
                           $"Mensaje: {ex.Message}\n";

            if (ex.InnerException != null)
            {
                mensaje += $"\nError interno: {ex.InnerException.Message}";
            }

            MessageBox.Show(mensaje, "Error Detallado", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cargarLista(List<clsActivos> lista)
        {
            lstvListaActivos.Items.Clear();

            // Mostrar todos los activos, incluyendo los dados de baja
            var activosList = lista ?? new List<clsActivos>();
            foreach (clsActivos activos in activosList)
            {
                try
                {
                    if (activos == null || activos.idActivo <= 0) continue;

                    // Manejo seguro de nulos en todas las propiedades
                    string nombreActivo = activos.nombreActivo ?? "Sin nombre";
                    string descripcion = activos.descripcion ?? "Sin descripción";
                    string idCategoria = activos.idCategoria.ToString();
                    string nombreCategoria = activos.categoria != null && activos.categoria.nombre != null ? activos.categoria.nombre : "Sin categoría";
                    string estadoUso = estadoUsoToString(activos.estadoUso);
                    string estado = activos.estado ? "Activo" : "Dado de baja";

                    ListViewItem item = new ListViewItem(activos.idActivo.ToString());
                    item.SubItems.Add(nombreActivo);
                    item.SubItems.Add(descripcion);
                    item.SubItems.Add(idCategoria);
                    item.SubItems.Add(nombreCategoria);
                    item.SubItems.Add(estadoUso);
                    item.SubItems.Add(estado);

                    lstvListaActivos.Items.Add(item);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error al cargar activo ID {activos?.idActivo}: {ex.Message}");
                }
            }
        }

        private string estadoUsoToString(int estadoUso)
        {
            switch (estadoUso)
            {
                case 0: return "Disponible";
                case 1: return "Prestado";
                case 2: return "Desechado";
                case 3: return "En uso";
                default: return $"Estado {estadoUso}";
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (lista == null || string.IsNullOrWhiteSpace(txtBusqueda.Text))
                {
                    cargarLista(lista ?? new List<clsActivos>());
                    return;
                }

                string busqueda = txtBusqueda.Text.ToUpper();

                var listaFiltrada = lista.Where(p =>
                    (p.idActivo.ToString().Contains(busqueda)) ||
                    (p.nombreActivo != null && p.nombreActivo.ToUpper().Contains(busqueda)) ||
                    (p.descripcion != null && p.descripcion.ToUpper().Contains(busqueda)) ||
                    (p.proveedor != null && p.proveedor.ToUpper().Contains(busqueda)) ||
                    (p.ubicacion != null && p.ubicacion.ToUpper().Contains(busqueda)) ||
                    (p.categoria?.nombre != null && p.categoria.nombre.ToUpper().Contains(busqueda))
                ).ToList();

                cargarLista(listaFiltrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lstvListaActivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstvListaActivos.SelectedItems.Count > 0)
                {
                    int id = int.Parse(lstvListaActivos.SelectedItems[0].SubItems[0].Text);
                    clsActivos activos = lista?.FirstOrDefault(p => p.idActivo == id);

                    if (activos != null)
                    {
                        frmActivos frmActivos = new frmActivos();
                        frmActivos.activosSelected = activos;

                        DialogResult result = frmActivos.ShowDialog();

                        if (result == DialogResult.OK)
                        {
                            RefrescarLista();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el activo seleccionado.",
                                      "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el activo: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                frmActivos frmActivos = new frmActivos();
                DialogResult result = frmActivos.ShowDialog();

                if (result == DialogResult.OK)
                {
                    RefrescarLista();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear activo: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarLista()
        {
            CargarListaConManejo();
        }

        // Botón para limpiar datos problemáticos (agregar al formulario si es necesario)
        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Está seguro de que desea limpiar los datos problemáticos?\n\n" +
                "Esto actualizará registros con campos NULL y puede afectar los datos.",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    _activoService.LimpiarDatosProblematicos();
                    MessageBox.Show("Datos limpiados correctamente.", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefrescarLista();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al limpiar datos: {ex.Message}",
                                  "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InicializarColumnasListView()
        {
            lstvListaActivos.View = View.Details;
            lstvListaActivos.FullRowSelect = true;
            lstvListaActivos.GridLines = true;
            lstvListaActivos.Columns.Clear();
            lstvListaActivos.Columns.Add("ID", 60);
            lstvListaActivos.Columns.Add("Nombre", 120);
            lstvListaActivos.Columns.Add("Descripción", 150);
            lstvListaActivos.Columns.Add("ID Categoría", 80);
            lstvListaActivos.Columns.Add("Categoría", 120);
            lstvListaActivos.Columns.Add("Estado Uso", 100);
            lstvListaActivos.Columns.Add("Estado", 80);
        }
    }
}
