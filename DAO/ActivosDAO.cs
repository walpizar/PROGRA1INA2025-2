using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ActivosDAO : IGenerica<clsActivos>
    {
        private dbContextINA _context;

        public ActivosDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsActivos activo)
        {
            _context.Activos.Add(activo);
            _context.SaveChanges();
        }

        public void modificar(clsActivos activo)
        {
            _context.Activos.Update(activo);
            _context.SaveChanges();
        }

        public void eliminar(int id)
        {
            var activo = consultarPorID(id);
            _context.Activos.Remove(activo);
            _context.SaveChanges();
        }

        public clsActivos consultarPorID(int id)
        {
            return _context.Activos.Where(p => p.IdActivo == id).SingleOrDefault();
        }

        public clsActivos consultarPorNombre(string nombre)
        {
            return _context.Activos.Where(p => p.NombreActivo.Trim().ToUpper() == nombre.Trim().ToUpper()).SingleOrDefault();
        }

        public List<clsActivos> consultarTodos()
        {
            return _context.Activos.ToList();
        }
    }

}

