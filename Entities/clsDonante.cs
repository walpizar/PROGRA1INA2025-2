using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Entities
{
    [Table("tbDonantes")]
    [PrimaryKey(nameof(personaId), nameof(personaTipoId))] // <-- Aquí se define la PK compuesta
    public class clsDonante
    {
        [Required, StringLength(20)]
        public string personaId { get; set; }

        [Required]
        public int personaTipoId { get; set; }

        public int tipoDonante { get; set; } // 1-afiliado, 2-ocasional

        [Required]
        public bool estado { get; set; }

        [Required]
        public DateTime fechaRegistro { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [StringLength(50)]
        public string usuarioModificacion { get; set; }

        [Required, StringLength(50)]
        public string usuarioRegistro { get; set; }

        [StringLength(200)]
        public string? razonInactivo { get; set; }

        [StringLength(50)]
        public string? razonModifica { get; set; }

        public clsPersona persona { get; set; }



        public clsDonante() { }
    }
}
