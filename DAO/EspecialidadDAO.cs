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
            //_context.EspecialidadMedica.Add(especialidad);
            //_context.SaveChanges();
        }

        public void modificar(clsEspecialidadMedica especialidad)
        {
            //_context.EspecialidadMedica.Update(especialidad);
            //_context.SaveChanges();
        }

        public void eliminar(int id)
        {
            //var esp = consultarPorID(id);
            //_context.EspecialidadMedica.Remove(esp);
            //_context.SaveChanges();
        }

        public clsEspecialidadMedica consultarPorID(int id)
        {
            //return _context.EspecialidadMedica
            //               .Where(e => e.id == id)
            //               .SingleOrDefault();
            return null;
        }

        public clsEspecialidadMedica consultarPorNombre(string nombre)
        {
            //return _context.EspecialidadMedica
            //               .Where(e => e.nombre.Trim().ToUpper() == nombre.Trim().ToUpper())
            //               .SingleOrDefault();
            return null;
        }

        public List<clsEspecialidadMedica> consultarTodos()
        {
            //return _context.EspecialidadMedica.ToList();
            return null;
        }

        public void eliminar(string id, int tipoId)
        {
            throw new NotImplementedException();
        }

        public clsEspecialidadMedica consultarPorID(string id, int tipoId)
        {
            throw new NotImplementedException();
        }
    }
}
