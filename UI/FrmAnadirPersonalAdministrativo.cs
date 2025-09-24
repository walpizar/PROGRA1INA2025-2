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
    public partial class FrmAnadirPersonalAdministrativo : Form
    {
        public clsPersonalAdministrativo adminSeleccionado { get; set; }

        private PuestoService _puestoService = new PuestoService();
        private PersonalAdministrativoService _personalService = new PersonalAdministrativoService();


        public FrmAnadirPersonalAdministrativo()
        {
            InitializeComponent();

        }

        private void FrmAnadirPersonalAdministrativo_Load(object sender, EventArgs e)
        {
            // Aquí podrías cargar combobox, por ejemplo combTipoIdent o combPuesto
            combTipoIdent.DataSource = Enum.GetValues(typeof(TipoIdentificacion));
            if (adminSeleccionado != null)
            {
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
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAnadir_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Si adminSeleccionado es null, estamos en modo "Añadir"
                clsPersonalAdministrativo admin = adminSeleccionado == null ? new clsPersonalAdministrativo() : adminSeleccionado;

                if (adminSeleccionado == null)
                {
                    // --- Lógica de añadir ---
                    if (string.IsNullOrWhiteSpace(txtIdentificacion.Text))
                        throw new Exception("Debe ingresar la identificación.");

                    if (string.IsNullOrWhiteSpace(txtNombre.Text))
                        throw new Exception("Debe ingresar el nombre.");

                    if (combPuesto.SelectedItem == null)
                        throw new Exception("Debe seleccionar un puesto.");

                    using (var db = new dbContextINA())
                    {
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
                    // --- Lógica de modificar ---
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
                    cargarForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


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
    }
}
