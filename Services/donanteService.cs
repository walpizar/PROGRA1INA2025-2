using Common.Interfaces; 
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Microsoft.IdentityModel.Tokens;
using Common.Exceptions;

namespace Services
{
    public class donanteService : IGenerica<clsDonante>
    {
        //inicio DAO
        donanteDAO donanteDAO;

        public donanteService()
        {
            donanteDAO = new donanteDAO();
        }

        public clsDonante consultarPorID(string id)
        {
            return donanteDAO.consultarPorID(id);
        }

        public clsDonante consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsDonante consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonante> consultarTodos()
        {
            return donanteDAO.consultarTodos();
        }

        public void crear(clsDonante entidad)
        {
            //validar si el donante ya existe
            var donanteExistente = donanteDAO.consultarPorID(entidad.personaId.ToString());
            if (donanteExistente != null)
            {
                throw new EntityExistDBException("EL DONANTE YA EXISTE EN LA BASE DE DATOS, " +
                    " PARA MODIFICAR DATOS USE EL MODULO APROPIADO");
            }
            
            //ASIGNO DATOS DE AUDITORIA: REGISTRO
            entidad.fechaRegistro = DateTime.Now;
            entidad.usuarioRegistro = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
            entidad.estado = true;

            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.fechaModificacion = entidad.fechaRegistro; //ES LA PRIMERA VEZ QUE SE CREA
            entidad.usuarioModificacion = entidad.usuarioRegistro;//ES LA PRIMERA VEZ QUE SE CREA

            //si pasa la validacion, se crea el donante
            donanteDAO.crear(entidad);


        }

        public void eliminar(string id)
        {
            //VALIDAR SI EL DONANTE EXISTE
            var donanteExistente = donanteDAO.consultarPorID(id);
            if (donanteExistente == null) {
                
                throw new EntityNotFoundDBException("EL DONANTE NO EXISTE EN LA BASE DE DATOS, " +
                    " NO SE PUEDE ELIMINAR");
                //no pongo datos de auditoria porque no se pueden setear aca los datos nuevos
            }

            //SI PASA LA VALIDACION, SE ELIMINA EL DONANTE
            donanteDAO.eliminar(id);

        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsDonante entidad)
        {
            //VALIDAR SI EL DONANTE EXISTE
            var donanteExistente = donanteDAO.consultarPorID(entidad.personaId.ToString());
            if (donanteExistente == null)
            {
                throw new EntityNotFoundDBException("EL DONANTE NO EXISTE EN LA BASE DE DATOS, " +
                    " PARA CREARLO USE EL MODULO APROPIADO");
            }

            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.fechaModificacion = DateTime.Now;
            entidad.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
            entidad.razonModifica = "MODIFICACION DE DATOS";//estos tengo que traerlo desde frm cuando quiera modificar un donante

            //SI PASA LA VALIDACION, SE MODIFICA EL DONANTE
            donanteDAO.modificar(entidad);
        }
    }
}
