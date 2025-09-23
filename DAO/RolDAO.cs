using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RolDAO
    {
        private readonly dbContextINA _context;

        public RolDAO(dbContextINA context)
        {
            _context = context;
        }

        public async Task<List<clsRol>> GetAllAsync() => await _context.Roles.ToListAsync();

        public async Task<clsRol> GetByIdAsync(int id) =>
            await _context.Roles.FindAsync(id);

        public async Task AddAsync(clsRol rol)
        {
            _context.Roles.Add(rol);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(clsRol rol)
        {
            _context.Roles.Update(rol);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var rol = await _context.Roles.FindAsync(id);
            if (rol != null)
            {
                _context.Roles.Remove(rol);
                await _context.SaveChangesAsync();
            }
        }
    }
}
