using Entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IDevolucion
    {
       void crear(clsDevolucion devolucion);
       void modificar(clsDevolucion devolucion);
       void eliminar(int id);
        clsDevolucion consultarPorID(int id);
       List<clsDevolucion> consultarTodos();

    }
}
