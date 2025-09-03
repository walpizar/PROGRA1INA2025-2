using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsPaciente
    {

        public string id { get; set; }
        public int tipoId { get; set; }

        [Required]//obligatorio
        [StringLength(100, ErrorMessage = "El nombre no puede tener mas de 100 caracteres")]//longitud maxima
        public string estadoCivil { get; set; }

        [Required]//obligatorio
        [StringLength(500, ErrorMessage = "El genero no puede tener mas de 500 caracteres")]//longitud maxima
        public string referencia { get; set; }


        //campo de llave foranea
        [Required]//obligatorio
        public int idPersona { get; set; }

        
        public clsPersona Persona { get; set; }


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


        
        public clsPaciente(string idPaciente, string estadoCivil, string referencia, int IdPersona, 
            bool estado, DateTime fecha_crea, string usuario_crea, DateTime fecha_ult_mod, string usuario_ult_mod)
        {
            this.id = idPaciente;
            this.tipoId = tipoId;
            this.estadoCivil = estadoCivil;
            this.referencia = referencia;
            this.idPersona = IdPersona;
            this.estado = estado;
            this.fecha_crea = fecha_crea;
            this.usuario_crea = usuario_crea;
            this.fecha_ult_mod = fecha_ult_mod;
            this.usuario_ult_mod = usuario_ult_mod;

        }

        public clsPaciente() { }

    }
}
