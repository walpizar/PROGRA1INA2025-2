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
    public class GastosService : IGenerica<clsGastos>
    {
        private readonly GastosDao _dao = new GastosDao();

        public clsGastos consultarPorID(int id)
        {
            return _dao.consultarPorID(id);
        }

        public clsGastos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public List<clsGastos> consultarTodos()
        {
            return _dao.consultarTodos();
        }

        public void crear(clsGastos gasto)
        {
            ValidarCampos(gasto);

            gasto.fechaCrea = DateTime.Now;
            gasto.usuario_crea = string.IsNullOrWhiteSpace(gasto.usuario_crea) ? "system" : gasto.usuario_crea;

            _dao.crear(gasto);
        }

        public void modificar(clsGastos gasto)
        {
            ValidarCampos(gasto);

            if (_dao.consultarPorID(gasto.idGasto) == null)
                throw new Exception("El gasto no existe.");

            gasto.fecha_ult_mod = DateTime.UtcNow;
            gasto.usuario_ult_mod = string.IsNullOrWhiteSpace(gasto.usuario_ult_mod) ? "system" : gasto.usuario_ult_mod;

            _dao.modificar(gasto);
        }

        public void eliminar(int id)
        {
            var gasto = _dao.consultarPorID(id);
            if (gasto == null)
                throw new Exception("El gasto no existe.");

            _dao.eliminar(id);
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        // Validaciones
        private static void ValidarCampos(clsGastos gasto)
        {
            if (gasto.montoGasto <= 0)
                throw new Exception("El monto del gasto debe ser mayor a 0.");

            if (gasto.montoGasto > 999999999.99m)
                throw new Exception("El monto del gasto es demasiado grande.");

            if (string.IsNullOrWhiteSpace(gasto.responsable))
                throw new Exception("Debe indicar quién realizó el gasto.");

            if (gasto.responsable.Length > 100)
                throw new Exception("El nombre de quien realizó el gasto no puede tener más de 100 caracteres.");

            if (string.IsNullOrWhiteSpace(gasto.descripcion))
                throw new Exception("La descripción del gasto es obligatoria.");

            if (gasto.descripcion.Length > 500)
                throw new Exception("La descripción no puede tener más de 500 caracteres.");

            if (gasto.fechaCompra > DateTime.Today)
                throw new Exception("La fecha del gasto no puede ser futura.");

            if (gasto.fechaCompra < new DateTime(2000, 1, 1))
                throw new Exception("La fecha del gasto no puede ser anterior al año 2000.");
        }

        // Métodos adicionales para reportes
        public List<clsGastos> consultarPorFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            if (fechaInicio > fechaFin)
                throw new Exception("La fecha de inicio no puede ser mayor que la fecha final.");

            return _dao.consultarPorFecha(fechaInicio, fechaFin);
        }

        public List<clsGastos> consultarPorPersona(string realizadoPor)
        {
            if (string.IsNullOrWhiteSpace(realizadoPor))
                throw new Exception("Debe especificar el nombre de la persona.");

            return _dao.consultarPorPersona(realizadoPor.Trim());
        }

        public decimal obtenerTotalGastos()
        {
            return _dao.obtenerTotalGastos();
        }

        public decimal obtenerTotalGastosPorMes(int año, int mes)
        {
            if (mes < 1 || mes > 12)
                throw new Exception("El mes debe estar entre 1 y 12.");

            if (año < 2000 || año > DateTime.Now.Year + 1)
                throw new Exception("Año inválido.");

            return _dao.obtenerTotalGastosPorMes(año, mes);
        }

        // Método para obtener estadísticas rápidas
        public Dictionary<string, object> obtenerEstadisticas()
        {
            var todos = consultarTodos();
            var hoy = DateTime.Today;
            var inicioMes = new DateTime(hoy.Year, hoy.Month, 1);
            var finMes = inicioMes.AddMonths(1).AddDays(-1);

            return new Dictionary<string, object>
            {
                {"TotalGeneral", todos.Sum(g => g.montoGasto)},
                {"TotalMesActual", todos.Where(g => g.fechaCompra >= inicioMes && g.fechaCompra <= finMes).Sum(g => g.montoGasto)},
                {"CantidadTotal", todos.Count},
                {"CantidadMesActual", todos.Count(g => g.fechaCompra >= inicioMes && g.fechaCompra <= finMes)},
                {"PromedioGasto", todos.Count > 0 ? todos.Average(g => g.montoGasto) : 0}
            };
        }

        public clsGastos consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}