using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAO
{
    public class ActivosDAO : IGenerica<clsActivos>
    {
        private dbContextINA _context;

        public ActivosDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsActivos activo)
        {
            _context.Activos.Add(activo);
            _context.SaveChanges();
        }

        public void modificar(clsActivos activo)
        {
            var local = _context.Activos.Local.FirstOrDefault(a => a.idActivo == activo.idActivo);
            if (local != null)
            {
                _context.Entry(local).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            }
            _context.Entry(activo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
        }

        // Borrado lógico: solo cambia el estado a false, y si corresponde, marca fecha y observación de desecho
        public void eliminar(int id, string observacionDesecho = null)
        {
            var activo = consultarPorID(id);
            if (activo != null)
            {
                activo.estado = false; // Borrado lógico
                activo.estadoUso = 2; // 2 = desechado
                activo.fechaDesecho = DateTime.Now;
                if (!string.IsNullOrWhiteSpace(observacionDesecho))
                    activo.observacionDesecho = observacionDesecho;
                _context.Activos.Update(activo);
                _context.SaveChanges();
            }
        }

        public clsActivos consultarPorID(int id)
        {
            return _context.Activos.SingleOrDefault(p => p.idActivo == id);
        }

        public clsActivos consultarPorNombre(string nombre)
        {
            return _context.Activos
                .SingleOrDefault(p => p.nombreActivo.Trim().ToUpper() == nombre.Trim().ToUpper());
        }

        // Solo retorna activos no eliminados lógicamente
        public List<clsActivos> consultarTodos()
        {
            return _context.Activos.ToList(); // Mostrar todos, incluso los dados de baja
        }

        // Implementación requerida por la interfaz, pero no utilizada
        public void eliminar(int id)
        {
            // Puedes lanzar una excepción o dejarlo vacío si no se usa
            throw new NotImplementedException();
        }

        public clsActivos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
    }
}
