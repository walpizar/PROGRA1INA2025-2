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

        public void crear(clsTiposAyudas tiposAyudas)
        {
            try
            {
                if (tiposAyudas == null)
                {
                    throw new ArgumentNullException("Estas creando un tipo de ayuda que tiene los datos vacios");
                }

                if (string.IsNullOrWhiteSpace(tiposAyudas.nombre))
                {
                    throw new ArgumentException("El nombre del tipo de ayuda no puede estar vacío");
                }

                _tipDao.Crear(tiposAyudas);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el tipo de ayuda", ex);
            }
        }

        public void modificar(clsTiposAyudas tiposAyudas)
        {
            
        }
        




    }
}
