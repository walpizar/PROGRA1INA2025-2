using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using DAO;  
using Entities;

namespace Services
{
    
    // Este servicio lo uso para manejar toda la lógica de negocio del personal administrativo.
    // Me aseguro de validar que existan las personas y los puestos antes de crear o modificar registros.
    // También manejo la creación, modificación y eliminación lógica de los administrativos.

    public class PersonalAdministrativoService : IGenerica<clsPersonalAdministrativo>
    {
        // Uso estos DAOs para interactuar con la base de datos
        private readonly PersonalAdministrativoDAO _AdminDao = new PersonalAdministrativoDAO();
        private readonly PuestosDao _puestoDao = new PuestosDao();
        private readonly DepartamentosService _depService = new DepartamentosService();

        // Cuando quiero traer un administrativo por su ID
        public clsPersonalAdministrativo consultarPorID(string id)
        {
            return _AdminDao.consultarPorID(id);
        }

        // Traigo todos los administrativos activos
        public List<clsPersonalAdministrativo> consultarTodos()
        {
            return _AdminDao.consultarTodos();
        }

        // Creo un administrativo después de validar persona, puesto y que no exista ya
        public void crear(clsPersonalAdministrativo personal)
        {
            try
            {
                // Validar que la persona exista
                var persona = consultarPorID(personal.personaId);
                if (persona == null)
                    throw new Exception("La persona con ID " + personal.personaId + " y tipo " + personal.personaTipoId + " no existe.");
                // Validar que el puesto exista
                var puesto = _puestoDao.consultarPorID(personal.puestoId);
                if (puesto == null)
                    throw new Exception("El puesto con ID " + personal.puestoId + " no existe.");
                // Validar que no exista ya un personal administrativo con la misma personaId y personaTipoId
                var existingAdmin = _AdminDao.consultarTodos()
                                        .Any(a => a.personaId == personal.personaId && a.personaTipoId == personal.personaTipoId);
                if (existingAdmin)
                    throw new Exception("Ya existe un personal administrativo con esa persona.");

                if ((DateTime.Today.Year - personal.persona.fechaNac.Year) < 18 || personal.persona.fechaNac > DateTime.Today.AddYears(-18))
                {
                    throw new Exception("La persona debe ser mayor de 18 años.");
                    
                }
                // Asignar fecha de creación
                personal.fechaCreacion = DateTime.Now;
                _AdminDao.crear(personal);
            }
            catch
            {
                throw new Exception("Error al crear el personal administrativo.");
            }
        }

        // Modifico un administrativo verificando que persona y puesto existan
        public void modificar(clsPersonalAdministrativo p)
        {
            // Validar que la persona exista
            var persona = consultarPorID(p.personaId);
            if (persona == null)
                throw new Exception("La persona con ID " + p.personaId + " y tipo " + p.personaTipoId + " no existe.");
            // Validar que el puesto exista
            var puesto = _puestoDao.consultarPorID(p.puestoId);
            if (puesto == null)
            {
                                throw new Exception("El puesto con ID " + p.puestoId + " no existe.");
            }

        }

        // Elimino un administrativo usando el DAO y capturo errores
        public void eliminar (string id)
        {
           
            try {
                _AdminDao.eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el personal administrativo: " + ex.Message);
            }
        }

        
        public clsPersonalAdministrativo consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        // Modifico tanto los datos de la persona como del administrativo
        public void modificarPersonaYPersonal(clsPersonalAdministrativo admin)
        {
            _AdminDao.modificarPersonaYPersonal(admin);
        }

       


    }
}
