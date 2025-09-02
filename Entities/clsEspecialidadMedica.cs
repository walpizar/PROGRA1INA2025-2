using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbEspecialidadesMedicas")]
    public class clsEspecialidadMedica
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string nombre { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "La descripción no puede tener más de 250 caracteres")]
        public string descripcion { get; set; }

        [Required]
        public bool estado { get; set; }

        public clsEspecialidadMedica() { }
    }
}
