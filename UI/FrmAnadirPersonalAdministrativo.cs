using Common.Enums;
using Entities;
using Services;
using System;
using System.Windows.Forms;
using static Common.Enums.Enums;

namespace UI
{
    public partial class FrmAnadirPersonalAdministrativo : Form
    {
        private UsuarioServicioExtend usuarioService;


        public FrmAnadirPersonalAdministrativo()
        {
            InitializeComponent();
            usuarioService = new UsuarioServicioExtend();


        }

        private void FrmAnadirAdmin_Load(object sender, EventArgs e)
        {
            // Cargar roles
            comboRol.DataSource = Enum.GetValues(typeof(Enums.TipoUsuario));
            comboRol.DropDownStyle = ComboBoxStyle.DropDownList;

            comboRol.DisplayMember = "Nombre";
            comboRol.ValueMember = "Id";

            // Fecha máxima para no permitir fechas futuras
            txtFecha.MaxDate = DateTime.Today;


        }



        private void btnAnadir_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Validaciones simples
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                    throw new Exception("El nombre es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtUsuario.Text))
                    throw new Exception("El nombre de usuario es obligatorio.");
                if (string.IsNullOrWhiteSpace(txtContra.Text))
                    throw new Exception("La contraseña es obligatoria.");
                if (string.IsNullOrWhiteSpace(txtEmail.Text))
                    throw new Exception("El email es obligatorio.");
                if (comboRol.SelectedItem == null)
                    throw new Exception("Debe seleccionar un rol.");

                TipoUsuario tipoSeleccionado = (TipoUsuario)comboRol.SelectedItem;

                string nombreCompleto = txtNombre.Text.Trim();

                string[] partes = nombreCompleto.Split(' ');

                string Nombre = partes.Length > 0 ? partes[0] : "-";

                string Apellido1 = partes.Length > 1 ? partes[1] : "-";

                string Apellido2 = partes.Length > 2 ? partes[2] : "-";


                // 1️⃣ Crear Persona
                clsPersona persona = new clsPersona
                {
                    id = Guid.NewGuid().ToString("N").Substring(0, 20),
                    tipoId = (int)tipoSeleccionado,
                    nombre = Nombre,
                    apellido1 = Apellido1,
                    apellido2 = Apellido2,
                    fechaNac = txtFecha.Value,
                    email = txtEmail.Text.Trim(),
                    direccion = txtDireccion.Text.Trim(),
                    telefono = txtTelefono.Text.Trim(),
                    estado = true
                };

                // 2️⃣ Crear Usuario vinculado a Persona
                clsUsuario usuario = new clsUsuario
                {
                    personaId = persona.id,
                    personaTipoId = (int)tipoSeleccionado,
                    nombre_usuario = txtUsuario.Text.Trim(),
                    contrasena = txtContra.Text.Trim(),
                    email = txtEmail.Text.Trim(),
                    estado = true,
                    persona = persona
                    // rol_id = ((dynamic)comboRol.SelectedItem).Id  // Descomenta si tienes rol_id en Usuario
                };

                // 3️⃣ Guardar
                usuarioService.crear(usuario);

                MessageBox.Show(" Administrador añadido correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
