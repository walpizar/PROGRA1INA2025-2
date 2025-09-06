using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class TipoAyudaDAO
    {
        // Cambia la declaración del campo _context de:
        // private readonly dbPaleativoGarabito _context;
        // a:
        private readonly dbContextINA _context;

        // Constructor - recibe el contexto por inyección de dependencias
        public TipoAyudaDAO(dbContextINA context)
        {
            _context = context;
        }

        // Crear un nuevo tipo de ayuda para el catálogo
        public void Crear(clsTiposAyudas tiposAyuda)
        {
            _context.TiposAyudas.Add(tiposAyuda); // Agrega el objeto al contexto
            _context.SaveChanges(); // Guarda los cambios en la BD
        }

        // Retorna un tipo de ayuda según su ID, o null si no existe
        public clsTiposAyudas ConsultarPorID(int id)
        {
            //Uso de AsNoTracking para consultar mas rapido y FistOrDefault para que devuel el primer elemento que cumpla con las condiciones
            return _context.TiposAyudas.AsNoTracking().FirstOrDefault(t => t.id_tipoAyuda == id);
        }

        // Retorna un tipo de ayuda según su nombre, o null si no existe
        public clsTiposAyudas ConsultarPorNombre(string nombre)
        {
            //Uso de AsNoTracking para consultar mas rapido
            return _context.TiposAyudas.AsNoTracking().FirstOrDefault(t => t.nombre == nombre);
        }


        // Retorna todos los tipos de ayuda registrados en la BD
        public List<clsTiposAyudas> ConsultarTodos()
        {
            //Uso de AsNoTracking para consultar mas rapido
            return _context.TiposAyudas.AsNoTracking().ToList();
        }


        // Modifica un tipo de ayuda existente en la BD
        public void Modificar(clsTiposAyudas tiposAyuda)
        {
            _context.TiposAyudas.Update(tiposAyuda); // Marca el objeto como modificado
            _context.SaveChanges(); // Guarda los cambios en la BD
        }


        // Elimina un tipo de ayuda según su ID
        public void Eliminar(int id)
        {
            //Uso del FirstOrDefault para que devuelva solo el primer elemento que encuentre que cumpla con la condición
            var tip = _context.TiposAyudas.FirstOrDefault(t => t.id_tipoAyuda == id);

            if (tip != null) // Si existe, se elimina
            {
                _context.TiposAyudas.Remove(tip);
                _context.SaveChanges();
            }
        }
        
    }
}

