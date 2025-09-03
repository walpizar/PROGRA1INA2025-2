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
    public class MedicoDAO : IGenerica<clsMedico>
    {
        private dbContextINA _context;
        public MedicoDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsMedico medico)
        {
            try
            {
                // Primero creamos la persona
                var varpersona = new clsPersona
                {
                    id = medico.id,
                    tipoId = medico.tipoId,
                    nombre = medico.persona.nombre,
                    apellido1 = medico.persona.apellido1,
                    fechaNac = medico.persona.fechaNac,
                    email = medico.persona.email,
                    direccion = medico.persona.direccion,
                    telefono = medico.persona.telefono,
                    estado = medico.persona.estado
                };

                _context.Personas.Add(varpersona);
                _context.SaveChanges(); //Guarda y genera el ID

                // Luego creamos el médico relacionado con llave compuesta de persona
                var varmedico = new clsMedico
                {
                    id = medico.id,
                    tipoId = medico.tipoId,
                    especialidad = medico.especialidad,
                };

                _context.Medicos.Add(medico);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log del error
                throw new Exception("Error al crear médico: " + ex.Message);
            }

        }

        public void eliminar(string id, int tipoId)
        {
            try
            {
                // Primero se elimina el médico
                var medico = _context.Medicos.Find(id,tipoId);
                if (medico != null)
                {
                    _context.Medicos.Remove(medico);
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
                throw new Exception("Error al eliminar médico: " + ex.Message);
            }
        }

        public void modificar(clsMedico entidad)
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

                // Buscar el médico existente
                var medico = _context.Medicos.Find(entidad.idPersona);
                if (medico != null)
                {
                    // Actualizar datos de médico
                    medico.especialidad = entidad.especialidad;

                    _context.Entry(medico).State = EntityState.Modified;
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar médico: " + ex.Message);
            }
        }

        public clsMedico consultarPorID(string id, int tipoId)
        {
            return _context.Medicos.Include(m => m.persona).FirstOrDefault(m => m.id == id && m.tipoId == tipoId);
        }

        public clsMedico consultarPorNombre(string nombre)
        {
            return _context.Medicos.Include(m => m.persona).FirstOrDefault(m => m.persona.nombre.Contains(nombre));
        }

        public List<clsMedico> consultarTodos()
        {
            return _context.Medicos.Include(m => m.persona).ToList();
        }
    }
}
