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
    [Table("tbPaciente")]
    public class clsPaciente
    {
        //llave primaria compuesta que es la misma que en clsPersona (id/tipoId)
        public string id { get; set; }//llave primaria compuesta 
        public int tipoId { get; set; }//llave primaria compuesta

        [Required]//obligatorio
        public int estadoCivil { get; set; }

        //propiedad de navegacion
        public clsPersona persona { get; set; }


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
