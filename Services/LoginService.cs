using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class LoginService : IGenerica<clsUsuario>
    {
        //declaro instacia de DAO, privado y solo lectura para que no se modifique
        private readonly LoginDao _loginDao = new LoginDao();

        //Diccionario para almacenar los códigos de recuperación temporalmente (en memoria)
        private static Dictionary<string, string> codigosRecuperacion = new Dictionary<string, string>();

        //declaro global para usar el metodo random
        private static Random random = new Random();

        public LoginService() 
        {

        }


        //metodo para validar el login
        public bool ValidarLogin(string usuario, string contra)
        {

            //llamo al metodo de DAO para validar el login
            clsUsuario user = _loginDao.consultarPorNombre(usuario);
            //valido si el usuario existe y la contraseña coincide
            if (user != null && user.contrasena == contra)
            {
                return true; //login exitoso
            }
            else
            {
                return false; //login fallido
            }
        }


        //metodo para consultar por nombre de usuario
        public clsUsuario consultarPorNombre(string nombre)
        {
            //llamo a mi capoa DAO para buscar el nombre usuario
            return _loginDao.consultarPorNombre(nombre);
        }


        //metodo para validar si el correo existe en la base de datos
        public bool ValidarCorreoExistente(string correoRegistrado)
        {
            //llamo al metodo de DAO para obtener el correo
            string correoEncontrado = _loginDao.ObtenerCorreoPorUsuario(correoRegistrado);

            //valido si el cooreo es vacio(Empy) o nulo
            if (string.IsNullOrEmpty(correoEncontrado))
            {
                return false; //correo no existe
            }
            else
            {
                return true; //correo existe
            }
        }


        //metodo para enviar codigo de recuperacion
        public bool EnviarCodigoRecuperacion(string correoRegistrado)
        {
            try
            {
                //obtengo el correo del usuario
                string correoEncontrado = _loginDao.ObtenerCorreoPorUsuario(correoRegistrado);

                //valido si el correo existe
                if (string.IsNullOrEmpty(correoEncontrado))
                {
                    return false;//si no existe, retorno false
                }

                //genero un código ramdom de 6 dígitos (entre 100000 y 999999)
                string codigo = random.Next(100000, 999999).ToString();

                //guardo el código en el diccionario, asociándolo al correo del usuario
                codigosRecuperacion[correoRegistrado] = codigo;

                //llamo al método para enviar el correo con el código de recuperación
                EnviarCorreo(correoEncontrado, codigo);

                //retorno true si se envió correctamente
                return true;
            }
            catch (Exception)
            {
                //retorno false en caso de error
                return false;
            }
        }

        private void EnviarCorreo(string correoEncontrado, string codigo)
        {
            try
            {
                //clase para enviar correo, el "smtp.gmail" es para indicar que se usara gmail
                SmtpClient smtp = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587, //puerto para Gmail con TLS

                    //****Tengo que reemplazar con un correo real y la contraseña de la app generada en google******
                    Credentials = new NetworkCredential("soporte.paliativosgarabito@gmail.com", "poyk ygzh aozx bmnx"),

                    EnableSsl = true //habilita SSL/TLS para seguridad
                };

                //crea el mensaje de correo
                MailMessage mensaje = new MailMessage();
                mensaje.From = new MailAddress("soporte.paliativosgarabito@gmail.com");
                mensaje.To.Add(correoEncontrado);
                mensaje.Subject = "Código de recuperación de contraseña - Sistema Paliativos";
                mensaje.Body = $"Estimado usuario,\n\n" +
                              $"Su código de recuperación de contraseña es:\n\n {codigo}\n\n" +
                              $"Este código expira en 10 minutos por seguridad.\n\n" +
                              $"Si no solicitó este código, ignore este mensaje.\n\n" +
                              $"No resporder a este correo, es unicamente para envio de codigos de recuperacion de contraseña. \n\n " +
                              $"Saludos.\n" +
                              $"Sistema de Cuidados Paliativos Garabito.";

                //envia el correo
                smtp.Send(mensaje);
            }
            catch (Exception ex)
            {
                //muestra mensaje de error en caso de fallo
                throw new Exception("Error al enviar el correo:. Contacte con su administrador"
                    + "\n" + "Error:" + "\n" + ex.Message);

            }
        }


        //metodo para validar el codigo de recuperacion
        public bool ValidarCodigoRecuperacion(string correoRegistrado, string codigoIngresado)
        {
            //verifico que existe un código para ese correo y que coincide
            return codigosRecuperacion.ContainsKey(correoRegistrado) &&
                   codigosRecuperacion[correoRegistrado] == codigoIngresado;
        }



        //metodo para cambniar la contraseña
        public bool CambiarContraseña(string correo, string nuevaContraseña)
        {
            try
            {
                //aqui llamo al metodo de DAO para actualizar la contraseña
                _loginDao.ActualizarContraseña(correo, nuevaContraseña);

                //limpio el código de recuperación del diccionario para ese correo
                if (codigosRecuperacion.ContainsKey(correo))
                {
                    //elimino el código para que no pueda reutilizarse
                    codigosRecuperacion.Remove(correo);
                    
                }

                //retorno true si se actualizó correctamente
                return true;
            }
            catch (Exception)
            {
                //retorno false en caso de error
                return false;
            }

        }


        public clsUsuario consultarPorID(string personaId)
        {
            //Obtengo el id del usuario persona que es el mismo id de usuario
            return _loginDao.consultarPorID(personaId);
        }



        //metodos no implementados para cumplir con la interfaz
        public List<clsUsuario> consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void crear(clsUsuario entidad)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsUsuario entidad)
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }
    }
}
