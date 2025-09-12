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
            return _context.Paciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.Persona)//esto es para traer los datos de la tabla persona que esta relacionada con paciente
                .Where(p => p.id == id).SingleOrDefault();

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
            return _context.Paciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.Persona)//esto es para traer los datos de la tabla persona que esta relacionada con paciente
                .ToList();

        }


        //crear un paciente
        public void crear(clsPaciente paciente)
        {
            //valido si lapersona existe
            if (paciente.Persona != null)
            {
                //asigno la persona encontrada a la variable personaExistente
                var personaExistente = _context.Personas
                    .FirstOrDefault(p => p.id == paciente.Persona.id && p.tipoId == paciente.Persona.tipoId);

                //si persona no existe 
                if (personaExistente == null)
                {
                    //si no existe, agregarla
                    _context.Personas.Add(paciente.Persona);
                }
                else
                {
                    //si existe, usar la existente, es decir no agrega nada a tbPersona y usa esa persona de referencia al insertar en tbPaciente
                    paciente.Persona = personaExistente;
                }

                //luego agrego el paciente
                _context.Paciente.Add(paciente);

                //guardo ambos cambios
                _context.SaveChanges();

            }   
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
            //verifico que la persona no sea nula, solo actualizo si la persona viene modificada o existe
            if (paciente.Persona != null)
            {
                //paciente.Persona es la persona que viene modificada del formulario
                _context.Personas.Update(paciente.Persona);
            }
            //modifico el paciente
            _context.Paciente.Update(paciente);
            //y guardo los cambios
            _context.SaveChanges();
        }


    }
}
