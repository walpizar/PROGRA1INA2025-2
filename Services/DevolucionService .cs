using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;

namespace Services
{
    //reglas de negocio
    public class DevolucionService: IDevolucion
    {
        private readonly DevolucionDao _devolucionDao = new DevolucionDao();
        private readonly ActivosServices _activosService = new ActivosServices();

        public DevolucionService() { }

        public void crear(clsDevolucion devolucion)
        {
            if (devolucion == null) throw new ArgumentNullException(nameof(devolucion));
            if (devolucion.idActivoFK <= 0) throw new ArgumentException("El activo asociado es obligatorio.", 
                nameof(devolucion.idActivoFK));

            // Validar que el activo exista
            var activo = _activosService.consultarPorID(devolucion.idActivoFK);
            if (activo == null)
                throw new Exception("El activo no existe.");

            /*
             * / Regla de negocio: el estado del activo debe indicar que está prestado/en uso
            var estado = (activo.estado ?? string.Empty).Trim();
            if (!string.Equals(estado, "Prestado", StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(estado, "En uso", StringComparison.OrdinalIgnoreCase))
            {
                throw new Exception("El activo no está prestado. No es posible registrar la devolución.");
            }*/

            // Registrar la devolución
            _devolucionDao.crear(devolucion);

            // Si deseas actualizar el activo tras la devolución, descomenta y ajusta:
            // activo.Estado = "Disponible";
            // _activosService.modificar(activo);
        }

        public void modificar(clsDevolucion devolucion)
        {
            if (devolucion == null) throw new ArgumentNullException(nameof(devolucion));
            _devolucionDao.modificar(devolucion);
        }

        public void eliminar(int id)
        {
            //validar que la devolución exista
            if (_devolucionDao.consultarPorID(id) == null)
            {
                throw new Exception("La devolución no existe");
            }
            _devolucionDao.eliminar(id);
        }

        public clsDevolucion consultarPorID(int id) => _devolucionDao.consultarPorID(id);

        public List<clsDevolucion> consultarTodos() => _devolucionDao.consultarTodos();
    }
}
