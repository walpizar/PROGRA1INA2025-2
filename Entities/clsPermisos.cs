using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{

    [Table("tbPermisos")]
    public class clsPermisos
    {
        [Key]
        public int idPermiso { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del permiso no puede tener más de 100 caracteres")]
        public string nombrePermiso { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        public clsPermisos() { }

        // Relación muchos a muchos
        public ICollection<clsRolPermiso> RolPermisos { get; set; }


    }

        
    
}



