// Ejemplo hipotético de CategoriaActivosDAO.cs (DAO)
using DAO.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class CategoriaActivosDAO : ICategoriaActivosDAO
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
            var categoria = _context.CategoriasActivos.Find(id);
            if (categoria != null)
            {
                _context.CategoriasActivos.Remove(categoria);
                _context.SaveChanges();
            }
        }

        public clsCategoriaActivos ConsultarPorID(int id)
        {
            return _context.CategoriasActivos.Find(id);
        }

        public clsCategoriaActivos ConsultarPorNombre(string nombre)
        {
            return _context.CategoriasActivos.FirstOrDefault(c => c.nombre == nombre);
        }

        public List<clsCategoriaActivos> ConsultarTodos()
        {
          
            try
            {
                return _context.CategoriasActivos.ToList() ?? new List<clsCategoriaActivos>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en ConsultarTodos: {ex.Message}");
                return new List<clsCategoriaActivos>();
            }
        }
    }
    
}