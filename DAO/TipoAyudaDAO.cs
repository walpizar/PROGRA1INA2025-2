using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    // Clase de acceso a datos para la entidad clsTiposAyudas
    public class TipoAyudaDAO
    {
        private readonly dbContextINA _context;

        public TipoAyudaDAO()
        {
            _context = new dbContextINA();
        }

        // Crear un nuevo tipo de ayuda
        public void Crear(clsTiposAyudas tiposAyuda)
        {
            _context.tiposAyudas.Add(tiposAyuda);
            _context.SaveChanges();
        }

        // Consultar por ID
        public clsTiposAyudas ConsultarPorID(int id)
        {
            return _context.tiposAyudas
                           .AsNoTracking()
                           .FirstOrDefault(t => t.id_tipoAyuda == id);
        }

        // Consultar por nombre
        public clsTiposAyudas ConsultarPorNombre(string nombre)
        {
            return _context.tiposAyudas
                           .AsNoTracking()
                           .FirstOrDefault(t => t.nombre == nombre);
        }

        // Consultar todos
        public List<clsTiposAyudas> ConsultarTodos()
        {
            return _context.tiposAyudas
                           .AsNoTracking()
                           .ToList();
        }

        // Modificar un tipo de ayuda existente
        public void Modificar(clsTiposAyudas tiposAyuda)
        {
            var existente = _context.tiposAyudas
                                    .FirstOrDefault(t => t.id_tipoAyuda == tiposAyuda.id_tipoAyuda);

            if (existente != null)
            {
                _context.Entry(existente).CurrentValues.SetValues(tiposAyuda);
                _context.SaveChanges();
            }
        }

        // Eliminar por ID
        public void Eliminar(int id)
        {
            var existente = _context.tiposAyudas
                                    .FirstOrDefault(t => t.id_tipoAyuda == id);

            if (existente != null)
            {
                _context.tiposAyudas.Remove(existente);
                _context.SaveChanges();
            }
        }
    }
}



