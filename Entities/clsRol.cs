
﻿using System;

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//CAMBIARLO LAS VARIABLES A CAMEL CASE

namespace Entities
{
    [Table("tbRoles")]
    public class clsRol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//INCREMENTO AUTOMATICO
        public int idRol { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//INCREMENTO AUTOMATICO

        [StringLength(20, ErrorMessage = "El nombre no puede tener mas de 20 caracteres")]
        public string nombreRol { get; set; }


        [StringLength(200, ErrorMessage = "La descripcion no puede tener mas de 200 caracteres")]
        public string descripcionRol { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool estadoRol { get; set; }
        public ICollection<clsPermiso> permisos { get; set; }

    }
}
