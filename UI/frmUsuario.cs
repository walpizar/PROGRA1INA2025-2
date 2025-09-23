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
        private readonly UsuarioService _usuarioService;
        public clsUsuario usuarioSelected { get; set; }
        


        public frmUsuario()
        {
            InitializeComponent();
            // Creamos dependencias aquí mismo (no tocamos Program.cs)
            var context = new dbContextINA();
            var usuarioDAO = new UsuarioDAO(context);
            _usuarioService = new UsuarioService(usuarioDAO);

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
                    // Lógica para crear o modificar.
                    clsUsuario usuario = usuarioSelected == null ? new clsUsuario() : usuarioSelected;

                    // Asigna valores a las propiedades del usuario.
                    usuario.personaId = cboPersona.SelectedValue.ToString();
                    usuario.nombre_Usuario = txtUsuario.Text.Trim();
                    usuario.contrasena = txtPassword.Text;
                    usuario.idRol = (int)cboRol.SelectedValue;

                    if (usuarioSelected == null)
                    {
                        _usuarioService.crear(usuario);
                        MessageBox.Show("Usuario creado correctamente");
                    }
                    else
                    {
                        _usuarioService.modificar(usuario);
                        MessageBox.Show("Usuario modificado correctamente");
                    }

                    //limpio los campos
                    limpiarForm();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ocurrió un error al guardar el usuario: " + ex.Message);
                string inner = ex.InnerException != null ? ex.InnerException.Message : "";
                string inner2 = ex.InnerException?.InnerException != null ? ex.InnerException.InnerException.Message : "";

                MessageBox.Show(
                    "Ocurrió un error al guardar el usuario:\n" + ex.Message +
                    (string.IsNullOrEmpty(inner) ? "" : "\n\nInnerException: " + inner) +
                    (string.IsNullOrEmpty(inner2) ? "" : "\n\nInnerException2: " + inner2)
                );
            }
        }

        private void limpiarForm()
        {
            cboPersona.ResetText();
            txtUsuario.ResetText();
            txtPassword.ResetText();
            txtConfirmar.ResetText();
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

            return true;
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
                new { id = "1", NombreCompleto = "Luis Alvarez Rojas" },
                new { id = "2", NombreCompleto = "Karla Rojas Sanchez" }
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



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                MessageBox.Show("Seleccione un usuario");
                return;
            }

            // Elimina por nombre de usuario
            _usuarioService.eliminar(txtUsuario.Text.Trim());
            MessageBox.Show("Usuario eliminado (lógicamente)");

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}

