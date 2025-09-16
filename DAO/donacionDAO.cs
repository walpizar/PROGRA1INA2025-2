using Common.Interfaces;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    internal class donacionDAO : IGenerica<clsDonacion>
    {
        //inicio  el contexto
        dbContextINA context ;
        public donacionDAO() 
        { 
            context = new dbContextINA(); 
        }

        public clsDonacion consultarPorID(int id)
        {
           return context.donacion.SingleOrDefault(d => d.idDonacion == id);
        }

        public clsDonacion consultarPorID(string id)
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

        public void eliminar(int id)
        {
            context.donacion.Remove(consultarPorID(id));
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
