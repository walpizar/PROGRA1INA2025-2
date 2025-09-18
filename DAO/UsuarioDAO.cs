using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class UsuarioDAO : IGenerica<clsUsuario>
    {
        private readonly dbContextINA _context;

        public UsuarioDAO()
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

        // Métodos con clave compuesta
        public void eliminar(string personaId, int personaTipoId)
        {
            var usua = _context.usuario
                .SingleOrDefault(u => u.personaId == personaId && u.personaTipoId == personaTipoId);

            if (usua != null)
            {
                _context.usuario.Remove(usua);
                _context.SaveChanges();
            }
        }

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
        }

        public clsUsuario consultarPorNombre(string nombre)
        {
            return _context.usuario
                .FirstOrDefault(u => u.nombre_usuario.Trim().ToUpper() == nombre.Trim().ToUpper());
        }

        public List<clsUsuario> consultarTodos()
        {
            using var context = new dbContextINA();
            { 
                return context.usuario.Include(u => u.persona).ToList();
            }
            //return _context.usuario.ToList();
        }
    }
}
