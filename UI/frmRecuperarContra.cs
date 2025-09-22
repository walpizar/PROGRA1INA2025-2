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
    public partial class frmRecuperarContra : Form
    {
        //declaro la instancia para la capa de servicios
        private Services.LoginService _loginService;

        //declaro vaRIAble paRA ALMACENAR EL CORREO
        private string _correoUsuario;

        public frmRecuperarContra()
        {
            //inicializa los componentes del formulario
            InitializeComponent();

            //centro el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //aqui instancio la clase de servicios
            _loginService = new Services.LoginService();
        }

        //constructor que recibe el correo del usuario, el this es para llamar al constructor por defecto
        public frmRecuperarContra(string correo) : this()
        {
            //recibo el correo y lo asigno a la variable global
            _correoUsuario = correo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cierro el formulario
            this.Close();

        }

        //evento click del boton aceptar
        private void btnAceptarRecuperarContra_Click(object sender, EventArgs e)
        {
            try
            {
                //llamo al metodo validar datos de entrada dentro de un if
                if (ValidarDatosEntrada(txtNuevaContra.Text, txtConfirmarContra.Text))
                {

                    //declaro las variables para obtener los valores de los textbox
                    string nuevaContra = txtNuevaContra.Text;
                    string confirmarContra = txtConfirmarContra.Text;

                    //Cambiar la contraseña usando el correo guardado
                    if (_loginService.CambiarContraseña(_correoUsuario, nuevaContra))
                    {
                        MessageBox.Show("Contraseña actualizada correctamente.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                //manejo de excepciones
                MessageBox.Show("Error al intentar cambiar la contraseña. Contacte con su administrador." +
                    "\n" + "Error:" + "\n" + ex.Message, "Error de sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //metodo para validaciones de datos de entrada
        private bool ValidarDatosEntrada(string nuevaContra, string confirmarContra)
        {
            //valido que las contraseñas coincidan
            if (nuevaContra != confirmarContra)
            {
                //muestro mensaje de error si las contraseñas no coinciden con botón OK y icono de error
                MessageBox.Show("Las contraseñas no coinciden. Por favor, inténtelo de nuevo.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //valido que la contraseña no esté vacía
            if (string.IsNullOrWhiteSpace(nuevaContra))
            {
                MessageBox.Show("La contraseña no puede estar vacía.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //valido que la contraseña tenga al menos 8 caracteres y menos de 15
            if (nuevaContra.Length < 8 || nuevaContra.Length > 15)
            {
                MessageBox.Show("La contraseña debe tener entre 8 y 15 caracteres.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //valido que la contraseña contenga al menos una letra mayúscula, una minúscula, un número y un carácter especial
            //el system.text.regex es para usar expresiones regulares como por ejemplo a-z, A-Z, 0-9, etc
            if (!System.Text.RegularExpressions.Regex.IsMatch(nuevaContra, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&,.%#_+-/:;])[A-Za-z\d@$!%*?&,.%#_+-/:;]{8,15}$"))
            {
                MessageBox.Show("La contraseña debe contener al menos una letra mayúscula, una letra minúscula, un número y un carácter especial.\n"
                    + "Itentelo nuevamente.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //si pasa todas las validaciones, retorno true
            return true;
        }

    }
}
