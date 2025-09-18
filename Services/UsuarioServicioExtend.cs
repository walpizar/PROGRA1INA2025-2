using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entities;

namespace Services
{
    public class UsuarioServicioExtend
    {
        private readonly UsuarioDAO _usuarioDAO = new UsuarioDAO();
        public UsuarioServicioExtend()
        {

        }

        public void crear(clsUsuario usuario) {
        if (_usuarioDAO.consultarPorID(usuario.personaId, usuario.personaTipoId) != null)
            {
                throw new Exception("El usuario ya existe");
            }
            _usuarioDAO.crear(usuario);
        }

        public void modificar(clsUsuario usuario) {
            if (_usuarioDAO.consultarPorID(usuario.personaId, usuario.personaTipoId) == null)
            {
                throw new Exception("El usuario no existe");
            }
            _usuarioDAO.modificar(usuario);
        }

        public void eliminar(string personaId, int personaTipoId) {
            if (_usuarioDAO.consultarPorID(personaId, personaTipoId) == null)
            {
                throw new Exception("El usuario no existe");
            }
            _usuarioDAO.eliminar(personaId, personaTipoId);
        }

        public clsUsuario consultarPorID(string personaId, int personaTipoId) {
            return _usuarioDAO.consultarPorID(personaId, personaTipoId);
        }

        public clsUsuario consultarPorNombre(string nombre) {
            return _usuarioDAO.consultarPorNombre(nombre);
        }

        public List<clsUsuario> consultarTodos() {
            throw new NotImplementedException();
        }
    }
}
