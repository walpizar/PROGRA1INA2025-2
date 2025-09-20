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
    //Implemento la interfaz generica para obligar a tener su estructura mas lo que quiera agregar propio de esta clase
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
            return _context.paciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.persona)//esto es para traer los datos de la tabla persona que esta relacionada con paciente
                .Where(p => p.id == id).SingleOrDefault();

        }


        //consultar todos los pacientes
        public List<clsPaciente> consultarTodos()
        {
            //retorno todos los pacientes de la tabla paciente
            //el include es para traer los datos de la tabla persona que esta relacionada con paciente
            return _context.paciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.persona)//esto es para traer los datos de la tabla persona que esta relacionada con paciente
                .Where(p => p.estado == true) //solo los activos
                .ToList();

        }

        //consultar por correo
        public clsPaciente consultarPorCorreo(string email)
        {
            //retorno una esxpresion lambda que busca en la tabla paciente el email que le paso por parametro
            return _context.paciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.persona)//esto es para traer los datos de la tabla persona que esta relacionada con paciente
                .Where(p => p.persona.email == email).SingleOrDefault();
        }

        //consultar por telefono
        public clsPaciente consultarPorTelefono(string telefono)
        {
            //retorno una esxpresion lambda que busca en la tabla paciente el telefono que le paso por parametro
            return _context.paciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.persona)//esto es para traer los datos de la tabla persona que esta relacionada con paciente
                .Where(p => p.persona.telefono == telefono).SingleOrDefault();
        }

        public List<clsPaciente> consultarTodosInactivos()
        {
            //retorno todos los pacientes inactivos de la tabla paciente
            //el include es para traer los datos de la tabla persona que esta relacionada con paciente
            return _context.paciente
                .AsNoTracking()//esto es para que no haga seguimiento de los cambios en los objetos, mejora el rendimiento en consultas de solo lectura
                .Include(p => p.persona)//esto es para traer los datos de la tabla persona que esta relacionada con paciente
                .Where(p => p.estado == false) //solo los inactivos
                .ToList();
        }


        //crear un paciente
        public void crear(clsPaciente paciente)
        {
            //valido si lapersona existe
            if (paciente.persona != null)
            {
                //asigno la persona encontrada a la variable personaExistente
                var personaExistente = _context.persona
                    .FirstOrDefault(p => p.id == paciente.persona.id && p.tipoId == paciente.persona.tipoId);

                //si persona no existe 
                if (personaExistente == null)
                {
                    //si no existe, agregarla
                    _context.persona.Add(paciente.persona);
                }
                else
                {
                    //si existe la persona, variable para almacenar si hubo cambios
                    bool haycambios = false;

                    //valido si el email guardado es diferente al de crear paciente, que entre al if
                    //el StringComparison.OrdinalIgnoreCase es para comparar letra (valor) por letra ignorando mayusculas o minusculas
                    if (!string.Equals(personaExistente.email, paciente.persona.email, StringComparison.OrdinalIgnoreCase))
                    {
                        //aqui le digo dele prioridad al email de crear paciente
                        personaExistente.email = paciente.persona.email;
                        //cambio a true
                        haycambios = true;
                    }

                    //valido si la dirrecion guardada en persona es diferente al de crear paciente que entre al if
                    if (!string.Equals(personaExistente.direccion, paciente.persona.direccion, StringComparison.OrdinalIgnoreCase))
                    {
                        //aqui le digo dele prioridad a la direccion de crear paciente
                        personaExistente.direccion = paciente.persona.direccion;
                        //cambio a true
                        haycambios = true;
                    }

                    //valido si el telef guardado en persona es diferente al de crear paciente que entre al if
                    if (!string.Equals(personaExistente.telefono, paciente.persona.telefono, StringComparison.OrdinalIgnoreCase))
                    {
                        //aqui le digo dele prioridad al telefono de crear paciente
                        personaExistente.telefono = paciente.persona.telefono;
                        //cambio a true
                        haycambios = true;
                    }

                    //si hubo cambios que entre y actualice en los campos de tbPersona
                    if (haycambios)
                    {
                        //actualice
                        _context.persona.Update(personaExistente);
                    }

                    //si existela persona que use esa de referencia, es decir no agrega nada a tbPersona a menos que tenga que actualizar arriba
                    //y usa esa persona de referencia al insertar en tbPaciente
                    paciente.persona = personaExistente;
                }

                //luego agrego el paciente
                _context.paciente.Add(paciente);

                //guardo ambos cambios
                _context.SaveChanges();

            }   
        }


        //eliminar un paciente para cumplir con interfaz
        public void eliminar(string id)
        {
            //devuelvo una excepcion de metodo no implementado
            throw new NotImplementedException();
            /*
            //primero busco el paciente por id y lo guardo en la variable pacient
            var pacient = consultarPorID(id);
            //luego lo elimino
            _context.paciente.Remove(pacient);
            //y guardo los cambios
            _context.SaveChanges();
            */
        }


        //modificar un paciente
        public void modificar(clsPaciente paciente)
        {
            //verifico que la persona no sea nula, solo actualizo si la persona viene modificada o existe
            if (paciente.persona != null)
            {
                //paciente.Persona es la persona que viene modificada del formulario
                _context.persona.Update(paciente.persona);
            }
            //modifico el paciente
            _context.paciente.Update(paciente);
            //y guardo los cambios
            _context.SaveChanges();
        }

        //metodo para reactivar un paciente
        public void reactivarPaciente(string id)
        {
            //primero busco el paciente por id y lo guardo en la variable pacient
            var pacienteExist = consultarPorID(id);

            if (pacienteExist != null)
            {
                pacienteExist.fecha_ult_mod = DateTime.Now;
                pacienteExist.usuario_ult_mod = "Jumira"; //X mientras luego lo cambio por el usuario logueado

                //luego cambio su estado a true
                pacienteExist.estado = true;
                //actualizo el paciente
                _context.paciente.Update(pacienteExist);
                //y guardo los cambios
                _context.SaveChanges();
            }
           
        }

        //METODO NO IMPLEMENTADO pero para cumplir con la interfaz
        public clsPaciente consultarPorNombre(string nombre)
        {
            //devuelvo una excepcion de metodo no implementado
            throw new NotImplementedException();
        }


    }
}
