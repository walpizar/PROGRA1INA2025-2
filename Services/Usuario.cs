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
    public class UsuarioService : IGenerica<clsUsuario, string>
    {
      
        UsuarioDAO _usuarioDAO= new UsuarioDAO();
        public UsuarioService() { }


        public void crear(clsUsuario usuario)
        {
            // regla de negocio valida queno exista un Usuario con el mismo id
            if (_usuarioDAO.consultarPorID(usuario.id) != null)
            {
                throw new Exception("El cliente ya existe");
            }
            _usuarioDAO.crear(usuario);
        }

        public void modificar(clsUsuario usuario)
        {
            _usuarioDAO.modificar(usuario);
        }

        public void eliminar(string id)
        {
            //validar que el usuario exista
            if (_usuarioDAO.consultarPorID(id) == null)
            {
                throw new Exception("El usuario no existe");
            }

            _usuarioDAO.eliminar(id);
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
            throw new NotImplementedException();
        }
        
    }
}
