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
    public partial class frmPuestos : Form
    {
        private readonly PuestoService _svc = new PuestoService();
        private readonly DepartamentosService _depSvc = new DepartamentosService();

        // null = crear
        private clsPuestos _puesto;
        public frmPuestos()
        {
            InitializeComponent();
        }

        public frmPuestos(int id) : this()
        {
            _puesto = _svc.consultarPorID(id);
        }

        private void frmPuestos_Load(object sender, EventArgs e)
        {
            var deps = _depSvc.consultarTodos();
            cboDepartamento.DataSource = deps;
            cboDepartamento.DisplayMember = "Nombre";
            cboDepartamento.ValueMember = "idDepartamento";
            cboDepartamento.DropDownStyle = ComboBoxStyle.DropDownList;

            if (_puesto == null)
            {
                // CREAR
                this.Text = "Crear Puesto";
                if (this.Controls.Find("lblTitulo", true).FirstOrDefault() is Label lbl)
                    lbl.Text = "Crear Puesto";

                btnGuardar.Text = "Crear";
                btnInactivar.Visible = false;
                btnActivar.Visible = false;

                // Campo código habilitado
                txtCodigo.Text = "";
                txtCodigo.Enabled = true;

                txtNombre.Text = "";
                txtDescripcion.Text = "";
                if (deps.Count > 0) cboDepartamento.SelectedIndex = 0;
            }
            else
            {
                // MODIFICAR
                this.Text = "Modificar Puesto";
                if (this.Controls.Find("lblTitulo", true).FirstOrDefault() is Label lbl)
                    lbl.Text = "Modificar Puesto";

                btnGuardar.Text = "Guardar cambios";
                btnInactivar.Visible = _puesto.Estado;
                btnActivar.Visible = !_puesto.Estado;

                // Mostrar código funcional y permitir editarlo
                txtCodigo.Text = _puesto.codigo;
                txtCodigo.Enabled = false;

                txtNombre.Text = _puesto.Nombre;
                txtDescripcion.Text = _puesto.descripcion ?? "";

                if (deps.Any(d => d.idDepartamento == _puesto.idDepartamento))
                    cboDepartamento.SelectedValue = _puesto.idDepartamento;
                else if (deps.Count > 0)
                    cboDepartamento.SelectedIndex = 0;
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cboDepartamento.SelectedValue == null)
                    throw new Exception("Debe seleccionar un departamento.");

                if (_puesto == null)
                {
                    // CREAR
                    var p = new clsPuestos(
                        txtCodigo.Text.Trim().ToUpper(),
                        txtNombre.Text.Trim(),
                        Convert.ToInt32(cboDepartamento.SelectedValue),
                        "admin")
                    {
                        descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim()
                    };

                    _svc.crear(p);
                }
                else
                {
                    // MODIFICAR
                    _puesto.codigo = txtCodigo.Text.Trim().ToUpper();
                    _puesto.Nombre = txtNombre.Text.Trim();
                    _puesto.descripcion = string.IsNullOrWhiteSpace(txtDescripcion.Text) ? null : txtDescripcion.Text.Trim();
                    _puesto.idDepartamento = Convert.ToInt32(cboDepartamento.SelectedValue);

                    _svc.modificar(_puesto);
                }

                MessageBox.Show("Guardado correctamente.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInactivar_Click_1(object sender, EventArgs e)
        {
            while (true)
            {
                var motivo = Microsoft.VisualBasic.Interaction.InputBox(
                    "Motivo de inactivación (obligatorio):",
                    "Inactivar puesto",
                    "");

                // Si se toca cancelar, motivo será "" o null
                if (motivo == null) return;
                motivo = motivo.Trim();

                if (motivo == "")
                {
                    // Si el usuario cancela, motivo es "" y debe salir
                    return;
                }

                try
                {
                    _svc.inactivar(_puesto.idPuesto, motivo, "admin");
                    MessageBox.Show("Puesto inactivado.");
                    DialogResult = DialogResult.OK; // refresca lista
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo inactivar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
        }

        private void btnActivar_Click_1(object sender, EventArgs e)
        {
            try
            {
                // si ya está activo, no tiene sentido
                if (_puesto != null && _puesto.Estado)
                {
                    MessageBox.Show("El puesto ya está activo.");
                    return;
                }

                _svc.reactivar(_puesto.idPuesto, "admin");

                MessageBox.Show("Puesto reactivado.");
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No se pudo reactivar",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
