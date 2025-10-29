using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace Entities
{
    [Table("tbSolicitudApoyo")]
    public class clsSolicitudApoyo
    {
        [Key]
        [Required]
        [StringLength(20, ErrorMessage = "El ID de la solicitud no puede exceder 20 caracteres.")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string idSolicitud { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El ID del paciente no puede exceder 20 caracteres.")]
        public string idPaciente { get; set; }

        [Required]
        public int tipoIdPaciente { get; set; }

        public string referenciaCCSS { get; set; }
        public string estudioSocioeconomico { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "La justificación no puede superar los 500 caracteres.")]
        public string justificacion { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "Los equipos necesarios no pueden superar los 500 caracteres.")]
        public string equiposNecesarios { get; set; }

        public int estado { get; set; }

        [Required]
        public DateTime fechaSolicitud { get; set; }

        // Constructor por defecto
        public clsSolicitudApoyo()
        {
            estado = 1;
            fechaSolicitud = DateTime.Now;
        }
    }
}