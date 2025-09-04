using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class NullDataException:Exception
    {
        public NullDataException(): base("El objeto o dato proporcionado es nulo.") { }

        public NullDataException(string message)
            : base(message) { }

        public NullDataException(string message, Exception inner)
            : base(message, inner) { }
    }
}
