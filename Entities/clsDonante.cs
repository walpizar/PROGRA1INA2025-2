using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonantes")]
    public class clsDonante
    {
        //llave primaria compuesta        
        public string personaId { get; set; }
        public int personaTipoId { get; set; }

       //auditoria
        [Required]
        public bool estado { get; set; }
        [Required]
        public DateTime fechaRegistro { get; set; }
        [Required]
        public DateTime? fechaModificacion { get; set; }
        public string usuarioModificacion { get; set; }
        public string usuarioRegistro { get; set; }


        //relacion 1 a 1 con persona 
        public clsPersona persona { get; set; }

        //relacion 1 a muchos con donacion
        public ICollection<clsDonacion> donaciones { get; set; }

        //constructor vacio
        public clsDonante() { }

        
       

       
    }
}
