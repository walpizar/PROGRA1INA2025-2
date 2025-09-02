using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //Nombre de la tabla en la bd
    [Table("tb_categoriaAyuda")]
    public class clsCategoriaAyuda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_categoria { get; set; }//Llave primaria de la tabla

        [Required]
        [StringLength(100, ErrorMessage ="El nombre no puede tener mas de 100 caracteres")]
        public string nombre { get; set; } //Nombre de la categoria requerido

        [StringLength(300, ErrorMessage = "La descripción no puede tener mas de 300 caracteres")]
        public string descripcion { get; set; } //Descripción de la tabla opcional

        //Una categoria puede tener muchos tipos de ayuda
        public ICollection<clsTipoAyuda> tipos { get; set; }=new List<clsTipoAyuda>();
    }
}
