using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{

    [Table("tbCita")]
    public class clsCita
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int citaId { get; set; }

        // Relación con Paciente (FK compuesta)
        [Required]
        public string idPaciente { get; set; }

        [Required]
        public int tipoIdPaciente { get; set; }

        public clsPaciente paciente { get; set; }

        // Relación con Medico (FK compuesta)
        [Required]
        public string idMedico { get; set; }

        [Required]
        public int tipoIdMedico { get; set; }

        public clsMedico medico { get; set; }

        // Fecha y hora de la cita
        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaCita { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public TimeSpan horaCita { get; set; }
        public string motivo { get; set; }


        // Estado de la cita
        [Required]
        [StringLength(20)]
        public string estado { get; set; } = "Pendiente";

        // Auditoría
        [Required]
        public bool activo { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaCrea { get; set; } = DateTime.Now;

        
        [StringLength(100)]
        public string usuarioCrea { get; set; } = "system";

        
        [DataType(DataType.Date)]
        public DateTime fechaUltMod { get; set; }

     

        // Constructor vacío
        public clsCita() { }




    }
}
