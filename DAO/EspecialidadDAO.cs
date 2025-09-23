using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class EspecialidadDao : IGenerica<clsEspecialidadMedica>
    {
        private dbContextINA _context;

        public EspecialidadDao()
        {
            _context = new dbContextINA();
        }

        public void crear(clsEspecialidadMedica especialidad)
        {
            _context.EspecialidadesMedicas.Add(especialidad);
            _context.SaveChanges();
        }

        public void modificar(clsEspecialidadMedica especialidad)
        {
            _context.EspecialidadesMedicas.Update(especialidad);
            _context.SaveChanges();
        }

        public void eliminar(int id)
        {
            var esp = consultarPorID(id);
            _context.EspecialidadesMedicas.Remove(esp);
            _context.SaveChanges();
        }

        public clsEspecialidadMedica consultarPorID(int id)
        {
            return _context.EspecialidadesMedicas
                           .Where(e => e.idEspecialidadMedica == id)
                           .SingleOrDefault();
        }

        public clsEspecialidadMedica consultarPorNombre(string nombre)
        {
            return _context.EspecialidadesMedicas
                           .Where(e => e.nombreEspecialidad.Trim().ToUpper() == nombre.Trim().ToUpper())
                           .SingleOrDefault();
        }

        public List<clsEspecialidadMedica> consultarTodos()
        {
            return _context.EspecialidadesMedicas.ToList();
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
