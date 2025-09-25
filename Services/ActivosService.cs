using DAO;
using Entities;
using System;
using System.Collections.Generic;

namespace Services
{
    public class ActivosServices : IDisposable
    {
        private readonly ActivosDAO _dao;

        public ActivosServices()
        {
            _dao = new ActivosDAO(new dbContextINA());
        }

        public void crear(clsActivos activo)
        {
            _dao.crear(activo);
        }

        public void modificar(clsActivos activo)
        {
            _dao.modificar(activo);
        }

        public List<clsActivos> consultarTodos()
        {
            return _dao.consultarTodos();
        }

        public clsActivos consultarPorID(int id)
        {
            return _dao.consultarPorID(id);
        }

        public void DarDeBajaActivo(int id)
        {
            _dao.EliminarActivo(id);
        }

        public void Dispose()
        {
            _dao.Dispose();
        }
    }
}
