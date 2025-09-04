using Common.Enums;
using Common.Exceptions;
using Common.Utils;
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
using static Common.Enums.Enums;

namespace UI
{
    public partial class frmMedico : Form
    {
        public clsMedico medicoSelected { get; set; }

        private readonly MedicoService _medicoService;

        public frmMedico()
        {
            _medicoService = new MedicoService();
            InitializeComponent();
        }

        private void frmMedico_Load(object sender, EventArgs e)
        {
            if (medicoSelected != null) //accion de modificar
            {
                this.lblTitulo.Text = "Modificar Medico";
                this.Text = "Modificar Medico";
                this.txtId.Enabled = false; //no se puede modificar el id
                btnGuardar.Text = "Modificar";
                btnEliminar.Visible = true; //muestro el boton de eliminar
                cargarForm();

            }
            else //medicoSelected es null, accion es crear
            {
                this.lblTitulo.Text = "Crear Medico";
                this.Text = "Crear Medico";
                this.txtId.Enabled = true; //se puede ingresar el id
                btnGuardar.Text = "Guardar";
                btnEliminar.Visible = false; //oculto el boton de eliminar
                limpiarForm();
            }
        }

        private void limpiarForm()
        {
            txtId.Text = "";
            txtTipoId.Text = "";
            txtNombre.Text = "";
            txtPrimerApellido.Text = "";
            txtSegundoApellido.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtEspecialidad.Text = "";
            txtEstado.Text = "";
        }

        private void cargarForm()
        {
            txtId.Text = medicoSelected.id.ToString();
            txtTipoId.Text = medicoSelected.tipoId.ToString();
            txtNombre.Text = medicoSelected.persona.nombre;
            txtPrimerApellido.Text = medicoSelected.persona.apellido1;
            txtSegundoApellido.Text = medicoSelected.persona.apellido2;
            dtpFechaNacimiento.Value = medicoSelected.persona.fechaNac;
            txtEmail.Text = medicoSelected.persona.email;
            txtDireccion.Text = medicoSelected.persona.direccion;
            txtTelefono.Text = medicoSelected.persona.telefono;
            txtEspecialidad.Text = medicoSelected.especialidad;
            txtEstado.Text = medicoSelected.persona.estado.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuarioActual = obtenerUsuario();
                var medicoService = new MedicoService(usuarioActual);

                if (ValidarDatos())
                {
                    //Asignacion de los datos a la entidad cliente
                    clsMedico medico = medicoSelected == null ? new clsMedico { persona = new clsPersona() } : _medicoService.consultarPorID(medicoSelected.id, medicoSelected.tipoId);
                    medico.id = txtId.Text;
                    medico.tipoId = Convert.ToInt32(txtTipoId.Text);
                    medico.persona.nombre = txtNombre.Text;
                    medico.persona.apellido1 = txtPrimerApellido.Text;
                    medico.persona.apellido2 = txtSegundoApellido.Text;
                    medico.especialidad = txtEspecialidad.Text;
                    medico.persona.fechaNac = dtpFechaNacimiento.Value;
                    medico.persona.email = txtEmail.Text;
                    medico.persona.direccion = txtDireccion.Text;
                    medico.persona.telefono = txtTelefono.Text;
                    medico.estado = Convert.ToBoolean(txtEstado.Text);

                    if (medicoSelected == null)
                    {
                        _medicoService.crear(medico);
                        //Mensaje de exito
                        MessageBox.Show("Medico creado con exito");
                    }
                    else
                    {
                        medico.idPersona = medicoSelected.idPersona; // Mantener el idPersona existente
                        _medicoService.modificar(medico);
                        //Mensaje de exito
                        MessageBox.Show("Medico modificado con exito");
                    }
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //Mensaje de error en caso de que algo falle
                MessageBox.Show(ex.Message);
            }
        }

        private string obtenerUsuario()
        {
            return Environment.UserName;
        }

        private bool ValidarDatos()
        {
            // Validación de datos de entrada
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("El campo ID es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtTipoId.Text))
            {
                MessageBox.Show("El campo Tipo ID es obligatorio y debe ser un valor válido.");
                return false;
            }
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtPrimerApellido.Text))
            {
                MessageBox.Show("El campo Primer Apellido es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtSegundoApellido.Text))
            {
                MessageBox.Show("El campo Segundo Apellido es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEspecialidad.Text))
            {
                MessageBox.Show("El campo Especialidad es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEmail.Text) || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("El correo es obligatorio y debe tener un formato válido.");
                return false;
            }
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("El campo Dirección es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono es obligatorio.");
                return false;
            }
            if (string.IsNullOrEmpty(txtEstado.Text) || !bool.TryParse(txtEstado.Text, out bool estado))
            {
                MessageBox.Show("El campo Estado es obligatorio y debe ser 'true' o 'false'.");
                return false;
            }
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult resp = MessageBox.Show("¿Está seguro que desea eliminar al medico?", "Confirmación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    _medicoService.eliminar(medicoSelected.id, medicoSelected.tipoId);
                    MessageBox.Show("Medico eliminado");
                    this.Close(); //cierro el formulario
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar medico.");
            }
        }
    }
}
