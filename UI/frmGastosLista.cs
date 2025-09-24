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
    public partial class frmGastosLista : Form
    {
        private readonly GastosService _svc = new GastosService();
        private List<clsGastos> _cache = new();

        public frmGastosLista()
        {
            InitializeComponent();
        }

        private void frmGastosLista_Load(object sender, EventArgs e)
        {

            CargarGastos();
        }

        private void CargarGastos()
        {
            try
            {
                _cache = _svc.consultarTodos();
                RefrescarListView(_cache);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar gastos: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefrescarListView(List<clsGastos> data)
        {
            lstvListaGastos.Items.Clear();

            foreach (var gasto in data)
            {
                var item = new ListViewItem(gasto.queSeCompro ?? "");
                item.SubItems.Add(gasto.responsable ?? "");
                item.SubItems.Add(gasto.montoGasto.ToString());
                item.SubItems.Add(gasto.numeroFactura ?? "-");
                item.SubItems.Add(gasto.fechaCompra.ToString("dd/MM/yyyy"));

                var justificacionCorta = gasto.descripcion?.Length > 50
                    ? gasto.descripcion.Substring(0, 50) + "..."
                    : gasto.descripcion ?? "";
                item.SubItems.Add(justificacionCorta);

                item.Tag = gasto.idGasto;

                item.ToolTipText = $"Justificación completa: {gasto.descripcion}\n" +
                                  $"Registrado: {gasto.fechaRegistro:dd/MM/yyyy HH:mm}\n" +
                                  $"Por: {gasto.usuario_crea}";

                lstvListaGastos.Items.Add(item);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                using (var frm = new frmGastos())
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        CargarGastos(); // Refrescar lista después de crear
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de creación: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstvListaGastos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (lstvListaGastos.SelectedItems.Count == 0) return;

                int gastoId = Convert.ToInt32(lstvListaGastos.SelectedItems[0].Tag);

                using (var frm = new frmGastos(gastoId))
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                        CargarGastos();
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
