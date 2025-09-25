using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class AfiliadoDonanteDAO
    {
        private readonly dbContextINA _context;

        public AfiliadoDonanteDAO(dbContextINA context)
        {
            _context = context;
        }

        // Traer todos los afiliados
        public List<clsDonante> ConsultarTodos()
        {
            return _context.donante
                           .Include(d => d.persona)
                           .Where(d => d.tipoDonante == 1)
                           .ToList();
        }

        // Traer un afiliado por ID
        public clsDonante ConsultarPorID(string id, int tipoId)
        {
            return _context.donante
                           .Include(d => d.persona)
                           .FirstOrDefault(d => d.personaId == id && d.personaTipoId == tipoId && d.tipoDonante == 1);
        }
    }
}
