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
    public class ModuloDAO : IPermisosRolModulo<clsModulo>
    {
        private dbContextINA _context;//se le quito el readonly

        // Constructor privado → nadie lo puede usar fuera
        public ModuloDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsModulo modu)//CREAR
        {
            _context.modulos.Add(modu);
            _context.SaveChanges();
        }

        public void modificar(clsModulo modu)//MODIFICAR
        {
            _context.modulos.Update(modu);
            _context.SaveChanges();
        }

        public void eliminar(int id)//ELIMINAR
        {
            var prod = consultarPorID(id);
            _context.modulos.Remove(prod);
            _context.SaveChanges();
        }

        public clsModulo consultarPorID(int id)// CONSULTAR ID
        {
            return _context.modulos.Where(p => p.id_modulo == id).SingleOrDefault();//id_rol

            return null;
        }


        public clsModulo consultarPorNombre(string nombre)
        {
            return _context.modulos
                           .FirstOrDefault(r => r.nombre_modulo == nombre);//nombre_rol
        }

        public List<clsModulo> consultarTodos()
        {
            return _context.modulos.ToList();
        }

    }
}
