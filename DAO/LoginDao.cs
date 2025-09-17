using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class LoginDao : IGenerica<clsUsuario>
    {
        //declaro el contexto
        private readonly dbContextINA _context;

        public LoginDao()
        {

            //aqui instancio el contexto
            _context = new dbContextINA();
        }

        //metodo obtener correo por usuario
        public string ObtenerCorreoPorUsuario(string correo)
        {
            try
            {
                //busco el usuario en la base de datos (tablaPersona)
                var persona = _context.persona.FirstOrDefault(p => p.email == correo);
                //si el usuario no existe, retorno null
                if (persona == null)
                {
                    return null;
                }
                //retorno el correo del usuario encontrado
                return persona.email;
            }
            catch (Exception ex)
            {
                //manejo de excepciones
                throw new Exception("Error al obtener el correo del usuario: " + ex.Message);
            }
        }

        //metodo para actualizar la contraseña en la base de datos
        public void ActualizarContraseña(string correo, string nuevaContraseña)
        {
            try
            {
                //busco el email usuario en la base de datos
                var persona = _context.persona.FirstOrDefault(c => c.email == correo);

                //si el usuario no existe, lanzo una excepcion
                if (persona == null)
                {
                    throw new Exception("El correo no existe");
                }

                //obtengo la persona asociada al correo
                var usuario = _context.usuario.FirstOrDefault(u => u.personaId == persona.id);

                if (usuario == null) {  
                    throw new Exception("El usuario no existe");
                }

                //actualizo la contraseña
                usuario.contrasena = nuevaContraseña;
                //guardo los cambios en la base de datos
                _context.SaveChanges();
            }
            catch (Exception)
            {
                //manejo de excepciones
                throw new Exception("Error al actualizar la contraseña");
            }
        }

        public clsUsuario consultarPorID(string id)
        {
            //obetengo el id de la persona que es el mismo id de usuario
            return _context.usuario.FirstOrDefault(u => u.personaId == id);//falta la propiedad usuarios en el dbContex
        }


        //metodo para consultar por nombr
        public clsUsuario consultarPorNombre(string nombre)
        {
            //busco el usuario por nombre en la base de datos
            return _context.usuario.FirstOrDefault(u => u.nombre_usuario == nombre);
        }



        //metodos no implementados para cumplir con la interfaz
        public void crear(clsUsuario entidad)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsUsuario entidad)
        {
            throw new NotImplementedException();
        }

        public List<clsUsuario> consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }
    }
}
