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
        
        private PuestoService _puestoService = new PuestoService();


        public FrmAnadirPersonalAdministrativo()
        {
            InitializeComponent();
            
        }

        private void FrmAnadirPersonalAdministrativo_Load(object sender, EventArgs e)
        {
            // Aquí podrías cargar combobox, por ejemplo combTipoIdent o combPuesto
            combTipoIdent.DataSource = Enum.GetValues(typeof(TipoIdentificacion));

            cargarPuestos();
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
                // Validación básica de campos
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
                            // 1️⃣ Insertar en persona
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

                            // 2️⃣ Insertar en personalAdministrativo
                            clsPersonalAdministrativo admin = new clsPersonalAdministrativo
                            {
                                personaId = persona.id,
                                personaTipoId = persona.tipoId,
                                puestoId = (int)combPuesto.SelectedValue,
                                descripcion = txtDescripcion.Text,
                                creadoPor = "admin",
                                fechaCreacion = DateTime.Now,
                                modificadoPor = "admin",

                            };

                            db.personalAdministrativo.Add(admin);

                            // Guardar cambios
                            db.SaveChanges();
                            transaction.Commit();

                            MessageBox.Show("Personal administrativo añadido correctamente.",
                                "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
