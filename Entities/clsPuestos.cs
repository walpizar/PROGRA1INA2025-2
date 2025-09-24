using System;
// <<<<<<< HEAD
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    [Table("tbPuestos")]
    public class clsPuestos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Explicitly set as IDENTITY
        public int idPuesto { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El código no puede tener más de 20 caracteres")]
        [Column(TypeName = "NVARCHAR(20)")]
        public string codigo { get; set; } = "";

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        [Column(TypeName = "NVARCHAR(100)")]
        public string Nombre { get; set; } = "";

        [StringLength(250, ErrorMessage = "La descripción no puede tener más de 250 caracteres")]
        [Column(TypeName = "NVARCHAR(250)")]
        public string? descripcion { get; set; }

        [Required]
        public int idDepartamento { get; set; }

        [ForeignKey("idDepartamento")]
        public virtual clsDepartamentos Departamento { get; set; }

        [StringLength(300, ErrorMessage = "El motivo no puede tener más de 300 caracteres")]
        [Column(TypeName = "NVARCHAR(300)")]
        public string? motivoInactivo { get; set; } = null;

        // Estado y auditoría
        [Required]
        public bool Estado { get; set; } = true;

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

        // Constructores
        public clsPuestos() { }

        public clsPuestos(string codigo, string nombre, int departamentoID, string usuario)
        {
            this.codigo = codigo;
            this.Nombre = nombre;
            this.idDepartamento = departamentoID;
            this.usuario_crea = usuario;
            this.fecha_crea = DateTime.UtcNow;
            this.Estado = true;
            this.motivoInactivo = null;
        }

        // Métodos
        public void Inactivar(string motivo, string usuario)
        {
            this.Estado = false;
            this.motivoInactivo = motivo;
            this.usuario_ult_mod = usuario;
            this.fecha_ult_mod = DateTime.UtcNow;
        }

        public void Reactivar(string usuario)
        {
            this.Estado = true;
            this.motivoInactivo = null;
            this.usuario_ult_mod = usuario;
            this.fecha_ult_mod = DateTime.UtcNow;
        }

        public override string ToString()
        {
            return $"{codigo} - {Nombre}";
        }
    }
}