using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PermisoDAO
    {
        private readonly dbContextINA _context;

        private PermisoDAO(dbContextINA context)
        {
            _context = context;
        }

        public async Task<List<clsPermisos>> GetAllAsync()
        {
            return await _context.permisos.Include(p => p.RolPermisos) // Incluye la colección de la tabla de unión
                          .ThenInclude(rp => rp.Rol) // Luego, desde ahí, incluye el Rol
                          .Include(p => p.RolPermisos) // Vuelve a incluir la colección de unión
                          .ThenInclude(rp => rp.Permiso) // Y luego el Permiso
                          .ToListAsync();
        }

        public async Task AddAsync(clsPermisos permiso)
        {
            _context.permisos.Add(permiso);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(clsPermisos permiso)
        {
            _context.permisos.Update(permiso);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var permiso = await _context.permisos.FindAsync(id);
            if (permiso != null)
            {
                _context.permisos.Remove(permiso);
                await _context.SaveChangesAsync();
            }
        }

        /*public async Task<clsRolPermiso?> GetPermisoByRolAndModuleAsync(int idRol, int idModulo)
        {
            return await _context.rolPermiso
                         .FirstOrDefaultAsync(rp => rp.dRol == idRol && rp.IdModulo == idModulo);
        }*/
    }
}
