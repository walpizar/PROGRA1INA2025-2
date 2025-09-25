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
    public class VisitasDAO : IGenerica<clsVisitasDomiciliares>
    {
        private readonly dbContextINA _context;

        public VisitasDAO()
        {
            _context = new dbContextINA();
        }

        public void crear(clsVisitasDomiciliares entidad)
        {
            _context.visitasDomiciliares.Add(entidad);
            _context.SaveChanges();
        }

        public void modificar(clsVisitasDomiciliares entidad)
        {
            _context.visitasDomiciliares.Update(entidad);
            _context.SaveChanges();
        }

        public void eliminar(int id)
        {
            var visita = consultarPorID(id);
            if (visita != null)
            {
                _context.visitasDomiciliares.Remove(visita);
                _context.SaveChanges();
            }
        }

        public void eliminar(string id)
        {
        }

        public clsVisitasDomiciliares consultarPorID(int id)
        {
            return null;
        }

        public clsVisitasDomiciliares consultarPorID(string id)
        {
            return null;
        }

        public clsVisitasDomiciliares consultarPorNombre(string nombre)
        {
            return null;
        }

        public List<clsVisitasDomiciliares> consultarTodos()
        {
            return _context.visitasDomiciliares.ToList();
        }

        //MAGIBER PARA ACCEDER A LA TB DE PERSONA
        public bool existePersonaPorNombre(string nombre)//SERIA MAS FACIL SI HUBIERA UNA RELACION 1 A 1 CON PACIENTE
        {
            var nombreNormalizado = nombre.Trim().ToLower();

            return _context.persona.Any(p =>
                ((p.nombre ?? "").Trim().ToLower() + " " +
                 (p.apellido1 ?? "").Trim().ToLower() + " " +
                 (p.apellido2 ?? "").Trim().ToLower()).Trim()
                 == nombreNormalizado);
        }
        public string consultarDireccion(string nombreCompleto)
        {
            var nombreNormalizado = nombreCompleto.Trim().ToLower();

            var persona = _context.persona
                .FirstOrDefault(p =>
                    ((p.nombre ?? "").Trim().ToLower() + " " +
                     (p.apellido1 ?? "").Trim().ToLower() + " " +
                     (p.apellido2 ?? "").Trim().ToLower()).Trim()
                     == nombreNormalizado);

            return persona?.direccion;
        }
        public string consultarTelefono(string nombreCompleto)
        {
            var nombreNormalizado = nombreCompleto.Trim().ToLower();

            var persona = _context.persona
                .FirstOrDefault(p =>
                    ((p.nombre ?? "").Trim().ToLower() + " " +
                     (p.apellido1 ?? "").Trim().ToLower() + " " +
                     (p.apellido2 ?? "").Trim().ToLower()).Trim()
                     == nombreNormalizado);

            return persona?.telefono;
        }
    }
}