using DAO;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class AfiliadoDonanteService
    {
        private readonly AfiliadoDonanteDAO _dao;

        public AfiliadoDonanteService(AfiliadoDonanteDAO dao)
        {
            _dao = dao;
        }

        // Devuelve todos los afiliados (tipoDonante = 1)
        public List<clsDonante> ConsultarAfiliados()
        {
            return _dao.ConsultarTodos().Where(d => d.tipoDonante == 1).ToList();
        }

        // Devuelve todos los donantes (tipoDonante = 2)
        public List<clsDonante> ConsultarDonantes()
        {
            return _dao.ConsultarTodos().Where(d => d.tipoDonante == 2).ToList();
        }

        // Métodos existentes
        public List<clsDonante> ConsultarTodos() => _dao.ConsultarTodos();
        public clsDonante ConsultarPorID(string id, int tipoId) => _dao.ConsultarPorID(id, tipoId);
    
    }
}
