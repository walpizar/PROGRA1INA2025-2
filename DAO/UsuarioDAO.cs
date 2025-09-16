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
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public void modificar(clsUsuario usuario)
        {
            _context.Usuarios.Update(usuario);
            _context.SaveChanges();
        }

        public void eliminar(string id)
        {
            var usua = _context.Usuarios.SingleOrDefault(u => u.personaId == id);
            if (usua != null)
            {
                _context.Usuarios.Remove(usua);
                _context.SaveChanges();
            }
        }
        public clsUsuario consultarPorID(string id)
        {
            return _context.Usuarios.Find(id);
        }

        public clsUsuario consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsUsuario consultarPorNombre(string nombre)
        {
            return _context.Usuarios.Where(u => u.nombre_usuario.Trim().ToUpper()
                                              == nombre.Trim().ToUpper()).SingleOrDefault();
        }

        public List<clsUsuario> consultarTodos()
        {
            return _context.Usuarios.ToList();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}