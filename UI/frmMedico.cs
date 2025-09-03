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
