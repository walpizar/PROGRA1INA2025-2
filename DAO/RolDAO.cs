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

        // Constructor privado → nadie lo puede usar fuera
        private RolDAO(dbContextINA context)
        {
            _context = context;
        }

        public async Task<List<clsRol>> GetAllAsync() => await _context.roles.ToListAsync();

        public async Task<clsRol> GetByIdAsync(int id) =>
            await _context.roles.FindAsync(id);

        public async Task AddAsync(clsRol rol)
        {
            _context.roles.Add(rol);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(clsRol rol)
        {
            _context.roles.Update(rol);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var rol = await _context.roles.FindAsync(id);
            if (rol != null)
            {
                _context.roles.Remove(rol);
                await _context.SaveChangesAsync();
            }
        }
    }
}
