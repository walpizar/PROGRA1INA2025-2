using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPermisosRolModulo <T>
    {
        void crear(T entidad);
        void modificar(T entidad);
        void eliminar(int id);
        T consultarPorID(int id);
        T consultarPorNombre(string nombre);
        List<T> consultarTodos();
    }
}
