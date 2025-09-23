using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class EspecialidadDao
    {
        // CRUD
        private dbContextINA _context; //CONTEXTO DE BASE DE DATOS

        public EspecialidadDao()
        {
            _context = new dbContextINA(); //INICIALIZAR EL CONTEXTO
        }

        public void crear(clsEspecialidadMedica especialidad)
        {
            _context.especialidadMedica.Add(especialidad);
            _context.SaveChanges();
        }

        public void modificar(clsEspecialidadMedica especialidad)
        {
            _context.especialidadMedica.Update(especialidad);
            _context.SaveChanges();
        }

        public void eliminar(int id)
        {
            var especialidad = consultarPorID(id);
            if (especialidad != null)
            {
                _context.especialidadMedica.Remove(especialidad);
                _context.SaveChanges();
            }
        }

        public clsEspecialidadMedica consultarPorID(int id)
        {
            return _context.especialidadMedica
                           .Where(e => e.idEspecialidadMedica == id)
                           .SingleOrDefault();
        }

        public clsEspecialidadMedica consultarPorNombre(string nombre)
        {
            return _context.especialidadMedica
                           .Where(e => e.nombreEspecialidad.Trim().ToUpper() == nombre.Trim().ToUpper())
                           .SingleOrDefault();
        }

        public List<clsEspecialidadMedica> consultarTodos()
        {
            return _context.especialidadMedica.ToList();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsEspecialidadMedica consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        

      
    }
}
