using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbVisitasDomiciliares")]
    public class clsVisitasDomiciliares 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVisita { get; set; } // ID INICIO DE CADA VISITA

        [Required]
        [Column(TypeName = "date")]
        public DateTime fecha { get; set; } // FECHA DE LA VISITA (solo fecha, sin hora)

        [Required]
        [StringLength(50)]
        public string nombreVisitante { get; set; } // NOMBRE DE LA PERSONA QUE ESTA LOGUEADA

        [Required]
        [StringLength(50)]
        public string nombrePaciente { get; set; } // NOMBRE DEL PACIENTE/PERSONA AL QUE SE VISITA

        [Range(0, 10)]
        public int telefono{ get; set; } // TELEFONO DEL PACIENTE

        [Required]
        [StringLength(100)]
        public string direccion { get; set; } // DIRECCIÓN DEL PACIENTE

        [StringLength(250)]
        public string detalles { get; set; } // DETALLES OPCIONALES DE LA VISITA
    }
}
