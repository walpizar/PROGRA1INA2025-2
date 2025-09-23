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

            gasto.fecha_ult_mod = DateTime.Now;
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

        public clsGastos consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}