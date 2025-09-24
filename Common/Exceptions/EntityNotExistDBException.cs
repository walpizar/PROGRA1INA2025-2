using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class EntityNotExistDBException : Exception
    {
        public EntityNotExistDBException() : base("La entidad no existe en la base de datos.") { }
        public EntityNotExistDBException(string mensaje) : base(mensaje) { }
    }
}
