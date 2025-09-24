using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class ActivosDAO : IGenerica<clsActivos>, IDisposable
    {
        private dbContextINA _context;
        private bool _disposed = false; // Para rastrear si ya se ha dispuesto

        public ActivosDAO(dbContextINA context = null)
        {
            _context = context ?? new dbContextINA();
        }

        public List<clsActivos> listar()
        {
            return _context.Activos
                .Include(a => a.categoria)
                .ToList();
        }

        public void crear(clsActivos activo)
        {
            if (string.IsNullOrWhiteSpace(activo.nombreActivo))
                throw new ArgumentException("El nombre del activo es obligatorio");

            if (activo.idCategoria <= 0)
                throw new ArgumentException("Debe seleccionar una categoría válida");

            if (string.IsNullOrWhiteSpace(activo.usuarioCreacion))
                activo.usuarioCreacion = "sistema";

            if (activo.fechaCreacion == default(DateTime))
                activo.fechaCreacion = DateTime.Now;

            _context.Activos.Add(activo);
            _context.SaveChanges();
        }

        public void modificar(clsActivos activo)
        {
            if (string.IsNullOrWhiteSpace(activo.nombreActivo))
                throw new ArgumentException("El nombre del activo es obligatorio");

            var local = _context.Activos.Local.FirstOrDefault(a => a.idActivo == activo.idActivo);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }

            _context.Entry(activo).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public clsActivos consultarPorID(int id)
        {
            return _context.Activos
                .Include(a => a.categoria)
                .SingleOrDefault(p => p.idActivo == id);
        }

        public clsActivos consultarPorNombre(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
                return null;

            return _context.Activos
                .SingleOrDefault(p => !string.IsNullOrEmpty(p.nombreActivo) &&
                                    p.nombreActivo.Trim().ToUpper() == nombre.Trim().ToUpper());
        }

        public List<clsActivos> consultarTodos()
        {
            // retorno todos los activos de la tabla tbActivos
            // el include es para traer los datos de la tabla categoria que esta relacionada con activos
            return _context.Activos
                .AsNoTracking() // esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(a => a.categoria)
                .Where(a => a.estado == true) // solo los activos
                .ToList();
        }

        public List<clsActivos> consultarTodosSinRelaciones()
        {
            try
            {
                var activos = _context.Activos
                    .Where(a => a.estado == true &&
                              !string.IsNullOrEmpty(a.nombreActivo) &&
                              a.idCategoria > 0)
                    .ToList();

                foreach (var activo in activos)
                {
                    try
                    {
                        activo.categoria = _context.Set<clsCategoriaActivos>()
                            .FirstOrDefault(c => c.Id == activo.idCategoria);
                    }
                    catch
                    {
                        activo.categoria = null;
                    }
                }

                return activos;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al consultar los activos: {ex.Message}");
            }
        }

        public void eliminarActivo(int id, string observacionDesecho = null)
        {
            var activo = consultarPorID(id);
            if (activo != null)
            {
                activo.estado = false;
                activo.estadoUso = 2;
                activo.fechaDesecho = DateTime.Now;
                activo.observacionDesecho = observacionDesecho ?? "Eliminado por el sistema";
                activo.usuarioModificacion = "sistema";
                activo.fechaModificacion = DateTime.Now;

                _context.Activos.Update(activo);
                _context.SaveChanges();
            }
        }

        public void eliminar(int id)
        {
            eliminarActivo(id, "Eliminación directa");
        }

        public void eliminate(int id)
        {
            eliminarActivo(id);
        }

        public clsActivos consultarPorID(string id)
        {
           /* if (int.TryParse(id, out int idNumerico))
                return consultarPorID(idNumerico);

            return null;*/
           return _context.Activos
                .Include(a => a.categoria)
                .SingleOrDefault(p => p.idActivo.ToString() == id);
        }

        public void LimpiarRegistrosProblematicos()
        {
            try
            {
                var sinNombre = _context.Activos
                    .Where(a => string.IsNullOrEmpty(a.nombreActivo))
                    .ToList();

                foreach (var activo in sinNombre)
                {
                    activo.nombreActivo = $"Activo sin nombre - ID: {activo.idActivo}";
                    activo.usuarioModificacion = "sistema_limpieza";
                    activo.fechaModificacion = DateTime.Now;
                }

                var categoriaInvalida = _context.Activos
                    .Where(a => a.idCategoria <= 0 ||
                              !_context.Set<clsCategoriaActivos>().Any(c => c.Id == a.idCategoria))
                    .ToList();

                foreach (var activo in categoriaInvalida)
                {
                    activo.estado = false;
                    activo.observacionDesecho = "Desactivado por categoría inválida";
                    activo.usuarioModificacion = "sistema_limpieza";
                    activo.fechaModificacion = DateTime.Now;
                }

                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al limpiar registros problemáticos: {ex.Message}");
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context?.Dispose(); // Libera el contexto si existe
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
