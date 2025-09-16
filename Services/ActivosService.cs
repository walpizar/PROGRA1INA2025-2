using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ActivosServices : IGenerica<clsActivos>
    {
        private readonly ActivosDAO _actiDAO = new ActivosDAO();

        public ActivosServices()
        {
        }
        public clsActivos consultarPorID(int id)
        {
            return _actiDAO.consultarPorID(id);
        }

        public clsActivos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsActivos consultarPorID(string id, int tipoId)
        {
            throw new NotImplementedException();
        }

        public clsActivos consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsActivos> consultarTodos()
        {
            return _actiDAO.consultarTodos();
        }

        public void crear(clsActivos activos)
        {
            if (_actiDAO.consultarPorID(activos.idActivo) != null)
            {
                throw new Exception("El activo ya existe");
            }
        }

        public void eliminar(int id)
        {
            if (_actiDAO.consultarPorID(id) == null)
            {
                throw new Exception("El activo no existe");
            }
            _actiDAO.eliminar(id);
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id, int tipoId)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsActivos activos)
        {
            _actiDAO.modificar(activos);
        }
    }
}