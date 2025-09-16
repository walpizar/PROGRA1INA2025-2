using Common.Exceptions;
using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    //Implemento la interfaz generica para obligar a tener su estructura mas lo que quiera agregar propio de esdta clase
    public class PacienteService : IGenerica<clsPaciente> 
    {
        //declaro dao para ir de la capa de servicios a la capa de dao
        private readonly PacienteDao _pacientDao;

        public PacienteService()
        {
            // y aqui lo instancio
            _pacientDao = new PacienteDao();
        }


        //CRUD de pacientes
        public clsPaciente consultarPorID(string id)
        {
            //llamo al metodo consultarPorID del dao para que me devuelva el paciente
            return _pacientDao.consultarPorID(id);
        }


        //consultar todos los pacientes
        public List<clsPaciente> consultarTodos()
        {
            //llamo al metodo consultarTodos del dao para que me devuelva todos los pacientes
            return _pacientDao.consultarTodos();
        }


        //crear un paciente
        public void crear(clsPaciente paciente)
        {

            // Asignar fechas de auditoría automáticamente
            paciente.fecha_crea = DateTime.Now;
            paciente.fecha_ult_mod = DateTime.Now;

            // Asignar usuario de auditoría automáticamente
            paciente.usuario_crea = "Jumira"; //X mientras luego lo cambio por el usuario logueado
            paciente.usuario_ult_mod = "Jumira"; //X mientras luego lo cambio por el usuario logueado


            //valido que no exista un paciente con el mismo id (cedula)
            if (_pacientDao.consultarPorID(paciente.id) != null)
            {
                throw new EntityExistDBException();
            }


            //valido que el telefono no se repita si ya existe
            var pacientesExistentes = _pacientDao.consultarTodos();
            //el Any es para validar si algun elemento de la lista cumple la condicion
            if (pacientesExistentes.Any(p => p.persona.telefono == paciente.persona.telefono))
            {
                throw new EntityExistDBException("El teléfono ya está registrado para otro paciente, NO puede ser el mismo.");
            }


            //validar fechas de auditoria que no sean futuras
            if (paciente.fecha_crea > DateTime.Now || paciente.fecha_ult_mod > DateTime.Now)
            {
                //mensaje de error personalizado
                throw new DateAuiditException();
            }

            //llamo al metodo crear del dao para que me cree el paciente
            _pacientDao.crear(paciente);
        }


        //eliminar un paciente
        public void eliminar(string id)
        {
            //validar que el paciente exista
            if (_pacientDao.consultarPorID(id) == null)
            {
                //si no existe lanzo una excepcion personalizada
                throw new EntityNotExistDBException();
            }

            //llamo al metodo eliminar del dao para que me elimine el paciente
            _pacientDao.eliminar(id);

        }


        //modificar un paciente
        public void modificar(clsPaciente paciente)
        {
            //validar que el paciente exista
            if (_pacientDao.consultarPorID(paciente.id) == null)
            {
                //si no existe lanzo una excepcion personalizada
                throw new EntityNotExistDBException();
            }

            // Asignar fecha de última modificación automáticamente
            paciente.fecha_ult_mod = DateTime.Now;

            // Asignar usuario de última modificación automáticamente
            paciente.usuario_ult_mod = "Jumira"; //X mientras luego lo cambio por el usuario logueado

            //validar fechas de auditoria que no sean futuras
            if (paciente.fecha_crea > DateTime.Now || paciente.fecha_ult_mod > DateTime.Now)
            {
                //mensaje de error personalizado
                throw new DateAuiditException();
            }

            //llamo al metodo modificar del dao para que me modifique el paciente
            _pacientDao.modificar(paciente);
        }


        //METODO NO IMPLEMENTADO pero para cumplir con la interfaz
        public clsPaciente consultarPorNombre(string nombre)
        {
            //devuelvo una excepcion de metodo no implementado
            throw new NotImplementedException();
        }


    }
}
