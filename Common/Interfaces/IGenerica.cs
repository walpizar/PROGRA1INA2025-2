using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IGenerica<T>
    {
        void crear(T entidad);
        void modificar(T entidad);
        void eliminarActivo(int id, string observacionDesecho = null);
        void eliminar(int id);
        T consultarPorID(int id);
        T consultarPorNombre(string nombre);
        List<T> consultarTodos();
    }
}
