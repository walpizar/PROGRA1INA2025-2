using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
<<<<<<< HEAD
            _context.Devoluciones.Add(devolucion);
=======
            _context.devolucion.Add(devolucion);
>>>>>>> develop
            _context.SaveChanges();
        }

        public void modificar(clsDevolucion devolucion)
        {
<<<<<<< HEAD
            _context.Devoluciones.Update(devolucion);
=======
            _context.devolucion.Update(devolucion);
>>>>>>> develop
            _context.SaveChanges();
        }

        public void eliminar(int id)
        {
            var devolucion = consultarPorID(id);
<<<<<<< HEAD
            _context.Devoluciones.Remove(devolucion);
=======
            _context.devolucion.Remove(devolucion);
>>>>>>> develop
            _context.SaveChanges();
        }

        public clsDevolucion consultarPorID(int id)
        {
<<<<<<< HEAD
            var devolucion = _context.Devoluciones.Where(p => p.IdDevolucion == id).SingleOrDefault();
=======
            var devolucion = _context.devolucion.Where(p => p.idDevolucion == id).SingleOrDefault();
>>>>>>> develop
            return devolucion ?? throw new InvalidOperationException($"No se encontró una devolución con el ID {id}.");
        }

        public List<clsDevolucion> consultarTodos()
        {
<<<<<<< HEAD
            return _context.Devoluciones.ToList();
=======
            return _context.devolucion.ToList();
>>>>>>> develop
        }
    }
}
