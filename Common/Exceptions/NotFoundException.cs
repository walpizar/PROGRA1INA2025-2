using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    internal class NotFoundException
    {
        public NotFoundException(string v)
        {
            throw new Exception(v);
        }
    }
}
