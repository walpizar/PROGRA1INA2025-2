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
    [Table("tb_ayuda")]
    public class clsAyuda
    {
        [Key]
        public int id_ayuda { get; set; }//Llave primaria de ayuda

        [Required]
        public DateTime FechaAsigancion { get; set; } //Fecha de la asignación de la ayuda

        //Llave foranea de tipo Ayuda
        [Required]
        public int id_tipoAyuda { get; set; }
        [Required]
        public clsTipoAyuda clsTipoAyudaTipo { get; set; }

        [StringLength(300,ErrorMessage ="La descripción no puede tener mas de 300 caracteres")]
        public string descripcion { get; set; }

        //Llave foranea de persona
        [Required]
        public  int id_responsable { get; set; }
        [Required]
        public clsPersona responsable { get; set; }

        //Llave foranea si el tipo de ayuda necesita un activo
        public int id_activo { get; set; }
        //public clsActivo activo { get; set; }

    }
}
