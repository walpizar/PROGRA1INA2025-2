using Common.Exceptions;
using DAO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class TipoAyudasService
    {
        private readonly TipoAyudaDAO _tipDao;

        public TipoAyudasService() 
        {
            _tipDao = new TipoAyudaDAO();

        }

        public void Crear(clsTiposAyudas tiposAyudas)
        {
            try
            {
                if (tiposAyudas == null)
                    throw new ArgumentNullException(nameof(tiposAyudas), "El objeto tipo de ayuda no puede ser nulo.");

                if (string.IsNullOrWhiteSpace(tiposAyudas.nombre))
                    throw new ArgumentException("El nombre del tipo de ayuda no puede estar vacío");

                if (string.IsNullOrWhiteSpace(tiposAyudas.id_responsable))
                    throw new ArgumentException("Debe asignarse un responsable válido");

                if (string.IsNullOrWhiteSpace(tiposAyudas.id_usuarioCrea))
                    throw new ArgumentException("Debe asignarse el usuario que crea el registro");

                if (string.IsNullOrWhiteSpace(tiposAyudas.id_usuarioUltimaModificacion))
                    throw new ArgumentException("Debe asignarse el usuario de última modificación");

                if (tiposAyudas.fecha_crea == default)
                    tiposAyudas.fecha_crea = DateTime.Now;

                if (tiposAyudas.fecha_ultimaModificacion == default)
                    tiposAyudas.fecha_ultimaModificacion = DateTime.Now;

                if (!tiposAyudas.estado) // Si no lo setearon, lo dejamos activo
                    tiposAyudas.estado = true;

                _tipDao.crear(tiposAyudas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el tipo de ayuda", ex);
            }
        }

        public void modificar(clsTiposAyudas tiposAyudas)
        {
            try
            {
                if (tiposAyudas == null)
                    throw new ArgumentNullException(nameof(tiposAyudas), "El objeto tipo de ayuda no puede ser nulo.");
                if (tiposAyudas.id_tipoAyuda <= 0)
                    throw new ArgumentException("El ID del tipo de ayuda no es válido.");
                var existente = _tipDao.consultarPorID(tiposAyudas.id_tipoAyuda);
                if (string.IsNullOrWhiteSpace(tiposAyudas.nombre))
                    throw new ArgumentException("El nombre del tipo de ayuda no puede estar vacío");
                if (string.IsNullOrWhiteSpace(tiposAyudas.id_responsable))
                    throw new ArgumentException("Debe asignarse un responsable válido");
                if (string.IsNullOrWhiteSpace(tiposAyudas.id_usuarioUltimaModificacion))
                    throw new ArgumentException("Debe asignarse el usuario de última modificación");
                tiposAyudas.fecha_ultimaModificacion = DateTime.Now;
                _tipDao.modificar(tiposAyudas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el tipo de ayuda", ex);
            }

        }

        public void Eliminar(int id)
        {
            try
            {
                if (id <= 0)
                    throw new ArgumentException("El ID del tipo de ayuda no es válido.");
                var existente = _tipDao.consultarPorID(id);
                //if (existente == null)
                    //throw new NotFoundException($"No se encontró un tipo de ayuda con ID {id}.");
                _tipDao.eliminar(id);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el tipo de ayuda", ex);
            }

        }
        public List<clsTiposAyudas> ConsultarTodos()
        {
            return _tipDao.consultarTodos();
        }

        public clsTiposAyudas ConsultarPorID(int id)
        {
            return _tipDao.consultarPorID(id);
        }


    }
}
