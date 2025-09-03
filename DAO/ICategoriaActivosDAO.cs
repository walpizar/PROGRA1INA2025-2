using Entities;
using System.Collections.Generic;

namespace DAO.Interfaces
{
    public interface ICategoriaActivosDAO
    {
        void Add(clsCategoriaActivos categoria);
        void Update(clsCategoriaActivos categoria);
        void Delete(int id);
        clsCategoriaActivos ConsultarPorID(int id, bool incluirActivos = false);
        List<clsCategoriaActivos> ConsultarTodos(bool incluirActivos = false);
        clsCategoriaActivos ConsultarPorNombre(string nombre);
    }
}
