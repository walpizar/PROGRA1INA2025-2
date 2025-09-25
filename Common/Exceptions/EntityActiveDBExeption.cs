using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class EntityActiveDBExeption : Exception
    {

        public EntityActiveDBExeption() : base("La entidad ya esta activa.") { }
        public EntityActiveDBExeption(string mensaje) : base(mensaje) { }
    }
}
