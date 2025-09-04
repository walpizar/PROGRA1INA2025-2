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
            //_context.Devolucion.Add(devolucion);
            //_context.SaveChanges();
        }

        public void modificar(clsDevolucion devolucion)
        {
            //_context.Devolucion.Update(devolucion);
            //_context.SaveChanges();
        }

        public void eliminar(int id)
        {
            //var devolucion = consultarPorID(id);
            //_context.Devolucion.Remove(devolucion);
            //_context.SaveChanges();
        }

        public clsDevolucion consultarPorID(int id)
        {
            //var devolucion = _context.Devolucion.Where(p => p.IdDevolucion == id).SingleOrDefault();
            //return devolucion ?? throw new InvalidOperationException($"No se encontró una devolución con el ID {id}.");
            return null;
        }

        public List<clsDevolucion> consultarTodos()
        {
            //return _context.Devolucion.ToList();
            return null;
        }
    }
}
