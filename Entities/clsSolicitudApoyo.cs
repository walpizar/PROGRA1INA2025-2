using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbSolicitudApoyo")]
    public class clsSolicitudApoyo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idSolicitud { get; set; }

        [Required]
        public int idPaciente { get; set; }

        public string referenciaCCSS { get; set; }           // Ruta archivo eventualmenrte
        public string estudioSocioeconomico { get; set; }   // Ruta archivo eventualmenrte

        [StringLength(500, ErrorMessage = "La justificación no puede tener más de 500 caracteres")]
        public string justificacion { get; set; }

        [StringLength(500, ErrorMessage = "La descripción de equipos necesarios no puede tener más de 500 caracteres")]
        public string equiposNecesarios { get; set; }

        [Required]
        [StringLength(20)]
        public string estado { get; private set; }  // Pendiente por defecto, solo aprobador puede cambiar

        [Required]
        public DateTime fechaSolicitud { get; set; }

        // Constructor por defecto
        public clsSolicitudApoyo()
        {
            estado = "Pendiente";
            fechaSolicitud = DateTime.Now;
        }

        // Constructor completo
        public clsSolicitudApoyo(int idPaciente, string referenciaCCSS, string estudioSocioeconomico,
                                 string justificacion, string equiposNecesarios)
        {
            this.idPaciente = idPaciente;
            this.referenciaCCSS = referenciaCCSS;
            this.estudioSocioeconomico = estudioSocioeconomico;
            this.justificacion = justificacion;
            this.equiposNecesarios = equiposNecesarios;
            this.estado = "Pendiente";
            this.fechaSolicitud = DateTime.Now;
        }

    }
}
