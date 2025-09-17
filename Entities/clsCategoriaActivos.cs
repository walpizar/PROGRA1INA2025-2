using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbCategoriaActivos")]
    public class clsCategoriaActivos
    {
        [Key]
        public int Id { get; set; }
        public int IdCategoria { get; set; }

        [StringLength(50, ErrorMessage = "El nombre no puede tener más de 50 caracteres")]
        public string nombre { get; set; }
        public string Nombre { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }
        [Required]
        [DefaultValue(true)]
        public bool estado { get; set; }

        // 🔹 Relación uno-a-muchos: una categoría tiene muchos activos
        public ICollection<clsActivos> Activos { get; set; } = new List<clsActivos>();
        public bool Estado { get; set; } // true = activa, false = inactiva
        // Para mostrar en combos
        public string Display => $"{Id} - {nombre}";
        public clsCategoriaActivos() { }
    }
}
