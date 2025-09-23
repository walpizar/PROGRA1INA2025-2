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
        public int idVisita { get; set; }

        public string nombreVisitante { get; set; }

        // Claves foráneas hacia Persona
        [Required]
        public string personaId { get; set; }

        [Required]
        public int personaTipoId { get; set; }

        [ForeignKey(nameof(personaId) + "," + nameof(personaTipoId))]
        public clsPersona persona { get; set; }

        // Clave foránea hacia Usuario (1 a 1 con Persona)
        public string usuarioId { get; set; }
        public int usuarioTipoId { get; set; }

        [ForeignKey(nameof(usuarioId) + "," + nameof(usuarioTipoId))]
        public clsUsuario usuario { get; set; }

        public string nombrePaciente { get; set; }
        public string direccion { get; set; }
        public string detalles { get; set; }
    }
}
