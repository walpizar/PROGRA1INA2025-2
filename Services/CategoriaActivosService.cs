using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using DAO.Interfaces;
using Common.Exceptions;
using Common.Interfaces;

namespace Services
{
    public class CategoriaActivosService : IGenerica<clsCategoriaActivos>
    {
        private readonly ICategoriaActivosDAO _categoriaDao;

        // Se inyecta la interfaz pública, nunca el DAO internal directamente
        public CategoriaActivosService(ICategoriaActivosDAO categoriaDao)
        {
            _categoriaDao = categoriaDao;
        }

        public void crear(clsCategoriaActivos categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.nombre))
                throw new Exception("El nombre es obligatorio");

            if (consultarPorNombre(categoria.nombre) != null)
                throw new EntityExistDBException();

            _categoriaDao.Add(categoria);
        }

        public void modificar(clsCategoriaActivos categoria)
        {
            _categoriaDao.Update(categoria);
        }

        public void eliminar(int id)
        {
            var existente = consultarPorID(id);
            if (existente == null)
                throw new Exception("La categoría no existe");

            _categoriaDao.Delete(id);
        }

        public clsCategoriaActivos consultarPorID(int id)
        {
            return _categoriaDao.ConsultarPorID(id);
        }

        public List<clsCategoriaActivos> consultarTodos()
        {
            return _categoriaDao.ConsultarTodos();
        }

        public clsCategoriaActivos consultarPorNombre(string nombre)
        {
            return _categoriaDao.ConsultarPorNombre(nombre);
        }
    }
}
