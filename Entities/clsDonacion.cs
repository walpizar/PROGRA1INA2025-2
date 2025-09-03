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

        [ForeignKey("donante")]
        public int idDonante { get; set; }

        public DateTime fechaDonacion { get; set; }
        public int tipoDonacion { get; set; }
        public string observaciones { get; set; }

        public clsDonante donante { get; set; }
        public clsDonacionDinero donacionDinero { get; set; }
        public ICollection<clsDonacionesActivos> donacionesActivos { get; set; }

        public clsDonacion() { }

        public clsDonacion(int idDonante, DateTime fechaDonacion, int tipoDonacion, string observaciones)
        {
            this.idDonante = idDonante;
            this.fechaDonacion = fechaDonacion;
            this.tipoDonacion = tipoDonacion;
            this.observaciones = observaciones;
        }

        public override string ToString()
        {
            return $"idDonacion: {idDonacion}, idDonante: {idDonante}, fechaDonacion: {fechaDonacion.ToShortDateString()}, tipoDonacion: {tipoDonacion}, observaciones: {observaciones}";
        }
    }
}
