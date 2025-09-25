using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class EmailExistDBExeption : Exception
    {
        public EmailExistDBExeption() : base("Ya existe otra persona con ese correo. NO puede ser el mismo.") { }
        public EmailExistDBExeption(string mensaje) : base(mensaje) { }
    }
}
