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
    public class clsTiposAyudas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tipoAyuda { get; set; }//Llave primaria autoincremental

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener mas de 100 caracteres")]
        public string nombre { get; set; }//Nombre del tipo de ayuda

        [StringLength(300, ErrorMessage = "La descripción no puede tener mas de 300 caracteres")]
        public string descripcion { get; set; }//Descripción del tipo de ayuda

        //Fk a reponsable
        [Required]
        public int id_responsable { get; set; }//Id reponsable

        [Required]
        public clsPersona responsable { get; set; }//Responsable

        //Campos de audioria
        [Required]
        public DateTime fecha_crea { get; set; }//Fecha de creación

        //Fk de campos de auditoria a tabla persona crea
        [Required]
        public int id_usuarioCrea { get; set; }

        [Required]
        public clsUsuario usuario_crea { get; set; }

        [Required]
        public DateTime fecha_ultimaModificacion { get; set; }//Fecha ultima modificación


        //Fk de campos de auditoria a tabla persona ultima modificación
        [Required]
        public int id_usuarioUltimaModificacion { get; set; }//Id de usuario de ultima modificación

        [Required]
        public clsUsuario usuario_ultimaModificacion { get; set; }

        [Required]
        public bool estado { get; set; } //Estado del tipo de ayuda
    }
}