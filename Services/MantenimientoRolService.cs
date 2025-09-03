using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SeguridadService
    {
        private readonly RolDAO _rolDao;
        private readonly ModuloDAO _moduloDao;
        private readonly PermisoDAO _permisoDao;

        public SeguridadService(RolDAO rolDao, ModuloDAO moduloDao, PermisoDAO permisoDao)
        {
            _rolDao = rolDao;
            _moduloDao = moduloDao;
            _permisoDao = permisoDao;
        }

        // Ejemplo: Validar si un rol tiene permiso para una acción
        public async Task<bool> TienePermisoAsync(int idRol, int idModulo, string accion)
        {
            var permiso = await _permisoDao.GetAllAsync();
            var p = permiso.FirstOrDefault(x => x.id_rol == idRol
                                              && x.id_modulo == idModulo);

            if (p == null) return false;

            return accion.ToLower() switch
            {
                "consultar" => p.consultar,
                "crear" => p.crear,
                "editar" => p.editar,
                "eliminar" => p.eliminar,
                _ => false
            };
        }

        // Otros métodos combinados de negocio
        public async Task<List<clsPermiso>> ObtenerPermisosPorRolYModulo(int idRol, int idModulo)
        {
            var permisos = await _permisoDao.GetAllAsync();
            return permisos.Where(p => p.id_rol == idRol && p.id_modulo == idModulo).ToList();
        }
    }
}
