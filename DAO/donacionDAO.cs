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
           return context.Donaciones.SingleOrDefault(d => d.IdDonacion == id);
        }

        public clsDonacion consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonacion> consultarTodos()
        {
            return context.Donaciones.ToList();
        }

        public void crear(clsDonacion entidad)
        {
            context.Donaciones.Add(entidad);
            context.SaveChanges();

        }

        public void eliminar(int id)
        {
            context.Donaciones.Remove(consultarPorID(id));
            context.SaveChanges();
        }

        public void modificar(clsDonacion entidad)
        {
            context.Donaciones.Update(entidad);
            context.SaveChanges();
        }
    }
}
