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
            try
            {
                return _context.Activos
                    .Include(a => a.categoria)
                    .ToList();
            }
            catch (Exception ex)
            {
                // Log o mensaje para depuración
                System.Diagnostics.Debug.WriteLine($"Error en listar Activos: {ex.Message}");
                throw new Exception($"Error al listar activos: {ex.Message}", ex);
            }
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
            // Retorna todos los activos, sin filtrar por estado ni por categoría
            return _context.Activos
                .AsNoTracking()
                .Include(a => a.categoria)
                .ToList();
        }

        public List<clsActivos> consultarTodosSinRelaciones()
        {
            var result = new List<clsActivos>();
            List<clsActivos> activos;
            try
            {
                activos = _context.Activos.ToList();
            }
            catch (Exception ex)
            {
                // Si hay un error al leer la tabla, retorna lista vacía
                return new List<clsActivos>();
            }

            foreach (var activo in activos)
            {
                try
                {
                    // Intenta cargar la categoría, si falla la deja en null
                    try
                    {
                        activo.categoria = _context.Set<clsCategoriaActivos>()
                            .FirstOrDefault(c => c.Id == activo.idCategoria);
                    }
                    catch
                    {
                        activo.categoria = null;
                    }

                    // Si algún campo obligatorio es nulo o inválido, lo salta
                    if (string.IsNullOrEmpty(activo.nombreActivo) ||
                        activo.idCategoria <= 0 ||
                        activo.estadoUso < 0 ||
                        activo.fechaAdquisicion == default ||
                        activo.fechaCreacion == default ||
                        string.IsNullOrEmpty(activo.usuarioCreacion))
                    {
                        continue;
                    }

                    result.Add(activo);
                }
                catch
                {
                    // Ignora el registro problemático
                    continue;
                }
            }

            return result;
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
                // 1. Activos sin nombre
                var sinNombre = _context.Activos
                    .Where(a => string.IsNullOrEmpty(a.nombreActivo))
                    .ToList();
                foreach (var activo in sinNombre)
                {
                    activo.nombreActivo = $"Activo sin nombre - ID: {activo.idActivo}";
                    activo.usuarioModificacion = "sistema_limpieza";
                    activo.fechaModificacion = DateTime.Now;
                }

                // 2. Activos con estadoUso inválido
                var estadoUsoInvalido = _context.Activos
                    .Where(a => a.estadoUso < 0)
                    .ToList();
                foreach (var activo in estadoUsoInvalido)
                {
                    activo.estadoUso = 0;
                    activo.usuarioModificacion = "sistema_limpieza";
                    activo.fechaModificacion = DateTime.Now;
                }

                // 3. Activos con idCategoria inválido o inexistente
                // Buscar una categoría válida por defecto
                var categoriaDefault = _context.CategoriasActivos.FirstOrDefault(c => c.estado);
                int idCategoriaDefault = categoriaDefault != null ? categoriaDefault.Id : 1;
                var categoriaInvalida = _context.Activos
                    .Where(a => a.idCategoria <= 0 ||
                        !_context.CategoriasActivos.Any(c => c.Id == a.idCategoria))
                    .ToList();
                foreach (var activo in categoriaInvalida)
                {
                    activo.idCategoria = idCategoriaDefault;
                    activo.usuarioModificacion = "sistema_limpieza";
                    activo.fechaModificacion = DateTime.Now;
                }

                // 4. Activos con fechaAdquisicion o fechaCreacion por defecto
                var fechasInvalidas = _context.Activos
                    .Where(a => a.fechaAdquisicion == default || a.fechaCreacion == default)
                    .ToList();
                foreach (var activo in fechasInvalidas)
                {
                    if (activo.fechaAdquisicion == default)
                        activo.fechaAdquisicion = DateTime.Now;
                    if (activo.fechaCreacion == default)
                        activo.fechaCreacion = DateTime.Now;
                    activo.usuarioModificacion = "sistema_limpieza";
                    activo.fechaModificacion = DateTime.Now;
                }

                // 5. Activos sin usuarioCreacion
                var sinUsuarioCreacion = _context.Activos
                    .Where(a => string.IsNullOrEmpty(a.usuarioCreacion))
                    .ToList();
                foreach (var activo in sinUsuarioCreacion)
                {
                    activo.usuarioCreacion = "sistema_limpieza";
                    activo.usuarioModificacion = "sistema_limpieza";
                    activo.fechaModificacion = DateTime.Now;
                }

                // 6. Categorías sin nombre
                var categoriasSinNombre = _context.CategoriasActivos
                    .Where(c => string.IsNullOrEmpty(c.nombre))
                    .ToList();
                foreach (var categoria in categoriasSinNombre)
                {
                    categoria.nombre = $"Categoría sin nombre - ID: {categoria.Id}";
                }

                // 7. Categorías con estado NULL o inválido (no debería ocurrir, pero por seguridad)
                var categoriasEstadoNull = _context.CategoriasActivos
                    .Where(c => c.estado != true && c.estado != false)
                    .ToList();
                foreach (var categoria in categoriasEstadoNull)
                {
                    categoria.estado = true;
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
