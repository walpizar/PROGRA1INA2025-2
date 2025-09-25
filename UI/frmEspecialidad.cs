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
            if (especialidadSelected != null) //SE MOFICICA
            {
                btnGuardar.Text = "Editar";
                lblTitulo.Text = "Editar Especialidad Médica";
                txtId.Text = especialidadSelected.idEspecialidadMedica.ToString();
                txtNombre.Text = especialidadSelected.nombreEspecialidad;
                txtDescripcion.Text = especialidadSelected.descripcion;

                // INHABILITAR EDICIÓN DEL CAMPO ID
                txtId.Enabled = false;
                txtId.ReadOnly = true;
                btnEliminar.Visible = true; // Mostrar botón de eliminar
            }
            else
            {
                btnEliminar.Visible = false; // Ocultar botón al crear
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
                    if (especialidadSelected == null) // Crear
                    {
                        // CREAR NUEVA ESPECIALIDAD
                        clsEspecialidadMedica nuevaEspecialidad = new clsEspecialidadMedica
                        {
                            idEspecialidadMedica = Convert.ToInt32(txtId.Text),
                            nombreEspecialidad = txtNombre.Text,
                            descripcion = txtDescripcion.Text,
                            estado = true
                        };
                        _especialidadService.crear(nuevaEspecialidad);
                    }
                    else // Modificar
                    {
                        // MODIFICAR EL OBJETO EXISTENTE
                        especialidadSelected.nombreEspecialidad = txtNombre.Text;
                        especialidadSelected.descripcion = txtDescripcion.Text;

                        _especialidadService.modificar(especialidadSelected);
                    }

                    MessageBox.Show("Especialidad actualizada correctamente");
                    this.DialogResult = DialogResult.OK;
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
        // Cerrar el formulario sin guardar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
                        especialidadSelected.estado = false; // marcar como inactivo
                        _especialidadService.modificar(especialidadSelected);
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

        private void gbxDatosEspecialidad_Enter(object sender, EventArgs e)
        {


        }
    }
}
