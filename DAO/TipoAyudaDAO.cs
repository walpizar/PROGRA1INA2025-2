using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    // Clase de acceso a datos para la entidad clsTiposAyudas
    public class TipoAyudaDAO: IGenerica<clsTiposAyudas>
    {
        private readonly dbContextINA _context;

        public TipoAyudaDAO()
        {
            _context = new dbContextINA();
        }

        // Crear un nuevo tipo de ayuda
        public void crear(clsTiposAyudas tiposAyuda)
        {
            // Añadimos el nuevo tipo de ayuda al contexto y guardamos los cambios
            _context.tiposAyudas.Add(tiposAyuda);
            _context.SaveChanges();
        }

        // Consultar por ID
        public clsTiposAyudas consultarPorID(int id)
        {
            //Retornamos el tipo de ayuda que coincida con el ID proporcionado
            return _context.tiposAyudas
                           .AsNoTracking()
                           .FirstOrDefault(t => t.id_tipoAyuda == id);
        }

        // Consultar por nombre
        public clsTiposAyudas consultarPorNombre(string nombre)
        {
            //Retornamos el nombre del tipo de ayuda que coincida con el nombre proporcionado
            return _context.tiposAyudas
                           .AsNoTracking()
                           .FirstOrDefault(t => t.nombre == nombre);
        }

        // Consultar todos
        public List<clsTiposAyudas> consultarTodos()
        {
            // Retornamos todos los tipos de ayudas en una lista
            return _context.tiposAyudas
                           .AsNoTracking()
                           .ToList();
        }

        // Modificar un tipo de ayuda existente
        public void modificar(clsTiposAyudas tiposAyuda)
        {
            // Buscar el tipo de ayuda primero para evitar un error de referencia nula
            var existente = _context.tiposAyudas
                                    .FirstOrDefault(t => t.id_tipoAyuda == tiposAyuda.id_tipoAyuda);


            // Si se encuentra, actualizar sus valores
            if (existente != null)
            {
                _context.Entry(existente).CurrentValues.SetValues(tiposAyuda);
                _context.SaveChanges();
            }
        }

        // Eliminar por ID
        public void eliminar(int id)
        {
            // Buscar el tipo de ayuda primero para evitar un error de referencia nula
            var existente = _context.tiposAyudas
                                    .FirstOrDefault(t => t.id_tipoAyuda == id);

            // Si se encuentra, eliminarlo
            if (existente != null)
            {
                _context.tiposAyudas.Remove(existente);
                _context.SaveChanges();
            }
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsTiposAyudas consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
    }
}



