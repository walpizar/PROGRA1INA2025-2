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
            await _context.permisos.Include(p => p.rol)
                                    .Include(p => p.modulo)
                                    .ToListAsync();

        public async Task AddAsync(clsPermiso permiso)
        {
            _context.permisos.Add(permiso);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(clsPermiso permiso)
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
    }
}
