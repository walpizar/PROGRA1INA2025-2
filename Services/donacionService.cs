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
    public class donacionService : IGenerica<clsDonacion>
    {
        //llamado al DAO
        donacionDAO donacionDAO;
        public donacionService()
        {
            //instancio el DAO
            donacionDAO = new donacionDAO();
        }

        //consultr por ID
        public clsDonacion consultarPorID(string id)
        {
            return donacionDAO.consultarPorID(id);
        }

        //consultar por nombre no se implementa
        public clsDonacion consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        //metodo consultar todos
        public List<clsDonacion> consultarTodos()
        {
            return donacionDAO.consultarTodos();
        }

        public void crear(clsDonacion entidad)
        {
            //validar que la donacion no exista
            var donacionExistente = donacionDAO.consultarPorID(entidad.idDonacion.ToString());
            if (donacionExistente != null)
            {
                throw new EntityExistDBException("LA DONACION YA EXISTE EN LA BASE DE DATOS, " +
                    " PARA MODIFICAR DATOS USE EL MODULO APROPIADO");
            }

            //ASIGNO DATOS DE AUDITORIA: REGISTRO
            entidad.fechaCreacion = DateTime.Now;
            entidad.usuarioCreacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado

            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.fechaModificacion = entidad.fechaCreacion; //ES LA PRIMERA VEZ QUE SE CREA
            entidad.usuarioModificacion = entidad.usuarioCreacion;//ES LA PRIMERA VEZ QUE SE CREA


            //si pasa la validacion, se crea la donacion
            donacionDAO.crear(entidad);
        }

        public void eliminar(string id)
        {
            //validar que la donacion exista
            var donacionExistente = donacionDAO.consultarPorID(id);
            if (donacionExistente == null)
            {
                throw new EntityNotFoundDBException("LA DONACION NO EXISTE EN LA BASE DE DATOS, " +
                    " NO SE PUEDE ELIMINAR");
            }
            
            //si pasa la validacion, se elimina la donacion
            donacionDAO.eliminar(id);
        }

        public void modificar(clsDonacion entidad)
        {
            //validar que la donacion exista
            var donacionExistente = donacionDAO.consultarPorID(entidad.idDonacion.ToString());
            if (donacionExistente == null)
            {
                throw new EntityNotFoundDBException("LA DONACION NO EXISTE EN LA BASE DE DATOS, " +
                    " NO SE PUEDE MODIFICAR");
            }
            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.fechaModificacion = DateTime.Now;
            entidad.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
            entidad.razonModifica = "MODIFICACION DE DATOS";//estos tengo que traerlo desde frm cuando quiera modificar una donacion
            

            //si pasa la validacion, se modifica la donacion
            donacionDAO.modificar(entidad);
        }
    }
}
