using Entities;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class SolicitudApoyoDao
    {
        private readonly dbContextINA _context = new dbContextINA();

        // Crear una nueva solicitud en la base de datos
        public void crear(clsSolicitudApoyo solicitud)
        {
            _context.solicitudApoyo.Add(solicitud);
            _context.SaveChanges();
        }

        // Modificar una solicitud existente
        public void modificar(clsSolicitudApoyo solicitud)
        {
            _context.solicitudApoyo.Update(solicitud);
            _context.SaveChanges();
        }

        // Eliminar una solicitud por ID
        public void eliminar(String id)
        {

        }

        // Consultar una solicitud por ID
        public clsSolicitudApoyo consultarPorID(string id)
        {
            return _context.solicitudApoyo.FirstOrDefault(s => s.idSolicitud == id);
        }

        // Consultar todas las solicitudes
        public List<clsSolicitudApoyo> consultarTodos()
        {
            return _context.solicitudApoyo.ToList();
        }

        // Consultar solicitudes por paciente
        public List<clsSolicitudApoyo> consultarPorPaciente(string idPaciente, int tipoIdPaciente)
        {
            return _context.solicitudApoyo
                           .Where(s => s.idPaciente == idPaciente && s.tipoIdPaciente == tipoIdPaciente)
                           .ToList();
        }

    }
}
