using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonacionesActivos")]
    public class clsDonacionesActivos
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

        public clsDonacion donacion { get; set; }
        public clsActivos activo { get; set; }

        public clsDonacionesActivos() { }

        public clsDonacionesActivos(int idDonacion, int idActivo, int cantidad, string estadoActivo, string observaciones)
        {
            this.idDonacion = idDonacion;
            this.idActivo = idActivo;
            this.cantidad = cantidad;
            this.estadoActivo = estadoActivo;
            this.observaciones = observaciones;
        }

        public override string ToString()
        {
            return $"idDonacionActivo: {idDonacionActivo}, idDonacion: {idDonacion}, idActivo: {idActivo}, cantidad: {cantidad}, estadoActivo: {estadoActivo}, observaciones: {observaciones}";
        }
    }
}
