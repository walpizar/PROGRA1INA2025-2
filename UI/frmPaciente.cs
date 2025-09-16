using Common.Exceptions;
using Common.Interfaces;
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
    public partial class frmPaciente : Form
    {
        //creo propiedad glogabal para pacienteSelected para saber si estoy en modo edicion o modo creacion
        public clsPaciente pacienteSelected { get; set; }

        //declaro para instancia el PacienteService para ir de la capa UI a la capa Services
        private readonly PacienteService _pacienteService;


        public frmPaciente()
        {
            InitializeComponent();

            //centro el form en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //instancio el pacienteService
            _pacienteService = new PacienteService();
        }


        //evento load del formulario crear paciente
        private void frmPaciente_Load(object sender, EventArgs e)
        {

            try
            {
                if (pacienteSelected != null) //accion de modificar
                {
                    //esta label pongale modificar paciente
                    this.lblTituloPaciente.Text = "Modificar Paciente";

                    //y al titulo del formulario pongale modificar paciente
                    this.Text = "Modificar Paciente";

                    this.txtIdPaciente.Enabled = false; //no se puede modificar el id
                    this.txtTipoId.Enabled = false; //no se puede modificar el tipo de id

                    //al boton guardar pongale modificar
                    btnGuardarPaciente.Text = "Modificar";

                    btnEliminarPaciente.Visible = true; //muestro el boton de eliminar

                    //llamo al metodo para cargar los datos del paciente en el formulario
                    cargarForm();

                }
                else //paciente es null, accion es crear
                {
                    //esta label pongale crear paciente
                    this.lblTituloPaciente.Text = "Crear Paciente";

                    //y al titulo del formulario pongale crear paciente
                    this.Text = "Crear Paciente";

                    this.txtIdPaciente.Enabled = true; //se puede ingresar el id

                    //al boton guardar pongale guardar
                    btnGuardarPaciente.Text = "Guardar";

                    btnEliminarPaciente.Visible = false; //oculto el boton de eliminar

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario, contacte con soporte o con su administrador" +
                    "\n" + "Error: " + "\n" + ex.Message);
            }
        }


        //metodo para cargar los datos del paciente en el formulario
        private void cargarForm()
        {
            //cargo los datos del paciente en el formulario
            txtIdPaciente.Text = pacienteSelected.persona.id;
            txtTipoId.Text = pacienteSelected.persona.tipoId.ToString();
            txtNombre.Text = pacienteSelected.persona.nombre;
            txtApellido1.Text = pacienteSelected.persona.apellido1;
            txtApellido2.Text = pacienteSelected.persona.apellido2;
            dtpFechaNacimiento.Value = pacienteSelected.persona.fechaNac;
            txtEmail.Text = pacienteSelected.persona.email;
            txtDireccion.Text = pacienteSelected.persona.direccion;
            txtTelefono.Text = pacienteSelected.persona.telefono;
            txtEstadoCivil.Text = pacienteSelected.estadoCivil;
            txtReferencia.Text = pacienteSelected.referencia;
            txtEstado.Text = pacienteSelected.persona.estado ? "Activo" : "Inactivo"; //si el estado es true, ponga activo, si es false, ponga inactivo


        }

     
        //evento click del boton guardar
        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                //validar datos de entrada dentro del if llamo al metodo ValidarDatos que devuelve true o false
                if (ValidarDatos())
                {
                    //creo la instancia del paciente nuevo, si pacienteSelected es null, estoy en modo creacion, si no, en modo edicion
                    //con el operador ternario, si pacienteSelected es null, creo una nueva instancia de clsPaciente, si no, le asigno el pacienteSelected
                    clsPaciente paciente = pacienteSelected == null ? new clsPaciente() : pacienteSelected;

                    //creo la instancia de persona para setear los datos de persona
                    clsPersona persona = new clsPersona();

                    //seteo los valores de la persona con los datos del formulario
                    persona.id = txtIdPaciente.Text;
                    persona.tipoId = int.Parse(txtTipoId.Text);
                    persona.nombre = txtNombre.Text;
                    persona.apellido1 = txtApellido1.Text;
                    persona.apellido2 = txtApellido2.Text;
                    persona.fechaNac = dtpFechaNacimiento.Value;
                    persona.email = txtEmail.Text;
                    persona.direccion = txtDireccion.Text;
                    persona.telefono = txtTelefono.Text;
                    //si el estado es "1" (ignora espacios en blanco) entonces es true, si no, es false
                    persona.estado = txtEstado.Text.Trim() == "1" ? true : false;

                    //creo instancia de paciente para setear los valores del paciente
                    clsPaciente pacie = new clsPaciente();

                    //seteo los valores del paciente con los datos del formulario
                    pacie.id = persona.id;//el id del paciente es el mismo que el de la persona
                    pacie.tipoId = persona.tipoId;//el tipo de id del paciente es el mismo que el de la persona
                    pacie.referencia = txtReferencia.Text;
                    pacie.estadoCivil = txtEstadoCivil.Text;
                    pacie.estado = persona.estado; //el estado del paciente es el mismo que el de la persona

                    pacie.persona = persona; //asigno la persona al paciente (relacion de navegacioon)

                    //llamo a mi capa de servicios para guardar/ crear el PACIENTE
                    if (pacienteSelected == null)
                    {
                        //si estoy en modo creacion, llamo al metodo crear y le poaso la imstancia de pacie que tiene los datos seteado
                        _pacienteService.crear(pacie);
                        //muestro mensaje de exito
                        MessageBox.Show("Paciente creado correctamente");
                    }
                    else
                    {

                        //al modificar, debo conservar los datos de auditoria que ya tenia de cuando se creo el paciente
                        pacie.fecha_crea = pacienteSelected.fecha_crea;
                        pacie.usuario_crea = pacienteSelected.usuario_crea;

                        //si no es null llamo al metodo modificar y le paso la instancia de pacie que tiene los datos seteado
                        _pacienteService.modificar(pacie);
                        //muestro mensaje de exito
                        MessageBox.Show("Paciente modificado correctamente");
                    }

                    //cierro el formulario
                    this.Close();

                //cierre del if ValidarDatos
                }
            //cierre del try
            }

            //exepciones personalizadas
            catch (EntityExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EntityNotExistDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DateAuiditException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el paciente, contacte con soporte o con su administrador" +
                    "\n" + "Error: " + "\n" + ex.Message);
            }

        }


        //metodo para validar los datos de entrada del formulario
        private bool ValidarDatos()
        {
            //valido que el id no este vacio y sea un numero
            if (string.IsNullOrEmpty(txtIdPaciente.Text) || !int.TryParse(txtIdPaciente.Text, out int id))
            {
                MessageBox.Show("El ID (Cedula) es obligatorio.");
                txtIdPaciente.Focus();
                return false;
            }

            //valido que el tipo de id no este vacio y sea 1 0 2
            if (string.IsNullOrEmpty(txtTipoId.Text) || (txtTipoId.Text.Trim() != "1" && txtTipoId.Text.Trim() != "2"))
            {
                MessageBox.Show("El tipo de ID es obligatorio. Debe colocar 1 para cédula física o 2 para cédula jurídica.");
                txtTipoId.Focus();
                return false;
            }


            //valido que el nombre no este vacio
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                txtNombre.Focus();
                return false;
            }

            //valido que el apellido 1 no este vacio
            if (string.IsNullOrEmpty(txtApellido1.Text))
            {
                MessageBox.Show("El apellido 1 es obligatorio.");
                txtApellido1.Focus();
                return false;
            }

            //valido que el apellido 2 no este vacio
            if (string.IsNullOrEmpty(txtApellido2.Text))
            {
                MessageBox.Show("El apellido 2 es obligatorio.");
                txtApellido2.Focus();
                return false;
            }

            //valido que el telefono no este vacio y tenga formato de costa Rica
            if (string.IsNullOrEmpty(txtTelefono.Text) || txtTelefono.Text.Length != 8 || !txtTelefono.Text.StartsWith("6")
                //el startswith es para validar que el telefono empiece con 6,7,8 o 9
                && !txtTelefono.Text.StartsWith("7") && !txtTelefono.Text.StartsWith("8") && !txtTelefono.Text.StartsWith("9")
                //el out int telefono es para convertir el string a int y validar que sean solo numeros
                || !int.TryParse(txtTelefono.Text, out int telefono))
            {
                MessageBox.Show("El teléfono es obligatorio y debe tener un formato válido de Costa Rica (8 dígitos, comenzando con 6, 7, 8 o 9).");
                txtTelefono.Focus();
                return false;
            }


            //valido que el email no este vacio y tenga formato de email
            if (string.IsNullOrEmpty(txtEmail.Text) || !txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("El email es obligatorio y debe tener un formato válido (Debe contener @ y .).");
                txtEmail.Focus();
                return false;
            }

            //valido que la direccion no este vacia
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("La dirección es obligatoria.");
                txtDireccion.Focus();
                return false;
            }

            //valido que la fecha de nacimiento no sea mayor a la fecha actual
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser mayor a la fecha actual.");
                dtpFechaNacimiento.Focus();
                return false;
            }

            //valido que la fecha de nacimiento no sea menor a 1900-01-01 y sea obligatoria
            DateTime fechaMinima = new DateTime(1900, 1, 1);
            if (dtpFechaNacimiento.Value <= fechaMinima)
            {
                MessageBox.Show("La fecha de nacimiento es obligatoria y debe ser mayor a 1/1/1900.");
                dtpFechaNacimiento.Focus();
                return false;
            }

            //valido que el estado no este vacio y solo pueda ser 1 o 2 (1=activo, 2=inactivo)
            if (string.IsNullOrEmpty(txtEstado.Text) || (txtEstado.Text.Trim() != "1"
                && txtEstado.Text.Trim() != "2"))
            {
                MessageBox.Show("El estado es obligatorio. Debe colocar 1 para activo o 2 para inactivo.");
                txtEstado.Focus();
                return false;
            }

            //valido que la referencia no este vacia
            if (string.IsNullOrEmpty(txtReferencia.Text))
            {
                MessageBox.Show("La referencia es obligatoria.");
                txtReferencia.Focus();
                return false;
            }

            //valido que el estado civil no este vacio y sea soltero, casado, viudo o n/a
            if (string.IsNullOrEmpty(txtEstadoCivil.Text) || (txtEstadoCivil.Text.Trim().ToLower() != "soltero" 
                && txtEstadoCivil.Text.Trim().ToLower() != "soltera" && txtEstadoCivil.Text.Trim().ToLower() != "casado" 
                && txtEstadoCivil.Text.Trim().ToLower() != "casada" && txtEstadoCivil.Text.Trim().ToLower() != "viudo"
                && txtEstadoCivil.Text.Trim().ToLower() != "viuda" && txtEstadoCivil.Text.Trim().ToLower() != "divorciado" 
                && txtEstadoCivil.Text.Trim().ToLower() != "divorciada" && txtEstadoCivil.Text.Trim().ToLower() != "n/a"))
            {
                MessageBox.Show("El estado civil es obligatorio y solo puede colocar soltero(@), casado(@), viudo(@), divorciado(@) o n/a.");
                txtEstadoCivil.Focus();
                return false;
            }

            //si pasa todas las validaciones, retorno true
            return true;

        }


        //evento click del boton cancelar
        private void btnCancelarPaciente_Click(object sender, EventArgs e)
        {
            this.Close(); //cierro el formulario
        }


        //evento click del boton eliminar
        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            try
            {

                //esto es para q muestre un mensaje de confirmacion antes de eliminar
                DialogResult resp = MessageBox.Show("¿Está seguro que desea eliminar el paciente?", "Confirmación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                //si el usuario dice que si, entonces elimino
                if (resp == DialogResult.Yes)
                {
                    //llamo a mi capa de servicios para eliminar el paciente
                    _pacienteService.eliminar(pacienteSelected.id);
                    MessageBox.Show("Paciente eliminado correctamente");
                    this.Close(); //cierro el formulario
                } 


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el paciente. Contacte con soporte o con su administrador." + 
                    "\n" + "Error: " + "\n" + ex.Message);
            }
        }

       
    }
}
