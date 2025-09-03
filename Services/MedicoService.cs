using Common.Interfaces;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MedicoService : IGenerica<clsMedico>
    {
        private readonly MedicoDAO _medicoDAO;
        public MedicoService()
        {
            _medicoDAO = new MedicoDAO();
        }

        //Reglas de negocio para crear, eliminar, modificar, consultar medicos
        public void crear(clsMedico medico)
        {
            ValidacionMedico(medico);
            //El id no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(medico.id))
            {
                throw new ArgumentException("Error de servicio: El ID no puede estar vacío.");
            }
            //El tipoId no puede ser nulo o vacio
            if (medico.tipoId <= 0)
            {
                throw new ArgumentException("Error de servicio: El tipo de ID no puede ser vacío o nulo.");
            }
            //El nombre no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(medico.persona.nombre))
            {
                throw new ArgumentException("Error de servicio: El nombre no puede ser vacío.");
            }
            //El apellido1 no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(medico.persona.apellido1))
            {
                throw new ArgumentException("Error de servicio: El primer apellido no puede estar vacío.");
            }
            //El apellido2 no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(medico.persona.apellido2))
            {
                throw new ArgumentException(" Error de servicio: El segundo apellido no puede estar vacío.");
            }
            //La fecha de nacimiento no puede ser una fecha futura o nula
            if (medico.persona.fechaNac > DateTime.Now)
            {
                throw new ArgumentException("Error de servicio: La fecha de nacimiento no puede ser una fecha futura.");
            }
            //El email no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(medico.persona.email))
            {
                throw new ArgumentException("Error de servicio: El email no puede estar vacío.");
            }
            //El email debe tener un formato valido
            if (!medico.persona.email.Contains("@") || !medico.persona.email.Contains(".com"))
            {
                throw new Exception("Error de servicio: El correo no tiene un formato valido");
            }
            //La direccion no puede ser vacia o nula
            if (string.IsNullOrWhiteSpace(medico.persona.direccion))
            {
                throw new ArgumentException("Error de servicio: La dirección no puede estar vacía.");
            }
            //La especialidad no puede ser vacia o nula
            if (string.IsNullOrWhiteSpace(medico.especialidad))
            {
                throw new ArgumentException("Error de servicio: La especialidad no puede estar vacía.");
            }
            // La especialidad no puede tener mas de 300 caracteres
            if (medico.especialidad.Length > 300)
            {
                throw new ArgumentException("Error de servicio: La especialidad no puede tener más de 300 caracteres.");
            }
            // La fecha de creación no puede ser una fecha futura
            if (medico.fecha_crea > DateTime.Now)
            {
                throw new ArgumentException("Error de servicio: La fecha de creación no puede ser una fecha futura.");
            }
            // El usuario de creación no puede ser vacío o nulo
            if (string.IsNullOrWhiteSpace(medico.usuario_crea))
            {
                throw new ArgumentException("Error de servicio: El usuario de creación no puede estar vacío.");
            }
            // El usuario de creación no puede tener más de 100 caracteres
            if (medico.usuario_crea.Length > 100)
            {
                throw new ArgumentException("Error de servicio: El usuario de creación no puede tener más de 100 caracteres.");
            }
            // La fecha de la última modificación no puede ser una fecha futura
            if (medico.fecha_ult_mod > DateTime.Now)
            {
                throw new ArgumentException("Error de servicio: La fecha de la última modificación no puede ser una fecha futura.");
            }
            // El usuario de la última modificación no puede ser vacío o nulo
            if (string.IsNullOrWhiteSpace(medico.usuario_ult_mod))
            {
                throw new ArgumentException("Error de servicio: El usuario de la última modificación no puede estar vacío.");
            }
            // El usuario de la última modificación no puede tener más de 100 caracteres
            if (medico.usuario_ult_mod.Length > 100)
            {
                throw new ArgumentException("Error de servicio: El usuario de la última modificación no puede tener más de 100 caracteres.");
            }
            // La entidad Persona asociada no puede ser nula
            if (medico.persona == null)
            {
                throw new ArgumentException("Error de servicio: La entidad Persona asociada no puede ser nula.");
            }

            // Llamar al DAO para crear el médico
            _medicoDAO.crear(medico);
        }

        public void modificar(clsMedico medico)
        {
            try
            {
                // Validaciones de negocio
                ValidacionMedico(medico);
                // La especialidad no puede ser vacia o nula
                if (string.IsNullOrWhiteSpace(medico.especialidad))
                {
                    throw new ArgumentException("Error de servicio: La especialidad no puede estar vacía.");
                }
                //El nombre no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(medico.persona.nombre))
                {
                    throw new ArgumentException("Error de servicio: El nombre no puede estar vacío.");
                }
                //El apellido1 no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(medico.persona.apellido1))
                {
                    throw new ArgumentException("Error de servicio: El primer apellido no puede estar vacío.");
                }
                //El apellido2 no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(medico.persona.apellido2))
                {
                    throw new ArgumentException("Error de servicio: El segundo apellido no puede estar vacío.");
                }
                //La fecha de nacimiento no puede ser una fecha futura o nula
                if (medico.persona.fechaNac > DateTime.Now)
                {
                    throw new ArgumentException("Error de servicio: La fecha de nacimiento no puede ser una fecha futura.");
                }
                //El email no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(medico.persona.email))
                {
                    throw new ArgumentException("Error de servicio: El email no puede estar vacío.");
                }
                //El email debe tener un formato valido
                if (!medico.persona.email.Contains("@") || !medico.persona.email.Contains(".com"))
                {
                    throw new Exception("Error de servicio: El correo no tiene un formato valido");
                }
                //La direccion no puede ser vacia o nula
                if (string.IsNullOrWhiteSpace(medico.persona.direccion))
                {
                    throw new ArgumentException("Error de servicio: La dirección no puede estar vacía.");
                }


                // Llamar al DAO para modificar el médico
                _medicoDAO.modificar(medico);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al modificar médico: {ex.Message}", ex);
            }
        }

        public void eliminar(string id, int tipoId)
        {
            try
            {
                // Validar que el médico existe antes de eliminar
                var medicoExiste = consultarPorID(id,tipoId);
                if (medicoExiste == null)
                    throw new Exception("Error de servicio: El médico no existe");

                _medicoDAO.eliminar(id,tipoId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al eliminar médico: {ex.Message}", ex);
            }
        }

        public clsMedico consultarPorID(string id, int tipoId)
        {
            try
            {
                return _medicoDAO.consultarPorID(id,tipoId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al consultar médico por ID: {ex.Message}", ex);
            }
        }

        public clsMedico consultarPorNombre(string nombre)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                    throw new Exception("Error en servicio: El nombre no puede estar vacío");

                return _medicoDAO.consultarPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al consultar médico por nombre: {ex.Message}", ex);
            }
        }

        public List<clsMedico> consultarTodos()
        {
            try
            {
                return _medicoDAO.consultarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al consultar todos los médicos: {ex.Message}", ex);
            }
        }

        private void ValidacionMedico(clsMedico medico)
        {
            if (medico.persona == null)
                throw new Exception("Los datos de persona son requeridos");

            if (string.IsNullOrWhiteSpace(medico.persona.nombre))
                throw new Exception("El nombre es requerido");

            if (string.IsNullOrWhiteSpace(medico.persona.apellido1))
                throw new Exception("El primer apellido es requerido");

            if (string.IsNullOrWhiteSpace(medico.persona.apellido2))
                throw new Exception("El segundo apellido es requerido");

            if (string.IsNullOrWhiteSpace(medico.especialidad))
                throw new Exception("La especialidad es requerida");
        }
    }
}
