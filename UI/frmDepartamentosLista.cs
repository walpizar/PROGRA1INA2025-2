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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI
{
    public partial class frmDepartamentosLista : Form
    {
        private readonly DepartamentosService _svc = new DepartamentosService();
        private List<clsDepartamentos> _cache = new();

        public frmDepartamentosLista()
        {
            InitializeComponent();
        }

        private void frmDepartamentosLista_Load(object sender, EventArgs e)
        {
            // Configuración visual del ListView
            lstvListaDept.View = View.Details;
            lstvListaDept.FullRowSelect = true;
            lstvListaDept.GridLines = true;
            lstvListaDept.HideSelection = false; // Mantiene selección visible

            if (lstvListaDept.Columns.Count == 0)
            {
                lstvListaDept.Columns.Add("Código", 110);
                lstvListaDept.Columns.Add("Nombre", 200);
                lstvListaDept.Columns.Add("Descripción", 320);
            }

            CargarDepartamentos();
        }

        private void CargarDepartamentos()
        {
            try
            {
                _cache = _svc.consultarTodos(); // CORREGIDO: Sin asteriscos
                RefrescarListView(_cache);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar departamentos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarListView(List<clsDepartamentos> data)
        {
            lstvListaDept.Items.Clear();

            foreach (var d in data)
            {
                var item = new ListViewItem(d.codigoDepartamento ?? ""); // Mostrar código funcional
                item.SubItems.Add(d.Nombre ?? "");
                item.SubItems.Add(d.descripcionDepartamento ?? "");
                item.Tag = d.idDepartamento; // Guardamos el ID técnico para referencia
                lstvListaDept.Items.Add(item);
            }

            // Actualizar información en la barra de estado o título
            this.Text = $"Lista de Departamentos ({data.Count})";
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (var frm = new frmDepartamentos()) // Crear nuevo departamento
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        CargarDepartamentos(); // Refrescar lista después de crear
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de creación: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstvListaDept_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstvListaDept.SelectedItems.Count == 0) return;

                var selectedItem = lstvListaDept.SelectedItems[0];
                if (selectedItem.Tag == null)
                {
                    MessageBox.Show("No hay ID asociado al elemento seleccionado.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int departamentoId = Convert.ToInt32(selectedItem.Tag);

                using (var frm = new frmDepartamentos(departamentoId)) // Editar departamento existente
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        CargarDepartamentos(); // Refrescar lista después de editar
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el editor: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método opcional para botón de editar si lo tienes
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (lstvListaDept.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un departamento para editar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Simular doble click
            lstvListaDept_MouseDoubleClick_1(sender, null);
        }

        // Método opcional para botón de eliminar si lo tienes
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lstvListaDept.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar un departamento para eliminar.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var selectedItem = lstvListaDept.SelectedItems[0];
                int departamentoId = Convert.ToInt32(selectedItem.Tag);

                var departamento = _cache.FirstOrDefault(d => d.idDepartamento == departamentoId);
                if (departamento == null) return;

                var result = MessageBox.Show(
                    $"¿Está seguro de que desea eliminar el departamento '{departamento.Nombre}'?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    _svc.eliminar(departamentoId);
                    CargarDepartamentos(); // Refrescar lista
                    MessageBox.Show("Departamento eliminado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar departamento: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = txtBusqueda.Text.Trim().ToUpper();

                if (string.IsNullOrWhiteSpace(query))
                {
                    RefrescarListView(_cache);
                    return;
                }

                var filtrados = _cache.Where(p =>
                       p.idDepartamento.ToString().Contains(query)
                    || (p.Nombre ?? "").ToUpper().Contains(query)
                    || (p.descripcionDepartamento ?? "").ToUpper().Contains(query)
                ).ToList();

                RefrescarListView(filtrados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}