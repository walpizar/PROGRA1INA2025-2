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
        //Constructor
        public clsMedico() { }

        //Atributos principales de Medico
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(300, ErrorMessage = "La especialidad no puede tener mas de 300 caracteres")]
        public string Especialidad { get; set; }

        //Atributos de auditoria
        [Required]
        [DataType(DataType.Date)]
        public DateTime fecha_crea { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El usuario de creacion no puede tener mas de 100 caracteres")]
        public string usuario_crea { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime fecha_ult_mod { get; set; }
        [Required]
        [StringLength(100, ErrorMessage = "El usuario de la ultima modificacion no puede tener mas de 100 caracteres")]
        public string usuario_ult_mod { get; set; }
        [Required]
        public bool estado { get; set; }

        //[Relacion 1 a 1 con Persona]
        public int IdPersona { get; set; }
        public clsPersona Persona { get; set; }

        //Constructor con parametros
        public clsMedico(int Id, string Especialidad, DateTime fecha_crea, string usuario_crea, DateTime fecha_ult_mod, string usuario_ult_mod, bool estado, int idPersona)
        {
            this.Id = Id;
            this.Especialidad = Especialidad;
            this.fecha_crea = fecha_crea;
            this.usuario_crea = usuario_crea;
            this.fecha_ult_mod = fecha_ult_mod;
            this.usuario_ult_mod = usuario_ult_mod;
            this.estado = estado;
            IdPersona = idPersona;
        }
    }
}