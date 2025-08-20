using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbClientes")]
    public class clsCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string nombre { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El primer apellido no puede tener mas de 50 caracteres")]
        public string apellido1 { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El segundo apellido no puede tener mas de 50 caracteres")]
        public string apellido2 { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "El género debe ser 0 (Masculino) o 1 (Femenino)")]
        public short genero { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaNac { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La dirección no puede tener mas de 100 caracteres")]
       // [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "La dirección no tiene formato correcto.")]
        [EmailAddress(ErrorMessage = "La dirección de correo electrónico no es válida.")]
        public string email { get; set; }


        [Required]        
        public bool estado { get; set; }

        public clsCliente() { }
    }
}
