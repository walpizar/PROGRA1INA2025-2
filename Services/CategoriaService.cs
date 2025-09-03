using Common.Enums;
using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CategoriaService : IGenerica<clsCategoria>
    {
        private readonly CategoriaDAO _categoriaDAO;
        public CategoriaService() {
            _categoriaDAO =  new CategoriaDAO();

        }
        public clsCategoria consultarPorID(int id)
        {

            throw new NotImplementedException();


        }

        public clsCategoria consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsCategoria consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsCategoria> consultarTodos()
        {
            try
            {
                return _categoriaDAO.consultarTodos();
            }
            catch (Exception)
            {

                throw;
            }
          
        }

        public void crear(clsCategoria entidad)
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

        public void modificar(clsCategoria entidad)
        {
            throw new NotImplementedException();
        }
    }
}
