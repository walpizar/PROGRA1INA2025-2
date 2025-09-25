using Common.Enums;
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

        //creo propiedad para saber si debo mostrar el boton reactivar
        public bool mostrarBotonReactivar { get; set; } = false;

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
                //llamo al metodo para cargar los combos
                cargarCombos();

                //valido si pacienteSelected es null o no
                if (pacienteSelected != null) //accion de modificar
                {
                    //esta label pongale modificar paciente
                    this.lblTituloPaciente.Text = "Modificar Paciente";

                    //y al titulo del formulario pongale modificar paciente
                    this.Text = "Modificar Paciente";

                    this.txtIdPaciente.Enabled = false; //no se puede modificar el id
                    this.cboTipoId.Enabled = false; //no se puede modificar el tipo de id

                    //al boton guardar pongale modificar
                    btnGuardarPaciente.Text = "Modificar";

                    btnEliminarPaciente.Visible = true; //muestro el boton de eliminar

                    //valido si el paciente esta inactivo, para mostrar el boton reactivar
                    if (mostrarBotonReactivar)
                    {
                        //cambio el nombre de lblTituloPaciente
                        this.lblTituloPaciente.Text = "Reactivar Paciente";
                        this.Text = "Reactivar Paciente";

                        btnReactivar.Visible = true;
                        btnGuardarPaciente.Visible = false;
                        btnEliminarPaciente.Visible = false;

                        //llamo al metodo para desabilitar los campos del formulario y solo se pueda reactivar no modificar
                        desabilitarCampos();
                    }
                    else//paciente esta activo
                    {
                        btnReactivar.Visible = false;
                        btnGuardarPaciente.Visible = true;
                        btnEliminarPaciente.Visible = true;
                    }

                    //llamo al metodo para cargar los datos del paciente en el formulario si esta en modo edicion o reactivacion
                    cargarForm();

                }
                else //paciente es null, accion es crear
                {
                    //esta label pongale crear paciente
                    this.lblTituloPaciente.Text = "Crear Paciente";

                    //y al titulo del formulario pongale crear paciente
                    this.Text = "Crear Paciente";

                    this.txtIdPaciente.Enabled = true; //se puede ingresar el id
                    this.cboTipoId.Enabled = true; //se puede ingresar el tipo de id

                    //al boton guardar pongale guardar
                    btnGuardarPaciente.Text = "Guardar";

                    btnEliminarPaciente.Visible = false; //oculto el boton de eliminar
                    btnReactivar.Visible = false; //oculto el boton de reactivar
                    btnGuardarPaciente.Visible = true; //muestro el boton de guardar

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario de crear paciente. Contacte con soporte o con su administrador." +
                    "\n" + "Error: " + "\n" + ex.Message);
            }
        }

        //metodo para desabilitar los campos del formulario si esta en modo reactivar
        private void desabilitarCampos()
        {
            //desabilito todos los campos del formulario
            txtNombre.Enabled = false;
            txtApellido1.Enabled = false;
            txtApellido2.Enabled = false;
            dtpFechaNacimiento.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            cboEstadoCivil.Enabled = false;

        }

        //metodo para cargar los combos
        private void cargarCombos()
        {
            //datasource es para cargar los datos en el combo, enum.getvalues es para obtener los valores del enum
            //typeof es para obtener el tipo del enum
            cboTipoId.DataSource = Enum.GetValues(typeof(Enums.TipoIdentificacion));

            //obtengo los valores del enum EstadoCivil y los cargo en el combo
            cboEstadoCivil.DataSource = Enum.GetValues(typeof(Enums.EstadoCivil));
        }


        //metodo para cargar los datos del paciente en el formulario
        private void cargarForm()
        {
            //cargo los datos del paciente en el formulario
            txtIdPaciente.Text = pacienteSelected.persona.id.Trim();

            //para seleccionar el valor del combo, hago un casteo del int a el enum TipoIdentificacion
            //el selectedItem es para seleccionar el valor del combo, el (enums.TipoIdentificacion) es para castear el int a el enum
            cboTipoId.SelectedItem = (Enums.TipoIdentificacion)pacienteSelected.tipoId;

            txtNombre.Text = pacienteSelected.persona.nombre.Trim();
            txtApellido1.Text = pacienteSelected.persona.apellido1.Trim();
            txtApellido2.Text = pacienteSelected.persona.apellido2.Trim();
            dtpFechaNacimiento.Value = pacienteSelected.persona.fechaNac;
            txtEmail.Text = pacienteSelected.persona.email.Trim();
            txtDireccion.Text = pacienteSelected.persona.direccion;
            txtTelefono.Text = pacienteSelected.persona.telefono.Trim();

            //lo seleccionado es igual al valor del enum EstadoCivil
            cboEstadoCivil.SelectedItem = (Enums.EstadoCivil)pacienteSelected.estadoCivil;
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
                    persona.id = txtIdPaciente.Text.Trim();

                    //el int cast es para convertir el enum a int 
                    persona.tipoId = (int)(Enums.TipoIdentificacion)cboTipoId.SelectedItem;//el tipo de id es el seleccionado en el combo
                    persona.nombre = txtNombre.Text.Trim();
                    persona.apellido1 = txtApellido1.Text.Trim();
                    persona.apellido2 = txtApellido2.Text.Trim();
                    persona.fechaNac = dtpFechaNacimiento.Value;
                    persona.email = txtEmail.Text.Trim();
                    persona.direccion = txtDireccion.Text;
                    persona.telefono = txtTelefono.Text.Trim();


                    //creo instancia de paciente para setear los valores del paciente
                    clsPaciente pacie = new clsPaciente();

                    //seteo los valores del paciente con los datos del formulario
                    pacie.id = persona.id;//el id del paciente es el mismo que el de la persona
                    pacie.tipoId = persona.tipoId;//el tipo de id del paciente es el mismo que el de la persona
                    pacie.estadoCivil = (int)(Enums.EstadoCivil)cboEstadoCivil.SelectedItem; //el estado civil del paciente es el seleccionado en el combo

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
            catch (EntityNotFoundDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (DateAuiditException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EmailExistDBExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (PhoneExistDBExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el paciente. Contacte con soporte o con su administrador." +
                    "\n" + "Error: " + "\n" + ex.Message);
            }

        }


        //metodo para validar los datos de entrada del formulario
        private bool ValidarDatos()
        {
            //valido que el id no este vacio y sea un numero
            if (string.IsNullOrEmpty(txtIdPaciente.Text))
            {
                MessageBox.Show("El ID (Cedula) es obligatorio.");
                txtIdPaciente.Focus();
                return false;
            }

            //valido que el tipo de id tenga una seleccion
            if (cboTipoId.SelectedItem == null)
            {
                MessageBox.Show("El tipo de ID (Tipo Cedula) es obligatorio.");
                cboTipoId.Focus();
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

            //VAlido que el estado civil tenga una seleccion
            if (cboEstadoCivil.SelectedItem == null)
            {
                MessageBox.Show("El estado civil es obligatorio.");
                cboEstadoCivil.Focus();
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
                DialogResult resp = MessageBox.Show("¿Está seguro que desea inactivar el paciente?", "Confirmación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //si el usuario dice que si, entonces elimino
                if (resp == DialogResult.Yes)
                {
                    //llamo a mi capa de servicios para eliminar el paciente
                    _pacienteService.eliminar(pacienteSelected.id);
                    MessageBox.Show("Paciente inactivado correctamente y enviado a la lista de pacientes inactivos.");
                    this.Close(); //cierro el formulario
                }


            }
            catch (EntityNotFoundDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al inactivar el paciente. Contacte con soporte o con su administrador." +
                    "\n" + "Error: " + "\n" + ex.Message);
            }
        }

        //evento click del boton reactivar
        private void btnReactivar_Click(object sender, EventArgs e)
        {
            try 
                {
                //esto es para q muestre un mensaje de confirmacion antes de reactivar
                DialogResult resp = MessageBox.Show("¿Está seguro que desea reactivar el paciente?\n" +
                    "\nEl paciente desaparecera de la lista de inactivos y volvera aparecer en la lista de pacientes activos.", "Confirmación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //si el usuario dice que si, entonces reactivo
                if (resp == DialogResult.Yes)
                {
                    //llamo a mi capa de servicios para reactivar el paciente
                    _pacienteService.reactivar(pacienteSelected.id);
                    MessageBox.Show("Paciente reactivado correctamente.\n\n" +
                        "NOTA: Verifique la lista de pacientes activos, si necesita modificar algun dato del paciente activado.");
                    this.Close(); //cierro el formulario
                }
            }
            //exepciones personalizadas
            catch (EntityNotFoundDBException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (EntityActiveDBExeption ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al reactivar el paciente. Contacte con soporte o con su administrador." +
                    "\n" + "Error: " + "\n" + ex.Message);
            }

        }
    }
}
