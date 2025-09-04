using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entities
{
    
    [Table("tbDonantes")]
    public class clsDonante
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdDonante { get; set; }

        [ForeignKey("Persona")]
        public int IdPersona { get; set; }

        [Required]
        public bool Estado { get; set; }
        
        [Required]
        public DateTime FechaRegistro { get; set; }

        // Relación: Un Donante es una Persona
        public clsPersona Persona { get; set; }

        // Relación: Un Donante puede tener muchas Donaciones
        public ICollection<clsDonacion> Donaciones { get; set; }

        // Constructor vacío
        public clsDonante() { }

        // Constructor con parámetros
        public clsDonante( int idPersona, bool estado, DateTime fechaRegistro)
        {
            IdDonante = IdPersona;
            IdPersona = idPersona;
            Estado = estado;
            FechaRegistro = fechaRegistro;
        }

        // Método ToString
        public override string ToString()
        {
            return $"IdDonante: {IdDonante}, IdPersona: {IdPersona}, Estado: {Estado}, FechaRegistro: {FechaRegistro.ToShortDateString()}";
        }
    }
}
