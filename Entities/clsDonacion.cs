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
        [Column("donantepersonaId")]
        public string donanteId { get; set; }


        [Required]
        [Column("donanteTipoId")]
        public int donanteTipoId { get; set; }

        [ForeignKey("tipoDonacion")]
        public int idTipoDonacion { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaDonacion { get; set; }

        [StringLength(200)]
        public string observaciones { get; set; }

        public decimal? monto { get; set; }
        public int? tipoTransaccion { get; set; }
        public int? frecuencia { get; set; }
        public int? tipoMoneda { get; set; }
        public DateTime? fechaProximaDonacion { get; set; }

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

        // Relaciones
        public clsDonante donante { get; set; }
        public ICollection<clsActivos> activos { get; set; }
        public clsTipoDonacion tipoDonacion { get; set; }

        public clsDonacion() { }
    }
}
