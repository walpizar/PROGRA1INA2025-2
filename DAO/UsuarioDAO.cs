using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class UsuarioDAO : IGenerica<clsUsuario>
    {
        private readonly dbContextINA _context;

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

        public void eliminar(string nombreUsuario)
        {
            var usua = consultarPorID(nombreUsuario);
            _context.usuario.Remove(usua);
            _context.SaveChanges();
           
        }

        public clsUsuario consultarPorID(string id)
        {
            // Asume que 'id' se refiere a 'personaId'.
            return _context.usuario.Where(u => u.personaId == id).SingleOrDefault();

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
            throw new NotImplementedException("Usar eliminar(string nombreUsuario)");
        }

        public clsUsuario consultarPorID(int id)
        {
            throw new NotImplementedException("Usar consultarPorID(string nombreUsuario)");
        }
    }
}