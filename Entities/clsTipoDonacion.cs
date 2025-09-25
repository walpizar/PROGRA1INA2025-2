using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbTipoDonacion")]
    public class clsTipoDonacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idTipoDonacion { get; set; }

        [Required, StringLength(100)]
        public string nombreTipoDonacion { get; set; }

        [StringLength(200)]
        public string descripcion { get; set; }

        // Requerimientos
        [Required]
        public bool? requiereMonto { get; set; }

        [Required]
        public bool? requiereTipoTransaccion { get; set; }

        [Required]
        public bool? requiereFrecuencia { get; set; }

        [Required]
        public bool? requiereTipoMoneda { get; set; }

        // Auditoría
        [Required]
        public bool estado { get; set; }

        [Required]
        public DateTime fechaCreacion { get; set; }

        [Required, StringLength(50)]
        public string usuarioCreacion { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [StringLength(50)]
        public string? usuarioModificacion { get; set; }

        [StringLength(200)]
        public string? razonInactivo { get; set; }

        [StringLength(200)]
        public string? razonModifica { get; set; }

        // Relación 1 a muchos con Donacion
        public ICollection<clsDonacion> donaciones { get; set; }

        public clsTipoDonacion() { }
    }
}
