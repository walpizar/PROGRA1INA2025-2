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
            //DEVUELVO LA DONACION QUE COINCIDA CON EL ID E INCLUYO EL DONANTE Y TIPO DE DONACION
            return context.donacion
                .Include(d => d.donante)
                .Include(d => d.tipoDonacion)
                .Include(d => d.activos) //incluyo los activos relacionados
                .Where(d => d.idDonacion.ToString() == id)
                .FirstOrDefault();
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
            return context.donacion
                .Include(d => d.donante)
                .Include(d => d.tipoDonacion)
                .Include(d => d.activos)
                .ToList();
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
