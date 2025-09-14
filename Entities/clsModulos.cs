using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tb_Modulo")]

    public class clsModulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//INCREMENTO AUTOMATICO
        public int id_modulo { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre_modulo { get; set; }

        [StringLength(200)]
        public string? descripcion_modulo { get; set; }



        // Navegación: un módulo puede tener muchos permisos
        public ICollection<clsPermiso> permisos { get; set; }//LIGADO A PERMISOS
    }
}
