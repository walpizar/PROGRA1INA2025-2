using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonacionesDinero")]
    public class clsDonacionDinero
    {
        [Key]
        public int idDonacionDinero { get; set; }

        [ForeignKey("donacion")]
        [Required]
        public int idDonacion { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "El monto debe ser mayor o igual a 0")]
        public decimal monto { get; set; }

        [Required]
        public int tipoTransaccion { get; set; }

        [Required]
        public int frecuencia { get; set; }

        [StringLength(5)]
        public string moneda { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }

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


        // Relación 1 a 1 con donacion
        public clsDonacion donacion { get; set; }

        public clsDonacionDinero() { }
    }
}
