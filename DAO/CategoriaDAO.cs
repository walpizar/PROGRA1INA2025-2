using Common.Enums;
using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class CategoriaDAO : IGenerica<clsCategoria>
    {
        private dbContextINA _context;

        public CategoriaDAO()
        {
            _context = new dbContextINA();
        }


        public clsCategoria consultarPorID(int id)
        {
            //_context.facturas.Where(f => f.tipopago == (int)Enums.MetodoPago.PayPal).ToList();
            throw new NotImplementedException();
        }

        public clsCategoria consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsCategoria> consultarTodos()
        {
            return _context.Categoria.Where(c=>c.estado == true).ToList();
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
