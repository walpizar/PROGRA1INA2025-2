using DAO;
using Entities;
using Microsoft.EntityFrameworkCore;
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

        /* Ejemplo: Validar si un rol tiene permiso para una acción
        public async Task<bool> TienePermisoAsync(int idRol, int idModulo, string accion)
        {
            var p = await _permisoDao.GetPermisoByRolAndModuleAsync(idRol, idModulo);

            if (p == null) return false;

            return accion.ToLower() switch
            {
                "consultar" => p.consultar,
                "crear" => p.crear,
                "editar" => p.editar,
                "eliminar" => p.eliminar,
                _ => false
            };
        }*/

        // Otros métodos combinados de negocio
       /* public async Task<List<clsPermisos>> ObtenerPermisosPorRolYModulo(int idRol, int idModulo)
        {
            var permisos = await _permisoDao.GetAllAsync();
           
            return permisos
                         .Where(p => p.RolPermisos.Any(rp => rp.idRol == idRol && rp.idModulo == idModulo))
                         .ToList();
        }*/
    }
}
