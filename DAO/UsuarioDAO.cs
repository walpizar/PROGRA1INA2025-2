using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
using System;
using System.Collections.Generic;
using System.Linq;
=======
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

namespace DAO
{
    public class UsuarioDAO : IGenerica<clsUsuario>
    {
        private readonly dbContextINA _context;

<<<<<<< HEAD
        public UsuarioDAO()
=======

        public UsuarioDAO() 
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
        {
            _context = new dbContextINA();
        }
      
        public void crear(clsUsuario usuario)
        {
            _context.usuario.Add(usuario);
            _context.SaveChanges();
        }

        public void modificar(clsUsuario usuario)
        {

            _context.usuario.Update(usuario);
            _context.SaveChanges();
        }

<<<<<<< HEAD
        // Métodos con clave compuesta
        public void eliminar(string personaId, int personaTipoId)
        {
            var usua = _context.usuario
                .SingleOrDefault(u => u.personaId == personaId && u.personaTipoId == personaTipoId);

            if (usua != null)
            {
                _context.usuario.Remove(usua);
                _context.SaveChanges();
=======
        public void eliminar(string nombreUsuario)
        {
            var usuario = _context.usuario
                .FirstOrDefault(u => u.nombre_Usuario == nombreUsuario);

            if (usuario != null)
            {
                _context.usuario.Remove(usuario);
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("El usuario no existe");
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
            }
        }

<<<<<<< HEAD
        public clsUsuario consultarPorID(string personaId, int personaTipoId)
        {
            return _context.usuario.Find(personaId, personaTipoId);
        }

        // Métodos de la interfaz (no aplican, pero obligatorios para compilar)
        public void eliminar(string id)
        {
            throw new NotImplementedException("Usa eliminar(personaId, personaTipoId).");
        }

        public clsUsuario consultarPorID(string id)
        {
            throw new NotImplementedException("Usa consultarPorID(personaId, personaTipoId).");
=======
        public clsUsuario consultarPorID(string id)
        {
            // Asume que 'id' se refiere a 'personaId'.
            return _context.usuario.Where(u => u.id == id).SingleOrDefault();

>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
        }
        public clsUsuario consultarPorNombre(string nombre)
        {
<<<<<<< HEAD
            return _context.usuario
                .FirstOrDefault(u => u.nombre_usuario.Trim().ToUpper() == nombre.Trim().ToUpper());
=======
            return _context.usuario.Where(u => u.nombre_Usuario.Trim().ToUpper()
                                              == nombre.Trim().ToUpper()).SingleOrDefault();
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
        }

        public List<clsUsuario> consultarTodos()
        {
            using var context = new dbContextINA();
            { 
                return context.usuario.Include(u => u.persona).ToList();
            }
            //return _context.usuario.ToList();
        }
<<<<<<< HEAD
=======

        public void eliminar(int id)
        {
            throw new NotImplementedException("Usar eliminar(string nombreUsuario)");
        }

        public clsUsuario consultarPorID(int id)
        {
            throw new NotImplementedException("Usar consultarPorID(string nombreUsuario)");
        }
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4
    }
}
