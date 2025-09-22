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
    public partial class frmLogin : Form
    {

        //declaro instamncia para capa de servicios
        private LoginService _loginService;

        public frmLogin()
        {
            InitializeComponent();

            //centro el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //instancio la clase de servicios
            _loginService = new LoginService();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                //variables para obtener los valores de los textbox de usuario y contraseña
                string usuario = txtUsuario.Text;
                string contra = txtPassword.Text;

                //Valido que los campos no esten null o vacios
                if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contra))
                {
                    MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Campos requeridos",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Valido login 
                if (_loginService.ValidarLogin(usuario, contra))
                {
                    MessageBox.Show("Login exitoso", "Bienvenido",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //aquí abrp el formulario principal
                    frmPrincipal principal = new frmPrincipal();
                    principal.Show();

                    //oculto el formulario de login si el logine es exitoso
                    this.Hide(); 

                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos. Verifique e intentelo de nuevo", "Error de autenticación",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                //manejo de excepciones
                MessageBox.Show("Error al intentar iniciar sesión. Contacte con su administrador.\n"
                    + "Error:\n" + ex.Message, "Error de sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //evento click del boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //aqui cierro el formulario
            this.Close();
        }


        //evento link click del link label de olvido contraseña       
        private void linkLblOlvidoContra_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                bool correoCorrecto = false;
                string correoRegistrado = "";

                //bucle para repetir si el correo ingresado no es el mismo que esta en la base de datos
                while (!correoCorrecto)
                {
                    correoRegistrado = Microsoft.VisualBasic.Interaction.InputBox(//uso un cuadro de dialogo para pedir el correo registrado
                        "Por favor, ingrese su correo electrónico registrado:",//mensaje del cuadro de diálogo 
                        "Recuperar Contraseña", //título del cuadro de diálogo
                        "");

                    //valido que el correo no sea vacio
                    if (string.IsNullOrEmpty(correoRegistrado))
                    {
                        return;//si es vacio, salgo del método
                    }

                    //valido que el correo exista en la base de datos, llamo a mi capa de servicios para validar el correo
                    if (_loginService.ValidarCorreoExistente(correoRegistrado))
                    {
                        correoCorrecto = true; //cambio a true si es correcto para salir del bucle
                    }
                    else
                    {
                        //muestro mensaje de error si el correo no existe con botón OK y icono de error
                        MessageBox.Show("El correo electrónico no está registrado. Por favor, inténtelo de nuevo.",
                            "Correo No Registrado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                //cierre del while
                }

                //llamo a mi capa de servicios para enviar el codigo de recuperacion, dentr del if valido si se envio correctamente
                if (_loginService.EnviarCodigoRecuperacion(correoRegistrado))
                {
                    //muestro mensaje de exito si se envio correctamente con botón OK y icono de información
                    MessageBox.Show("Se ha enviado un código de recuperación a su correo electrónico.",
                        "Código Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    bool codigoValido = false; //variable para verificar si es true y salga del bucle
                    string codigoIngresado = "";

                    //bucle para repetir si el codigo ingresado no es el mismo que se envio al correo
                    while (!codigoValido)
                    {
                        //uso un cuadro de dialogo para pedir el codigo enviado
                        codigoIngresado = Microsoft.VisualBasic.Interaction.InputBox(//uso un cuadro de dialogo para pedir el codigo enviado
                            "Por favor, ingrese el código de recuperación que se envió a su correo electrónico:", //mensaje del cuadro de diálogo
                            "Ingresar Código", "");//título del cuadro de diálogo

                        //valido que el codigo no sea vacio
                        if (string.IsNullOrEmpty(codigoIngresado))
                        {
                            return; //si es vacio, salgo del método
                        }


                        //aqui valido el codigo ingresado, llamo a mi capa de servicios para validar el codigo
                        if (_loginService.ValidarCodigoRecuperacion(correoRegistrado, codigoIngresado))
                        {
                            codigoValido = true;//cambio a true si es valido para salir del bucle

                            //ocultop el form de login
                            this.Hide();

                            //si el codigo es valido, abro el formulario para cambiar la contraseña
                            //llamo al constructor que recibe el correo del usuario para pasarselo al formulario de recuperar contraseña
                            frmRecuperarContra frmRecuperar = new frmRecuperarContra(correoRegistrado);
                            frmRecuperar.ShowDialog(); //muestro el formulario 

                            //cuando se cierre el formulario de recuperar contraseña, musestro el formulario de login
                            this.Show();

                        }
                        else
                        {
                            //si el codigo no es valido, muestro mensaje de error con botón OK y icono de error
                            MessageBox.Show("El código ingresado es incorrecto. Por favor, inténtelo de nuevo.",
                                "Código Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    //cierre del while
                    }
                //cierre del if enviarCodigoRecuperacion
                }
            }
            catch (Exception ex)
            {
                //manejo de excepciones
                MessageBox.Show("Error al intentar enviar el código de recuperación. Contacte con su administrador.\n"
                    + "Error:\n" + ex.Message,
                    "Error de Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
