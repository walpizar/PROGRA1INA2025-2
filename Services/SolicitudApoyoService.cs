using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;

namespace Services
{
    public class SolicitudApoyoService : IGenerica<clsSolicitudApoyo>
    {
        private readonly SolicitudApoyoDao _solicitudDao = new SolicitudApoyoDao(); // DAO de solicitud de apoyo

        // Constructor
        public SolicitudApoyoService() { }

        // Crear nueva solicitud
        public void crear(clsSolicitudApoyo solicitud)
        {
            if (string.IsNullOrWhiteSpace(solicitud.justificacion))
                throw new Exception("La justificación de la ayuda no puede estar vacía.");

            if (string.IsNullOrWhiteSpace(solicitud.equiposNecesarios))
                throw new Exception("Debe especificar los equipos que necesita el paciente.");

            if (_solicitudDao.consultarPorID(solicitud.idSolicitud) != null)
                throw new EntityExistDBException(); // Ya existe una solicitud con ese ID

            _solicitudDao.crear(solicitud); // Crear la solicitud
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
        public void eliminar(int id)
        {
            if (_solicitudDao.consultarPorID(id) == null)
                throw new Exception("La solicitud no existe.");

            _solicitudDao.eliminar(id);
        }

        // Consultar por ID
        public clsSolicitudApoyo consultarPorID(int id)
        {
            return _solicitudDao.consultarPorID(id);
        }

        // Consultar todas las solicitudes
        public List<clsSolicitudApoyo> consultarTodos()
        {
            return _solicitudDao.consultarTodos();
        }

        // Consultar solicitudes por paciente
        public List<clsSolicitudApoyo> consultarPorPaciente(int idPaciente)
        {
            return _solicitudDao.consultarPorPaciente(idPaciente);
        }

        // Consultar solicitudes por estado
        public List<clsSolicitudApoyo> consultarPorEstado(string estado)
        {
            return _solicitudDao.consultarPorEstado(estado);
        }

        // Métodos de la interfaz que no aplican
        public clsSolicitudApoyo consultarPorNombre(string nombre)
        {
            throw new NotImplementedException("No aplica consultar por nombre en Solicitud de Apoyo.");
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsSolicitudApoyo consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
