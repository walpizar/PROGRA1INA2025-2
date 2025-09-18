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

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDonante { get; set; }
        
        public string personaId { get; set; }
        public int personaTipoId { get; set; }

       
        [Required]
        public bool estado { get; set; }
        
        [Required]
        public DateTime fechaRegistro { get; set; }

        public clsPersona persona { get; set; }

        public ICollection<clsDonacion> donaciones { get; set; }

        public clsDonante() { }


        // Constructor con parámetros
        public clsDonante(string personaId, int personaTipoId, bool estado, DateTime fechaRegistro)
        {

            personaId = personaId;
            personaTipoId = personaTipoId;
            estado = estado;
            fechaRegistro = fechaRegistro;
        }
       
       


       
    }
}
