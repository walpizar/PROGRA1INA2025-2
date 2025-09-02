using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tb_tipoAyuda")]//Nombre de la tabla
    public class clsTipoAyuda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tipoAyuda { get; set; }//Llave primaria autoincremental

        [Required]
        [StringLength(100,ErrorMessage ="El nombre no puede tener mas de 100 caracteres")]
        public string nombre { get;set; }//Nombre del tipo de ayuda

        [StringLength(300, ErrorMessage = "La descripción no puede tener mas de 300 caracteres")]
        public string descripcion {  get; set; }//Descripción del tipo de ayuda

        //Fk a reponsable
        public int id_responsable { get; set; }//Id reponsable
        public clsPersona clsPersona { get; set; }//Responsable

        //Fk a categoria
        public int idCategoria { get; set; }
        public clsCategoria clsCategoria { get; set; }


        //Un tipo de ayuda puede estar en muchas ayudas asignadas
        public ICollection<clsAyuda> clsAyuda { get; set; } = new List<clsAyuda>();
    }
}
