using Entities;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IProducto
    {
       void crear(clsProducto producto);
       void modificar(clsProducto producto);
       void eliminar(int id);
       clsProducto consultarPorID(int id);
       clsProducto consultarPorNombre(string nombre);
       List<clsProducto> consultarTodos();

    }
}
