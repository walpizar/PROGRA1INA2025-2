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
    public class DepartamentosService : IGenerica<clsDepartamentos>
    {
        private readonly DepartamentosDao _dao = new DepartamentosDao();

        private readonly PuestosDao _puestosDao = new PuestosDao();

        public clsDepartamentos consultarPorID(int id)
        {
            return _dao.consultarPorID(id);
        }

        public clsDepartamentos consultarPorNombre(string nombre)
        {
            return _dao.consultarPorNombre(nombre);
        }

        public List<clsDepartamentos> consultarTodos()
        {
            return _dao.consultarTodos().Where(d => d.estado).ToList(); // Solo activos
        }

        public void crear(clsDepartamentos d)
        {

            // Validar código funcional (NO el ID autoincremental)
            if (string.IsNullOrWhiteSpace(d.codigoDepartamento))
                throw new Exception("El código del departamento es obligatorio.");

            // Validación de código funcional único (solo entre activos)
            var codigoDup = _dao.consultarTodos()
                .Where(x => x.estado) // Solo validar entre activos
                .Any(x => x.codigoDepartamento.Trim().ToUpper() == d.codigoDepartamento.Trim().ToUpper());
            if (codigoDup)
                throw new Exception("Ya existe un departamento activo con ese código.");

            if (string.IsNullOrWhiteSpace(d.Nombre))
                throw new Exception("El nombre es obligatorio.");

            // Validación de nombre único (solo entre activos)
            var nombreDup = _dao.consultarTodos()
                .Where(x => x.estado) // Solo validar entre activos
                .Any(x => x.Nombre.Trim().ToUpper() == d.Nombre.Trim().ToUpper());
            if (nombreDup)
                throw new Exception("Ya existe un departamento activo con ese nombre.");

            if (string.IsNullOrWhiteSpace(d.descripcionDepartamento))
                throw new Exception("La descripcion del departamento es obligatoria");

            d.fecha_crea = DateTime.UtcNow;
            d.usuario_crea = string.IsNullOrWhiteSpace(d.usuario_crea) ? "system" : d.usuario_crea;

            _dao.crear(d);
        }

        public void eliminar(int id, string motivo, string usuario)
        {
            if (string.IsNullOrWhiteSpace(motivo))
                throw new Exception("Debe ingresar un motivo de inactivación.");

            var dep = _dao.consultarPorID(id);
            if (dep == null) throw new Exception("El departamento no existe.");

            // Verificar si tiene puestos activos asociados
            bool tienePuestosActivos = _puestosDao
                .consultarTodos()
                .Any(p => p.idDepartamento == id && p.Estado);

            if (tienePuestosActivos)
                throw new Exception("No se puede inactivar: el departamento tiene puestos activos asociados.");

            dep.Inactivar(motivo.Trim(), string.IsNullOrWhiteSpace(usuario) ? "system" : usuario);
            _dao.modificar(dep);
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsDepartamentos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsDepartamentos entidad)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
