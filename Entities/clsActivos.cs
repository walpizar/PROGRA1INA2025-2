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
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // No autonumérico
        public int idActivo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string nombreActivo { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "La cantidad debe estar entre 0 y 1000")]
        [Column("CantidadDisponible", TypeName = "int")]
        public int cantidadDisponible { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El estado no puede tener más de 20 caracteres")]
        public string estado { get; set; } // Ejemplo: Nuevo, En uso, Reparación, Baja

        [Column(TypeName = "date")]
        public DateTime fechaAdquisicion { get; set; }

        [Range(0, 1000000, ErrorMessage = "El costo debe estar entre 0 y 1,000,000")]
        public decimal costoUnitario { get; set; }

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
        public string usuarioModificacion { get; set; }

        // Relación con Categoría de Activos (FK)
        [Required]
        public int idCategoria { get; set; }

        [ForeignKey("idCategoria")]
        public clsCategoriaActivos categoria { get; set; }

        // Relación con Devoluciones (uno a muchos)
        public List<clsDevolucion> devoluciones { get; set; }

        // Relación muchos a 1 con Donacion
        public clsDonacion donacion { get; set; }

        public clsActivos(int idActivo, string nombreActivo, string descripcion,
                          int cantidadDisponible, string estado, DateTime fechaAdquisicion,
                          string proveedor, string ubicacion, int idCategoria,
                          string usuarioCreacion)
        {
            this.idActivo = idActivo;
            this.nombreActivo = nombreActivo;
            this.descripcion = descripcion;
            this.cantidadDisponible = cantidadDisponible;
            this.estado = estado;
            this.fechaAdquisicion = fechaAdquisicion;
            this.proveedor = proveedor;
            this.ubicacion = ubicacion;
            this.idCategoria = idCategoria;
            this.fechaCreacion = DateTime.Now;
            this.usuarioCreacion = usuarioCreacion;
            this.devoluciones = new List<clsDevolucion>();
        }

        public clsActivos()
        {
            this.devoluciones = new List<clsDevolucion>();
            this.fechaCreacion = DateTime.Now;
        }
    }
}
