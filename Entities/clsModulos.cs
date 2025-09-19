using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//LA CAPA SE LLAMA CLSMODULOS PERO LA CLASE SE LLAMA CLSMODULO SIN S

namespace Entities
{
    [Table("tbModulo")]

    public class clsModulo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]//INCREMENTO AUTOMATICO
        public int idModulo { get; set; }

        [Required]
        [StringLength(100)]
        public string nombreModulo { get; set; }

        [StringLength(200)] 
        public string? descripcionModulo { get; set; }




    }
}
