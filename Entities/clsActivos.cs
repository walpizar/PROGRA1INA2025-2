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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // No autonumérico
        public int idActivo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string nombreActivo { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El estado no puede tener más de 20 caracteres")]
        public bool estado { get; set; }

        [Required]
        public int estadoUso { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime fechaAdquisicion { get; set; }

        [StringLength(100, ErrorMessage = "El proveedor no puede tener más de 100 caracteres")]
        public string proveedor { get; set; }

        [StringLength(100, ErrorMessage = "La ubicación no puede tener más de 100 caracteres")]
        public string ubicacion { get; set; }

        [ForeignKey("idDonacion")]
        public int idDonacion { get; set; }

        // Campos de auditoría
        [Column(TypeName = "datetime")]
        public DateTime fechaCreacion { get; set; }

        [StringLength(50, ErrorMessage = "El usuario de creación no puede tener más de 50 caracteres")]
        public string usuarioCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? fechaModificacion { get; set; }

        [StringLength(50, ErrorMessage = "El usuario de modificación no puede tener más de 50 caracteres")]
        public string? usuarioModificacion { get; set; }

        // Relación muchos a 1 con Donacion
        public clsDonacion donacion { get; set; }

        // 🔹 Relación con categoría
        [Required]
        public int idCategoria { get; set; }

        [ForeignKey("idCategoria")]
        public clsCategoriaActivos categoria { get; set; }

        // 🔹 Relación con devoluciones
        public List<clsDevolucion> devoluciones { get; set; } = new List<clsDevolucion>();

        // Solo pueden ser nulos si estadoUso == 2 (Desechado)
        [Column(TypeName = "date")]
        public DateTime? fechaDesecho { get; set; }

        [StringLength(200, ErrorMessage = "La observación de desecho no puede tener más de 200 caracteres")]
        public string observacionDesecho { get; set; }

        public clsActivos()
        {
            this.fechaCreacion = DateTime.Now;
            // Inicializar campos de desecho como null
            this.fechaDesecho = null;
            this.observacionDesecho = null;
        }

        /// <summary>
        /// Validación para asegurar que solo se registren datos de desecho
        /// si el activo está en estado de uso == 2 (Desechado).
        /// </summary>
        public void ValidarDesecho()
        {
            if (estadoUso != 2)
            {
                fechaDesecho = null;
                observacionDesecho = null;
            }
        }

        
    }
}
