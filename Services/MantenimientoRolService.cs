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

        public List<clsModulo> consultarModulos()
        {
            return _moduloDao.consultarTodos();
        }

        public void crearRol(clsRol roool)
        {
            if (string.IsNullOrWhiteSpace(roool.nombre_rol)) 
            {
                throw new NullException();
            }
            if (string.IsNullOrWhiteSpace(roool.descripcion_rol))
            {
                throw new NullException();
            }
            if (_rolDao.consultarPorID(roool.id_rol) != null)
            {
                throw new EntityExistDBException();
            }
            if (_rolDao.consultarPorNombre(roool.nombre_rol) != null)
            {
                throw new NameProductExistDBException();
            }
            _rolDao.crear(roool);
        }

        public void crearPer(clsPermiso permi)//CREAR PERMISO
        {
            _permisoDao.crearPermiso(permi);
        }

        public clsPermiso consultarPermi(int idModulo, int idRol)//CONSULTAR PERMMISOS
        {
            return _permisoDao.consultarPorIDs(idModulo, idRol);
        }


        public void modificarPermiso(clsPermiso permi)
        {
            _permisoDao.modificar(permi);
        }

        public void eliminarPermiso(clsPermiso permi)
        {
            _permisoDao.eliminarP(permi);
        }
    }
}
