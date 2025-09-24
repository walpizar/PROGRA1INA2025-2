using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    //defino el nombre de la tabla que va a representar esta clase en sql
    [Table("tbAsigActivoPaciente")]
    public class clsAsignacionActivosPaciente
    {

        [Key]
        public int idAsigActivo { get; set; }//llave primaria

        [Required]
        public string idPaciente { get; set; }//campo de llave foranea
        [Required]
        public int tipoIdPaciente { get; set; }//campo de llave foranea

        [Required]
        public int idActivo { get; set; }//llave foranea
        
        [Required]
        [DataType(DataType.Date)]//tipo de dato fecha
        public DateTime fechaAsignacion { get; set; }


        //propiedad de navegacion de la llave foranea de paciente
        public clsPaciente paciente { get; set; }
        //propiedad de navegacion de la llave foranea de activo
        public clsActivos activo { get; set; }
       

        //Atributos de auditoria
        [Required]//obligatorio
        public bool estado { get; set; }

        [Required]//obligatorio
        [DataType(DataType.Date)]//tipo de dato fecha
        public DateTime fecha_crea { get; set; }

        [Required]//obligatorio
        [StringLength(100, ErrorMessage = "El usuario de creacion no puede tener mas de 100 caracteres")]//longitud maxima
        public string usuario_crea { get; set; }

        [Required]//obligatorio
        [DataType(DataType.Date)]//tipo de dato fecha
        public DateTime fecha_ult_mod { get; set; }

        [Required]//obligatorio
        //longitud maxima
        [StringLength(100, ErrorMessage = "El usuario de la ultima modificacion no puede tener mas de 100 caracteres")]
        public string usuario_ult_mod { get; set; }


    }
}
