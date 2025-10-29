using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{ 
    [Table("tbDepartamento")]
    public class clsDepartamentos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDepartamento { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El código no puede tener más de 20 caracteres")]
        [Column(TypeName = "NVARCHAR(20)")]
        public string codigoDepartamento { get; set; } = "";

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del departamento no puede tener más de 100 caracteres")]
        [Column(TypeName = "NVARCHAR(100)")]
        public string Nombre { get; set; } = "";

        [Required]
        [StringLength(250, ErrorMessage = "La descripción no puede tener más de 250 caracteres")]
        [Column(TypeName = "NVARCHAR(250)")]
        public string descripcionDepartamento { get; set; } = "";

        [Required]
        public bool estado { get; set; } = true;

        // Auditoría
        [Required]
        [Column(TypeName = "DATETIME2")]
        public DateTime fecha_crea { get; set; } = DateTime.UtcNow;

        [Required]
        [StringLength(50)]
        [Column(TypeName = "NVARCHAR(50)")]
        public string usuario_crea { get; set; } = "system";

        [Column(TypeName = "DATETIME2")]
        public DateTime? fecha_ult_mod { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? usuario_ult_mod { get; set; }

        // Navegación
        public virtual ICollection<clsPuestos> Puestos { get; set; } = new List<clsPuestos>();

        // Constructores
        public clsDepartamentos() { }

        public clsDepartamentos(string codigo, string nombre, string descripcion, string usuario)
        {
            this.codigoDepartamento = codigo;
            this.Nombre = nombre;
            this.descripcionDepartamento = descripcion;
            this.usuario_crea = usuario;
            this.fecha_crea = DateTime.UtcNow;
            this.estado = true;
        }

        public override string ToString()
        {
            return $"{codigoDepartamento} - {Nombre}";
        }
    }
}