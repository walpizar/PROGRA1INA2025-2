using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;

namespace Services
{
    public class EspecialidadService : IGenerica<clsEspecialidadMedica>
    {
        private readonly EspecialidadDao _especialidadDao = new EspecialidadDao(); // DAO de especialidad médica

        // Constructor
        public EspecialidadService() { }

        
        public void crear(clsEspecialidadMedica especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.nombreEspecialidad))
            {
                throw new Exception("El nombre de la especialidad no puede estar vacío");
            }

            if (_especialidadDao.consultarPorID(especialidad.idEspecialidadMedica) != null)
            {
                throw new EntityExistDBException();//"Ya existe una especialidad con ese ID");
            }

            if (_especialidadDao.consultarPorNombre(especialidad.nombreEspecialidad) != null)
            {
                throw new Exception("Ya existe una especialidad con ese nombre");
            }

            _especialidadDao.crear(especialidad);// Crear la especialidad
        }

        public void modificar(clsEspecialidadMedica especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.nombreEspecialidad))
            {
                throw new Exception("El nombre de la especialidad no puede estar vacío");
            }

            _especialidadDao.modificar(especialidad);
        }

        public void eliminar(int id)
        {
            if (_especialidadDao.consultarPorID(id) == null)
            {
                throw new Exception("La especialidad no existe");
            }
            _especialidadDao.eliminar(id);
        }

        public clsEspecialidadMedica consultarPorID(int id)
        {
            return _especialidadDao.consultarPorID(id);
        }

        public List<clsEspecialidadMedica> consultarTodos()
        {
            return _especialidadDao.consultarTodos();
        }

        public clsEspecialidadMedica consultarPorNombre(string nombre)
        {
            return _especialidadDao.consultarPorNombre(nombre);
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsEspecialidadMedica consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
