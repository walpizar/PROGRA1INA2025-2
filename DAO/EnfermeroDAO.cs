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
    public class EnfermeroDAO : IGenerica<clsEnfermero>
    {
        private dbContextINA _context;
        public EnfermeroDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsEnfermero enfermero)
        {
            try
            {
                // Primero creamos la persona
                var varpersona = new clsPersona
                {
                    id = enfermero.id,
                    tipoId = enfermero.tipoId,
                    nombre = enfermero.persona.nombre,
                    apellido1 = enfermero.persona.apellido1,
                    apellido2 = enfermero.persona.apellido2,
                    fechaNac = enfermero.persona.fechaNac,
                    email = enfermero.persona.email,
                    direccion = enfermero.persona.direccion,
                    telefono = enfermero.persona.telefono,
                    estado = enfermero.persona.estado
                };

                _context.Personas.Add(varpersona);
                _context.SaveChanges(); //Guarda y genera el ID

                // Luego creamos al enfermero relacionado con llave compuesta de persona
                var varenfermero = new clsEnfermero
                {
                    id = enfermero.id,
                    tipoId = enfermero.tipoId,
                    area = enfermero.area,
                };

                _context.Enfermeros.Add(enfermero);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear al enfermero: " + ex.Message);
            }

        }

        public void eliminar(string id, int tipoId)
        {
            try
            {
                // Primero se elimina el enfermero
                var enfermero = _context.Enfermeros.Find(id, tipoId);
                if (enfermero != null)
                {
                    _context.Enfermeros.Remove(enfermero);
                    _context.SaveChanges();
                }

                //Despues se elimina la persona
                var persona = _context.Personas.Find(id, tipoId);
                if (persona != null)
                {
                    _context.Personas.Remove(persona);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar al enfermero: " + ex.Message);
            }
        }

        public void modificar(clsEnfermero entidad)
        {
            try
            {
                // Buscar la persona existente
                var persona = _context.Personas.Find(entidad.idPersona);
                if (persona != null)
                {
                    // Actualizar datos de persona
                    persona.nombre = entidad.persona.nombre;
                    persona.apellido1 = entidad.persona.apellido1;
                    persona.apellido2 = entidad.persona.apellido2;
                    persona.fechaNac = entidad.persona.fechaNac;
                    persona.telefono = entidad.persona.telefono;

                    _context.Entry(persona).State = EntityState.Modified;
                }

                // Buscar el enfermero existente
                var enfermero = _context.Enfermeros.Find(entidad.idPersona);
                if (enfermero != null)
                {
                    // Actualizar datos del enfermero
                    enfermero.area = entidad.area;

                    _context.Entry(enfermero).State = EntityState.Modified;
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar al enfermero: " + ex.Message);
            }
        }

        public clsEnfermero consultarPorID(string id, int tipoId)
        {
            return _context.Enfermeros.Include(m => m.persona).FirstOrDefault(m => m.id == id && m.tipoId == tipoId);
        }

        public clsEnfermero consultarPorNombre(string nombre)
        {
            return _context.Enfermeros.Include(m => m.persona).FirstOrDefault(m => m.persona.nombre.Contains(nombre));
        }

        public List<clsEnfermero> consultarTodos()
        {
            return _context.Enfermeros.Include(m => m.persona).ToList();
        }
    }
}
