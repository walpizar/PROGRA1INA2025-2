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
        public clsDonacionDinero consultarPorID(string id)
        {
            return dbContextINA.donacionesDinero.FirstOrDefault(d => d.idDonacionDinero.ToString() == id);
        }

        public clsDonacionDinero consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public List<clsDonacionDinero> consultarTodos()
        {
            return dbContextINA.donacionesDinero.ToList();
        }

        public void crear(clsDonacionDinero entidad)
        {
            dbContextINA.donacionesDinero.Add(entidad);
            dbContextINA.SaveChanges();
        }

        public void eliminar(string id)
        {
            dbContextINA.donacionesDinero.Remove(consultarPorID(id));
            dbContextINA.SaveChanges();
        }

        public void modificar(clsDonacionDinero entidad)
        {
            dbContextINA.donacionesDinero.Update(entidad);
            dbContextINA.SaveChanges();
        }
    }
}
