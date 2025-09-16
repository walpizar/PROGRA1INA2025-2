using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbRoles")]
    public class clsRol
    {
        [Key]
        public int idRol { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del rol no puede tener más de 100 caracteres")]
        public string nombreRol { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        // Relación muchos a muchos
        public ICollection<clsRolPermiso> RolPermisos { get; set; }

    }
}
