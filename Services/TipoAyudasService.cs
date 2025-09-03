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

        public TipoAyudasService(dbPaleativoGarabito context) 
        {
            _tipDao = new TipoAyudaDAO(context);
        }

        public void crear(clsTiposAyudas tiposAyudas, int usuarioActualId)
        {
            try
            {
                //Validar que el objeto creado no sea nulo
                if (tiposAyudas == null)
                {
                    throw new ArgumentNullException("Estas creando un tipo de ayuda que tiene los datos vacios");
                }

                //Validar que el nombre tenga mas de un caracte y no este vacio
                if (string.IsNullOrEmpty(tiposAyudas.nombre)||tiposAyudas.nombre.Length<2)
                {
                    throw new ArgumentNullException("El nombre no puede estar vacio, o tener menos de 2 caracteres");
                }

                //Validar nombres duplicados del tipo de ayuda
                if (_tipDao.ConsultarPorNombre(tiposAyudas.nombre.Trim().ToLower()) != null)
                    throw new ArgumentException("El nombre del tipo de ayuda ya existe");

                // Validar si el responsable existe
                //if (_usuario.ConsultarPorID(tiposAyudas.id_responsable) == null)
                //{
                    //throw new ArgumentException("El responsable especificado no existe");
                //}

                // Validar usuario creador
                //if (_usuario.ConsultarPorID(usuarioActualId) == null) 
                //{
                    //throw new ArgumentException("El usuario creador no existe");
                //}
                    

                // Setear datos de auditoría en Service (no en UI)
                tiposAyudas.fecha_crea = DateTime.Now;
                tiposAyudas.id_usuarioCrea = usuarioActualId;
                tiposAyudas.fecha_ultimaModificacion = DateTime.Now;
                tiposAyudas.id_usuarioUltimaModificacion = usuarioActualId;
                tiposAyudas.estado = true;

                // Si pasa todas las validaciones, crear el tipo de ayuda
                _tipDao.Crear(tiposAyudas);
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
