using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class UsuarioDAO : IGenerica<clsUsuario>
    {
<<<<<<< HEAD
        private dbContextINA _context;
        

        public UsuarioDAO() {
            _context = new dbContextINA();
=======
        private readonly dbContextINA _context;
        

        public UsuarioDAO(dbContextINA context) { 
            _context = context;
>>>>>>> 402d6eeb49317638690ae90a0ab7fd445c339002

        }

        public void crear(clsUsuario usuario)
        {
            _context.usuario.Update(usuario);
            _context.SaveChanges();
        }

        public void modificar(clsUsuario usuario)
        {
<<<<<<< HEAD
            _context.usuario.Add(usuario);
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
            return _context.usuario.Where(u => u.id == id).SingleOrDefault();
=======
            var existing = _context.usuario
        .SingleOrDefault(u => u.personaId == usuario.personaId);

            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(usuario);
                _context.SaveChanges();
            }

        }

        public void eliminar(string nombreUsuario)
        {
            var usua = _context.usuario.SingleOrDefault(u => u.nombre_Usuario == nombreUsuario);
            if (usua != null)
            {
                // Borrado lógico
                usua.estado = false;
                _context.usuario.Update(usua);
                _context.SaveChanges();
            }

        }

        public clsUsuario consultarPorID(string id)
        {
            // Asume que 'id' se refiere a 'personaId'.
            return _context.usuario.SingleOrDefault(u => u.personaId == id);
        }
        public clsUsuario consultarPorID(string personaId, int personaTipoId)
        {
            return _context.usuario
                 .SingleOrDefault(u => u.personaId == personaId && u.personaTipoId == personaTipoId);
>>>>>>> 402d6eeb49317638690ae90a0ab7fd445c339002
        }

        public clsUsuario consultarPorNombre(string nombre)
        {
            return _context.usuario.Where(u => u.nombre_Usuario.Trim().ToUpper()
                                              == nombre.Trim().ToUpper()).SingleOrDefault();
        }

        public List<clsUsuario> consultarTodos()
        {
            return _context.usuario.ToList();

        }
<<<<<<< HEAD
=======


>>>>>>> 402d6eeb49317638690ae90a0ab7fd445c339002
       
    }
}