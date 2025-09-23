using DAO;
using Entities;

namespace UI
{
    public class UsuarioService
    {
        private UsuarioDAO usuarioDAO;

        public UsuarioService(UsuarioDAO usuarioDAO)
        {
            this.usuarioDAO = usuarioDAO;
        }

        internal List<clsUsuario> consultarTodos()
        {
            throw new NotImplementedException();
        }

        internal void crear(clsUsuario usuario)
        {
            throw new NotImplementedException();
        }

        internal void eliminar(string v)
        {
            throw new NotImplementedException();
        }

        internal void modificar(clsUsuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}