using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ModuloDAO
    {
        private readonly dbContextINA _context;

        private ModuloDAO(dbContextINA context)
        {
            _context = context;
        }

        public async Task<List<clsModulo>> GetAllAsync() =>
            await _context.modulos.Include(m => m.permisos).ToListAsync();

        public async Task<clsModulo> GetByIdAsync(int id) =>
            await _context.modulos.Include(m => m.permisos)
                                  .FirstOrDefaultAsync(m => m.id_modulo == id);

        public async Task AddAsync(clsModulo modulo)
        {
            _context.modulos.Add(modulo);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(clsModulo modulo)
        {
            _context.modulos.Update(modulo);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var modulo = await _context.modulos.FindAsync(id);
            if (modulo != null)
            {
                _context.modulos.Remove(modulo);
                await _context.SaveChangesAsync();
            }
        }
    }
}
