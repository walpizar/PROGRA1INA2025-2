using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class SolicitudApoyoService : IGenerica<clsSolicitudApoyo>
    {
        private readonly SolicitudApoyoDao _solicitudDao = new SolicitudApoyoDao();

        public SolicitudApoyoService() { }

        // Crear nueva solicitud
        public void crear(clsSolicitudApoyo solicitud)
        {
            if (string.IsNullOrWhiteSpace(solicitud.justificacion))
                throw new Exception("La justificación de la ayuda no puede estar vacía.");

            if (string.IsNullOrWhiteSpace(solicitud.equiposNecesarios))
                throw new Exception("Debe especificar los equipos que necesita el paciente.");

            if (_solicitudDao.consultarPorID(solicitud.idSolicitud) != null)
                throw new EntityExistDBException();

            var solicitudesPaciente = _solicitudDao.consultarPorPaciente(solicitud.idPaciente, solicitud.tipoIdPaciente);
            if (solicitudesPaciente != null && solicitudesPaciente.Count > 0)
                throw new Exception("Este paciente ya tiene una solicitud de apoyo registrada.");

            _solicitudDao.crear(solicitud);
        }

        // Modificar solicitud existente
        public void modificar(clsSolicitudApoyo solicitud)
        {
            if (string.IsNullOrWhiteSpace(solicitud.justificacion))
                throw new Exception("La justificación de la ayuda no puede estar vacía.");

            if (string.IsNullOrWhiteSpace(solicitud.equiposNecesarios))
                throw new Exception("Debe especificar los equipos que necesita el paciente.");

            _solicitudDao.modificar(solicitud);
        }

        // Eliminar solicitud por ID
        public void eliminar(string id)
        {
            // Obtener la solicitud por ID
            var solicitud = _solicitudDao.consultarPorID(id);
            if (solicitud == null)
                throw new Exception("La solicitud no existe.");

            // Cambiar el estado a Rechazada (enum valor 3)
            solicitud.estado = (int)Common.Enums.Enums.EstadoAprobacionSolicitudApoyo.Rechazada;

            // Guardar cambios en la BD
            _solicitudDao.modificar(solicitud);
        }
        // Consultar solicitud por ID
        public clsSolicitudApoyo consultarPorID(string id)
        {
            return _solicitudDao.consultarPorID(id);
        }

        // Consultar todas las solicitudes
        public List<clsSolicitudApoyo> consultarTodos()
        {
            return _solicitudDao.consultarTodos();
        }
        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public clsSolicitudApoyo consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsSolicitudApoyo consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
