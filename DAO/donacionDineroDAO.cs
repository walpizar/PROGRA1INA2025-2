using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class donacionDineroDAO : IGenerica<clsDonacionDinero>
    {
        //inicio  el contexto
        dbContextINA dbContextINA;

        public donacionDineroDAO()
        {
            dbContextINA = new dbContextINA();
        }
        //metodo de consultar por ID
        public clsDonacionDinero consultarPorID(string id)
        {
            return dbContextINA.donacionesDinero.FirstOrDefault(d => d.idDonacionDinero.ToString() == id);
        }

        //no se implementa consultar por nombre
        public clsDonacionDinero consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        //metodo de consultar todos
        public List<clsDonacionDinero> consultarTodos()
        {
            return dbContextINA.donacionesDinero.ToList();
        }

        //metodo de crear
        public void crear(clsDonacionDinero entidad)
        {
            dbContextINA.donacionesDinero.Add(entidad);
            dbContextINA.SaveChanges();
        }

        public void eliminar(string id)
        {
            //dbContextINA.donacionesDinero.Remove(consultarPorID(id));
            //dbContextINA.SaveChanges();

            //borrado logico
            var donacionBorrar = consultarPorID(id);
            if (donacionBorrar != null)
            {
                donacionBorrar.estado = false; //marcar como inactivo
                //ASIGNO DATOS DE AUDITORIA: MODIFICACION
                donacionBorrar.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
                donacionBorrar.fechaModificacion = DateTime.Now;
                donacionBorrar.razonInactivo = "ELIMINACION LOGICA";//estos tengo que traerlo desde frm cuando quiera borrar una donacion

                //actualizo la donacion con el estado en false
                dbContextINA.donacionesDinero.Update(donacionBorrar);
                dbContextINA.SaveChanges();
            }
            
        }

        public void modificar(clsDonacionDinero entidad)
        {
            //hago el update
            dbContextINA.donacionesDinero.Update(entidad);
            dbContextINA.SaveChanges();

        }
    }
}
