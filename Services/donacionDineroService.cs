using Common;
using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Common.Exceptions;

namespace Services
{
    public class donacionDineroService : IGenerica<clsDonacionDinero>
    {
        //llamado al DAO
        donacionDineroDAO donacionDineroDAO;
        public donacionDineroService()
        {
            //instancio el DAO
            donacionDineroDAO = new donacionDineroDAO();
        }

        //metodo consultar por ID
        public clsDonacionDinero consultarPorID(string id)
        {
            return donacionDineroDAO.consultarPorID(id);
        }

        //no se implementa consultar por nombre
        public clsDonacionDinero consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        //metodo consultar todos
        public List<clsDonacionDinero> consultarTodos()
        {
            return donacionDineroDAO.consultarTodos();
        }

        public void crear(clsDonacionDinero entidad)
        {
            //valido que exista la donacionDinero
            var donacionDineroExistente = donacionDineroDAO.consultarPorID(entidad.idDonacionDinero.ToString());
            if (donacionDineroExistente != null)
            {
                throw new EntityExistDBException("LA DONACION DE DINERO YA EXISTE EN LA BASE DE DATOS, " +
                    " PARA MODIFICAR DATOS USE EL MODULO APROPIADO");
            }

            //ASIGNO DATOS DE AUDITORIA: REGISTRO
            entidad.fechaCreacion = DateTime.Now;
            entidad.usuarioCreacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
            entidad.estado = true;

            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.fechaModificacion = entidad.fechaCreacion; //ES LA PRIMERA VEZ QUE SE CREA
            entidad.usuarioModificacion = entidad.usuarioCreacion;//ES LA PRIMERA VEZ QUE SE CREA

            //si pasa la validacion, se crea la donacionDinero
            donacionDineroDAO.crear(entidad);


        }

        public void eliminar(string id)
        {
            //valido que exista la donacionDinero
            var donacionDineroExistente = donacionDineroDAO.consultarPorID(id);
            if (donacionDineroExistente == null)
            {
                throw new EntityNotFoundDBException("LA DONACION DE DINERO NO EXISTE EN LA BASE DE DATOS, " +
                    " NO SE PUEDE ELIMINAR");
            }

            //si pasa la validacion, se elimina la donacionDinero
            donacionDineroDAO.eliminar(id);
        }

        public void modificar(clsDonacionDinero entidad)
        {
            //valido que exista la donacionDinero
            var donacionDineroExistente = donacionDineroDAO.consultarPorID(entidad.idDonacionDinero.ToString());
            if (donacionDineroExistente == null)
            {
                throw new EntityNotFoundDBException("LA DONACION DE DINERO NO EXISTE EN LA BASE DE DATOS, " +
                    " NO SE PUEDE MODIFICAR");
            }

            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
            entidad.fechaModificacion = DateTime.Now;
            entidad.razonModifica = "MODIFICACION DE DATOS";//estos tengo que traerlo desde frm cuando quiera modificar una donacion

            //modifico los datos de la donacionDinero
            donacionDineroDAO.modificar(entidad);

        }
    }
}
