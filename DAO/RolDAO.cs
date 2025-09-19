using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//NO ME FUNCIONO LOS ASINC


namespace DAO
{
    public class RolDAO : IPermisosRolModulo<clsRol>
    {
        private dbContextINA _context;//se le quito el readonly

        // Constructor privado →nadie lo puede usar fuera
        public RolDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsRol roool)//CREAR
        {
            _context.rol.Add(roool);
            _context.SaveChanges();
        }

        public void modificar(clsRol roool)//MODIFICAR
        {
            _context.rol.Update(roool);
            _context.SaveChanges();
        }

        public void eliminar(int id)//ELIMINAR
        {
            var prod = consultarPorID(id);
            _context.rol.Remove(prod);
            _context.SaveChanges();
        }

        public clsRol consultarPorID(int id)// CONSULTAR ID
        {
            return _context.rol.Where(p => p.idRol == id).SingleOrDefault();//id_rol
        }


        public clsRol consultarPorNombre(string nombre)
        {
            return _context.rol
                           .FirstOrDefault(r => r.nombreRol == nombre);//nombre 
        }

        public List<clsRol> consultarTodos()
        {
            return _context.rol.ToList();
        }

    }
}
