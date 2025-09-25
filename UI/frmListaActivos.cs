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
        private readonly ActivosServices _activoService;
        private List<clsActivos> lista;

        public frmListaActivos()
        {
            InitializeComponent();
            _activoService = new ActivosServices();
            InicializarColumnasListView();
        }

        private void frmListaActivos_Load(object sender, EventArgs e)
        {
            try
            {
                if (!VerificarConexion())
                {
                    MessageBox.Show("No se puede conectar a la base de datos.",
                                    "Error de Conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CargarListaConManejo();
            }
            catch (Exception ex)
            {
                MostrarErrorDetallado("Error al inicializar el formulario", ex);
                lista = new List<clsActivos>();
                cargarLista(lista);
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

        private void CargarListaConManejo()
        {
            try
            {
                lista = _activoService.consultarTodos();
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

        private void cargarLista(List<clsActivos> lista)
        {
            lstvListaActivos.Items.Clear();
            var activosList = lista ?? new List<clsActivos>();
            foreach (clsActivos activo in activosList)
            {
                try
                {
                    if (activo == null || activo.idActivo <= 0) continue;

                    string nombreActivo = activo.nombreActivo ?? "Sin nombre";
                    string descripcion = activo.descripcion ?? "Sin descripción";
                    string idCategoria = activo.idCategoria.ToString();
                    string nombreCategoria = activo.categoria != null && activo.categoria.nombre != null ? activo.categoria.nombre : "Sin categoría";
                    string estadoUso = estadoUsoToString(activo.estadoUso);
                    string estado = activo.Estado ? "Activo" : "Dado de baja";

                    var item = new ListViewItem(activo.idActivo.ToString());
                    item.SubItems.Add(nombreActivo);
                    item.SubItems.Add(descripcion);
                    item.SubItems.Add(idCategoria);
                    item.SubItems.Add(nombreCategoria);
                    item.SubItems.Add(estadoUso);
                    item.SubItems.Add(estado);
                    item.Tag = activo;

                    // Resaltar activos con Estado = false (Dado de baja) con fondo gris claro
                    if (!activo.Estado)
                    {
                        item.BackColor = System.Drawing.Color.LightGray; // Mejora visual
                    }

                    lstvListaActivos.Items.Add(item);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error al cargar activo ID {activo?.idActivo}: {ex.Message}");
                }
            }
        }

        private string estadoUsoToString(int estadoUso)
        {
            return estadoUso switch
            {
                0 => "Disponible",
                1 => "Prestado",
                2 => "Desechado",
                3 => "En uso",
                _ => $"Estado {estadoUso}"
            };
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

                string busqueda = txtBusqueda.Text.ToLower();
                var listaFiltrada = lista.Where(a =>
                    (a.idActivo.ToString().Contains(busqueda)) ||
                    (a.nombreActivo != null && a.nombreActivo.ToLower().Contains(busqueda)) ||
                    (a.descripcion != null && a.descripcion.ToLower().Contains(busqueda)) ||
                    (a.proveedor != null && a.proveedor.ToLower().Contains(busqueda)) ||
                    (a.ubicacion != null && a.ubicacion.ToLower().Contains(busqueda)) ||
                    (a.categoria?.nombre != null && a.categoria.nombre.ToLower().Contains(busqueda))
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
                    var activo = (clsActivos)lstvListaActivos.SelectedItems[0].Tag;
                    if (activo != null)
                    {
                        using (frmActivos frm = new frmActivos())
                        {
                            frm.activosSelected = activo;
                            if (frm.ShowDialog() == DialogResult.OK)
                            {
                                RefrescarLista();
                            }
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
                using (frmActivos frm = new frmActivos())
                {
                    frm.activosSelected = null;
                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        RefrescarLista();
                    }
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
    }
}