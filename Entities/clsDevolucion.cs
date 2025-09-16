using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbDevolucion")]
    public class clsDevolucion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDevolucion { get; set; }

        [Required(ErrorMessage = "La fecha de devolución es obligatoria")]
        [Column(TypeName = "date")]
        public DateTime fechaDevolucion { get; set; }

        [StringLength(200, ErrorMessage = "Las observaciones no pueden tener más de 200 caracteres")]
        public string observaciones { get; set; } = string.Empty;

        [Required(ErrorMessage = "El activo asociado es obligatorio")]
        [ForeignKey(nameof(activo))]
        public int idActivoFK { get; set; }

        public clsActivos? activo { get; set; }
    }
}
