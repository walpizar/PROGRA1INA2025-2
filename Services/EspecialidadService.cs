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
        private readonly EspecialidadDao _especialidadDao = new EspecialidadDao();

        public EspecialidadService() { }

        public void crear(clsEspecialidadMedica especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.nombre))
            {
                throw new Exception("El nombre de la especialidad no puede estar vacío");
            }

            if (_especialidadDao.consultarPorID(especialidad.id) != null)
            {
                throw new EntityExistDBException();
            }

            if (_especialidadDao.consultarPorNombre(especialidad.nombre) != null)
            {
                throw new Exception("Ya existe una especialidad con ese nombre");
            }

            _especialidadDao.crear(especialidad);
        }

        public void modificar(clsEspecialidadMedica especialidad)
        {
            if (string.IsNullOrWhiteSpace(especialidad.nombre))
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

        public void eliminar(string id, int tipoId)
        {
            throw new NotImplementedException();
        }

        public clsEspecialidadMedica consultarPorID(string id, int tipoId)
        {
            throw new NotImplementedException();
        }
    }
}
