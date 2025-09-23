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


        //consultar todos los pacientes activos
        public List<clsPaciente> consultarTodos()
        {
            //llamo al metodo consultarTodos del dao para que me devuelva todos los pacientes activos
            return _pacientDao.consultarTodos();
        }

        //consultar por correo
        public clsPaciente consultarPorCorreo(string email)
        {
            //llamo al metodo consultarPorCorreo del dao para que me devuelva el paciente por correo
            return _pacientDao.consultarPorCorreo(email);
        }

        //consultar por telefono
        public clsPaciente consultarPorTelefono(string telefono)
        {
            //llamo al metodo consultarPorTelefono del dao para que me devuelva el paciente por telefono
            return _pacientDao.consultarPorTelefono(telefono);
        }


        //consultar todos los pacientes inactivos
        public List<clsPaciente> consultarTodosInactivos()
        {
            //llamo al metodo consultarTodosInactivos del dao para que me devuelva todos los pacientes inactivos
            return _pacientDao.consultarTodosInactivos();
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

            paciente.estado = true; //por defecto el paciente se crea activo
            paciente.persona.estado = true; //por defecto la persona se crea activa

            //valido que no exista un paciente con el mismo id (cedula)
            if (_pacientDao.consultarPorID(paciente.id) != null)
            {
                throw new EntityExistDBException();
            }

            //valido que no tenga el mismo correo que otro paciente(email unico)
            if (_pacientDao.consultarPorCorreo(paciente.persona.email) != null)
            {
                throw new EmailExistDBExeption();
            }

            //valido que el telefono no se repita si ya existe otro paciente con ese telefono
            if ( _pacientDao.consultarPorTelefono(paciente.persona.telefono) != null)
            {
                throw new PhoneExistDBExeption();
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
            //obtengo el paciente existente
            var pacienteExistente = _pacientDao.consultarPorID(id);

            //validar que el paciente exista
            if (pacienteExistente == null)
            {
                //si no existe lanzo una excepcion personalizada
                throw new EntityNotExistDBException();
            }

            pacienteExistente.estado = false; //cambio el estado a false para eliminarlo logicamente
            pacienteExistente.fecha_ult_mod = DateTime.Now; //actualizo la fecha de ultima modificacion
            pacienteExistente.usuario_ult_mod = "Jumira"; //X mientras luego lo cambio por el usuario logueado

            //llamo al metodo modificar del dao para que me modifique el paciente en vez de eliminarlo fisicamente(borrado logico)
            _pacientDao.modificar(pacienteExistente);

            //llamo al metodo eliminar del dao para que me elimine el paciente
            //_pacientDao.eliminar(id);

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

            paciente.estado = true; //por defecto el paciente se modificado se mantiene activo
            paciente.persona.estado = true;

            //valido que el correo no se repita si ya existe otro paciente con ese correo y no es el mismo paciente
            var pacienteConMismoCorreo = _pacientDao.consultarPorCorreo(paciente.persona.email);
            if (pacienteConMismoCorreo != null && pacienteConMismoCorreo.id != paciente.id)
            {
                throw new EmailExistDBExeption();
            }

            //valido que el telefono no se repita si ya existe otro paciente con ese telefono y no es el mismo paciente
            var pacienteConMismoTelefono = _pacientDao.consultarPorTelefono(paciente.persona.telefono);
            if (pacienteConMismoTelefono != null && pacienteConMismoTelefono.id != paciente.id)
            {
                throw new PhoneExistDBExeption();
            }

            //validar fechas de auditoria que no sean futuras
            if (paciente.fecha_crea > DateTime.Now || paciente.fecha_ult_mod > DateTime.Now)
            {
                //mensaje de error personalizado
                throw new DateAuiditException();
            }

            //llamo al metodo modificar del dao para que me modifique el paciente
            _pacientDao.modificar(paciente);
        }

        //metodo reactivar del service dnd llamo al de dao
        public void reactivar(string id)
        {
            //obtengo el paciente existente
            var pacienteExistente = _pacientDao.consultarPorID(id);

            //valido que el paciente exista
            if (pacienteExistente == null)
            {
                //si no existe lanzo una excepcion personalizada
                throw new EntityNotExistDBException();
            }
            //valido que el paciente no este activo
            if (pacienteExistente.estado == true)
            {
                //si el paciente ya esta activo lanzo una excepcion personalizada
                throw new EntityActiveDBExeption();
            }

            //llamo al metodo reactivar del dao para que me reactive el paciente
            _pacientDao.reactivarPaciente(id);
        }


        //METODO NO IMPLEMENTADO pero para cumplir con la interfaz
        public clsPaciente consultarPorNombre(string nombre)
        {
            //devuelvo una excepcion de metodo no implementado
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public clsPaciente consultarPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
