using Common.Interfaces;
using Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAO
{
    public class PersonalAdministrativoDAO: IGenerica<clsPersonalAdministrativo>
    {
        private dbContextINA _context = new dbContextINA();

        public PersonalAdministrativoDAO()
        {
            _context = new dbContextINA();

        }  
        
        public void crear(clsPersonalAdministrativo administrativo)
        {
            try
            {
                _context.personalAdministrativo.Add(administrativo);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al agregar el personal administrativo: " + ex.Message);
            }

        }

        public void modificar(clsPersonalAdministrativo administrativo)
        {
            try
            {
                var existingAdmin = _context.personalAdministrativo
                    .FirstOrDefault(a => a.personaId == administrativo.personaId && a.personaTipoId == administrativo.personaTipoId);
                if (existingAdmin == null)
                    throw new Exception("El personal administrativo no existe.");
                existingAdmin.puestoId = administrativo.puestoId;
                existingAdmin.descripcion = administrativo.descripcion;
                existingAdmin.modificadoPor = administrativo.modificadoPor;
                existingAdmin.fechaModificacion = DateTime.Now;

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el personal administrativo: " + ex.Message);
            }
        }

        public void eliminar(string personaId)
        {
            try
            {
              var admin = consultarPorID(personaId);
              if (admin == null)
                    throw new Exception("El personal administrativo no existe.");
                _context.personalAdministrativo.Remove(admin);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el personal administrativo: " + ex.Message);
            }
        }

        public clsPersonalAdministrativo consultarPorID(string personaId)
        {
            try
            {

                return _context.personalAdministrativo
                     .Include(a => a.persona)
                     .Include(a => a.Puesto)
                     .FirstOrDefault(a => a.personaId == personaId);

            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el personal administrativo: " + ex.Message);
            }
        }

        public List<clsPersonalAdministrativo> consultarTodos()
        {
            try
            {
                return _context.personalAdministrativo
                        .Include(a => a.persona)
                        .Include(a => a.Puesto)
                        .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los personales administrativos: " + ex.Message);
            }
        }

        public clsPersonalAdministrativo consultarPorNombre(string nombre)
        {
            try { 
                
                return _context.personalAdministrativo.FirstOrDefault(a => a.persona.nombre == nombre);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el personal administrativo por nombre: " + ex.Message);
            }
        }

        public void modificarPersonaYPersonal(clsPersonalAdministrativo admin)
        {
            using (var db = new dbContextINA())
            {
                var existente = db.personalAdministrativo
                                  .Include(a => a.persona)
                                  .FirstOrDefault(a => a.personaId == admin.personaId
                                                    && a.personaTipoId == admin.personaTipoId);

                if (existente != null)
                {
                    // Actualizar persona
                    existente.persona.nombre = admin.persona.nombre;
                    existente.persona.apellido1 = admin.persona.apellido1;
                    existente.persona.apellido2 = admin.persona.apellido2;
                    existente.persona.direccion = admin.persona.direccion;
                    existente.persona.telefono = admin.persona.telefono;
                    existente.persona.email = admin.persona.email;
                    existente.persona.fechaNac = admin.persona.fechaNac;
                    existente.persona.estado = true; // Asegurar que la persona esté activa

                    // Actualizar admin
                    existente.puestoId = admin.puestoId;
                    existente.descripcion = admin.descripcion;
                    existente.modificadoPor = admin.modificadoPor;
                    existente.fechaModificacion = admin.fechaModificacion;

                    db.SaveChanges();
                }
            }
        }

    }
}
