using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using static Common.Enums.Enums;


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
            if (devolucion.idActivoFK <= 0)
                throw new ArgumentException("El activo asociado es obligatorio.", nameof(devolucion.idActivoFK));

            // Validar que el activo exista
            var activo = _activosService.consultarPorID(devolucion.idActivoFK);
            if (activo == null)
                throw new Exception("El activo no existe.");

            // 1) Debe estar activo lógicamente
            if (!activo.estado)
                throw new Exception("El activo está eliminado. No es posible registrar la devolución.");

            // 2) Debe estar prestado o en uso (según catálogo de estadoUso)
            var estadoUso = (EstadoUsoActivo)activo.estadoUso;
            var esPrestadoOEnUso = estadoUso is EstadoUsoActivo.Prestado or EstadoUsoActivo.EnUso;
            if (!esPrestadoOEnUso)
                throw new Exception("El activo no está prestado ni en uso. No es posible registrar la devolución.");

            // Registrar la devolución
            _devolucionDao.crear(devolucion);

            // Poner el activo como Disponible
            activo.estadoUso = (int)EstadoUsoActivo.Disponible;
            _activosService.modificar(activo);
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
