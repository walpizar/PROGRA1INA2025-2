using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class GastosDao : IGenerica<clsGastos>
    {
        private readonly dbContextINA _context;

        public GastosDao()
        {
            _context = new dbContextINA();
        }

        public clsGastos consultarPorID(int id)
        {
            {
                try
                {
                    return _context.Gastos.Find(id);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public clsGastos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public List<clsGastos> consultarTodos()
        {
            using (var context = new dbContextINA())
            {
                return context.Gastos
                    .Where(g => g.Estado) // Solo los activos, si usas borrado lógico
                    .OrderByDescending(g => g.fechaCompra)
                    .ThenByDescending(g => g.fechaCrea)
                    .ToList();
            }
        }

        public void crear(clsGastos gasto)
        {
            try
            {
                _context.Gastos.Add(gasto);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void modificar(clsGastos gasto)
        {
            try
            {
                var gastoExistente = _context.Gastos.Find(gasto.idGasto);
                if (gastoExistente != null)
                {
                    gastoExistente.montoGasto = gasto.montoGasto;
                    gastoExistente.responsable = gasto.responsable;
                    gastoExistente.descripcion = gasto.descripcion;
                    gastoExistente.fechaCompra = gasto.fechaCompra;
                    gastoExistente.fecha_ult_mod = gasto.fecha_ult_mod;
                    gastoExistente.usuario_ult_mod = gasto.usuario_ult_mod;

                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void eliminar(int id)
        {
            var gasto = _context.Gastos.SingleOrDefault(g => g.idGasto == id);
            if (gasto == null)
                throw new Exception("El gasto no existe");

            gasto.Estado = false;
            _context.Gastos.Update(gasto);
            _context.SaveChanges();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsGastos consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
