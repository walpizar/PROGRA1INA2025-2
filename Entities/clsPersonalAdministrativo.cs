using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbPersonalAdministrativo")]
    public class clsPersonalAdministrativo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }   // PK

        [Required]
        public string personaId { get; set; }  // FK a Persona

        [Required]
        public int personaTipoId { get; set; }  // nueva FK

        public clsPersona persona { get; set; }

        [Required]
        public int puestoId { get; set; }  // FK a Puesto
        public clsPuestos Puesto { get; set; }

        [StringLength(255)]
        public string descripcion { get; set; }

        // Auditoría
        [Required]
        [StringLength(50)]
        public string creadoPor { get; set; }

        [Required]
        public DateTime fechaCreacion { get; set; } = DateTime.Now;

        [StringLength(50)]
        public string modificadoPor { get; set; }

        public DateTime? fechaModificacion { get; set; }
    }

}
