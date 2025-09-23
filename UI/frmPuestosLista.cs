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
    public partial class frmPuestosLista : Form
    {
        private readonly PuestoService _svc = new PuestoService();
        private List<clsPuestos> _cache = new();

        public frmPuestosLista()
        {
            InitializeComponent();
        }

        private void frmPuestosLista_Load(object sender, EventArgs e)
        {
            lstvListaPuestos.View = View.Details;
            lstvListaPuestos.FullRowSelect = true;
            lstvListaPuestos.GridLines = true;
            lstvListaPuestos.HideSelection = false;

            CargarPuestos();

        }

        private void CargarPuestos()
        {
            try
            {
                _cache = _svc.consultarTodos();
                RefrescarListView(_cache);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar puestos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarListView(List<clsPuestos> data)
        {
            lstvListaPuestos.Items.Clear();

            foreach (var p in data)
            {
                var item = new ListViewItem(p.codigo ?? "");
                item.SubItems.Add(p.Nombre ?? "");
                item.SubItems.Add(p.descripcion ?? "");
                item.SubItems.Add(p.Estado ? "ACTIVO" : "INACTIVO");
                item.SubItems.Add(p.Departamento?.Nombre ?? "Sin departamento");
                // Guardamos el ID para referencia
                item.Tag = p.idPuesto;

                // Cambiar color para puestos inactivos
                if (!p.Estado)
                {
                    item.ForeColor = Color.DarkRed;
                    item.Font = new Font(item.Font, FontStyle.Italic);
                }

                lstvListaPuestos.Items.Add(item);
            }

            // Actualizar información en el título
            this.Text = $"Lista de Puestos ({data.Count})";
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {// Crear nuevo puesto
                using (var frm = new frmPuestos())
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        CargarPuestos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de creación: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBusqueda_TextChanged_1(object sender, EventArgs e)
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
                       p.idPuesto.ToString().Contains(query)
                    || (p.Nombre ?? "").ToUpper().Contains(query)
                    || (p.codigo ?? "").ToUpper().Contains(query)
                    || (p.descripcion ?? "").ToUpper().Contains(query)
                    || (p.Departamento?.Nombre ?? "").ToUpper().Contains(query)
                ).ToList();

                RefrescarListView(filtrados);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstvListaPuestos_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstvListaPuestos.SelectedItems.Count == 0) return;

                int puestoId = Convert.ToInt32(lstvListaPuestos.SelectedItems[0].Tag);

                // Editar puesto existente
                using (var frm = new frmPuestos(puestoId))
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        CargarPuestos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el editor: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}