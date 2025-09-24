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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Cambiado a Identity para autogeneración
        public int idActivo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string nombreActivo { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        [Required]
        public bool estado { get; set; }

        [Required]
        public int estadoUso { get; set; }

        [Column(TypeName = "date")]
        public DateTime fechaAdquisicion { get; set; }

        [StringLength(100, ErrorMessage = "El proveedor no puede tener más de 100 caracteres")]
        public string proveedor { get; set; }

        [StringLength(100, ErrorMessage = "La ubicación no puede tener más de 100 caracteres")]
        public string ubicacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime fechaCreacion { get; set; }

        [StringLength(50, ErrorMessage = "El usuario de creación no puede tener más de 50 caracteres")]
        public string usuarioCreacion { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? fechaModificacion { get; set; }

        [StringLength(50, ErrorMessage = "El usuario de modificación no puede tener más de 50 caracteres")]
        public string usuarioModificacion { get; set; }

        [Required]
       
        public int idCategoria { get; set; }

        [ForeignKey("idCategoria")]
        public clsCategoriaActivos categoria { get; set; }

        public List<clsDevolucion> devoluciones { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaDesecho { get; set; }

        [StringLength(200, ErrorMessage = "La observación de desecho no puede tener más de 200 caracteres")]
        public string observacionDesecho { get; set; }
        //propiedad de navegacion para la relacion uno a muchos con clsCategoriaActivos
        

        public clsActivos()
        {
            this.devoluciones = new List<clsDevolucion>();
            this.fechaCreacion = DateTime.Now;
        }
    }
}