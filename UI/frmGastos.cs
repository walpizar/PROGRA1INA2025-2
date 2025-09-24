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
    public partial class frmGastos : Form
    {
        private readonly GastosService _svc = new GastosService();
        private clsGastos _gasto;

        public frmGastos()
        {
            InitializeComponent();
        }

        public frmGastos(int id) : this()
        {
            _gasto = _svc.consultarPorID(id);
        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
            // CREAR
            if (_gasto == null)
            {
                this.Text = "Registrar Gasto";
                if (this.Controls.Find("lblTitulo", true).FirstOrDefault() is Label lbl)
                    lbl.Text = "Registrar Gasto";

                btnGuardar.Text = "Guardar";

                // Limpiar campos
                txtProductoComprado.Text = "";
                txtResponsable.Text = "";
                txtMonto.Text = "";
                txtNumFactura.Text = "";
                txtJustificacion.Text = "";
                dtmCompra.Value = DateTime.Today;
                btnEliminar.Visible = false;
            }
            else // MODIFICAR
            {
                this.Text = "Modificar Gasto";
                if (this.Controls.Find("lblTitulo", true).FirstOrDefault() is Label lbl)
                    lbl.Text = "Modificar Gasto";

                btnGuardar.Text = "Guardar cambios";

                dtmCompra.Enabled = false;
                btnEliminar.Visible = true;

                // Cargar datos del gasto
                txtProductoComprado.Text = _gasto.queSeCompro;
                txtResponsable.Text = _gasto.responsable;
                txtMonto.Text = _gasto.montoGasto.ToString("F2");
                txtNumFactura.Text = _gasto.numeroFactura ?? "";
                txtJustificacion.Text = _gasto.descripcion;
                dtmCompra.Value = _gasto.fechaCompra;
            }
            // se me estaba bugueando el txtJustificacion entonces le puse estas propiedades quemadas aqui para arreglarlo.
            txtJustificacion.Multiline = false;
            txtJustificacion.ScrollBars = ScrollBars.None;
            txtJustificacion.AcceptsReturn = false;
            txtJustificacion.AcceptsTab = false;
            txtJustificacion.WordWrap = false;
            txtJustificacion.AutoSize = true;
            txtJustificacion.Height = txtJustificacion.PreferredHeight;
        }

        private void TxtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Solo permitir números, punto decimal y backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Solo permitir un punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones básicas de UI
                if (string.IsNullOrWhiteSpace(txtProductoComprado.Text))
                {
                    MessageBox.Show("Debe indicar qué se compró.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtProductoComprado.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtResponsable.Text))
                {
                    MessageBox.Show("Debe indicar el responsable.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtResponsable.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtMonto.Text))
                {
                    MessageBox.Show("Debe ingresar el monto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonto.Focus();
                    return;
                }

                if (!decimal.TryParse(txtMonto.Text, out decimal monto))
                {
                    MessageBox.Show("El monto debe ser un número válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtMonto.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtJustificacion.Text))
                {
                    MessageBox.Show("Debe ingresar la justificación del gasto.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtJustificacion.Focus();
                    return;
                }

                if (_gasto == null)
                {
                    // CREAR nuevo gasto
                    var nuevoGasto = new clsGastos(
                        monto,
                        txtResponsable.Text.Trim(),
                        dtmCompra.Value.Date,
                        txtProductoComprado.Text.Trim(),
                        txtJustificacion.Text.Trim(),
                        "admin",
                        string.IsNullOrWhiteSpace(txtNumFactura.Text) ? null : txtNumFactura.Text.Trim()
                    );

                    _svc.crear(nuevoGasto);
                    MessageBox.Show("Gasto registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // MODIFICAR gasto existente
                    _gasto.queSeCompro = txtProductoComprado.Text.Trim();
                    _gasto.responsable = txtResponsable.Text.Trim();
                    _gasto.montoGasto = monto;
                    _gasto.numeroFactura = string.IsNullOrWhiteSpace(txtNumFactura.Text) ? null : txtNumFactura.Text.Trim();
                    _gasto.descripcion = txtJustificacion.Text.Trim();
                    _gasto.fechaCompra = dtmCompra.Value.Date;
                    _gasto.fecha_ult_mod = DateTime.Now;
                    _gasto.usuario_ult_mod = "admin";

                    _svc.modificar(_gasto);
                    MessageBox.Show("Gasto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_gasto == null)
            {
                MessageBox.Show("No hay un gasto seleccionado para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(
                "¿Está seguro que desea eliminar este gasto? Esta acción solo lo inactivará.",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _svc.eliminar(_gasto.idGasto);
                    MessageBox.Show("Gasto eliminado (inactivado) correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el gasto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}