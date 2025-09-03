using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbRoles")]
    public class clsRol
    {
        [Key]
        public int idRol { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del rol no puede tener más de 100 caracteres")]
        public string nombreRol { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        public clsRol() { }

        public clsRol(int idRol, string nombreRol, string descripcion, bool estado)
        {
            this.idRol = idRol;
            this.nombreRol = nombreRol;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"idRol: {idRol}, nombreRol: {nombreRol}, descripcion: {descripcion}, estado: {estado}";
        }
    }
}
