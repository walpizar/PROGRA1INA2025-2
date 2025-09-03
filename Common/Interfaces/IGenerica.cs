using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IGenerica <T>
    {
        void crear(T entidad);
        void modificar(T entidad);
        void eliminar(string id);
        T consultarPorID(string id);
        T consultarPorNombre(string nombre);
        List<T> consultarTodos();

    }
}
