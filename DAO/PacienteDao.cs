using Common.Interfaces;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PacienteDao : IGenerica<clsPaciente>
    {
        //declaro dbcontext para conectar con la base de datos
        private dbContextINA _context;


        public PacienteDao()
        {
            //aqui lo instancio
            _context = new dbContextINA();

        }


        //CRUD de pacientes
        public clsPaciente consultarPorID(string id)
        {

            //retorno una esxpresion lambda que busca en la tabla paciente el id que le paso por parametro
            return _context.Paciente.Where(p => p.id == id).SingleOrDefault();

        }


        //METODO NO IMPLEMENTADO pero para cumplir con la interfaz
        public clsPaciente consultarPorNombre(string nombre)
        {
            //devuelvo una excepcion de metodo no implementado
            throw new NotImplementedException();
        }


        //consultar todos los pacientes
        public List<clsPaciente> consultarTodos()
        {
            //retorno todos los pacientes de la tabla paciente
            //el include es para traer los datos de la tabla persona que esta relacionada con paciente
            return _context.Paciente.Include(p => p.Persona).ToList();

        }


        //crear un paciente
        public void crear(clsPaciente paciente)
        {
            //agrego el paciente a la tabla paciente
            _context.Paciente.Add(paciente);
            //y guardo los cambios
            _context.SaveChanges();
        }


        //eliminar un paciente
        public void eliminar(string id)
        {
            //primero busco el paciente por id y lo guardo en la variable pacient
            var pacient = consultarPorID(id);
            //luego lo elimino
            _context.Paciente.Remove(pacient);
            //y guardo los cambios
            _context.SaveChanges();
        }


        //modificar un paciente
        public void modificar(clsPaciente paciente)
        {
            //modifico el paciente
            _context.Paciente.Update(paciente);
            //y guardo los cambios
            _context.SaveChanges();
        }


    }
}
