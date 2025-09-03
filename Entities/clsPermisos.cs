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
    
        [Table("tb_Permisos")]//TABLA INTERMEDIA
        public class clsPermiso
        {
            //LLAVE PRIMARIA COMPUESTA
            public int id_modulo { get; set; } // Relación con módulo
            public clsModulo modulo { get; set; }//PROPIEDAD DE NAVEGACION
            public int id_rol { get; set; } // Relación con rol
            public clsRol rol { get; set; }//PROPIEDAD DE NAVEGACION



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
        }

}
