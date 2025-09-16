using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Entities;

namespace Entities
{
    [Table("tbRolPermiso")]
    public class clsRolPermiso
    {
        //llave primaria compuesta
        public int idRol { get; set; }
        public int idPermiso { get; set; }

        public bool estado { get; set; }

        //relaciones con clsRol y clsPermisos
        public clsRol Rol { get; set; }
        public clsPermisos Permiso { get; set; }
    }
}
