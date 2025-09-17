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
    public class RolDAO : IGenerica<clsRol>
    {
        private dbContextINA _context;//se le quito el readonly

        // Constructor privado → nadie lo puede usar fuera
        public RolDAO()
        {
            _context = new dbContextINA();
        }

<<<<<<< Updated upstream
        public async Task<List<clsRol>> GetAllAsync() => await _context.rol.ToListAsync();

        public async Task<clsRol> GetByIdAsync(int id) =>
            await _context.rol.FindAsync(id);

        public async Task AddAsync(clsRol rol)
        {
            _context.rol.Add(rol);
            await _context.SaveChangesAsync();
=======
        public void crear(clsRol roool)//CREAR
        {
            _context.roles.Add(roool);
            _context.SaveChanges();
>>>>>>> Stashed changes
        }

        public void modificar(clsRol roool)//MODIFICAR
        {
<<<<<<< Updated upstream
            _context.rol.Update(rol);
            await _context.SaveChangesAsync();
=======
            _context.roles.Update(roool);
            _context.SaveChanges();
>>>>>>> Stashed changes
        }

        public void eliminar(int id)//ELIMINAR
        {
<<<<<<< Updated upstream
            var rol = await _context.rol.FindAsync(id);
            if (rol != null)
            {
                _context.rol.Remove(rol);
                await _context.SaveChangesAsync();
            }
=======
            var prod = consultarPorID(id);
            _context.roles.Remove(prod);
            _context.SaveChanges();
>>>>>>> Stashed changes
        }

        public clsRol consultarPorID(int id)// CONSULTAR ID
        {
            return _context.roles.Where(p => p.id_rol == id).SingleOrDefault();//id_rol
        }


        public clsRol consultarPorNombre(string nombre)
        {
            return _context.roles
                           .FirstOrDefault(r => r.nombre_rol == nombre);//nombre 
        }

        public List<clsRol> consultarTodos()
        {
            return _context.roles.ToList();
        }

    }
}
