using Entities;
using System;
using System.Collections.Generic;
using DAO.Interfaces;

namespace Services
{
    public class CategoriaActivosService
    {
        private readonly ICategoriaActivosDAO _categoriaDao;

        public CategoriaActivosService(ICategoriaActivosDAO categoriaDao)
        {
            _categoriaDao = categoriaDao;
        }

        public void crear(clsCategoriaActivos categoria)
        {
            if (string.IsNullOrWhiteSpace(categoria.nombre))
                throw new Exception("El nombre es obligatorio");

            if (_categoriaDao.ConsultarPorNombre(categoria.nombre) != null)
                throw new Exception("La categoría ya existe");

            _categoriaDao.Add(categoria);
        }

        public void modificar(clsCategoriaActivos categoria)
        {
            var existente = _categoriaDao.ConsultarPorID(categoria.Id);
            if (existente != null)
            {
                existente.nombre = categoria.nombre;
                existente.descripcion = categoria.descripcion;
                existente.estado = categoria.estado;

                _categoriaDao.Update(existente);
            }
        }

        public void eliminar(int id)
        {
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
    }
}
