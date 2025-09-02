using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    

    [Table("tbDonaciones")]
    public class clsDonacion
    {
        [Key]
        public int IdDonacion { get; set; }
        [ForeignKey("Donante")]
        public int IdDonante { get; set; }
        public DateTime FechaDonacion { get; set; }
        public int TipoDonacion { get; set; }
        public string Observaciones { get; set; }

        // Relación: Una Donación pertenece a un Donante
        public clsDonante Donante { get; set; }

        // Relación: Una Donación puede tener DonacionDinero y/o DonacionArticulo
        public clsDonacionDinero DonacionDinero { get; set; }
        public ICollection<clsDonacionActivo> DonacionActivos { get; set; }

        // Constructor vacío
        public clsDonacion() { }

        // Constructor con parámetros
        public clsDonacion(int idDonante, DateTime fechaDonacion, int tipoDonacion, string observaciones)
        {
            IdDonante = idDonante;
            FechaDonacion = fechaDonacion;
            TipoDonacion = tipoDonacion;
            Observaciones = observaciones;
        }

        // Método ToString
        public override string ToString()
        {
            return $"IdDonacion: {IdDonacion}, IdDonante: {IdDonante}, FechaDonacion: {FechaDonacion.ToShortDateString()}, TipoDonacion: {TipoDonacion}, Observaciones: {Observaciones}";
        }
    }
}
