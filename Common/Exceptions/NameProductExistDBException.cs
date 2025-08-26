using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class NameProductExistDBException: Exception
    {
        public NameProductExistDBException() : base("Ya existe un producto con ese nombre") { }
        public NameProductExistDBException(string mensaje) : base(mensaje) { }
    }
}
