using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbPersonas")]
    public class clsPersona
    {
        // 🔑 Clave compuesta (se define en OnModelCreating)
        public string id { get; set; }
        public int tipoId { get; set; }

        [Required, StringLength(50)]
        public string nombre { get; set; }

        [Required, StringLength(50)]
        public string apellido1 { get; set; }

        [StringLength(50)]
        public string apellido2 { get; set; }

        [Required]
        public DateTime fechaNac { get; set; }

        [Required, EmailAddress, StringLength(100)]
        public string email { get; set; }

        [StringLength(200)]
        public string direccion { get; set; }

        [Phone, StringLength(20)]
        public string telefono { get; set; }

        public bool estado { get; set; }

        // Relación 1 a 1 (si aplica) con Donante
        public clsDonante donante { get; set; }

        public clsPersona() { }
    }
}
