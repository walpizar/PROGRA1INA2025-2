using Services;  // <-- Importante
using Entities;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmAnadirAdmin : Form
    {
        private UsuarioService usuarioService;

        public FrmAnadirAdmin()
        {
            InitializeComponent();
            usuarioService = new UsuarioService(); //  instanciamos el Service
        }

        private void FrmAnadirAdmin_Load(object sender, EventArgs e)
        {
            // 🔹 Cargar roles disponibles (ejemplo estático por ahora)
            comboRol.Items.Add(new { Id = 1, Nombre = "Administrador" });
            comboRol.Items.Add(new { Id = 2, Nombre = "OtroRol" });

            comboRol.DisplayMember = "Nombre";
            comboRol.ValueMember = "Id";
        }

        private void btnAnadir_Click_1(object sender, EventArgs e)
        {
            try
            {
                // 1️⃣ Crear Persona
                clsPersona persona = new clsPersona
                {
                    id = Guid.NewGuid().ToString(),
                    tipoId = 1,
                    nombre = txtNombre.Text,
                    apellido1 = "-",
                    apellido2 = "-",
                    fechaNac = txtFecha.Value,
                    email = txtEmail.Text,
                    direccion = txtDireccion.Text,
                    telefono = txtTelefono.Text,
                    estado = true
                };

                // 2️⃣ Crear Usuario vinculado a esa persona
                clsUsuario usuario = new clsUsuario
                {
                    personaId = persona.id,
                    personaTipoId = persona.tipoId,
                    nombre_usuario = txtUsuario.Text,
                    contraseña = txtContra.Text,
                    rol_id = ((dynamic)comboRol.SelectedItem).Id,
                    Persona = persona
                };

                // 3️⃣ Guardar usando el Service (ya hace validaciones y llama al DAO)
                usuarioService.crear(usuario);

                MessageBox.Show("✅ Administrador añadido correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }
        }
    }
}
