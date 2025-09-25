using DAO;
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
    public partial class frmDepartamentos : Form
    {
        private readonly DepartamentosService _svc = new DepartamentosService();
        private clsDepartamentos _dep;
        public frmDepartamentos()
        {
            InitializeComponent();
        }

        public frmDepartamentos(int id) : this()
        {
            _dep = _svc.consultarPorID(id);
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            // CREAR
            if (_dep == null)
            {
                this.Text = "Crear Departamento";
                if (this.Controls.Find("lblTitulo", true).FirstOrDefault() is Label lbl)
                    lbl.Text = "Crear Departamento";

                btnGuardar.Text = "Crear";

                // Campo código HABILITADO para crear
                txtCodigo.Text = "";
                txtCodigo.Enabled = true;
                txtCodigo.BackColor = SystemColors.Window;
                txtCodigo.Focus();

                txtNombre.Text = "";
                txtDescripcion.Text = "";

                btnEliminar.Visible = false;
            }
            else // MODIFICAR
            {
                this.Text = "Modificar Departamento";
                if (this.Controls.Find("lblTitulo", true).FirstOrDefault() is Label lbl)
                    lbl.Text = "Modificar Departamento";

                btnGuardar.Text = "Guardar cambios";

                // Mostrar el código funcional y permitir editarlo
                txtCodigo.Text = _dep.codigoDepartamento;
                txtCodigo.Enabled = false;
                txtCodigo.BackColor = SystemColors.Window;

                txtNombre.Text = _dep.Nombre;
                txtDescripcion.Text = _dep.descripcionDepartamento;

                btnEliminar.Visible = true;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_dep == null)
                {
                    // CREAR 
                    var d = new clsDepartamentos
                    {
                        // idDepartamento se asigna automáticamente
                        codigoDepartamento = txtCodigo.Text.Trim().ToUpper(), // Normalizar a mayúsculas
                        Nombre = txtNombre.Text.Trim(),
                        descripcionDepartamento = txtDescripcion.Text.Trim(),
                        usuario_crea = "IAN",
                        fecha_crea = DateTime.UtcNow
                    };
                    _svc.crear(d);
                }
                else
                {
                    // MODIFICAR - NO cambiar el ID, solo los campos editables
                    _dep.codigoDepartamento = txtCodigo.Text.Trim().ToUpper();
                    _dep.Nombre = txtNombre.Text.Trim();
                    _dep.descripcionDepartamento = txtDescripcion.Text.Trim();
                    _dep.fecha_ult_mod = DateTime.UtcNow;
                    _dep.usuario_ult_mod = "Admin";
                    _svc.modificar(_dep);
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

        private void btnEliminar_Click_1(object sender, EventArgs e)
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
                    _svc.eliminar(_dep.idDepartamento, motivo, "admin");
                    MessageBox.Show("Departamento eliminado.");
                    DialogResult = DialogResult.OK; // refresca lista
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "No se pudo eliminar",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }
        }
    }
}
