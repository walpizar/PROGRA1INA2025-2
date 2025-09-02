using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbDonacionesActivos")]
    public class clsDonacionActivo
    {
        [Key]
        public int IdDonacionActivo { get; set; }
        [ForeignKey("Donacion")]
        public int IdDonacion { get; set; }
        [ForeignKey("Activo")]
        public int IdActivo { get; set; }
        public int Cantidad { get; set; }
        [StringLength(30)]
        public string EstadoActivo { get; set; }
        public string Observaciones { get; set; }

        // Relación: Una DonacionActivo pertenece a una Donacion y a un Activo
        public clsDonacion Donacion { get; set; }
        public clsActivo1 Activo { get; set; }

        // Constructor vacío
        public clsDonacionActivo() { }

        // Constructor con parámetros
        public clsDonacionActivo(int idDonacion, int idActivo, int cantidad, string estadoActivo, string observaciones)
        {
            IdDonacion = idDonacion;
            IdActivo = idActivo;
            Cantidad = cantidad;
            EstadoActivo = estadoActivo;
            Observaciones = observaciones;
        }

        // Método ToString
        public override string ToString()
        {
            return $"IdDonacionActivo: {IdDonacionActivo}, IdDonacion: {IdDonacion}, IdActivo: {IdActivo}, Cantidad: {Cantidad}, EstadoActivo: {EstadoActivo}, Observaciones: {Observaciones}";
        }
    }
}
