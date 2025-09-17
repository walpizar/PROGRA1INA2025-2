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

        //foreign key con donante es la de persona
        public int donanteId { get; set; }
        public int donanteTipoId { get; set; }

        public DateTime fechaDonacion { get; set; }
        public int tipoDonacion { get; set; }
        public string observaciones { get; set; }
        
        //auditoria
        public string usuarioCreacion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string usuarioModificacion { get; set; }
        public DateTime? fechaModificacion { get; set; }
        public bool estado { get; set; }

        //relacion muchos a 1 con donante
        public clsDonante donante { get; set; }

        //relacion 1 a 1 con donacionDinero
        public clsDonacionDinero donacionDinero { get; set; }

        //relacion 1 a muchos con donacionActivo
        public ICollection<clsDonacionActivo> donacionesActivos { get; set; }

        public clsDonacion() { }

       

       
    }
}
