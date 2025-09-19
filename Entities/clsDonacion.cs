using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonaciones")]
    public class clsDonacion
    {
        [Key]
        public int idDonacion { get; set; }

        // Foreign key compuesta con donante
        [Required, StringLength(20)]
        public string donanteId { get; set; }

        [Required]
        public int donanteTipoId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaDonacion { get; set; }

        [Required]
        public int tipoDonacion { get; set; }

        [StringLength(200)]
        public string observaciones { get; set; }

        // Auditoría
        [Required, StringLength(50)]
        public string usuarioCreacion { get; set; }

        [Required]
        public DateTime fechaCreacion { get; set; }

        [StringLength(50)]
        public string usuarioModificacion { get; set; }

        public DateTime? fechaModificacion { get; set; }
        [Required]
        public bool estado { get; set; }

        [StringLength(200)]
        public string? razonInactivo { get; set; }

        [StringLength(200)]
        public string? razonModifica { get; set; }

        // Relación muchos a 1 con donante
        public clsDonante donante { get; set; }

        // Relación 1 a 1 con donacionDinero
        public clsDonacionDinero donacionDinero { get; set; }

        // Relación 1 a muchos con donacionActivo
        public ICollection<clsDonacionActivo> donacionesActivos { get; set; }

        public clsDonacion() { }
    }
}
