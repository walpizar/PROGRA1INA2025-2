using Common.Interfaces;
using Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DAO
{
    public class TipoDonacionDAO : IGenerica<clsTipoDonacion>
    {
        dbContextINA context;

        public TipoDonacionDAO()
        {
            context = new dbContextINA();
        }

        public void crear(clsTipoDonacion entidad)
        {
            context.TiposDonacion.Add(entidad);
            context.SaveChanges();
        }

        public void modificar(clsTipoDonacion entidad)
        {
            context.TiposDonacion.Update(entidad);
            context.SaveChanges();
        }

        public void eliminar(string id)
        {
            //borrado logico
            var tipoDonacionBorrar = consultarPorID(id);
            if (tipoDonacionBorrar != null)
            {
                tipoDonacionBorrar.estado = false; //marcar como inactivo

                //ASIGNO DATOS DE AUDITORIA: MODIFICACION
                tipoDonacionBorrar.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
                tipoDonacionBorrar.fechaModificacion = System.DateTime.Now;
                tipoDonacionBorrar.razonInactivo = "ELIMINACION LOGICA";//estos tengo que traerlo desde frm cuando quiera borrar una donacion
                context.TiposDonacion.Update(tipoDonacionBorrar);
                context.SaveChanges();
            }

        }

        public clsTipoDonacion consultarPorID(string id)
        {
            int idInt = int.Parse(id);
            return context.TiposDonacion.Find(idInt);
        }

        public clsTipoDonacion consultarPorNombre(string nombre)
        {
            //no se implementa porque no es necesario 
            throw new System.NotImplementedException();
        }

        public List<clsTipoDonacion> consultarTodos()
        {
            return context.TiposDonacion.ToList();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public clsTipoDonacion consultarPorID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
