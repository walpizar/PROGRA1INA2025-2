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
        public int IdDevolucion { get; set; }

        [Required(ErrorMessage = "La fecha de devolución es obligatoria")]
        [Column(TypeName = "date")]
        public DateTime FechaDevolucion { get; set; }

        [StringLength(200, ErrorMessage = "Las observaciones no pueden tener más de 200 caracteres")]
        public string Observaciones { get; set; } = string.Empty;

        [Required(ErrorMessage = "El activo asociado es obligatorio")]
        [ForeignKey(nameof(Activo))]
        public int IdActivoFK { get; set; }

        public clsActivos? Activo { get; set; }
    }
}
