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

        public int PersonaId { get; set; }
        public int PersonaTipoId { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; }

        // Navegación
        public clsPersona Persona { get; set; }

        public ICollection<clsDonacion> Donaciones { get; set; }

        // Constructor vacío
        public clsDonante() { }

        // Constructor con parámetros
        public clsDonante(int personaId, int personaTipoId, bool estado, DateTime fechaRegistro)
        {
            PersonaId = personaId;
            PersonaTipoId = personaTipoId;
            Estado = estado;
            FechaRegistro = fechaRegistro;
        }

        // Método ToString
        public override string ToString()
        {
            return $"PersonaId: {PersonaId}, PersonaTipoId: {PersonaTipoId}, Estado: {Estado}, FechaRegistro: {FechaRegistro.ToShortDateString()}";
        }
    }
}
