using Common.Interfaces;
using Entities;
using DAO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DAO
{
    public class PermisoDAO : IGenerica<clsPermiso>
    {
        private dbContextINA _context;//se le quito el readonly

        // Constructor privado → nadie lo puede usar fuera
        public PermisoDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsPermiso roool)
        {
            _context.permisos.Add(roool);
            _context.SaveChanges();
        }

        public void modificar(clsPermiso permi)
        {
            _context.permisos.Update(permi);
            _context.SaveChanges();
        }

        public void eliminar(int id)///NO SE USA
        {
            //var prod = consultarPorID(id);
            //_context.permisos.Remove(prod);
            //_context.SaveChanges();
        }

        public void eliminar(string id)//NO SE USA 
        {
            //var prod = consultarPorID(id);
            //_context.permisos.Remove(prod);
           // _context.SaveChanges();
        }
        public void eliminarPermiso(clsPermiso permi)//ELIMINAR // ELIMINA LA LLAVE COMPUESTA
        {
            _context.permisos.Remove(permi);
            _context.SaveChanges();
        }

        public clsPermiso consultarPorID(int id)// CONSULTAR ID //NO SE USA
        {
            return null;
        }

        public clsPermiso consultarPorID(string id)// CONSULTAR ID //NO SE USA
        {
            return null;
        }

        public clsPermiso consultarPorNombre(string nombre)//NO SE USA
        {
            return null;
        }
        public List<clsPermiso> consultarTodos()//NO SE USA // PORQUE MUESTRA EL NOMBRE DE MODULO Y ROL MEDIANTE PROPIEDADES DE NAVEGACION
        {
            return _context.permisos.ToList();
        }

        public clsPermiso consultarPorIDs(int idModulo, int idRol)//CONSULTAR LLAVE COMPUESTA
        {
            return _context.permisos
                           .SingleOrDefault(p => p.idModulo == idModulo && p.idRol == idRol);
        }

        public List<clsPermiso> consultarPermisosDos()//CADA PERMISO ESTA COMPUESTO POR EL ID DE MODULO Y ROL
        {
            //MUESTRA NOMBRE POR ID MEDIANTE LA PROPIEDAD DE NAVEGACION
            return _context.permisos
                           .Include(p => p.rol)
                           .Include(p => p.modulo)
                           .ToList();
        }
    }
}
