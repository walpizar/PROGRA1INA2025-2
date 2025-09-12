using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

        // ACCIONES DEL CRUD
        [Required]
        [DefaultValue(false)]
        public bool consultar { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool crear { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool editar { get; set; }
        [Required]
        [DefaultValue(false)]
        public bool eliminar { get; set; }
        public int IdModulo { get; set; }
    }
}
