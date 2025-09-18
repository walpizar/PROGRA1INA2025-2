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
            throw new NotImplementedException();
        }

        public void modificar(clsDonacion entidad)
        {
            context.donacion.Update(entidad);
            context.SaveChanges();
        }
    }
}
