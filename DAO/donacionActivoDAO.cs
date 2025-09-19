using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAO
{
    public class donacionActivoDAO : IGenerica<clsDonacionActivo>
    {
        //inicio  el contexto
        dbContextINA dbContextINA;

        public donacionActivoDAO()
        {
            dbContextINA = new dbContextINA();
        }
        public clsDonacionActivo consultarPorID(string id)
        {
            return dbContextINA.donacionesActivos.FirstOrDefault(d => d.idDonacionActivo.ToString() == id);
        }

        public clsDonacionActivo consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonacionActivo> consultarTodos()
        {
            return dbContextINA.donacionesActivos.ToList();
        }

        public void crear(clsDonacionActivo entidad)
        {
            dbContextINA.donacionesActivos.Add(entidad);
            dbContextINA.SaveChanges();
        }

        public void eliminar(string id)
        {
            //dbContextINA.donacionesActivos.Remove(consultarPorID(id));
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

                //actualizo la donacion
                dbContextINA.donacionesActivos.Update(donacionBorrar);
                dbContextINA.SaveChanges();
            }
        }

        public void modificar(clsDonacionActivo entidad)
        {
            dbContextINA.donacionesActivos.Update(entidad);
            dbContextINA.SaveChanges();
        }
    }
}
