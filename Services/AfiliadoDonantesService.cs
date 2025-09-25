using DAO;
using Entities;
using System.Collections.Generic;

namespace Services
{
    public class AfiliadoDonanteService
    {
        private readonly AfiliadoDonanteDAO _dao;

        public AfiliadoDonanteService(AfiliadoDonanteDAO dao)
        {
            _dao = dao;
        }

        public List<clsDonante> ConsultarTodos()
        {
            return _dao.ConsultarTodos();
        }

        public clsDonante ConsultarPorID(string id, int tipoId)
        {
            return _dao.ConsultarPorID(id, tipoId);
        }
    }
}
