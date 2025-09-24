
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
    public class DepartamentosDao : IGenerica<clsDepartamentos>
    {
        private dbContextINA _context;
        public DepartamentosDao()
        {
            _context = new dbContextINA();
        }


        public clsDepartamentos consultarPorID(int id)
        {
            using var ctx = new dbContextINA();
            return ctx.departamentos
                      .AsNoTracking()
                      .SingleOrDefault(d => d.idDepartamento == id);
        }

        public clsDepartamentos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsDepartamentos consultarPorNombre(string nombre)
        {
            return _context.departamentos
                          .Where(d => d.Nombre.Trim().ToUpper() == nombre.Trim().ToUpper())
                          .SingleOrDefault();
        }

        public List<clsDepartamentos> consultarTodos()
        {
            using var ctx = new dbContextINA();
            return ctx.departamentos
                      .AsNoTracking()
                      .ToList();
        }

        public void crear(clsDepartamentos d)
        {
            using var ctx = new dbContextINA();
            ctx.departamentos.Add(d);
            ctx.SaveChanges();
        }

        public void eliminar(int id)
        {
            using var ctx = new dbContextINA();
            var dep = ctx.departamentos.Find(id);
            if (dep == null) return;
            ctx.departamentos.Remove(dep);
            ctx.SaveChanges();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsDepartamentos d)
        {
            using var ctx = new dbContextINA();
            ctx.departamentos.Update(d);
            ctx.SaveChanges();
        }
    }
}