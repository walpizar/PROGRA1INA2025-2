using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;
namespace Entities
{
    [Table("tbCategoriasActivos")]
    public class clsCategoriaActivos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Autonumérico
        public int IdCategoria { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El nombre de la categoría no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        [Required]
        public bool Estado { get; set; } // true = activa, false = inactiva

        public clsCategoriaActivos() { }
    }
}