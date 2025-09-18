using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbUsuarios")]
    public class clsUsuario
    {
        [Key]
        public string personaId {  get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres.")]

        public int personaTipoId {  get; set; }

        public string nombre_usuario { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La contraseña no puede tener más de 100 caracteres")]
        public string contrasena { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El correo electrónico no puede tener más de 100 caracteres")]
        public string email { get; set; }

        public bool estado { get; set; }

        public clsPersona persona { get; set; }

        public clsUsuario() { }

       
    }
}
