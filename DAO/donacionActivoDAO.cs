using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAO
{
    internal class donacionActivoDAO : IGenerica<clsDonacionActivo>
    {
        public clsDonacionActivo consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsDonacionActivo consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsDonacionActivo consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonacionActivo> consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void crear(clsDonacionActivo entidad)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsDonacionActivo entidad)
        {
            throw new NotImplementedException();
        }
    }
}
