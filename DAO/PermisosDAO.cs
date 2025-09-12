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

        public async Task<List<clsPermiso>> GetAllAsync() =>
            await _context.Permisos.Include(p => p.RolPermisos) // Incluye la colección de la tabla de unión
                          .ThenInclude(rp => rp.Rol) // Luego, desde ahí, incluye el Rol
                          .Include(p => p.RolPermisos) // Vuelve a incluir la colección de unión
                          .ThenInclude(rp => rp.Permiso) // Y luego el Permiso
                          .ToListAsync();


        public async Task AddAsync(clsPermiso permiso)
        {
            _context.Permisos.Add(permiso);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(clsPermiso permiso)
        {
            _context.Permisos.Update(permiso);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var permiso = await _context.Permisos.FindAsync(id);
            if (permiso != null)
            {
                _context.Permisos.Remove(permiso);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<clsRolPermiso?> GetPermisoByRolAndModuleAsync(int idRol, int idModulo)
        {
            return await _context.RolPermisos
                         .FirstOrDefaultAsync(rp => rp.IdRol == idRol && rp.IdModulo == idModulo);
        }
    }
}
