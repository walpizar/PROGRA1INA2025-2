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
            try
            {
                return _context.Gastos
                    .OrderByDescending(g => g.fechaCompra)
                    .ThenByDescending(g => g.fechaCrea)
                    .ToList();
            }
            catch (Exception)
            {
                throw;
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
            try
            {
                var gasto = _context.Gastos.Find(id);
                if (gasto != null)
                {
                    _context.Gastos.Remove(gasto);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
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
