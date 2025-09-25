using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class PhoneExistDBExeption : Exception
    {
        public PhoneExistDBExeption() : base("Ya existe otra persona con ese numero de telefono. NO puede ser el mismo.") { }
        public PhoneExistDBExeption(string mensaje) : base(mensaje) { }
    }
    
}
