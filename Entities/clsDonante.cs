using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonantes")]
    public class clsDonante
    {
               
        public string personaId { get; set; }
        public int personaTipoId { get; set; }

       
        [Required]
        public bool estado { get; set; }
        
        [Required]
        public DateTime fechaRegistro { get; set; }

        public clsPersona persona { get; set; }

        public ICollection<clsDonacion> donaciones { get; set; }

        public clsDonante() { }

        
       

       
    }
}
