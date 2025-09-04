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
    public class EnfermeroService : IGenerica<clsEnfermero>
    {
        private readonly EnfermeroDAO _enfermeroDAO;
        private string _usuarioActual;
        public EnfermeroService(string _usuarioActual = null)
        {
            _enfermeroDAO = new EnfermeroDAO();
            _usuarioActual = _usuarioActual ?? Environment.UserName;
        }

        //Reglas de negocio para crear, eliminar, modificar, consultar enfermeros
        public void crear(clsEnfermero enfermero)
        {
            //El id no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(enfermero.id))
            {
                throw new ArgumentException("Error de servicio: El ID no puede estar vacío.");
            }
            //El tipoId no puede ser nulo o vacio
            if (enfermero.tipoId <= 0)
            {
                throw new ArgumentException("Error de servicio: El tipo de ID no puede ser vacío o nulo.");
            }
            //El nombre no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(enfermero.persona.nombre))
            {
                throw new ArgumentException("Error de servicio: El nombre no puede ser vacío.");
            }
            //El apellido1 no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(enfermero.persona.apellido1))
            {
                throw new ArgumentException("Error de servicio: El primer apellido no puede estar vacío.");
            }
            //El apellido2 no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(enfermero.persona.apellido2))
            {
                throw new ArgumentException(" Error de servicio: El segundo apellido no puede estar vacío.");
            }
            //La fecha de nacimiento no puede ser una fecha futura o nula
            if (enfermero.persona.fechaNac > DateTime.Now)
            {
                throw new ArgumentException("Error de servicio: La fecha de nacimiento no puede ser una fecha futura.");
            }
            //El email no puede ser vacio o nulo
            if (string.IsNullOrWhiteSpace(enfermero.persona.email))
            {
                throw new ArgumentException("Error de servicio: El email no puede estar vacío.");
            }
            //El email debe tener un formato valido
            if (!enfermero.persona.email.Contains("@") || !enfermero.persona.email.Contains(".com"))
            {
                throw new Exception("Error de servicio: El correo no tiene un formato valido");
            }
            //La direccion no puede ser vacia o nula
            if (string.IsNullOrWhiteSpace(enfermero.persona.direccion))
            {
                throw new ArgumentException("Error de servicio: La dirección no puede estar vacía.");
            }
            //La especialidad no puede ser vacia o nula
            if (string.IsNullOrWhiteSpace(enfermero.area))
            {
                throw new ArgumentException("Error de servicio: El area no puede estar vacía.");
            }
            // La especialidad no puede tener mas de 300 caracteres
            if (enfermero.area.Length > 300)
            {
                throw new ArgumentException("Error de servicio: El area no puede tener más de 300 caracteres.");
            }
            // La entidad Persona asociada no puede ser nula
            if (enfermero.persona == null)
            {
                throw new ArgumentException("Error de servicio: La entidad Persona asociada no puede ser nula.");
            }

            //Datos de auditoria
            enfermero.usuario_crea = _usuarioActual;
            enfermero.fecha_crea = DateTime.Now;
            enfermero.usuario_ult_mod = _usuarioActual;
            enfermero.fecha_ult_mod = DateTime.Now;

            // Llamar al DAO para crear al enfermero
            _enfermeroDAO.crear(enfermero);
        }

        public void modificar(clsEnfermero enfermero)
        {
            var enfermeroExistente = _enfermeroDAO.consultarPorID(enfermero.id, enfermero.idPersona);
            try
            {
                // El area no puede ser vacia o nula
                if (string.IsNullOrWhiteSpace(enfermero.area))
                {
                    throw new ArgumentException("Error de servicio: El area no puede estar vacía.");
                }
                //El nombre no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(enfermero.persona.nombre))
                {
                    throw new ArgumentException("Error de servicio: El nombre no puede estar vacío.");
                }
                //El apellido1 no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(enfermero.persona.apellido1))
                {
                    throw new ArgumentException("Error de servicio: El primer apellido no puede estar vacío.");
                }
                //El apellido2 no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(enfermero.persona.apellido2))
                {
                    throw new ArgumentException("Error de servicio: El segundo apellido no puede estar vacío.");
                }
                //La fecha de nacimiento no puede ser una fecha futura o nula
                if (enfermero.persona.fechaNac > DateTime.Now)
                {
                    throw new ArgumentException("Error de servicio: La fecha de nacimiento no puede ser una fecha futura.");
                }
                //El email no puede ser vacio o nulo
                if (string.IsNullOrWhiteSpace(enfermero.persona.email))
                {
                    throw new ArgumentException("Error de servicio: El email no puede estar vacío.");
                }
                //El email debe tener un formato valido
                if (!enfermero.persona.email.Contains("@") || !enfermero.persona.email.Contains(".com"))
                {
                    throw new Exception("Error de servicio: El correo no tiene un formato valido");
                }
                //La direccion no puede ser vacia o nula
                if (string.IsNullOrWhiteSpace(enfermero.persona.direccion))
                {
                    throw new ArgumentException("Error de servicio: La dirección no puede estar vacía.");
                }

                enfermero.usuario_crea = enfermeroExistente.usuario_crea;
                enfermero.fecha_crea = enfermeroExistente.fecha_crea;
                enfermero.usuario_ult_mod = _usuarioActual;
                enfermero.fecha_ult_mod = DateTime.Now;

                // Llamar al DAO para modificar el médico
                _enfermeroDAO.modificar(enfermero);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al modificar al enfermero: {ex.Message}", ex);
            }
        }

        public void eliminar(string id, int tipoId)
        {
            try
            {
                // Validar que el enfermero existe antes de eliminar
                var enfermeroExiste = consultarPorID(id, tipoId);
                if (enfermeroExiste == null)
                    throw new Exception("Error de servicio: El enfermero no existe");

                _enfermeroDAO.eliminar(id, tipoId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al eliminar al enfermero: {ex.Message}", ex);
            }
        }

        public clsEnfermero consultarPorID(string id, int tipoId)
        {
            try
            {
                return _enfermeroDAO.consultarPorID(id, tipoId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al consultar enfermero por ID: {ex.Message}", ex);
            }
        }

        public clsEnfermero consultarPorNombre(string nombre)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(nombre))
                    throw new Exception("Error en servicio: El nombre no puede estar vacío");

                return _enfermeroDAO.consultarPorNombre(nombre);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al consultar el enfermero por nombre: {ex.Message}", ex);
            }
        }

        public List<clsEnfermero> consultarTodos()
        {
            try
            {
                return _enfermeroDAO.consultarTodos();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error en servicio al consultar todos los enfermeros: {ex.Message}", ex);
            }
        }
    }
}
