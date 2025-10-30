using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class ActivosDAO : IDisposable
    {
        private readonly dbContextINA _context;

        public ActivosDAO(dbContextINA context)
        {
            _context = context;
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

        public List<clsActivos> consultarTodos()
        {
            return _context.Activos
                .Include(a => a.categoria) // Incluye la categoría relacionada
                .ToList(); // Eliminado el filtro .Where(a => a.Estado) para incluir activos con Estado = false
        }

        public clsActivos consultarPorID(int id)
        {
            return _context.Activos
                .Include(a => a.categoria)
                .FirstOrDefault(a => a.idActivo == id && a.Estado);
        }

        public void EliminarActivo(int id)
        {
            var activo = _context.Activos.FirstOrDefault(a => a.idActivo == id);
            if (activo != null)
            {
                activo.Estado = false; // Cambia a dado de baja
                _context.SaveChanges();
            }
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
