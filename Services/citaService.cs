using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Common.Interfaces;
using DAO;

namespace Services
{
    public class citaService: IGenerica<clsCita>
    {
        private readonly citaDao _citaDao = new citaDao();

        public citaService() {

        }
        public void crear(clsCita cita) { 
         try {
                // Validaciones previas a la creación de la cita
                if (cita == null)
                {
                    throw new ArgumentNullException(nameof(cita), "La cita no puede ser nula.");
                }
                if (cita.idPaciente == null)
                {
                                        throw new ArgumentException("El ID del paciente es obligatorio.");
                }
                if (cita.fechaCita.Date < DateTime.Today)
                    throw new ArgumentException("La fecha de la cita no puede ser anterior al día de hoy.");
                if (cita.horaCita < new TimeSpan(8, 0, 0) || cita.horaCita > new TimeSpan(18, 0, 0))
                    throw new ArgumentException("La cita debe estar dentro del horario laboral (08:00-18:00).");
                if (_citaDao.ExisteCitaPaciente(cita.idPaciente, cita.fechaCita, cita.horaCita))
                    throw new InvalidOperationException("El paciente ya tiene una cita en esa fecha y hora.");
                if (_citaDao.ExisteCitaMedico(cita.idMedico, cita.fechaCita, cita.horaCita))
                    throw new InvalidOperationException("El médico no está disponible en esa fecha y hora.");
                _citaDao.crear(cita);
                
                
         } 
         catch (Exception ex) 
         {
             // Manejo de la excepción (puede ser registro en log, re-lanzar, etc.)
             throw new Exception("Error al crear la cita: " + ex.Message);
            }
        }

        public void modificar(clsCita cita) { 
         throw new NotImplementedException();
        }
        public void eliminar(int id) { 
         throw new NotImplementedException();
        }

        public clsCita consultarPorID(string id) { 
         throw new NotImplementedException();
        }
        public clsCita consultarPorID(int id) { 
         throw new NotImplementedException();
        }

        public List<clsCita> consultarTodos() { 
         throw new NotImplementedException();
        }

        public void eliminar(string id) { 
         throw new NotImplementedException();
        }

        public clsCita consultarPorNombre(string nombre) { 
         throw new NotImplementedException();
        }
    }
}
