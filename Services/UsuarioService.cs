using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class UsuarioService : IGenerica<clsUsuario>
    {

        // Declara la dependencia de UsuarioDAO.
        private readonly UsuarioDAO _usuarioDAO= new UsuarioDAO();
        private object _context;

       
        public UsuarioService()
        {

        }
        public void crear(clsUsuario usuario)
        {
            // regla de negocio valida que no exista un Usuario con el mismo id
            if (_usuarioDAO.consultarPorNombre(usuario.nombre_Usuario) != null)
            {
                throw new Exception("El usuario ya existe");
            }
            // Validar por ID de persona
            if (_usuarioDAO.consultarPorID(usuario.id) != null)
            {
                throw new Exception("Ya existe un usuario asociado a esta persona.");
            }

            usuario.estado = true; // siempre en true al crear
            // Si el usuario no existe, se procede a crearlo.
            _usuarioDAO.crear(usuario);
        }

        public void modificar(clsUsuario usuario)
        {
            _usuarioDAO.modificar(usuario);
        }

        public void eliminar(string nombreUsuario)
        {
            _usuarioDAO.eliminar(nombreUsuario);
        }

        public clsUsuario consultarPorID(string id)
        {
            return _usuarioDAO.consultarPorID(id);
        }

        public clsUsuario consultarPorNombre(string nombre)
        {
            return _usuarioDAO.consultarPorNombre(nombre);
        }

        public List<clsUsuario> consultarTodos()
        {
            return _usuarioDAO.consultarTodos();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException("Usar eliminar(string nombreUsuario)");
        }

        public clsUsuario consultarPorID(int id)
        {
            throw new NotImplementedException("Usar consultarPorID(string nombreUsuario)");
        }

        
    }
}
