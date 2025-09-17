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
        public int idDonacion { get; set; }
        public decimal monto { get; set; }
        public int tipoTransaccion { get; set; }
        public int frecuencia { get; set; }

        [StringLength(5)]
        public string moneda { get; set; }

        [StringLength(100)]
        public string descripcion { get; set; }
        
        //auditoria
        public string usuarioCreacion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string usuarioModificacion { get; set; }
        public DateTime? fechaModificacion { get; set; }
        public bool estado { get; set; }


        //relacion 1 a 1 con donacion
        public clsDonacion donacion { get; set; }

        public clsDonacionDinero() { }

        
    }
}
