using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class DateAuiditException : Exception
    {

        public DateAuiditException() : base("La fecha de creacion o modificacion no pueden ser futuras") { }
        public DateAuiditException(string mensaje) : base(mensaje) { }

    }
}
