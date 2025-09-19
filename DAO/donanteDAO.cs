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
    public class donanteDAO : IGenerica<clsDonante>
    {
        //llamo  al contexto
        dbContextINA dbContextINA;

        public donanteDAO()
        {
            //inicio  el contexto
            dbContextINA = new dbContextINA();
        }
        //metodo de consultar por ID
        public clsDonante consultarPorID(string id)
        {
            // Incluyo la entidad relacionada 'persona' para cargar sus datos junto con el donante
            return dbContextINA.donante
                .Include(d => d.persona)
                .FirstOrDefault(d => d.personaId.ToString() == id);
        }

        //no se implementa consultar por nombre
        public clsDonante consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        //metodo de consultar todos
        public List<clsDonante> consultarTodos()
        {
            // Incluyo la entidad relacionada 'persona' para cargar sus datos junto con cada donante
            return dbContextINA.donante.Include(d=>d.persona).ToList();
        }

        //metodo de crear
        public void crear(clsDonante entidad)
        {
            // Buscar si la persona existe por clave compuesta
            var personaExistente = dbContextINA.persona
                .FirstOrDefault(p => p.id == entidad.personaId && p.tipoId == entidad.personaTipoId);

            // Si no existe, crear la persona con los datos del donante
            if (personaExistente == null && entidad.persona != null)
            {
                dbContextINA.persona.Add(entidad.persona);
                dbContextINA.SaveChanges();
            }

            // Guardar el donante
            dbContextINA.donante.Add(entidad);
            dbContextINA.SaveChanges();
        }

        //metodo de eliminar
        public void eliminar(string id)
        {
            //elimino el donante resusltado de consultar por ID
           // dbContextINA.donante.Remove(consultarPorID(id));
            //dbContextINA.SaveChanges();

            //USO BORRADO LOGICO
            var donanteAEliminar = consultarPorID(id);
            if (donanteAEliminar != null)
            {
                donanteAEliminar.estado = false; //marco el estado como inactivo
                donanteAEliminar.fechaModificacion = DateTime.Now;
                donanteAEliminar.usuarioModificacion = "SYSTEM"; //esto se debe cambiar por el usuario que este logueado
                donanteAEliminar.razonInactivo = "ELIMINACION LOGICA";//estos tengo que traerlo desde frm cuando quiera borrar un donante

                /*puedo dejarlo por ahora pero la idea es que el formulario
                 pida el motivo si se le da eliminar
                puedo usar el evento click para seleccionar el ente a eliminar y 
                mandarselo a los botones de eliminar y editar
                o puedo usar dobleclick para editar y si le doy en el boton eliminar que se abra 
                un formulario pidiendo la razon*/

                dbContextINA.donante.Update(donanteAEliminar);
                dbContextINA.SaveChanges();
            }
        }

        //metodo de modificar
        public void modificar(clsDonante entidad)
        {
            // Modificar la persona asociada si viene en la entidad
            if (entidad.persona != null)
            {
                dbContextINA.persona.Update(entidad.persona);
            }
           
            // Modificar el donante
            dbContextINA.donante.Update(entidad);
            dbContextINA.SaveChanges();
        }
    }
}
