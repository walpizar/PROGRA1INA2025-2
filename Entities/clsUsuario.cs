using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbUsuarios")]
    public class clsUsuario
    {
        [Key]
        public int idUsuario { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre de usuario no puede tener más de 100 caracteres")]
        public string nombreUsuario { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "La contraseña no puede tener más de 100 caracteres")]
        public string contrasena { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El correo electrónico no puede tener más de 100 caracteres")]
        public string email { get; set; }

        public bool estado { get; set; }

        public clsUsuario() { }

        public clsUsuario(int idUsuario, string nombreUsuario, string contrasena, string email, bool estado)
        {
            this.idUsuario = idUsuario;
            this.nombreUsuario = nombreUsuario;
            this.contrasena = contrasena;
            this.email = email;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"idUsuario: {idUsuario}, nombreUsuario: {nombreUsuario}, email: {email}, estado: {estado}";
        }
    }
}
