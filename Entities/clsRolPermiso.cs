using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    [Table("tb_RolesPermisos")]
    public class clsRolPermiso
    {
        //LLAVE COMPUESTA
        public int IdRol { get; set; }
        public int IdPermiso { get; set; }


        ///PROPIEDADES DE NAVEGACION//
        public clsRol Rol { get; set; }
        public clsPermiso Permiso { get; set; }
    }
}
