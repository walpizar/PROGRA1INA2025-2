using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    //Clase de acceso a datos para la entidad clsTiposAyudas
    public class TipoAyudaDAO
    {
        // Contexto de la base de datos
        private readonly dbContextINA _context;

        // Constructor - recibe el contexto por inyección de dependencias
        public TipoAyudaDAO()
        {
            _context =new dbContextINA(); // Inicializa el contexto
        }

        // Crear un nuevo tipo de ayuda para el catálogo
        public void Crear(clsTiposAyudas tiposAyuda)
        {
            _context.tiposAyudas.Add(tiposAyuda); // Agrega el objeto al contexto
            _context.SaveChanges(); // Guarda los cambios en la BD
        }

        // Retorna un tipo de ayuda según su ID, o null si no existe
        public clsTiposAyudas ConsultarPorID(int id)
        {
            //Uso de AsNoTracking para consultar mas rapido y FistOrDefault para que devuel el primer elemento que cumpla con las condiciones
            return _context.tiposAyudas.AsNoTracking().FirstOrDefault(t => t.id_tipoAyuda == id);
        }

        // Retorna un tipo de ayuda según su nombre, o null si no existe
        public clsTiposAyudas ConsultarPorNombre(string nombre)
        {
            //Uso de AsNoTracking para consultar mas rapido
            return _context.tiposAyudas.AsNoTracking().FirstOrDefault(t => t.nombre == nombre);
        }


        // Retorna todos los tipos de ayuda registrados en la BD
        public List<clsTiposAyudas> ConsultarTodos()
        {
            //Uso de AsNoTracking para consultar mas rapido
            return _context.tiposAyudas.AsNoTracking().ToList();
        }


        // Modifica un tipo de ayuda existente en la BD
        public void Modificar(clsTiposAyudas tiposAyuda)
        {
            _context.tiposAyudas.Update(tiposAyuda); // Marca el objeto como modificado
            _context.SaveChanges(); // Guarda los cambios en la BD
        }


        // Elimina un tipo de ayuda según su ID
        public void Eliminar(int id)
        {
            //Uso del FirstOrDefault para que devuelva solo el primer elemento que encuentre que cumpla con la condición
            var tip = _context.tiposAyudas.FirstOrDefault(t => t.id_tipoAyuda == id);

            if (tip != null) // Si existe, se elimina
            {
                _context.tiposAyudas.Remove(tip);
                _context.SaveChanges();
            }
        }
    }
}


