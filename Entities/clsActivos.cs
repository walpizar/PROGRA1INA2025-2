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

        // Relación con Categoría de Activos (FK)
        [Required]
        public int idCategoria { get; set; }

        [ForeignKey("idCategoria")]
        public clsCategoriaActivos categoria { get; set; }

        // Relación con Devoluciones (uno a muchos)
        public List<clsDevolucion> devoluciones { get; set; }

        // Relación: Un Activo puede estar en muchas DonacionActivos
        public ICollection<clsDonacionesActivos> donacionActivos { get; set; }

        // Constructores
        public clsActivos(int idActivo, string nombreActivo, string descripcion,
                          int cantidadDisponible, string estado, DateTime fechaAdquisicion,
                          decimal costoUnitario, string proveedor, string ubicacion, int idCategoria)
        {
            this.idActivo = idActivo;
            this.nombreActivo = nombreActivo;
            this.descripcion = descripcion;
            this.cantidadDisponible = cantidadDisponible;
            this.estado = estado;
            this.fechaAdquisicion = fechaAdquisicion;
            this.costoUnitario = costoUnitario;
            this.proveedor = proveedor;
            this.ubicacion = ubicacion;
            this.idCategoria = idCategoria;
            this.devoluciones = new List<clsDevolucion>();
        }

        public clsActivos()
        {
            this.devoluciones = new List<clsDevolucion>();
        }
    }
}

