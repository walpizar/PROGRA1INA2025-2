using Entities;
using Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PermisoDAO : IPermisosRolModulo<clsPermiso>
    {
        private dbContextINA _context;//se le quito el readonly

        // Constructor privado → nadie lo puede usar fuera
        public PermisoDAO()
        {
            _context = new dbContextINA();
        }


        public void crearPermiso(clsPermiso permi)//AQUI ESTA EL PROBLEMA
        {
            _context.permisos.Add(permi);
            _context.SaveChanges();
        }


        public void crear(clsPermiso modu)
        {
            _context.permisos.Add(modu);
            _context.SaveChanges();
        }

        public void modificar(clsPermiso permi)//MODIFICAR//NO SE USA AUN
        {
            _context.permisos.Update(permi);
            _context.SaveChanges();
        }

        public void eliminar(int id)//ELIMINAR//NO SE USA AUN
        {
            var prod = consultarPorID(id);
            _context.permisos.Remove(prod);
            _context.SaveChanges();
        }

        public void eliminarP(clsPermiso permi)//ELIMINAR//NO SE USA AUN
        {


            _context.permisos.Remove(permi);

            _context.SaveChanges();
        }


        public clsPermiso consultarPorID(int id)// CONSULTAR ID //NO SE USA
        {
            //ID ?????LLAVE COMPUESTA
            return null;
        }

        public clsPermiso consultarPorIDs(int idModulo, int idRol)//CONSULTAR LLAVE COMPUESTA/////////////
        {
            return _context.permisos
                           .SingleOrDefault(p => p.id_modulo == idModulo && p.id_rol == idRol);
        }


        public clsPermiso consultarPorNombre(string nombre)//NO SE USA
        {
            return null;
        }

        public List<clsPermiso> consultarTodos()//NO SE USA
        {
            return _context.permisos.ToList();
      
        }


        public void consultarPermisos(int idModulo, int idRol)//MASO MENOS//AUN NO SE USA
        {
            var permiso = consultarPorIDs(idModulo, idRol); 

            if (permiso != null)
            {
                Console.WriteLine($"Consultar: {permiso.consultar}");
                Console.WriteLine($"Crear: {permiso.crear}");
                Console.WriteLine($"Editar: {permiso.editar}");
                Console.WriteLine($"Eliminar: {permiso.eliminar}");
            }
            else
            {
                Console.WriteLine("No hay permisos asignados.");
            }
        }
    }
}
