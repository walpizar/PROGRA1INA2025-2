using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Common.Interfaces;

namespace DAO
{
    public class DevolucionDao : IDevolucion
    {
        //CRUD
        private dbContextINA _context;

        public DevolucionDao()
        {
            _context = new dbContextINA();
        }

        public void crear(clsDevolucion devolucion)
        {
            if (devolucion == null) throw new ArgumentNullException(nameof(devolucion));
            devolucion.estado = true; // asegurar activa al crear
            _context.Devoluciones.Add(devolucion);
            _context.SaveChanges();
        }

        public void modificar(clsDevolucion devolucion)
        {
            if (devolucion == null) throw new ArgumentNullException(nameof(devolucion));
            _context.Devoluciones.Update(devolucion);
            _context.SaveChanges();
        }

        public void eliminar(int id)
        {
            var devolucion = _context.Devoluciones.SingleOrDefault(p => p.idDevolucion == id);
            if (devolucion == null || !devolucion.estado)
                throw new InvalidOperationException($"No se encontró una devolución activa con el ID {id}.");

            // Borrado lógico
            devolucion.estado = false;
            _context.SaveChanges();
        }

        public clsDevolucion consultarPorID(int id)
        {
            var devolucion = _context.Devoluciones
                .Include(d => d.activo)
                .SingleOrDefault(p => p.idDevolucion == id && p.estado);

            return devolucion ?? throw new InvalidOperationException($"No se encontró una devolución con el ID {id}.");
        }

        public List<clsDevolucion> consultarTodos()
        {
            return _context.Devoluciones
                .Include(d => d.activo)
                .Where(d => d.estado)
                .ToList();
        }
    }
}
