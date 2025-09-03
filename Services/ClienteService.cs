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
    public class ClienteService: IGenerica<clsCliente>
    {
        //capa de servicio viaja o accede a capa de datos    
        ClienteDao _clienteDao = new ClienteDao();

        public ClienteService() { }

        public void crear(clsCliente cliente)
        {

            //regals de negocio           
           
            // regla de negocio valida queno exista un cliente con el mismo id
            if (_clienteDao.consultarPorID(cliente.id) != null)
            {
                throw new Exception("El cliente ya existe");
            }
           

            _clienteDao.crear(cliente);

        }

        public void modificar(clsCliente cliente)
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
        public clsCliente consultarPorID(int id)
        {
            return _clienteDao.consultarPorID(id);
        }

        public List<clsCliente> consultarTodos()
        {
            return _clienteDao.consultarTodos();
        }

        public clsProducto consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        clsCliente IGenerica<clsCliente>.consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsCliente consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
