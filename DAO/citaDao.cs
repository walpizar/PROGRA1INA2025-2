using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;
using Entities;
namespace DAO
{

        
    public class citaDao : IGenerica<clsCita>
    {
        // Contexto de base de datos

        private dbContextINA  _context;

        // Constructor: inicializa el contexto

        public citaDao()
        {
            _context = new dbContextINA();

        }

        // Crea una nueva cita en la base de datos

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

        // Verifica si un paciente ya tiene una cita en la misma fecha y hora

        public bool ExisteCitaPaciente(string idPaciente, DateTime fechaCita, TimeSpan horaCita)
        {
            return _context.cita.Any(c => c.idPaciente == idPaciente && c.fechaCita.Date == fechaCita.Date && c.horaCita == horaCita);
        }


        public bool ExisteCitaDiaPaciente(string idPaciente, DateTime fechaCita)
        {
            var fechaInicio = fechaCita.Date;
            var fechaFin = fechaInicio.AddDays(1);

            Console.WriteLine($"Buscando citas: Paciente={idPaciente}, FechaInicio={fechaInicio}, FechaFin={fechaFin}");

            return _context.cita.Any(c =>
                c.idPaciente == idPaciente &&
                c.fechaCita >= fechaInicio &&
                c.fechaCita < fechaFin
            );
        }

        // Verifica si un médico ya tiene una cita asignada en la misma fecha y hora

        public bool ExisteCitaMedico(string idMedico, DateTime fechaCita, TimeSpan horaCita)
        {
           return _context.cita.Any(c => c.idMedico == idMedico && c.fechaCita.Date == fechaCita.Date && c.horaCita == horaCita);
        }
    }
}
