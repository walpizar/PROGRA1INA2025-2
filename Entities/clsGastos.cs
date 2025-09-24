using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbGastos")]
    public class clsGastos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idGasto { get; set; }

        [Required]
        [Column(TypeName = "DATETIME2")]
        public DateTime fechaRegistro { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal montoGasto { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El responsable no puede tener más de 100 caracteres")]
        [Column(TypeName = "NVARCHAR(100)")]
        public string responsable { get; set; } = "";

        [Required]
        [Column(TypeName = "DATE")]
        public DateTime fechaCompra { get; set; }

        [StringLength(50, ErrorMessage = "El número de factura no puede tener más de 50 caracteres")]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? numeroFactura { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "La descripción de qué se compró no puede tener más de 300 caracteres")]
        [Column(TypeName = "NVARCHAR(300)")]
        public string queSeCompro { get; set; } = "";

        [Required]
        [StringLength(500, ErrorMessage = "La descripcion no puede tener más de 500 caracteres")]
        [Column(TypeName = "NVARCHAR(500)")]
        public string descripcion { get; set; } = "";

        // Auditoría
        [Required]
        [Column(TypeName = "DATETIME2")]
        public DateTime fechaCrea { get; set; } = DateTime.Now;

        [Required]
        [StringLength(50)]
        [Column(TypeName = "NVARCHAR(50)")]
        public string usuario_crea { get; set; } = "system";

        [Column(TypeName = "DATETIME2")]
        public DateTime? fecha_ult_mod { get; set; }

        [StringLength(50)]
        [Column(TypeName = "NVARCHAR(50)")]
        public string? usuario_ult_mod { get; set; }

        [Required]
        public bool Estado { get; set; } = true;

        // Constructores
        public clsGastos() { }

        public clsGastos(decimal monto, string responsable, DateTime fechaCompra, string queSeCompro, string justificacion, string usuario, string numeroFactura = null)
        {
            this.montoGasto = monto;
            this.responsable = responsable;
            this.fechaCompra = fechaCompra;
            this.queSeCompro = queSeCompro;
            this.descripcion = justificacion;
            this.numeroFactura = numeroFactura;
            this.usuario_crea = usuario;
            this.fechaRegistro = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{fechaCompra:dd/MM/yyyy} - {responsable} - {queSeCompro} - ₡{montoGasto:N2}";
        }
    }
}