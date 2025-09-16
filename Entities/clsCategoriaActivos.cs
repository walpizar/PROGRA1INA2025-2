using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbCategoriaActivos")]
    public class clsCategoriaActivos
    {
        [Key]
        public int idCategoriaActivo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre de la categoría no puede tener más de 100 caracteres")]
        public string nombreCategoriaActivo { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        public clsCategoriaActivos() { }

        public clsCategoriaActivos(int idCategoriaActivo, string nombreCategoriaActivo, string descripcion, bool estado)
        {
            this.idCategoriaActivo = idCategoriaActivo;
            this.nombreCategoriaActivo = nombreCategoriaActivo;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"idCategoriaActivo: {idCategoriaActivo}, nombreCategoriaActivo: {nombreCategoriaActivo}, descripcion: {descripcion}, estado: {estado}";
        }
    }
}