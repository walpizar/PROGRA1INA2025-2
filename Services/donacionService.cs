using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class DonacionService : IGenerica<clsDonacion>
    {
        private readonly donacionDAO donacionDAO;

        public DonacionService()
        {
            donacionDAO = new donacionDAO();
        }

        // Consultar por ID (string)
        public clsDonacion consultarPorID(string id)
        {
            return donacionDAO.consultarPorID(id);
        }

        // Consultar por ID (int) no implementado
        public clsDonacion consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        // Consultar por nombre no implementado
        public clsDonacion consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        // Consultar todos
        public List<clsDonacion> consultarTodos()
        {
            return donacionDAO.consultarTodos();
        }

        // Crear donación
        public void crear(clsDonacion entidad)
        {
            // Validar que no exista
            var donacionExistente = donacionDAO.consultarPorID(entidad.idDonacion.ToString());
            if (donacionExistente != null)
            {
                throw new EntityExistDBException("LA DONACION YA EXISTE EN LA BASE DE DATOS, " +
                    " PARA MODIFICAR DATOS USE EL MODULO APROPIADO");
            }

            // Validar campos obligatorios
            if (string.IsNullOrEmpty(entidad.donanteId) || entidad.donanteTipoId == 0)
            {
                throw new ArgumentException("Los campos donanteId y donanteTipoId son obligatorios.");
            }

            if (entidad.fechaDonacion == default)
            {
                throw new ArgumentException("La fecha de donación es obligatoria.");
            }

            if (string.IsNullOrEmpty(entidad.usuarioCreacion))
            {
                entidad.usuarioCreacion = "SYSTEM"; // Usuario por defecto
            }

            entidad.fechaCreacion = DateTime.Now;

            // Auditoría
            entidad.fechaModificacion = entidad.fechaCreacion;
            entidad.usuarioModificacion = entidad.usuarioCreacion;

            // Guardar en la base de datos
            donacionDAO.crear(entidad);
        }

        // Eliminar por ID
        public void eliminar(string id)
        {
            var donacionExistente = donacionDAO.consultarPorID(id);
            if (donacionExistente == null)
            {
                throw new EntityNotFoundDBException("LA DONACION NO EXISTE EN LA BASE DE DATOS, " +
                    " NO SE PUEDE ELIMINAR");
            }

            donacionDAO.eliminar(id);
        }

        // Eliminar por int no implementado
        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        // Modificar donación
        public void modificar(clsDonacion entidad)
        {
            var donacionExistente = donacionDAO.consultarPorID(entidad.idDonacion.ToString());
            if (donacionExistente == null)
            {
                throw new EntityNotFoundDBException("LA DONACION NO EXISTE EN LA BASE DE DATOS, " +
                    " NO SE PUEDE MODIFICAR");
            }

            // Auditoría
            entidad.fechaModificacion = DateTime.Now;
            entidad.usuarioModificacion = "SYSTEM"; // Reemplazar por usuario actual
            entidad.razonModifica = "MODIFICACION DE DATOS";

            donacionDAO.modificar(entidad);
        }
    }
}
