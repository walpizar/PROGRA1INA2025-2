using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbPermisos")]
    public class clsPermisos
    {
        [Key]
        public int idPermiso { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del permiso no puede tener más de 100 caracteres")]
        public string nombrePermiso { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        public clsPermisos() { }

        public clsPermisos(int idPermiso, string nombrePermiso, string descripcion, bool estado)
        {
            this.idPermiso = idPermiso;
            this.nombrePermiso = nombrePermiso;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"idPermiso: {idPermiso}, nombrePermiso: {nombrePermiso}, descripcion: {descripcion}, estado: {estado}";
        }
    }
}
