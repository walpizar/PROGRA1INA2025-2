using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonantes")]
    public class clsDonante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idDonante { get; set; }

        [ForeignKey("persona")]
        public int idPersona { get; set; }

        [Required]
        public bool estado { get; set; }
        
        [Required]
        public DateTime fechaRegistro { get; set; }

        public clsPersona persona { get; set; }

        public ICollection<clsDonacion> donaciones { get; set; }

        public clsDonante() { }

        public clsDonante(int idPersona, bool estado, DateTime fechaRegistro)
        {
            idDonante = idPersona;
            this.idPersona = idPersona;
            this.estado = estado;
            this.fechaRegistro = fechaRegistro;
        }

        public override string ToString()
        {
            return $"idDonante: {idDonante}, idPersona: {idPersona}, estado: {estado}, fechaRegistro: {fechaRegistro.ToShortDateString()}";
        }
    }
}
