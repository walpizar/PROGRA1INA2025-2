using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonantes")]
    public class clsDonante
    {
        // Llave primaria compuesta
        [Key, Column(Order = 0)]
        [Required, StringLength(20)]
        public string personaId { get; set; }

        [Key, Column(Order = 1)]
        [Required]
        public int personaTipoId { get; set; }

        //tipo de donante: 1-afiliado, 2-ocasional
        public int tipoDonante { get; set; }//lleva enums

        // Auditoría
        [Required]
        public bool estado { get; set; }

        [Required]
        public DateTime fechaRegistro { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [StringLength(50)]
        public string usuarioModificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string usuarioRegistro { get; set; }

        [StringLength(200)]
        public string? razonInactivo { get; set; }

        [StringLength(50)]
        public string? razonModifica { get; set; }

        // Relación 1 a 1 con persona
        public clsPersona persona { get; set; }

        // Relación 1 a muchos con donacion
        public ICollection<clsDonacion> donaciones { get; set; }

        //constructor vacio
        public clsDonante() { }
    }
}
