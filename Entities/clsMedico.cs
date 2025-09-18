using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbMedico")]
    public class clsMedico
    {
        // Constructor vacío
        public clsMedico() { }

        //Atributos principales de Medico

        public string id { get; set; }
        public int tipoId { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "La especialidad no puede tener mas de 300 caracteres")]
        public string especialidad { get; set; }

        // Atributos de auditoria
        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaCrea { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El usuario de creacion no puede tener mas de 100 caracteres")]
        public string usuarioCrea { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaUltMod { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El usuario de la ultima modificacion no puede tener mas de 100 caracteres")]
        public string usuarioUltMod { get; set; }
        [Required]
        public bool estado { get; set; }

        // Relación 1 a 1 con Persona
        public int idPersona { get; set; }
        public clsPersona persona { get; set; }

        //Constructor con parametros
        public clsMedico(string Id, int tipoId, string Especialidad, DateTime fecha_crea, string usuario_crea, DateTime fecha_ult_mod, string usuario_ult_mod, bool estado, int idPersona)
        {
            this.id = id;
            this.tipoId = tipoId;
            this.especialidad = especialidad;
            this.fechaCrea = fechaCrea;
            this.usuarioCrea = usuarioCrea;
            this.fechaUltMod = fechaUltMod;
            this.usuarioUltMod = usuarioUltMod;
            this.estado = estado;
            this.idPersona = idPersona;
        }
    }
}