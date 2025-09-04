using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;

namespace Services
{
    //reglas de negocio
    public class DevolucionService: IDevolucion
    {
        //capa de servicio viaja o accede a capa de datos    
        private readonly DevolucionDao _devolucionDao = new DevolucionDao();


        public DevolucionService() {      
        }

        public void crear(clsDevolucion devolucion)
        {

            //reglas de negocio
            //el estado del articulo debe ser  = prestado

            // regla de negocio validar que no exista un articulo con el mismo id
            if (_devolucionDao.consultarPorID(devolucion.IdDevolucion)!= null)
            {
                throw new EntityExistDBException();
            }


            _devolucionDao.crear(devolucion);

        }

        public void modificar(clsDevolucion devolucion)
        {
           

            _devolucionDao.modificar(devolucion);


        }

        public void eliminar(int id)
        {
            //reglas de negocio
            //validar que el articulo exista
            if (_devolucionDao.consultarPorID(id) == null)
            {
                throw new Exception("El articulo no existe");
            }
            _devolucionDao.eliminar(id);


        }
        public clsDevolucion consultarPorID(int id)
        {
          return _devolucionDao.consultarPorID(id);
        }

        public List<clsDevolucion> consultarTodos()
        {
           return _devolucionDao.consultarTodos();
        }

        
    }
}
