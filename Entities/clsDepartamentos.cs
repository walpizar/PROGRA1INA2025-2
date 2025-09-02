using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbDepartamento")]
    public class clsDepartamentos
    {
        [Key]
        public int idDepartamento { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string descripcionDepartamento { get; set; }

        // auditoria
        [Required]
        public DateTime fecha_crea { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario_crea { get; set; } = "system";

        public DateTime? fecha_ult_mod { get; set; }

        [StringLength(50)]
        public string? usuario_ult_mod { get; set; }


        // constructor
        public clsDepartamentos() { }

        public clsDepartamentos(string nombre, string usuario)
        {
            this.Nombre = nombre;
            this.usuario_crea = usuario;
        }

        public ICollection<clsPuestos> Puestos { get; set; } = new List<clsPuestos>();
    }
}
