using DAO;
using Entities;

namespace Services
{
    //reglas de negocio
    public class ProductoService
    {
        //capa de servicio viaja o accede a capa de datos    
        private readonly ProductoDao _prodDao= new ProductoDao();

        public ProductoService() {

      
        }

        public void crear(clsProducto producto)
        {

            //regals de negocio
            //el precio debe ser mayor a 0
            if (producto.precio <= 0)
            {
                throw new Exception("El precio debe ser mayor a 0");
            }
            // regla de negocio valida queno exista un producto con el mismo id
            if (_prodDao.consultarPorID(producto.id)!= null)
            {
                throw new Exception("El producto ya existe");
            }
            // regla de negocio valida que el nombre    
            if (_prodDao.consultarPorNombre(producto.getNombre())!= null)
            {
                throw new Exception("Ya existe un producto con ese nombre");
            }

            _prodDao.crear(producto);

        }

        public void modificar(clsProducto producto)
        {
           //reglasd de negocio
            //el precio debe ser mayor a 0
            if (producto.precio <= 0)
            {
                throw new Exception("El precio debe ser mayor a 0");
            }            
            // regla de negocio valida que el nombre    
            //if (_prodDao.consultarPorNombre(producto.getNombre()) != null)
            //{
            //    throw new Exception("Ya existe un producto con ese nombre");
            //}

            _prodDao.modificar(producto);


        }

        public void eliminar(int id)
        {
            //reglas de negocio
            //validar que el producto exista
            if (_prodDao.consultarPorID(id) == null)
            {
                throw new Exception("El producto no existe");
            }
            _prodDao.eliminar(id);


        }
        public clsProducto consultarPorID(int id)
        {
          return _prodDao.consultarPorID(id);
        }

        public List<clsProducto> consultarTodos()
        {
           return _prodDao.consultarTodos();
        }

    }
}
