using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class donacionDAO : IGenerica<clsDonacion>
    {
        //inicio  el contexto
        dbContextINA context ;
        public donacionDAO() 
        { 
            context = new dbContextINA(); 
        }

        public clsDonacion consultarPorID(string id)
        {
            return context.donacion.FirstOrDefault(d => d.idDonacion.ToString() == id);
        }

        public clsDonacion consultarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public clsDonacion consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonacion> consultarTodos()
        {
            return context.donacion.ToList();
        }

        public void crear(clsDonacion entidad)
        {
            context.donacion.Add(entidad);
            context.SaveChanges();

        }

        public void eliminar(string id)
        {
            //borrado logico
            var donacionBorrar = consultarPorID(id);
            if (donacionBorrar != null)
             {
                donacionBorrar.estado = false; //marcar como inactivo

                //ASIGNO DATOS DE AUDITORIA: MODIFICACION
                donacionBorrar.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
                donacionBorrar.fechaModificacion = DateTime.Now;
                donacionBorrar.razonInactivo = "ELIMINACION LOGICA";//estos tengo que traerlo desde frm cuando quiera borrar una donacion

                context.donacion.Update(donacionBorrar);
                context.SaveChanges();
            }

        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void modificar(clsDonacion entidad)
        {
            context.donacion.Update(entidad);
            context.SaveChanges();
        }
    }
}
