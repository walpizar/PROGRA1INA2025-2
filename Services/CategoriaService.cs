using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoriaService : IGenerica<clsCategoria>
    {
        public clsCategoria consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsCategoria consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsCategoria> consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void crear(clsCategoria entidad)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsCategoria entidad)
        {
            throw new NotImplementedException();
        }
    }
}
