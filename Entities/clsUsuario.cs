using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbUsuarios")]
    public class clsUsuario
    {
        [Key]
        public int usuarioId { get; set; }   // PK propia de usuario

        // 🔑 FK hacia Persona (compuesta)
        public string personaId { get; set; }
        public int personaTipoId { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres.")]
        public string nombre_usuario { get; set; }

        [Required, StringLength(100)]
        public string contrasena { get; set; }

        [Required, StringLength(100)]
        public string email { get; set; }

        public bool estado { get; set; }

        // Navegación
        public clsPersona persona { get; set; }

        public clsUsuario() { }
    }
}
