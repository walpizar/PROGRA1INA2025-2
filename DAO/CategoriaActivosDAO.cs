using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using DAO.Interfaces;

namespace DAO
{
    internal class CategoriaActivosDAO : ICategoriaActivosDAO
    {
        private readonly dbContextINA _context;

        public CategoriaActivosDAO(dbContextINA context)
        {
            _context = context;
        }

        public void Add(clsCategoriaActivos categoria)
        {
            _context.CategoriasActivos.Add(categoria);
            _context.SaveChanges();
        }

        public void Update(clsCategoriaActivos categoria)
        {
            _context.CategoriasActivos.Update(categoria);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var cat = _context.CategoriasActivos.Find(id);
            if (cat != null)
            {
                _context.CategoriasActivos.Remove(cat);
                _context.SaveChanges();
            }
        }

        public clsCategoriaActivos ConsultarPorID(int id, bool incluirActivos = false)
        {
            if (incluirActivos)
                return _context.CategoriasActivos.Include(c => c.Activos).FirstOrDefault(c => c.Id == id);

            return _context.CategoriasActivos.FirstOrDefault(c => c.Id == id);
        }

        public List<clsCategoriaActivos> ConsultarTodos(bool incluirActivos = false)
        {
            if (incluirActivos)
                return _context.CategoriasActivos.Include(c => c.Activos).OrderBy(c => c.nombre).ToList();

            return _context.CategoriasActivos.OrderBy(c => c.nombre).ToList();
        }

        public clsCategoriaActivos ConsultarPorNombre(string nombre)
        {
            return _context.CategoriasActivos.FirstOrDefault(c => c.nombre.Equals(nombre));
        }
    }
}
