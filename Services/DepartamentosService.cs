using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;

namespace Services
{
    public class DepartamentosService
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
            return _dao.consultarTodos();
        }

        public void crear(clsDepartamentos d)
        {
            ValidarCampos(d);

            // Validar código personalizado (NO el ID autoincremental)
            if (string.IsNullOrWhiteSpace(d.codigoDepartamento))
                throw new Exception("El código del departamento es obligatorio.");

            // Validación de código funcional único
            var codigoDup = _dao.consultarTodos()
                .Any(x => x.codigoDepartamento.Trim().ToUpper() == d.codigoDepartamento.Trim().ToUpper());
            if (codigoDup)
                throw new Exception("Ya existe un departamento con ese código.");

            if (string.IsNullOrWhiteSpace(d.Nombre))
                throw new Exception("El nombre es obligatorio.");

            // Validación de nombre único
            var nombreDup = _dao.consultarTodos()
                .Any(x => x.Nombre.Trim().ToUpper() == d.Nombre.Trim().ToUpper());
            if (nombreDup)
                throw new Exception("Ya existe un departamento con ese nombre.");

            if (string.IsNullOrWhiteSpace(d.descripcionDepartamento))
                throw new Exception("La descripcion del departamento es obligatoria");

            d.fecha_crea = DateTime.Now;
            d.usuario_crea = string.IsNullOrWhiteSpace(d.usuario_crea) ? "system" : d.usuario_crea;

            _dao.crear(d);
        }

        public void eliminar(int id)
        {
            var dep = _dao.consultarPorID(id);
            if (dep == null) throw new Exception("El departamento no existe.");

            bool tienePuestos = _puestosDao
                .consultarTodos()
                .Any(p => p.idDepartamento == id);

            if (tienePuestos)
                throw new Exception("No se puede eliminar: el departamento tiene puestos asociados.");

            _dao.eliminar(id);
        }

        public void modificar(clsDepartamentos d)
        {
            ValidarCampos(d);

            if (_dao.consultarPorID(d.idDepartamento) == null)
                throw new Exception("El departamento no existe.");

            if (string.IsNullOrWhiteSpace(d.codigoDepartamento))
                throw new Exception("El código del departamento es obligatorio.");

            if (string.IsNullOrWhiteSpace(d.Nombre))
                throw new Exception("El nombre es obligatorio.");

            if (string.IsNullOrWhiteSpace(d.descripcionDepartamento))
                throw new Exception("La descripción del departamento es obligatoria.");

            // Validación de código funcional único
            var codigoDup = _dao.consultarTodos()
                .Any(x => x.idDepartamento != d.idDepartamento &&
                          x.codigoDepartamento.Trim().ToUpper() == d.codigoDepartamento.Trim().ToUpper());
            if (codigoDup)
                throw new Exception("Ya existe otro departamento con ese código.");

            // Validación de nombre único
            var nombreDup = _dao.consultarTodos()
                .Any(x => x.idDepartamento != d.idDepartamento &&
                          x.Nombre.Trim().ToUpper() == d.Nombre.Trim().ToUpper());
            if (nombreDup)
                throw new Exception("Ya existe otro departamento con ese nombre.");

            d.fecha_ult_mod = DateTime.Now;
            d.usuario_ult_mod = string.IsNullOrWhiteSpace(d.usuario_ult_mod) ? "system" : d.usuario_ult_mod;

            _dao.modificar(d);
        }

        private static void ValidarCampos(clsDepartamentos d)
        {
            if (string.IsNullOrWhiteSpace(d.codigoDepartamento) || d.codigoDepartamento.Length > 20)
                throw new Exception("Código es obligatorio y ≤ 20 caracteres.");
            if (string.IsNullOrWhiteSpace(d.Nombre) || d.Nombre.Length > 100)
                throw new Exception("Nombre es obligatorio y ≤ 100 caracteres.");
            if (string.IsNullOrWhiteSpace(d.descripcionDepartamento) || d.descripcionDepartamento.Length > 250)
                throw new Exception("Descripción es obligatoria y ≤ 250 caracteres.");
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsDepartamentos consultarPorID(string id)
        {
            throw new NotImplementedException();
        }


    }
}
