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

    [Table("tb_Permisos")]
    public class clsPermiso
    {
        [Key]
        public int id_permiso { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El nombre no puede tener mas de 20 caracteres")]
        public string nombre_permiso { get; set; }

        [StringLength(200, ErrorMessage = "La descripcion no puede tener mas de 200 caracteres")]
        public string descripcion_permiso { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool estado_permiso { get; set; }



        // Relación muchos a muchos
        public ICollection<clsRolPermiso> RolPermisos { get; set; }
    }

    
        [Table("tb_RolPermisos")]//TABLA INTERMEDIA
        public class clsRolPermiso  
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
