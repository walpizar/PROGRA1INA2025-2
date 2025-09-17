using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonacionesActivos")]
    public class clsDonacionActivo
    {
        [Key]
        public int idDonacionActivo { get; set; }

        [ForeignKey("donacion")]
        public int idDonacion { get; set; }

        [ForeignKey("activo")]
        public int idActivo { get; set; }

        public int cantidad { get; set; }

        [StringLength(30)]
        public string estadoActivo { get; set; }

        public string observaciones { get; set; }

        //auditoria
        public string usuarioCreacion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string usuarioModificacion { get; set; }
        public DateTime? fechaModificacion { get; set; }
        public bool estado { get; set; }
        
        //relacion muchos a 1 con donacion
        public clsDonacion donacion { get; set; }

        //relacion muchos a 1 con activo
        public clsActivos activo { get; set; }

        public clsDonacionActivo() { }

        public clsDonacionActivo(int idDonacion, int idActivo, int cantidad, string estadoActivo, string observaciones)
        {
            this.idDonacion = idDonacion;
            this.idActivo = idActivo;
            this.cantidad = cantidad;
            this.estadoActivo = estadoActivo;
            this.observaciones = observaciones;
        }

    }
}
