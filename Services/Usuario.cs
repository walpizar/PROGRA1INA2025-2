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
      
        UsuarioDAO _usuarioDAO= new UsuarioDAO();
        public UsuarioService() { }


        public void crear(clsUsuario usuario)
        {
            // regla de negocio valida queno exista un Usuario con el mismo id
            if (_usuarioDAO.consultarPorID(usuario.personaId) != null)
            {
                throw new Exception("El cliente ya existe");
            }
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
            try
            {
                return _usuarioDAO.consultarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar todos los usuarios", ex);
            }
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
