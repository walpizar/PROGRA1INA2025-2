using Common.Interfaces;
using Entities;

namespace DAO
{
    public class UsuarioDAO : IGenerica<clsUsuario>
    {
        private dbContextINA _context;

        public UsuarioDAO() { 
            _context = new dbContextINA();

        }

        public void crear(clsUsuario usuario)
        {
            _context.usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void modificar(clsUsuario usuario)
        {
            _context.usuario.Update(usuario);
            _context.SaveChanges();

        }

        public void eliminar(string id)
        {
            // Se busca el usuario primero para evitar un error de referencia nula
            var usua = _context.usuario.SingleOrDefault(u => u.personaId == id);
            if (usua != null)
            {
                _context.usuario.Remove(usua);
                _context.SaveChanges();

            }

        }
        public clsUsuario consultarPorID(string id)
        {
            return _context.usuario.Find(id);
        }

        public clsUsuario consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsUsuario consultarPorNombre(string nombre)
        {
            return _context.usuario.Where(u => u.nombre_usuario.Trim().ToUpper()
                                              == nombre.Trim().ToUpper()).SingleOrDefault();
        }

        public List<clsUsuario> consultarTodos()
        {
            return _context.usuario.ToList();

        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id, int tipoId)
        {
            throw new NotImplementedException();
        }

        public clsUsuario consultarPorID(string id, int tipoId)
        {
            throw new NotImplementedException();
        }
    }
}