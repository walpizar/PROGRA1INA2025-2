using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbVisitasDomiciliares")]
    public class clsVisitasDomiciliares 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idVisita { get; set; }//ID INICO DE CADA VISITA
        public DateTime fecha { get; set; }
        public string nombreVisitante { get; set; }//NOMBRE DE LA PERSONA QUE ESTA LOEADA
        public string nombrePaciente { get; set; }//NOMBRE DEL PACIENTE/PACIENTE AL QUE SE VISITA
        public string direccion { get; set; }//DIRECCION DEL PACIENTE/PERSONA 
        public string detalles { get; set; }
    }
}
