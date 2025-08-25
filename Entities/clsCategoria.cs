using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbCategorias")]
    public class clsCategoria

    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string Nombre { get; set; }

        [StringLength(200, ErrorMessage = "La descripcion no puede tener mas de 200 caracteres")]
        public string descripcion { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool estado { get; set; }

        public ICollection<clsProducto> Productos { get; set; } = new List<clsProducto>();

    }
}
