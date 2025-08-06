using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ClienteService
    {
        //capa de servicio viaja o accede a capa de datos    
        ProductoDao _clienteDao = new ProductoDao();

        public ClienteService() { }

        public void crear(clsProducto cliente)
        {

            //regals de negocio           
           
            // regla de negocio valida queno exista un cliente con el mismo id
            if (_clienteDao.consultarPorID(cliente.id) != null)
            {
                throw new Exception("El cliente ya existe");
            }
           

            _clienteDao.crear(cliente);

        }

        public void modificar(clsProducto cliente)
        {
            //reglasd de negocio
           
            _clienteDao.modificar(cliente);


        }

        public void eliminar(int id)
        {
            //reglas de negocio
            //validar que el cliente exista
            if (_clienteDao.consultarPorID(id) == null)
            {
                throw new Exception("El cliente no existe");
            }
            _clienteDao.eliminar(id);


        }
        public clsProducto consultarPorID(int id)
        {
            return _clienteDao.consultarPorID(id);
        }

        public List<clsProducto> consultarTodos()
        {
            return _clienteDao.consultarTodos();
        }

    }
}
