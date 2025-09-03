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
    [Table("tb_Roles")]
    public class clsRol
    {
        [Key]
        public int id_rol { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El nombre no puede tener mas de 20 caracteres")]
        public string nombre_rol { get; set; }

        [StringLength(200, ErrorMessage = "La descripcion no puede tener mas de 200 caracteres")]
        public string descripcion_rol { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool estado_rol { get; set; }

    }
}
