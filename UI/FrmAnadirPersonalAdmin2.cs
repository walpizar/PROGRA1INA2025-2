using DAO;
using Entities;
using Services;
using System;
using System.Windows.Forms;
using static Common.Enums.Enums;

namespace UI
{
    public partial class FrmAnadirPersonalAdmin2 : Form
    {
        // Instancias de los UserControls
        private DatosPersonalesControl datosControl;
        private CredencialesControl credencialesControl;
        private AdministrativoControl adminControl;
        private UsuarioServicioExtend usuarioService;
        

        public FrmAnadirPersonalAdmin2()
        {
            InitializeComponent();
            usuarioService = new UsuarioServicioExtend();
            
            
            
        }

        private void FrmAnadirPersonalAdmin2_Load(object sender, EventArgs e)
        {
            // Inicializar los controles
            datosControl = new DatosPersonalesControl();
            credencialesControl = new CredencialesControl();
            adminControl = new AdministrativoControl();

            // Asignar eventos a los ToolStripMenuItem
            datosPersonalesToolStripMenuItem.Click += (s, ev) => MostrarUserControl(datosControl);
            credencialesToolStripMenuItem.Click += (s, ev) => MostrarUserControl(credencialesControl);
            adminToolStripMenuItem.Click += (s, ev) => MostrarUserControl(adminControl);

            // Mostrar por defecto "Datos Personales"
            MostrarUserControl(datosControl);

            try
            {
               

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al el enumerador de tipo de id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        
        }

        private void MostrarUserControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            panelContenedor.Controls.Clear();
            panelContenedor.Controls.Add(control);
        }
        private void btnCredenciales_Click(object sender, EventArgs e)
        {
            MostrarUserControl(credencialesControl);
        }

        private void btnAdministrativo_Click(object sender, EventArgs e)
        {
            MostrarUserControl(adminControl);
        }

        private void btnDatosPersonales_Click(object sender, EventArgs e)
        {
            MostrarUserControl(datosControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Validar datos del control
                datosControl.Validar();

                // 2️⃣ Obtener el enum seleccionado desde el control
                TipoIdentificacion tipoSeleccionado = datosControl.TipoSeleccionado;
                int tipoId = (int)tipoSeleccionado;

                // 3️⃣ Crear instancia del contexto y transacción
                using (var db = new dbContextINA())
                {
                    using (var transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            // 4️⃣ Construir persona
                            clsPersona persona = new clsPersona
                            {
                                id = datosControl.Identificacion,
                                tipoId = tipoId,
                                nombre = datosControl.Nombre,
                                apellido1 = datosControl.Apellido1,
                                apellido2 = datosControl.Apellido2,
                                fechaNac = datosControl.FechaNacimiento,
                                email = datosControl.Email,
                                direccion = datosControl.Direccion,
                                telefono = datosControl.Telefono,
                                estado = true
                            };

                            // 5️⃣ Verificar que no exista la persona
                            var existingPersona = db.persona
                                .FirstOrDefault(p => p.id == persona.id && p.tipoId == persona.tipoId);

                            if (existingPersona != null)
                                throw new Exception("La persona ya existe.");

                            db.persona.Add(persona);

                            // 6️⃣ Construir usuario
                            clsUsuario usuario = new clsUsuario
                            {
                                personaId = persona.id,
                                personaTipoId = persona.tipoId,
                                nombre_usuario = credencialesControl.Usuario,
                                contrasena = credencialesControl.Contrasena,
                                email = persona.email,
                                estado = true,
                                persona = persona
                            };

                            // 7️⃣ Verificar que no exista el usuario
                            var existingUsuario = db.usuario
                                .FirstOrDefault(u => u.personaId == usuario.personaId && u.personaTipoId == usuario.personaTipoId);

                            if (existingUsuario != null)
                                throw new Exception("El usuario ya existe.");

                            db.usuario.Add(usuario);

                            // 8️⃣ Crear registro administrativo
                            int puestoId = adminControl.comboPuesto.SelectedValue != null
                                          ? (int)adminControl.comboPuesto.SelectedValue
                                          : throw new Exception("Debe seleccionar un puesto.");

                            clsPersonalAdministrativo admin = new clsPersonalAdministrativo
                            {
                                personaId = persona.id,
                                personaTipoId = persona.tipoId,
                                puestoId = puestoId,
                                descripcion = adminControl.txtDescripcion.Text,
                                creadoPor = "admin",
                                fechaCreacion = DateTime.Now
                            };

                            db.personalAdministrativo.Add(admin);

                            // 9️⃣ Guardar todo y confirmar transacción
                            db.SaveChanges();
                            transaction.Commit();

                            MessageBox.Show("Administrador añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw; // relanzamos para capturar en el catch externo
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
