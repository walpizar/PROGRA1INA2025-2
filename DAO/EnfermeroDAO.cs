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
                    estado = true, // Asumimos que una nueva persona está activa
                };

                _context.persona.Add(varpersona);
                _context.SaveChanges(); //Guarda y genera el ID

                // Luego creamos al enfermero relacionado con llave compuesta de persona
                var varenfermero = new clsEnfermero
                {
                    id = enfermero.id,
                    tipoId = varpersona.tipoId,
                    area = enfermero.area,
                    estado = true, // Asumimos que un nuevo enfermero está activo

                    //Datos de auditoria
                    usuario_crea = enfermero.usuario_crea ?? ObtenerUsuarioActual(),
                    fecha_crea = DateTime.Now,
                    usuario_ult_mod = enfermero.usuario_ult_mod ?? ObtenerUsuarioActual(),
                    fecha_ult_mod = DateTime.Now
                };

                _context.enfermero.Add(varenfermero);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear al enfermero: " + ex.Message);
            }

        }

        private string ObtenerUsuarioActual()
        {
            return Environment.UserName;
        }

        public void eliminar(string id, int tipoId)
        {
            try
            {
                var enfermero = _context.medico
                .Include(e => e.persona)
                .FirstOrDefault(e => e.id == id && e.tipoId == tipoId);

                if (enfermero != null)
                {
                    //BORRADO LÓGICO
                    enfermero.estado = false;
                    enfermero.fecha_ult_mod = DateTime.Now;
                    enfermero.usuario_ult_mod = ObtenerUsuarioActual();

                    if (enfermero.persona != null)
                    {
                        enfermero.persona.estado = false;
                    }

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
                // Convertir idPersona a string
                string idPersonaString = entidad.idPersona.ToString();
                // Buscar la persona existente
                var persona = _context.persona.Find(idPersonaString,entidad.tipoId);
                if (persona != null)
                {
                    // Actualizar datos de persona
                    persona.nombre = entidad.persona.nombre;
                    persona.apellido1 = entidad.persona.apellido1;
                    persona.apellido2 = entidad.persona.apellido2;
                    persona.fechaNac = entidad.persona.fechaNac;
                    persona.email = entidad.persona.email;
                    persona.telefono = entidad.persona.telefono;
                    persona.direccion = entidad.persona.direccion;

                    _context.persona.Update(persona);
                }

                // Buscar el enfermero existente
                var enfermero = _context.enfermero.Find(idPersonaString, entidad.tipoId);
                if (enfermero != null)
                {
                    // Actualizar datos del enfermero
                    enfermero.area = entidad.area;

                    //Actualizar datos de auditoria
                    enfermero.usuario_crea = entidad.usuario_crea;
                    enfermero.fecha_crea = entidad.fecha_crea;
                    enfermero.usuario_ult_mod = entidad.usuario_ult_mod;
                    enfermero.fecha_ult_mod = DateTime.Now;

                    _context.enfermero.Update(enfermero);
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
            return _context.enfermero
            .Include(e => e.persona)
            .Where(e => e.id == id && e.tipoId == tipoId)
            .Where(e => e.estado == true && e.persona.estado == true)
            .FirstOrDefault();
        }

        public clsEnfermero consultarPorNombre(string nombre)
        {
            return _context.enfermero
                .Include(e => e.persona)
                .FirstOrDefault(e => e.persona.nombre
                .Contains(nombre));
        }

        public List<clsEnfermero> consultarTodos()
        {
            return _context.enfermero
                .Include(e => e.persona)
                .Where(e => e.estado == true)
                .Where(e => e.persona.estado == true)
                .ToList();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsEnfermero consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsEnfermero consultarPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
