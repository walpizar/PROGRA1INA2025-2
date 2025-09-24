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
    public class AsignacActivoService : IGenerica<clsAsignacionActivosPaciente>
    {
        //creo instancia del dao para ir a la capa de dao
        private readonly AsigActivoDao _asigActivoDao;

        //constructor
        public AsignacActivoService()
        {
            //aqui lo instancio
            _asigActivoDao = new AsigActivoDao();
        }


        public void crear(clsAsignacionActivosPaciente asigActivo)
        {

            //aqui llamo al metodo crear del dao
            _asigActivoDao.crear(asigActivo);
        }

        public void eliminar(int id)
        {
            //obtengo el activo existente
            var asigActivoExistente = _asigActivoDao.consultarPorID(id);

            //valido que el activo exista
            if (asigActivoExistente == null)
            {
                //si no existe lanzo una excepcion personalizada
                throw new EntityNotExistDBException();
            }

            //asigno datos de auditoria
            asigActivoExistente.estado = false; //activo por defecto
            asigActivoExistente.fecha_ult_mod = DateTime.Now;//asigno la fecha actual
            asigActivoExistente.usuario_ult_mod = "Jumira"; //X mientras luego lo cambio por el usuario logueado

            //llamo al metrodo modificar del dao para que me modifique el estado del activo(borrado logico) 
            _asigActivoDao.modificar(asigActivoExistente);
        }

        public clsAsignacionActivosPaciente consultarPorID(int id)
        {
            //llamo al metodo consultarPorID del dao para que me devuelva el activo
            return _asigActivoDao.consultarPorID(id);
        }

        public clsAsignacionActivosPaciente consultarPorID(string id)
        {
            throw new NotImplementedException();
        }

        public clsAsignacionActivosPaciente consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsAsignacionActivosPaciente> consultarTodos()
        {
            throw new NotImplementedException();
        }

        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsAsignacionActivosPaciente entidad)
        {
            throw new NotImplementedException();
        }


    }
}
