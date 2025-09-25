using Entities;
using Services;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;
using static Common.Enums.Enums;


namespace UI
{
    public partial class frmDonante : Form
    {
        //AGREGO PARAMETRO CLSDONANTE
        public clsDonante donanteSelected { get; set; }

        //llamo al service
        donanteService donanteService;

        public frmDonante()
        {
            //instancio el service
            donanteService = new donanteService();

            InitializeComponent();
        }

        private void frmDonante_Load(object sender, EventArgs e)
        {
            //cargar combos
            cargarCombos();

            //procedemos a modificar o crear
            if (donanteSelected != null)
            {
                /*modo modificacion*/

                //modifico label para modo modificacion
                this.Text = "MODIFICAR DONANTE";
                this.lblCrearDonante.Text = "MODIFICAR DONANTE";
                btnGuardarDonante.Text = "MODIFICAR";

                //IMPIDO LA MODIFICACION DEL ID 
                txtbxDonanteID.Enabled = false;

                //MUESTRO EL BOTON ELIMINAR
                btnEliminarDonante.Visible = true;

                //cargo los datos en el formulario
                cargarFormModificarDoannte();

            }
            else
            {
                /*modo creacion*/

                //OCULTO EL BOTON ELIMINAR
                btnEliminarDonante.Visible = false;
                limpiarForm();
            }
        }

        private void cargarCombos()
        {
            //cargo el combo tipo donante
            cboxDonanteTipo.DataSource = Enum.GetValues(typeof(tipoDonante));

            //cargo combo tipo identificacion
            cboxDonanteTipoID.DataSource = Enum.GetValues(typeof(TipoIdentificacion));

        }

        private void cargarFormModificarDoannte()
        {
            txtbxDonanteID.Text = donanteSelected.personaId.ToString();
            cboxDonanteTipoID.SelectedItem = (TipoIdentificacion)donanteSelected.persona.personaTipoId;
            txtbxDonanteNombre.Text = donanteSelected.persona.nombre;
            txtbxDonanteAp1.Text = donanteSelected.persona.apellido1;
            txtbxDonanteAp2.Text = donanteSelected.persona.apellido2;
            txtbxDonanteEmail.Text = donanteSelected.persona.email;
            txtbxDonanteTelefono.Text = donanteSelected.persona.telefono;
            txtbxDonanteDireccion.Text = donanteSelected.persona.direccion;
            datepkDonanteFechaNac.Value = donanteSelected.persona.fechaNac;
            cboxDonanteTipo.SelectedItem = (tipoDonante)donanteSelected.tipoDonante;
        }

        private void limpiarForm()
        {

            txtbxDonanteID.ResetText();
            cboxDonanteTipoID.SelectedIndex = 0;
            txtbxDonanteNombre.ResetText();
            txtbxDonanteAp1.ResetText();
            txtbxDonanteAp2.ResetText();
            txtbxDonanteEmail.ResetText();
            txtbxDonanteTelefono.ResetText();
            txtbxDonanteDireccion.ResetText();
            datepkDonanteFechaNac.Value = DateTime.Now;
            cboxDonanteTipo.SelectedIndex = 0;

        }

        private void btnGuardarDonante_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarCampos())
                {
                    if (donanteSelected == null)
                    {
                        clsDonante nuevoDonante = new clsDonante
                        {
                            //seteo los valores de persona primero
                            persona = new clsPersona
                            {
                                id = txtbxDonanteID.Text,
                                tipoId = (int)(TipoIdentificacion)cboxDonanteTipoID.SelectedItem,
                                nombre = txtbxDonanteNombre.Text,
                                apellido1 = txtbxDonanteAp1.Text,
                                apellido2 = txtbxDonanteAp2.Text,
                                email = txtbxDonanteEmail.Text,
                                telefono = txtbxDonanteTelefono.Text,
                                direccion = txtbxDonanteDireccion.Text,
                                fechaNac = datepkDonanteFechaNac.Value,
                                estado = true //nuevo donante activo por defecto
                            },
                            personaId = txtbxDonanteID.Text,
                            personaTipoId = (int)(TipoIdentificacion)cboxDonanteTipoID.SelectedItem,
                            tipoDonante = (int)(tipoDonante)cboxDonanteTipo.SelectedItem
                        };

                        donanteService.crear(nuevoDonante);
                        MessageBox.Show("Donante creado correctamente");
                        this.Close();
                    }
                    else
                    {
                        /*modo modificacion*/

                        //valores de persona
                        donanteSelected.persona.tipoId = (int)(TipoIdentificacion)cboxDonanteTipoID.SelectedItem;
                        donanteSelected.persona.nombre = txtbxDonanteNombre.Text;
                        donanteSelected.persona.apellido1 = txtbxDonanteAp1.Text;
                        donanteSelected.persona.apellido2 = txtbxDonanteAp2.Text;
                        donanteSelected.persona.email = txtbxDonanteEmail.Text;
                        donanteSelected.persona.telefono = txtbxDonanteTelefono.Text;
                        donanteSelected.persona.direccion = txtbxDonanteDireccion.Text;
                        donanteSelected.persona.fechaNac = datepkDonanteFechaNac.Value;
                        donanteSelected.persona.estado = true; //si se modifica, queda activo

                        //valores de donante
                        donanteSelected.tipoDonante = (int)(tipoDonante)cboxDonanteTipo.SelectedItem;
                        donanteSelected.personaTipoId = (int)(TipoIdentificacion)cboxDonanteTipoID.SelectedItem;

                        donanteService.modificar(donanteSelected);
                        MessageBox.Show("Donante modificado correctamente");
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el donante: " + ex.Message);
            }
        }

        private void btnEliminarDonante_Click(object sender, EventArgs e)
        {
            try
            {
                var confirm = MessageBox.Show("¿Está seguro de eliminar este donante?", "Confirmar", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    donanteService.eliminar(donanteSelected.personaId.ToString());
                    MessageBox.Show("Donante eliminado correctamente");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el donante: " + ex.Message);
            }
        }

        private bool validarCampos()
        {
            //validar todos los campos de frmDonante
            if (string.IsNullOrWhiteSpace(txtbxDonanteID.Text))
            {
                MessageBox.Show("El campo ID es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtbxDonanteNombre.Text))
            {
                MessageBox.Show("El campo Nombre es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtbxDonanteAp1.Text))
            {
                MessageBox.Show("El campo Primer Apellido es obligatorio.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtbxDonanteAp2.Text))
            {
                MessageBox.Show("El campo Segundo Apellido es obligatorio.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(txtbxDonanteEmail.Text) && !new EmailAddressAttribute().IsValid(txtbxDonanteEmail.Text))
            {
                MessageBox.Show("El formato del Email no es válido.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtbxDonanteEmail.Text))
            {
                MessageBox.Show("El campo Email es obligatorio.");
                return false;
            }

            if (datepkDonanteFechaNac.Value >= DateTime.Now)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.");
                return false;
            }
            if (cboxDonanteTipo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de donante.");
                return false;
            }
            if (cboxDonanteTipoID.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de identificación.");
                return false;
            }

            //formato telefono costa rica
            if (!string.IsNullOrWhiteSpace(txtbxDonanteTelefono.Text))
            {
                string telefono = txtbxDonanteTelefono.Text;
                if (!(telefono.Length == 8 && (telefono.StartsWith("2") || telefono.StartsWith("8"))))
                {
                    MessageBox.Show("El formato del teléfono no es válido. Debe tener 8 dígitos y comenzar con 2 u 8.");
                    return false;
                }
            }


            //si pasa todas las validaciones
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
