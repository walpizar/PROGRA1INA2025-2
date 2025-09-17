<<<<<<< Updated upstream
﻿using System;
=======
﻿ using System;
using System.Collections.Generic;
using System.ComponentModel;
>>>>>>> Stashed changes
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbRoles")]
    public class clsRol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//INCREMENTO AUTOMATICO
        public int id_rol { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//INCREMENTO AUTOMATICO
>>>>>>>>> Temporary merge branch 2
        [StringLength(20, ErrorMessage = "El nombre no puede tener mas de 20 caracteres")]
        public string nombre_rol { get; set; }


        [StringLength(200, ErrorMessage = "La descripcion no puede tener mas de 200 caracteres")]
        public string descripcion_rol { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool estado_rol { get; set; }
        [Required]
        public bool estado_rol { get; set; }

<<<<<<<<< Temporary merge branch 1

<<<<<<< Updated upstream
        public ICollection<clsRolPermiso> RolPermisos { get; set; }
=========
>>>>>>>>> Temporary merge branch 2
=======
        public ICollection<clsPermiso> permisos { get; set; }

        //public string RolDisplay => $"{id_rol} - {nombre_rol}";
>>>>>>> Stashed changes
    }
}
