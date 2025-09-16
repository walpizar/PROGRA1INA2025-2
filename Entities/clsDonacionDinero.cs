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

        public clsDonacion donacion { get; set; }

        public clsDonacionDinero() { }

        public clsDonacionDinero(int idDonacion, decimal monto, int tipoTransaccion, int frecuencia, string moneda, string descripcion)
        {
            this.idDonacion = idDonacion;
            this.monto = monto;
            this.tipoTransaccion = tipoTransaccion;
            this.frecuencia = frecuencia;
            this.moneda = moneda;
            this.descripcion = descripcion;
        }

        public override string ToString()
        {
            return $"idDonacionDinero: {idDonacionDinero}, idDonacion: {idDonacion}, monto: {monto}, tipoTransaccion: {tipoTransaccion}, frecuencia: {frecuencia}, moneda: {moneda}, descripcion: {descripcion}";
        }
    }
}
