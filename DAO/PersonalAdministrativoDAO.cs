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
    // Este DAO lo uso para manejar directamente la base de datos de personal administrativo.
    // Me encargo de crear, modificar, eliminar (lógico), y consultar los administrativos.
    // Siempre trato de capturar errores y lanzarlos de manera clara.
    public class PersonalAdministrativoDAO: IGenerica<clsPersonalAdministrativo>
    {
        // Uso mi contexto para interactuar con la DB
        private dbContextINA _context = new dbContextINA();


        public PersonalAdministrativoDAO()
        {
            _context = new dbContextINA();

        }

        // Aquí agrego un administrativo a la base de datos
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

        // Modifico un administrativo existente
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

        // Elimino un administrativo de forma lógica
        public void eliminar(string personaId)
        {
            try
            {
              var admin = consultarPorID(personaId);
              if (admin == null)
                    throw new Exception("El personal administrativo no existe.");
                if (admin != null)
                {
                    admin.estado = false; // solo desactiva
                    admin.fechaModificacion = DateTime.Now;
                    admin.modificadoPor = "admin"; // o el usuario actual
                    _context.Update(admin);
                    _context.SaveChanges();

                }
              
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el personal administrativo: " + ex.Message);
            }
        }

        // Traigo un administrativo por su ID
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

        // Traigo todos los administrativos activos
        public List<clsPersonalAdministrativo> consultarTodos()
        {
            try
            {
                return _context.personalAdministrativo
                        .Include(a => a.persona)
                        .Include(a => a.Puesto)
                        .Where(a => a.estado == true) // solo activos
                        .AsNoTracking()
                        .ToList();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los personales administrativos: " + ex.Message);
            }
        }

        // Traigo un administrativo por nombre
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


        // Actualizo tanto los datos de la persona como del administrativo
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
