using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonacionesActivos")]
    public class clsDonacionActivo
    {
        [Key]
        public int idDonacionActivo { get; set; }

        [ForeignKey("donacion")]
        [Required]
        public int idDonacion { get; set; }

        [ForeignKey("activo")]
        [Required]
        public int idActivo { get; set; }

        [StringLength(30)]
        public string estadoActivo { get; set; }

        [StringLength(200)]
        public string observaciones { get; set; }

        // Auditoría
        [Required]
        public bool estado { get; set; }

        [Required, StringLength(50)]
        public string usuarioCreacion { get; set; }

        [Required]
        public DateTime fechaCreacion { get; set; }

        [StringLength(50)]
        public string usuarioModificacion { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [StringLength(200)]
        public string razonModifica { get; set; }
        
        [StringLength(200)]
        public string razonInactivo { get; set; }

        // Relación muchos a 1 con donacion
        public clsDonacion Donacion { get; set; }

        // Relación muchos a 1 con activo
        public clsActivos Activo { get; set; }

        public clsDonacionActivo() { }
    }
}
