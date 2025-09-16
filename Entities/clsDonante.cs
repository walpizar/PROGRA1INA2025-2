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
<<<<<<< HEAD
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDonante { get; set; }


        public string PersonaId { get; set; }
        public int PersonaTipoId { get; set; }



=======
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDonante { get; set; }
        
        public string personaId { get; set; }
        public int personaTipoId { get; set; }

       
>>>>>>> develop
        [Required]
        public bool estado { get; set; }
        
        [Required]
        public DateTime fechaRegistro { get; set; }

        public clsPersona persona { get; set; }

        public ICollection<clsDonacion> donaciones { get; set; }

        public clsDonante() { }

<<<<<<< HEAD
        // Constructor con parámetros
        public clsDonante(string personaId, int personaTipoId, bool estado, DateTime fechaRegistro)
        {

            PersonaId = personaId;
            PersonaTipoId = personaTipoId;
            Estado = estado;
            FechaRegistro = fechaRegistro;
        }
=======
        
       
>>>>>>> develop

       
    }
}
