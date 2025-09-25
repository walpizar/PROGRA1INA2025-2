using DAO;
using Entities;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmUsuario : Form
    {
        public clsUsuario usuarioSelected { get; set; }
        private readonly UsuarioService _usuarioService;

        public frmUsuario()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();

        }

        private void frmUsuarioLista_Load(object sender, EventArgs e)
        {
            //llenar el Combox de personas y roles cuando se carga el formulario
            CargarComboPersona();
            CargarComboRol();


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    using (var context = new dbContextINA())
                    {
                        // Obtener persona seleccionada
                        string idPersona = cboPersona.SelectedValue?.ToString();
                        var personaSeleccionada = context.persona.FirstOrDefault(p => p.id == idPersona);

                        if (personaSeleccionada == null)
                        {
                            MessageBox.Show("Debe seleccionar una persona válida.",
                                            "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Verificar si ya existe un usuario asociado a esta persona
                        var usuarioExistente = context.usuario
                            .FirstOrDefault(u => u.id == personaSeleccionada.id && u.tipoId == personaSeleccionada.tipoId);

                        if (usuarioExistente != null)
                        {
                            MessageBox.Show("Ya existe un usuario asociado a esta persona.",
                                            "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Crear nuevo usuario
                        var nuevoUsuario = new clsUsuario
                        {
                            id = personaSeleccionada.id,
                            tipoId = personaSeleccionada.tipoId,
                            nombre_Usuario = txtUsuario.Text.Trim(),
                            contrasena = txtPassword.Text.Trim(),
                            estado = true,
                            idRol = (int)cboRol.SelectedValue
                        };

                        // Guardar en la BD
                        context.usuario.Add(nuevoUsuario);
                        context.SaveChanges();

                        MessageBox.Show("El usuario fue creado correctamente.",
                                        "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        limpiarForm();
                        this.Close();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrió un error al guardar el usuario. " +
                                "Por favor, verifique la información e intente nuevamente.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void limpiarForm()
        {
            cboPersona.ResetText();
            txtUsuario.ResetText();
            txtPassword.ResetText();
            txtConfirmarContraseña.ResetText();
            cboRol.SelectedIndex = -1;
        }

        private bool validarDatos()
        {
            // Tus validaciones de campos (txtUsuario, txtPassword, etc.) van aquí.
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario");
                return false;
            }
            // ... (otras validaciones)
            if (cboPersona.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar una persona");
                return false;
            }
            if (cboRol.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un rol");
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("La contraseña no puede estar vacía.");
                return false;

            }
            if (txtPassword.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifíquelas.");
                return false;

            }

            return true;
        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //llenar el Combox de personas y roles cuando se carga el formulario
            CargarComboPersona();
            CargarComboRol();

        }
        
        private void CargarComboPersona()
        {
            /*using (var context = new dbContextINA())
            {
                var personas = context.persona
                    .Select(p => new
                    {
                        p.id,
                        NombreCompleto = p.nombre + " " + p.apellido1 + " " + p.apellido2
                    })
                    .ToList();*/
            var personas = new[]
            {
                new { id = "1", NombreCompleto = "Luis Alvarez Rojas", tipoId = 1 },
                new { id = "2", NombreCompleto = "Karla Rojas Sanchez", tipoId = 2 }
                
            }.ToList();

            cboPersona.DataSource = personas;
            cboPersona.DisplayMember = "NombreCompleto";
            cboPersona.ValueMember = "id";

        }

        private void CargarComboRol()
        {
            /*using (var context = new dbContextINA())
            {
                var roles = context.rol
                    .Where(r => r.estado == true)
                    .ToList();*/
            var roles = new[]
            {
                new { idRol = 1, nombreRol = "Administrador" },
                new { idRol = 2, nombreRol = "Usuario" }
            }.ToList();

            cboRol.DataSource = roles;
            cboRol.DisplayMember = "nombreRol";
            cboRol.ValueMember = "idRol";

        }

        private void cboPersona_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPersona.SelectedValue == null)
                return;

            string idPersonaSeleccionada = cboPersona.SelectedValue.ToString();
            using (var context = new dbContextINA())
            {
                var persona = context.persona.FirstOrDefault(p => p.id == idPersonaSeleccionada);

                if (persona != null)
                {
                    string info = $"Nombre: {persona.nombre} {persona.apellido1} {persona.apellido2}\n" +
                          $"Fecha Nac.: {persona.fechaNac.ToShortDateString()}\n" +
                          $"Email: {persona.email}\n" +
                          $"Dirección: {persona.direccion}\n" +
                          $"Teléfono: {persona.telefono}\n" +
                          $"Estado: {(persona.estado ? "Activo" : "Inactivo")}";

                    MessageBox.Show(info, "Datos Persona");

                }
            }
        }

        private void cboRol_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Obtener el item seleccionado y hacer cast a clsRol
            if (cboRol.SelectedItem is Entities.clsRol rolSeleccionado)
                // Aquí accedes a la "collection item" seleccionada
                MessageBox.Show("Rol: " + rolSeleccionado.nombreRol + "\nDescripción: " +
                    rolSeleccionado.descripcion);

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

            //Obtener el item seleccionado y hacer cast a clsRol
            if (cboRol.SelectedItem is Entities.clsRol rolSeleccionado)
                // Aquí accedes a la "collection item" seleccionada
                MessageBox.Show("Rol: " + rolSeleccionado.nombreRol + "\nDescripción: " +
                    rolSeleccionado.descripcion);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult resp = MessageBox.Show("¿Está seguro que desea eliminar el usuario?", "Confirmación",
                     MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resp == DialogResult.Yes)
                {
                    _usuarioService.eliminar(usuarioSelected.id);
                    MessageBox.Show("Usuario eliminado correctamente");
                    this.Close(); //cierro el formulario
                }


            }
            catch (Exception)
            {

                MessageBox.Show("Error al eliminar el usuario.");
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}

