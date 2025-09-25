using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbUsuarios")]
    public class clsUsuario
    {
        
        // La clave primaria para la entidad, que es el nombre de usuario
        [Key]
        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres.")]
        public string nombre_Usuario { get; set; }

        // Mapea la propiedad Id a la columna 'Id' en la base de datos
        [Column("Id")]
        public string id{ get; set; }

        [Column("TipoId")]
        public int tipoId { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La contraseña no puede tener más de 100 caracteres")]
        public string contrasena { get; set; }

        public bool estado { get; set; }

        public int idRol {  get; set; }

        public clsPersona persona { get; set; }

        public clsUsuario() { }

       
    }
}
