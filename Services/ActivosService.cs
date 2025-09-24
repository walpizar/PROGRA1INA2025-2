using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ActivosServices : IGenerica<clsActivos>, IDisposable
    {
        private readonly ActivosDAO _actiDAO;
        private bool _disposed = false; // Para rastrear si ya se ha dispuesto

        public ActivosServices()
        {
            _actiDAO = new ActivosDAO();
        }

        public clsActivos consultarPorID(int id)
        {
            return _actiDAO.consultarPorID(id);
        }

        public clsActivos consultarPorNombre(string nombre)
        {
            return _actiDAO.consultarPorNombre(nombre);
        }

        public List<clsActivos> consultarTodos()
        {
            try
            {
                return _actiDAO.consultarTodos();
            }
            catch (System.Exception)
            {
                return _actiDAO.consultarTodosSinRelaciones();
            }
        }

        public void crear(clsActivos activos)
        {
            if (activos == null)
                throw new System.ArgumentNullException(nameof(activos));

            if (string.IsNullOrWhiteSpace(activos.nombreActivo))
                throw new System.ArgumentException("El nombre del activo es obligatorio");

            if (activos.idCategoria <= 0)
                throw new System.ArgumentException("Debe seleccionar una categoría válida");

            // ❌ No validar el idActivo, la BD lo genera automáticamente
            using (var dao = new ActivosDAO())
            {
                dao.crear(activos);
            }
        }


        public void modificar(clsActivos activos)
        {
            if (activos == null)
                throw new System.ArgumentNullException(nameof(activos));

            var existeActivo = _actiDAO.consultarPorID(activos.idActivo);
            if (existeActivo == null)
                throw new System.ArgumentException($"No se encontró el activo con ID {activos.idActivo}");

            using (var dao = new ActivosDAO()) // Nuevo contexto, se dispone automáticamente
            {
                dao.modificar(activos);
            }
        }

        public void eliminar(int id)
        {
            eliminarLogico(id, "Eliminación directa");
        }

        public void eliminarActivo(int id, string observacionDesecho = null)
        {
            using (var dao = new ActivosDAO()) // Nuevo contexto
            {
                dao.eliminarActivo(id, observacionDesecho);
            }
        }

        public void eliminarLogico(int id, string observacionDesecho = null)
        {
            var activo = _actiDAO.consultarPorID(id);
            if (activo == null)
                throw new System.ArgumentException($"No se encontró el activo con ID {id}");

            using (var dao = new ActivosDAO()) // Nuevo contexto
            {
                dao.eliminarActivo(id, observacionDesecho);
            }
        }

        public int GetNextId()
        {
            using (var context = new DAO.dbContextINA())
            {
                var maxId = context.Activos.Max(a => (int?)a.idActivo) ?? 0;
                return maxId + 1;
            }
        }

        public List<clsActivos> consultarPorCategoria(int idCategoria)
        {
            var todos = consultarTodos();
            return todos.Where(a => a.idCategoria == idCategoria).ToList();
        }

        public List<clsActivos> consultarPorEstado(int estadoUso)
        {
            var todos = consultarTodos();
            return todos.Where(a => a.estadoUso == estadoUso).ToList();
        }

        public List<clsActivos> consultarDesechados()
        {
            using (var context = new DAO.dbContextINA())
            {
                return context.Activos
                    .Where(a => a.estadoUso == 2) // Desechados
                    .ToList();
            }
        }

        public bool ExisteActivo(int idActivo)
        {
            return _actiDAO.consultarPorID(idActivo) != null;
        }

        public void LimpiarDatosProblematicos()
        {
            using (var dao = new ActivosDAO()) // Nuevo contexto
            {
                dao.LimpiarRegistrosProblematicos();
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _actiDAO?.Dispose(); // Libera el DAO si existe
                }
                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
