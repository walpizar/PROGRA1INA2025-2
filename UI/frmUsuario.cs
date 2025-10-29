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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UI
{
    public partial class frmUsuario : Form
    {
        public clsUsuario usuarioSelected { get; set; }
        private readonly UsuarioService _usuarioService;
        private string? idSeleccionado;


        public frmUsuario()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();

        }
        private void frmUsuario_Load(object sender, EventArgs e)
        {
            //llenar el Combox de personas y roles cuando se carga el formulario
            CargarComboPersona();
            CargarComboRol();

            if (usuarioSelected != null)
            {

                //MessageBox.Show("Cargando usuario: " + usuarioSelected.nombre_Usuario);

                txtUsuario.Text = usuarioSelected.nombre_usuario;
                txtPassword.Text = usuarioSelected.contrasena;
                txtConfirmarContraseña.Text = usuarioSelected.contrasena;
                cboRol.SelectedValue = usuarioSelected.personaId;

                // Si manejás Persona vinculada al usuario
                if (!string.IsNullOrEmpty(usuarioSelected.personaId))
                {
                    cboPersona.SelectedValue = usuarioSelected.personaId;
                }
            }

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    using (var context = new dbContextINA())
                    {
                        clsPersona personaSeleccionada = null;

                        // Si el combo está vacío o no tiene seleccionada una persona
                        if (cboPersona.SelectedValue == null)
                        {
                            // Crear nueva persona desde los textbox
                            personaSeleccionada = new clsPersona
                            {
                                id = Guid.NewGuid().ToString("N").Substring(0, 20),
                                tipoId = 1, //ajustalo según tu lógica
                                nombre = txtNombre.Text,
                                apellido1 = "", // si no lo usás, déjalo vacío
                                apellido2 = "",
                                email = txtEmail.Text,
                                telefono = txtTelefono.Text,
                                direccion = txtDireccion.Text,
                                fechaNac = DateTime.TryParse(dtpFechaNac.Text, out var fecha) ? fecha : DateTime.Now,
                                estado = true
                            };

                            context.persona.Add(personaSeleccionada);
                            context.SaveChanges();

                            // Refrescar el combo y seleccionar la nueva persona
                            CargarComboPersona(personaSeleccionada.id);
                        }
                        else
                        {
                            // Buscar persona seleccionada en el combo
                            string idPersona = cboPersona.SelectedValue.ToString();
                            personaSeleccionada = context.persona.FirstOrDefault(p => p.id == idPersona);
                        }

                        // Crear o actualizar Usuario
                        clsUsuario usuario = usuarioSelected ?? new clsUsuario();

                        usuario.personaId = personaSeleccionada.id;
                        usuario.personaTipoId = personaSeleccionada.tipoId;
                        usuario.nombre_usuario = txtUsuario.Text.Trim();
                        usuario.contrasena = txtPassword.Text;
                        usuario.rol = (int)cboRol.SelectedValue;
                        usuario.estado = true;

                        var existente = context.usuario
                            .FirstOrDefault(u => u.nombre_usuario == usuario.nombre_usuario);

                        if (existente != null)
                        {
                            context.Entry(existente).CurrentValues.SetValues(usuario);
                            context.Entry(existente).State = EntityState.Modified;
                        }
                        else
                        {
                            context.usuario.Add(usuario);
                        }

                        // Crear nuevo usuario
                        var nuevoUsuario = new clsUsuario
                        {
                            personaId = personaSeleccionada.id,
                            personaTipoId = personaSeleccionada.tipoId,
                            nombre_usuario = txtUsuario.Text.Trim(),
                            contrasena = txtPassword.Text.Trim(),
                            estado = true,
                            //idRol = (int)cboRol.SelectedValue
                        };

                        // Guardar en la BD
                        context.usuario.Add(nuevoUsuario);
                    }

                    MessageBox.Show(usuarioSelected == null
                        ? "Usuario creado correctamente."
                        : "Usuario modificado correctamente.",
                        "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    limpiarForm();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                string error = "Error al guardar:\n" + ex.Message;

                if (ex.InnerException != null)
                {
                    error += "\nInner: " + ex.InnerException.Message;

                    if (ex.InnerException.InnerException != null)
                    {
                        error += "\nDetalle: " + ex.InnerException.InnerException.Message;
                    }
                }

                MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            //Validaciones de Persona 
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de la persona.");
                txtNombre.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Debe ingresar un correo electrónico.");
                txtEmail.Focus();
                return false;
            }

            // Validar formato de email
            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Debe ingresar un número de teléfono.");
                txtTelefono.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("Debe ingresar la dirección.");
                txtDireccion.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(dtpFechaNac.Text))
            {
                MessageBox.Show("Debe ingresar la fecha de nacimiento.");
                dtpFechaNac.Focus();
                return false;
            }

            DateTime fechaNacimiento;
            if (dtpFechaNac.Value > DateTime.Today)
            {
                MessageBox.Show("La fecha de nacimiento no puede ser en el futuro.");
                return false;
            }


            // Validaciones de Usuario
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Debe ingresar el nombre de usuario.");
                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Debe ingresar una contraseña.");
                txtPassword.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text))
            {
                MessageBox.Show("Debe confirmar la contraseña.");
                txtConfirmarContraseña.Focus();
                return false;
            }

            if (txtPassword.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden. Por favor, verifíquelas.");
                txtConfirmarContraseña.Focus();
                return false;
            }

            if (cboRol.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un rol.");
                cboRol.Focus();
                return false;
            }

            // Si todas las validaciones pasan
            return true;

        }

        private void CargarComboPersona(string idSeleccionado = null)
        {
            using (var context = new dbContextINA())
            {
                var personas = context.persona
                    .Select(p => new
                    {
                        p.id,
                        NombreCompleto = p.nombre + " " + p.apellido1 + " " + p.apellido2
                    })
                    .ToList();

                cboPersona.DataSource = personas;
                cboPersona.DisplayMember = "NombreCompleto";
                cboPersona.ValueMember = "id";

                if (!string.IsNullOrEmpty(idSeleccionado))
                {
                    cboPersona.SelectedValue = idSeleccionado; // selecciona la nueva persona
                }
                else
                {
                    cboPersona.SelectedIndex = -1; // ninguno seleccionado por defecto
                }
            }

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

        private void cboPersona_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboPersona.SelectedValue == null)
                return;

            string idPersonaSeleccionada = cboPersona.SelectedValue.ToString();

            using (var context = new dbContextINA())
            {
                var persona = context.persona.FirstOrDefault(p => p.id == idPersonaSeleccionada);

                if (persona != null)
                {
                    txtNombre.Text = persona.nombre;
                    txtEmail.Text = persona.email;
                    txtTelefono.Text = persona.telefono;
                    txtDireccion.Text = persona.direccion;
                    dtpFechaNac.Text = persona.fechaNac.ToShortDateString();
                    //txtEstado.Text = persona.estado ? "Activo" : "Inactivo";
                }
                else
                {
                    txtNombre.Clear();
                    txtEmail.Clear();
                    txtTelefono.Clear();
                    txtDireccion.Clear();
                    dtpFechaNac.Value = DateTime.Today;
                    //txtEstado.Clear();
                }
            }

        }

        private void cboRol_SelectedChanged(object sender, EventArgs e)
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
                if (usuarioSelected != null)
                {

                    DialogResult resp = MessageBox.Show(
                        "¿Está seguro que desea eliminar el usuario?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (resp == DialogResult.Yes)
                    {
                        _usuarioService.eliminar(usuarioSelected.nombre_usuario);
                        MessageBox.Show("Usuario eliminado correctamente.");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No hay un usuario seleccionado.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtConfirmarContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

