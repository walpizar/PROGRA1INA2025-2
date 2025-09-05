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
        public int IdActivo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string NombreActivo { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string Descripcion { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "La cantidad debe estar entre 0 y 1000")]
        [Column("CantidadDisponible", TypeName = "int")]
        public int CantidadDisponible { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El estado no puede tener más de 20 caracteres")]
        public string Estado { get; set; } // Ejemplo: Nuevo, En uso, Reparación, Baja

        [Column(TypeName = "date")]
        public DateTime FechaAdquisicion { get; set; }

        [Range(0, 1000000, ErrorMessage = "El costo debe estar entre 0 y 1,000,000")]
        public decimal CostoUnitario { get; set; }

        [StringLength(100, ErrorMessage = "El proveedor no puede tener más de 100 caracteres")]
        public string Proveedor { get; set; }

        [StringLength(100, ErrorMessage = "La ubicación no puede tener más de 100 caracteres")]
        public string Ubicacion { get; set; }

        //Relación con Categoría de Activos (FK)
        [Required]
        public int IdCategoria { get; set; }

        [ForeignKey("IdCategoria")]
        public clsCategoriaActivos Categoria { get; set; }

        //Relación con Devoluciones (uno a muchos)
        public List<clsDevolucion> Devoluciones { get; set; }


        // Relación: Un Activo puede estar en muchas DonacionActivos
        public ICollection<clsDonacionActivo> DonacionActivos { get; set; }


        // Constructores
        public clsActivos(int idActivo, string nombreActivo, string descripcion,
                          int cantidadDisponible, string estado, DateTime fechaAdquisicion,
                          decimal costoUnitario, string proveedor, string ubicacion, int idCategoria)
        {
            this.IdActivo = idActivo;
            this.NombreActivo = nombreActivo;
            this.Descripcion = descripcion;
            this.CantidadDisponible = cantidadDisponible;
            this.Estado = estado;
            this.FechaAdquisicion = fechaAdquisicion;
            this.CostoUnitario = costoUnitario;
            this.Proveedor = proveedor;
            this.Ubicacion = ubicacion;
            this.IdCategoria = idCategoria;
            this.Devoluciones = new List<clsDevolucion>();
        }

        public clsActivos()
        {
            this.Devoluciones = new List<clsDevolucion>();
        }
    }
}

