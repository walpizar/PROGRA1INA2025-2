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
    public class PersonalAdministrativoService : IGenerica<clsPersonalAdministrativo>
    {

        private readonly PersonalAdministrativoDAO _AdminDao = new PersonalAdministrativoDAO();
        private readonly PuestosDao _puestoDao = new PuestosDao();
        private readonly DepartamentosService _depService = new DepartamentosService();

        public clsPersonalAdministrativo consultarPorID(string id)
        {
            return _AdminDao.consultarPorID(id);
        }
        public List<clsPersonalAdministrativo> consultarTodos()
        {
            return _AdminDao.consultarTodos();
        }
        public void crear(clsPersonalAdministrativo personal)
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
            // Validar campos obligatorios
            if (string.IsNullOrWhiteSpace(personal.creadoPor))
                throw new Exception("El campo 'creadoPor' es obligatorio.");
            // Asignar fecha de creación
            personal.fechaCreacion = DateTime.Now;
            _AdminDao.crear(personal);
        }
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

       


    }
}
