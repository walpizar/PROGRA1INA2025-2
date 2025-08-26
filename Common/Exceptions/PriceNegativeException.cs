using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class PriceNegativeException: Exception
    { 
   
        public PriceNegativeException() : base("El precio no puede ser negativo") { }
        public PriceNegativeException(string mensaje) : base(mensaje) { }
    }
}
