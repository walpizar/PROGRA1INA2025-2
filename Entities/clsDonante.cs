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

<<<<<<< HEAD
        public string PersonaId { get; set; }
        public int PersonaTipoId { get; set; }
=======
        public string PersonaTipoId { get; set; }
        public int IdPersona { get; set; }

        

>>>>>>> feature/mantenimientoDeUsuarioAct_Inact
        [Required]
        public bool Estado { get; set; }
        
        [Required]
        public DateTime FechaRegistro { get; set; }
        // Relación: Un Donante es una Persona
        [ForeignKey("PersonaId,PersonaTipoId")]
        public clsPersona Persona { get; set; }

        // Relación: Un Donante puede tener muchas Donaciones
        public ICollection<clsDonacion> Donaciones { get; set; }

        // Constructor vacío
        public clsDonante() { }

        // Constructor con parámetros
        public clsDonante(string personaId, int personaTipoId, bool estado, DateTime fechaRegistro)
        {
<<<<<<< HEAD
            PersonaId = personaId;
            PersonaTipoId = personaTipoId;
=======
            IdDonante = idPersona;
            IdPersona = idPersona;
>>>>>>> feature/mantenimientoDeUsuarioAct_Inact
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
