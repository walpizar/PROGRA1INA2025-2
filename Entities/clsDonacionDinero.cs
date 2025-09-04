using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
   

    [Table("tbDonacionesDinero")]
    public class clsDonacionDinero
    {
        [Key]
        public int IdDonacionDinero { get; set; }

        [ForeignKey("Donacion")]
        public int IdDonacion { get; set; }

        public decimal Monto { get; set; }

        public int TipoTransaccion { get; set; }

        public int Frecuencia { get; set; }

        [StringLength(5)]
        public string Moneda { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        // Relación: Una DonacionDinero pertenece a una Donacion
        public clsDonacion Donacion { get; set; }

        // Constructor vacío
        public clsDonacionDinero() { }

        // Constructor con parámetros
        public clsDonacionDinero(int idDonacion, decimal monto, int tipoTransaccion, int frecuencia, string moneda, string descripcion)
        {
            IdDonacion = idDonacion;
            Monto = monto;
            TipoTransaccion = tipoTransaccion;
            Frecuencia = frecuencia;
            Moneda = moneda;
            Descripcion = descripcion;
        }

        // Método ToString
        public override string ToString()
        {
            return $"IdDonacionDinero: {IdDonacionDinero}, IdDonacion: {IdDonacion}, Monto: {Monto}, TipoTransaccion: {TipoTransaccion}, Frecuencia: {Frecuencia}, Moneda: {Moneda}, Descripcion: {Descripcion}";
        }

    }
}
