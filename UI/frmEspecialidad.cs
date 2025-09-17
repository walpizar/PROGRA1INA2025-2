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
    public partial class frmEspecialidad : Form
    {
        private readonly EspecialidadService _especialidadService; // Servicio de cliente
        public clsEspecialidadMedica especialidadSelected { get; set; }  // Cliente seleccionado (para modificar)
        public frmEspecialidad()
        {
            InitializeComponent();
            _especialidadService = new EspecialidadService();   
        }

        private void frmEspecialidades_Load(object sender, EventArgs e)
        {
            if (especialidadSelected != null) // modificar
            {
                btnGuardar.Text = "Editar";
                lblTitulo.Text = "Editar Especialidad Médica";
                txtId.Text = especialidadSelected.idEspecialidadMedica.ToString();
                txtNombre.Text = especialidadSelected.nombreEspecialidad;
                txtDescripcion.Text = especialidadSelected.descripcion;
                chkEstado.Checked = especialidadSelected.estado;
            }
        }

        // Validación de datos obligatorios
        private bool validarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtId.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text)) return false;
            return true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    clsEspecialidadMedica especialidad = new clsEspecialidadMedica
                    {
                        idEspecialidadMedica = Convert.ToInt32(txtId.Text),
                        nombreEspecialidad = txtNombre.Text,
                        descripcion = txtDescripcion.Text,
                        estado = chkEstado.Checked
                    };

                    if (especialidadSelected == null) // Crear
                        _especialidadService.crear(especialidad);
                    else // Modificar
                        _especialidadService.modificar(especialidad);

                    MessageBox.Show("Especialidad guardada correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Faltan datos obligatorios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (especialidadSelected != null)
            {
                try
                {
                    DialogResult resp = MessageBox.Show("¿Desea eliminar esta especialidad?", "Confirmación", MessageBoxButtons.YesNo);
                    if (resp == DialogResult.Yes)
                    {
                        _especialidadService.eliminar(especialidadSelected.idEspecialidadMedica);
                        MessageBox.Show("Especialidad eliminada correctamente");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }
        }
    }
}
