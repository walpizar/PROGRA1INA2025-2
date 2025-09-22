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
            _actiDAO.crear(activos);
        }

        // Borrado lógico: se debe pasar la observación de desecho si aplica
        public void eliminar(int id, string observacionDesecho = null)
        {
            _actiDAO.eliminar(id, observacionDesecho);
        }

        public void eliminar(int id)
        {
            eliminar(id, null);
        }

        public void modificar(clsActivos activos)
        {
            _actiDAO.modificar(activos);
        }
    }
}