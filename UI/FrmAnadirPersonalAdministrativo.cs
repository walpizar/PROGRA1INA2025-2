using Common.Enums;
using DAO;
using Entities;
using Services;
using System;
using System.Linq;
using System.Windows.Forms;
using static Common.Enums.Enums;

namespace UI
{
    // Este formulario lo uso para añadir o modificar un administrador
    // Manejo la persona y el admin en un mismo form, según si adminSeleccionado es null
    public partial class FrmAnadirPersonalAdministrativo : Form
    {

        // Guardo el admin que estoy editando (si aplica)
        public clsPersonalAdministrativo adminSeleccionado { get; set; }

        // Servicios que uso para cargar puestos y manejar admins
        private PuestoService _puestoService = new PuestoService();
        private PersonalAdministrativoService _personalService = new PersonalAdministrativoService();


        public FrmAnadirPersonalAdministrativo()
        {
            InitializeComponent();

        }

        // Al cargar el form, lleno combos y campos según si estoy añadiendo o editando
        private void FrmAnadirPersonalAdministrativo_Load(object sender, EventArgs e)
        {
            
            combTipoIdent.DataSource = Enum.GetValues(typeof(TipoIdentificacion));

            if (adminSeleccionado != null)
            {
                // Estoy editando: desactivo identificación, cambio títulos y botón
                this.lblTitulo.Text = "Modificar Administrador";
                this.gbDatosPersonales.Text = "Modificar Administrador";
                this.txtIdentificacion.Enabled = false;
                this.combTipoIdent.Enabled = false; 
                this.btnAnadir.Text = "Modificar";
                this.btnEliminar.Visible = true;
                
                cargarForm();
                cargarPuestos();


            }
            else
            {
                // Estoy añadiendo: habilito todo, oculto botón eliminar
                this.lblTitulo.Text = "Añadir Administrador";
                this.gbDatosPersonales.Text = "Añadir Administrador";
                this.txtIdentificacion.Enabled = true;
                this.btnAnadir.Text = "Añadir";
                btnEliminar.Visible = false;
                cargarPuestos();
            }

            cargarPuestos();
        }

        private void cargarForm()
        {
            // Lleno los campos con los datos del admin que edito
            txtIdentificacion.Text = adminSeleccionado.personaId;
            txtNombre.Text = adminSeleccionado.persona.nombre;
            txt1Apellido.Text = adminSeleccionado.persona.apellido1;
            txt2Apellido.Text = adminSeleccionado.persona.apellido2;
            txtDireccion.Text = adminSeleccionado.persona.direccion;
            txtEmail.Text = adminSeleccionado.persona.email;
            txtTelefono.Text = adminSeleccionado.persona.telefono;
            dateFecha.Value = adminSeleccionado.persona.fechaNac;
            combTipoIdent.SelectedItem = (TipoIdentificacion)adminSeleccionado.persona.tipoId;
            combPuesto.SelectedValue = adminSeleccionado.puestoId;
            txtDescripcion.Text = adminSeleccionado.descripcion;

        }

        // Cargo los puestos en el combo
        private void cargarPuestos()
        {
            try
            {
                var puestos = _puestoService.consultarTodos();
                combPuesto.DataSource = puestos
                    .Select(p => new
                    {
                        Id = p.idPuesto,
                        Texto = $"{p.idPuesto} - {p.codigo} - {p.Nombre}"
                    })
                    .ToList();
                combPuesto.DisplayMember = "Texto";
                combPuesto.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los puestos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Cierro el form sin guardar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Aquí añado o modifico al admin según el modo
        private void btnAnadir_Click_1(object sender, EventArgs e)
        {
            try
            {
                validarDatos();
                // Si adminSeleccionado es null, estamos en modo "Añadir"
                clsPersonalAdministrativo admin = adminSeleccionado == null ? new clsPersonalAdministrativo() : adminSeleccionado;

                if (adminSeleccionado == null)
                {
                    // --- Lógica de añadir ---

                    using (var db = new dbContextINA())
                    {

                        // Creo persona y admin dentro de transacción
                        using (var transaction = db.Database.BeginTransaction())
                        {
                            try
                            {
                                var personaExistente = db.persona
                                    .FirstOrDefault(p => p.id == txtIdentificacion.Text
                                                      && p.tipoId == (int)combTipoIdent.SelectedItem);

                                if (personaExistente != null)
                                    throw new Exception("La persona ya existe.");

                                clsPersona persona = new clsPersona
                                {
                                    id = txtIdentificacion.Text,
                                    tipoId = (int)combTipoIdent.SelectedItem,
                                    nombre = txtNombre.Text,
                                    apellido1 = txt1Apellido.Text,
                                    apellido2 = txt2Apellido.Text,
                                    direccion = txtDireccion.Text,
                                    telefono = txtTelefono.Text,
                                    email = txtEmail.Text,
                                    fechaNac = DateTime.Parse(dateFecha.Text),
                                    estado = true
                                };

                                db.persona.Add(persona);

                                clsPersonalAdministrativo admin2 = new clsPersonalAdministrativo
                                {
                                    personaId = persona.id,
                                    personaTipoId = persona.tipoId,
                                    puestoId = (int)combPuesto.SelectedValue,
                                    descripcion = txtDescripcion.Text,
                                    creadoPor = "admin",
                                    fechaCreacion = DateTime.Now,
                                    modificadoPor = "admin",
                                };

                                db.personalAdministrativo.Add(admin2);

                                db.SaveChanges();
                                transaction.Commit();

                                MessageBox.Show("Personal administrativo añadido correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                limpiarForm();
                                this.Close();
                                
                            }
                            catch
                            {
                                MessageBox.Show("Error al añadir el personal administrativo. Se revertirán los cambios.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
                else
                {
                    // --- Modificar ---
                    var adminEditado = new clsPersonalAdministrativo
                    {
                        personaId = admin.personaId,
                        personaTipoId = admin.personaTipoId,
                        puestoId = (int)combPuesto.SelectedValue,
                        descripcion = txtDescripcion.Text,
                        modificadoPor = "admin",
                        fechaModificacion = DateTime.Now,

                        persona = new clsPersona
                        {
                            id = txtIdentificacion.Text,
                            tipoId = (int)combTipoIdent.SelectedItem,
                            nombre = txtNombre.Text,
                            apellido1 = txt1Apellido.Text,
                            apellido2 = txt2Apellido.Text,
                            direccion = txtDireccion.Text,
                            telefono = txtTelefono.Text,
                            email = txtEmail.Text,
                            fechaNac = DateTime.Parse(dateFecha.Text),
                            estado = true
                        }
                    };

                    _personalService.modificarPersonaYPersonal(adminEditado);

                    MessageBox.Show("Personal administrativo modificado correctamente.",
                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarForm();
                    this.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Limpio los campos del form
        private void limpiarForm()
        {
            txt1Apellido.ResetText();
            txt2Apellido.ResetText();   
            txtDescripcion.ResetText();
            txtDireccion.ResetText();
            txtEmail.ResetText();
            txtIdentificacion.ResetText();
            txtNombre.ResetText();
            txtTelefono.ResetText();
            dateFecha.Value = DateTime.Now;
            txtIdentificacion.ResetText();

           

        }

        // Borro lógicamente al admin
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar este administrador?",
                    "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _personalService.eliminar(adminSeleccionado.personaId);
                    MessageBox.Show("Administrador eliminado correctamente.", "Éxito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el administrador: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método que revisa que todo lo obligatorio esté correcto
        private void validarDatos()
        {
            // Validaciones de persona
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
                throw new Exception("Debe ingresar la identificación.");

            if (combTipoIdent.SelectedItem == null)
                throw new Exception("Debe seleccionar un tipo de identificación.");

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
                throw new Exception("Debe ingresar el nombre.");

            if (string.IsNullOrWhiteSpace(txt1Apellido.Text))
                throw new Exception("Debe ingresar el primer apellido.");

            if (string.IsNullOrWhiteSpace(txt2Apellido.Text))
                throw new Exception("Debe ingresar el segundo apellido.");

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                throw new Exception("Debe ingresar el correo electrónico.");

            if (!txtEmail.Text.Contains("@"))
                throw new Exception("Debe ingresar un correo electrónico válido.");

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
                throw new Exception("Debe ingresar un teléfono.");

            if (!txtTelefono.Text.All(char.IsDigit))
                throw new Exception("El teléfono solo debe contener números.");

            if (dateFecha.Value >= DateTime.Now)
                throw new Exception("La fecha de nacimiento no puede ser futura.");
            
            // Validaciones de admin
            if (combPuesto.SelectedItem == null)
                throw new Exception("Debe seleccionar un puesto.");

            if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                throw new Exception("Debe ingresar una descripción.");
        }

    }
}
