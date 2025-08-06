using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsCliente
    {

        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido1 { get; set; }
        public string apellido2 { get; set; }
        public short genero { get; set; }
        public DateTime fechaNac { get; set; }
        public string email { get; set; }
        public bool estado { get; set; }

        public clsCliente() { }
    }
}
