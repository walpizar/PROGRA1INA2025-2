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
    public class donacionActivoService : IGenerica<clsDonacionActivo>
    {
        //llamo al DAO
        donacionActivoDAO donacionActivoDAO;
        public donacionActivoService()
        {
            //instancio el DAO
            donacionActivoDAO = new donacionActivoDAO();
        }
        public clsDonacionActivo consultarPorID(string id)
        {
            return donacionActivoDAO.consultarPorID(id);
        }

        //no se implementa consultar por nombre
        public clsDonacionActivo consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonacionActivo> consultarTodos()
        {
            return donacionActivoDAO.consultarTodos();
        }

        public void crear(clsDonacionActivo entidad)
        {
            //validar que no exista la donacionActivo
            var donacionActivoExistente = donacionActivoDAO.consultarPorID(entidad.idDonacionActivo.ToString());
            if (donacionActivoExistente != null)
            {
                throw new Common.Exceptions.EntityExistDBException("LA DONACION DE ACTIVO YA EXISTE EN LA BASE DE DATOS, " +
                    " PARA MODIFICAR DATOS USE EL MODULO APROPIADO");
            }

            //ASIGNO DATOS DE AUDITORIA: REGISTRO
            entidad.fechaCreacion = DateTime.Now;
            entidad.usuarioCreacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
            entidad.estado = true;

            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.fechaModificacion = entidad.fechaCreacion; //ES LA PRIMERA VEZ QUE SE CREA
            entidad.usuarioModificacion = entidad.usuarioCreacion;//ES LA PRIMERA VEZ QUE SE CREA

            //si pasa la validacion, se crea la donacionActivo
            donacionActivoDAO.crear(entidad);

        }

        public void eliminar(string id)
        {
            //valido si existe la donacionActivo
            var donacionActivoExistente = consultarPorID(id);
            if (donacionActivoExistente == null)
            {
                throw new Common.Exceptions.EntityNotFoundDBException("LA DONACION DE ACTIVO NO EXISTE EN LA BASE DE DATOS, " +
                    " PARA ELIMINARLA DEBE CREARLA");
            }

            //si pasa la validacion, se elimina la donacionActivo
            donacionActivoDAO.eliminar(id);
        }

        public void modificar(clsDonacionActivo entidad)
        {
            //valido que exista la donacionActivo
            var donacionActivoExistente = consultarPorID(entidad.idDonacionActivo.ToString());
            if (donacionActivoExistente == null)
            {
                throw new Common.Exceptions.EntityNotFoundDBException("LA DONACION DE ACTIVO NO EXISTE EN LA BASE DE DATOS, " +
                    " PARA MODIFICAR DATOS DEBE CREARLA");
            }

            //ASIGNO DATOS DE AUDITORIA: MODIFICACION
            entidad.fechaModificacion = DateTime.Now;
            entidad.usuarioModificacion = "SYSTEM";//esto se debe cambiar por el usuario que este logueado
            entidad.razonModifica = "MODIFICACION DE DATOS";//estos tengo que traerlo desde frm cuando quiera modificar una donacionActivo

            //si pasa la validacion, se modifica la donacionActivo
            donacionActivoDAO.modificar(entidad);

        }
    }
}
