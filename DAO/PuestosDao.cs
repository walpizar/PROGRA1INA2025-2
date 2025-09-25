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
    public class PuestosDao : IGenerica<clsPuestos>
    {

        private dbContextINA _context;

        public PuestosDao()
        {
            _context = new dbContextINA();
        }

        public clsPuestos consultarPorID(int id)
        {
            using var ctx = new dbContextINA();
            return ctx.puestos
                      .AsNoTracking()
                      .Include(p => p.Departamento)
                      .SingleOrDefault(p => p.idPuesto == id);
        }

        public List<clsPuestos> consultarTodos()
        {
            using (var context = new dbContextINA())
            {
                return context.puestos
                    .Where(p => p.Estado)
                    .ToList();
            }
        }

        public void crear(clsPuestos p)
        {
            using var ctx = new dbContextINA();
            ctx.puestos.Add(p);
            ctx.SaveChanges();
        }

        public void modificar(clsPuestos p)
        {
            using var ctx = new dbContextINA();
            ctx.puestos.Update(p);
            ctx.SaveChanges();
        }

        public void eliminar(int id)
        {
            using var ctx = new dbContextINA();
            var puesto = ctx.puestos.Find(id);
            if (puesto == null) return;
            ctx.puestos.Remove(puesto);
            ctx.SaveChanges();
        }

        public void inactivar(int id, string motivo, string usuario)
        {
            var puesto = consultarPorID(id);
            if (puesto != null)
            {
                puesto.Inactivar(motivo, usuario);
                _context.SaveChanges();
            }
        }

        public void reactivar(int id, string usuario)
        {
            var puesto = consultarPorID(id);
            if (puesto != null)
            {
                puesto.Reactivar(usuario);
                _context.SaveChanges();
            }
        }

        public clsPuestos consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsPuestos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
    }
}

   
