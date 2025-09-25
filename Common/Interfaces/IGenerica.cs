using System.Collections.Generic;

namespace Common.Interfaces
{
    public interface IGenerica<T>
    {
        void crear(T entidad);
        void modificar(T entidad);
        void eliminar(int id);
        void eliminar(string id);
        T consultarPorID(int id);
        T consultarPorID(string id);
        T consultarPorNombre(string nombre);
        List<T> consultarTodos();

    }
}
