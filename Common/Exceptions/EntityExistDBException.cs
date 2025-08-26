using Common.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class EntityExistDBException: Exception
    {
        public EntityExistDBException() : base("Ya existe la entidad en la base de datos.") { }
        public EntityExistDBException(string mensaje) : base(mensaje) { }
    }
}

