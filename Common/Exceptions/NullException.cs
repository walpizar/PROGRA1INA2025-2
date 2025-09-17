using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class NullException : Exception
    {
        public NullException(): base("No se permite campos vacios") { }
        public NullException(string message) : base(message) { }   
    }
}
