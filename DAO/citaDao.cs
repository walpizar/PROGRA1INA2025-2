using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Entities;
namespace DAO
{
    public class citaDao : IGenerica<Entities.clsCita>
    {
        private dbContextINA  _context;


        public citaDao()
        {
            _context = new dbContextINA();

        }

        public void crear(clsCita cita)
        {
            _context.cita.Add(cita);
            _context.SaveChanges();
        }

        public void modificar(clsCita cita)
        {
            throw new NotImplementedException();
        }

        public void eliminar(int id)
        {
            throw new NotImplementedException();
        }
        public void eliminar(string id)
        {
            throw new NotImplementedException();
        }

        public clsCita consultarPorID(string id)
        {
            throw new NotImplementedException();
        }
        public clsCita consultarPorID(int id)
        {
            throw new NotImplementedException();
        }
        public List<clsCita> consultarTodos()
        {
            throw new NotImplementedException();
        }
        public clsCita consultarPorNombre(string nombre)
        {
            throw new NotImplementedException();
        }

        public bool ExisteCitaPaciente(string idPaciente, DateTime fechaCita, TimeSpan horaCita)
        {
            return _context.cita.Any(c => c.idPaciente == idPaciente && c.fechaCita.Date == fechaCita.Date && c.horaCita == horaCita);
        }

        public bool ExisteCitaMedico(string idMedico, DateTime fechaCita, TimeSpan horaCita)
        {
           return _context.cita.Any(c => c.idMedico == idMedico && c.fechaCita.Date == fechaCita.Date && c.horaCita == horaCita);
        }
    }
}
