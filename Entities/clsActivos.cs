using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbActivos")]
    public class clsActivos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // Ya no es autonumérico
        public int idActivo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string nombreActivo { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        // Estado lógico: true = activo, false = dado de baja
        [Required]
        public bool estado { get; set; }

        // Estado de uso: 0 = disponible, 1 = prestado, 2 = desechado, 3 = en uso, etc.
        [Required]
        public int estadoUso { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaAdquisicion { get; set; }

        [StringLength(100, ErrorMessage = "El proveedor no puede tener más de 100 caracteres")]
        public string proveedor { get; set; }

        [StringLength(100, ErrorMessage = "La ubicación no puede tener más de 100 caracteres")]
        public string ubicacion { get; set; }

        // Campos de auditoría
        [Column(TypeName = "datetime")]
        public DateTime fechaCreacion { get; set; }

        [StringLength(50, ErrorMessage = "El usuario de creación no puede tener más de 50 caracteres")]
        public string usuarioCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? fechaModificacion { get; set; }

        [StringLength(50, ErrorMessage = "El usuario de modificación no puede tener más de 50 caracteres")]
        public string usuarioModificacion { get; set; }

        // Relación con Categoría de Activos (FK)
        [Required]
        public int idCategoria { get; set; }

        [ForeignKey("idCategoria")]
        public clsCategoriaActivos categoria { get; set; }

        // Relación con Devoluciones (uno a muchos)
        public List<clsDevolucion> devoluciones { get; set; }

        // Relación: Un Activo puede estar en muchas DonacionActivos
        public ICollection<clsDonacionesActivos> donacionActivos { get; set; }

        // Nuevos campos para desecho
        [Column(TypeName = "date")]
        public DateTime? fechaDesecho { get; set; }

        [StringLength(200, ErrorMessage = "La observación de desecho no puede tener más de 200 caracteres")]
        public string observacionDesecho { get; set; }

        public clsActivos()
        {
            this.devoluciones = new List<clsDevolucion>();
            this.fechaCreacion = DateTime.Now;
        }
    }
}
