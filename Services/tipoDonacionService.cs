using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;

namespace Services
{
    public class tipoDonacionService : IGenerica<clsTipoDonacion>
    {
        TipoDonacionDAO tipoDonacionDAO;

        public tipoDonacionService()
        {
            tipoDonacionDAO = new TipoDonacionDAO();
        }

        public clsTipoDonacion consultarPorID(string id)
        {
            return tipoDonacionDAO.consultarPorID(id);
        }

        public clsTipoDonacion consultarPorNombre(string nombre)
        {
            //no se implementa porque no es necesario 
            throw new System.NotImplementedException();

        }

        public List<clsTipoDonacion> consultarTodos()
        {
            return tipoDonacionDAO.consultarTodos();
        }

        public void crear(clsTipoDonacion entidad)
        {
            var existente = tipoDonacionDAO.consultarPorID(entidad.idTipoDonacion.ToString());
            if (existente != null)
            {
                throw new EntityExistDBException("EL TIPO DE DONACIÓN YA EXISTE EN LA BASE DE DATOS, PARA MODIFICAR DATOS USE EL MÓDULO APROPIADO");
            }

            entidad.fechaCreacion = DateTime.Now;
            entidad.usuarioCreacion = "SYSTEM"; // Cambiar por usuario logueado
            entidad.fechaModificacion = entidad.fechaCreacion;
            entidad.usuarioModificacion = entidad.usuarioCreacion;

            tipoDonacionDAO.crear(entidad);
        }

        public void eliminar(string id)
        {
            var existente = tipoDonacionDAO.consultarPorID(id);
            if (existente == null)
            {
                throw new EntityNotFoundDBException("EL TIPO DE DONACIÓN NO EXISTE EN LA BASE DE DATOS, NO SE PUEDE ELIMINAR");
            }

            tipoDonacionDAO.eliminar(id);
        }

        public void modificar(clsTipoDonacion entidad)
        {
            var existente = tipoDonacionDAO.consultarPorID(entidad.idTipoDonacion.ToString());
            if (existente == null)
            {
                throw new EntityNotFoundDBException("EL TIPO DE DONACIÓN NO EXISTE EN LA BASE DE DATOS, NO SE PUEDE MODIFICAR");
            }

            entidad.fechaModificacion = DateTime.Now;
            entidad.usuarioModificacion = "SYSTEM"; // Cambiar por usuario logueado
            entidad.razonModifica = "MODIFICACIÓN DE DATOS"; // Traer desde el formulario

            tipoDonacionDAO.modificar(entidad);
        }
    }
}
