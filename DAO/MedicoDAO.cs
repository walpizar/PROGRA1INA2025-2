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
                    apellido2 = medico.persona.apellido2,
                    fechaNac = medico.persona.fechaNac,
                    email = medico.persona.email,
                    direccion = medico.persona.direccion,
                    telefono = medico.persona.telefono,
                    estado = true, // Asumimos que una nueva persona está activa
                };

                _context.persona.Add(varpersona);
                _context.SaveChanges(); //Guarda y genera el ID

                // Luego creamos el médico relacionado con llave compuesta de persona
                var varmedico = new clsMedico
                {
                    id = varpersona.id,
                    tipoId = varpersona.tipoId,
                    especialidad = medico.especialidad,
                    estado = true, // Asumimos que un nuevo médico está activo

                    //Datos de auditoria
                    usuario_crea = medico.usuario_crea ?? ObtenerUsuarioActual(),
                    fecha_crea = DateTime.Now,
                    usuario_ult_mod = medico.usuario_ult_mod ?? ObtenerUsuarioActual(),
                    fecha_ult_mod = DateTime.Now
                };

                _context.medico.Add(varmedico);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                // Log del error
                throw new Exception("Error al crear médico: " + ex.Message);
            }

        }

        private string ObtenerUsuarioActual()
        {
            return Environment.UserName;
        }

        public void eliminar(string id, int tipoId)
        {
            //var donanteAEliminar = consultarPorID(id);
            //if (donanteAEliminar != null)
            //{
            //    donanteAEliminar.estado = false; //marco el estado como inactivo
            //    donanteAEliminar.fechaModificacion = DateTime.Now;
            //    donanteAEliminar.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
            //    dbContextINA.donante.Update(donanteAEliminar);
            //    dbContextINA.SaveChanges();
            //}

            try
            {
                var medico = _context.medico
                .Include(m => m.persona)
                .FirstOrDefault(m => m.id == id && m.tipoId == tipoId);

                if (medico != null)
                {
                    //BORRADO LÓGICO
                    medico.estado = false;
                    medico.fecha_ult_mod = DateTime.Now;
                    medico.usuario_ult_mod = ObtenerUsuarioActual();

                    if (medico.persona != null)
                    {
                        medico.persona.estado = false;
                    }

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

                // Buscar el médico existente
                var medico = _context.medico.Find(idPersonaString,entidad.tipoId);
                if (medico != null)
                {
                    // Actualizar datos de médico
                    medico.especialidad = entidad.especialidad;

                    //Actualizar datos de auditoria
                    medico.usuario_crea = entidad.usuario_crea;
                    medico.fecha_crea = entidad.fecha_crea;
                    medico.usuario_ult_mod = entidad.usuario_ult_mod;
                    medico.fecha_ult_mod = DateTime.Now;

                   _context.medico.Update(medico);

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
            return _context.medico
            .Include(m => m.persona)
            .Where(m => m.id == id && m.tipoId == tipoId)
            .Where(m => m.estado == true && m.persona.estado == true)
            .FirstOrDefault();
        }

        public clsMedico consultarPorNombre(string nombre)
        {
            return _context.medico
                .Include(m => m.persona)
                .FirstOrDefault(m => m.persona.nombre
                .Contains(nombre));
        }

        public List<clsMedico> consultarTodos()
        {
            return _context.medico
            .Include(m => m.persona)
            .Where(m => m.estado == true)
            .Where(m => m.persona.estado == true)
            .ToList();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsMedico consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsMedico consultarPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
