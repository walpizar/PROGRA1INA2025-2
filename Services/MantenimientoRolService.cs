using Common.Exceptions;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

  namespace Services
{
    public class SeguridadService
    {
        private readonly RolDAO _rolDao;
        private readonly ModuloDAO _moduloDao;
        private readonly PermisoDAO  _permisoDao;

        public SeguridadService()//ACCESOS
        {
            _rolDao = new RolDAO();
            _moduloDao = new ModuloDAO();
            _permisoDao = new PermisoDAO();
        }

        public class PermisosDTO//OBTENER SOLO PERMISOS
        {
            public bool Consultar { get; set; }
            public bool Crear { get; set; }
            public bool Editar { get; set; }
            public bool Eliminar { get; set; }

        }

        public PermisosDTO TienePermiso(int idRol, int idModulo)
        {
            var permiso = _permisoDao.consultarPorIDs(idModulo, idRol);

            if (permiso == null)
                return new PermisosDTO(); // Todo false

            return new PermisosDTO//CONSULTAR SOLO LOS PERMISOS DTO
            {
                Consultar = permiso.consultar,
                Crear = permiso.crear,
                Editar = permiso.editar,
                Eliminar = permiso.eliminar
            };
        }

        public List<clsRol> consultarRoles()
        {
            return _rolDao.consultarTodos();
        }

        public List<clsPermiso> consultarPermisos()
        {
            return _permisoDao.consultarPermisosDos();//CADA PERMISO ESTA COMPUESTO POR MODULO Y ROL
        }

        public clsRol consultarID(int id)
        {
            return _rolDao.consultarPorID(id);
        }

        public void editarRol(clsRol roool)
        {
            _rolDao.modificar(roool);
        }

        public void eliminando (int id)
        {
            _rolDao.eliminar(id);
        }

        public List<clsModulo> consultarModulos()
        {
            return _moduloDao.consultarTodos();
        }

        public void crearRol(clsRol roool)//RETORNAR EXCEPCIONES
        {
            if (string.IsNullOrWhiteSpace(roool.nombreRol) && string.IsNullOrWhiteSpace(roool.descripcionRol))
            {
                throw new Exception("No se permiten espacios vacios");
            }
            if (string.IsNullOrWhiteSpace(roool.nombreRol)) 
            {
                throw new Exception("El nombre del rol no puede estar vacio");
            }
            if (string.IsNullOrWhiteSpace(roool.descripcionRol))
            {
                throw new Exception("La descripcion del el rol no puede estar vacia");
            }
            if (_rolDao.consultarPorNombre(roool.nombreRol) != null)
            {
                throw new Exception("No se puede repetir el nombre de un rol");
            }
            _rolDao.crear(roool);
        }

        public void crearPer(clsPermiso permi)//CREAR PERMISO
        {
            _permisoDao.crear(permi);
        }

        public clsPermiso consultarPermi(int idModulo, int idRol)//CONSULTAR PERMMISOS
        {
            return _permisoDao.consultarPorIDs(idModulo, idRol);
        }

        public void modificarPermiso(clsPermiso permi)
        {
            _permisoDao.modificar(permi);
        }

        public void eliminarPermiso(clsPermiso permi)//PARA ELIMINAR LLAVE COMPUESTA
        {
            _permisoDao.eliminarPermiso(permi);
        }
    }
}
