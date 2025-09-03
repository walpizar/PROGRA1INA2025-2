using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("usuarios")]
    public class clsUsuario
    {
        [Key]
        [ForeignKey("Persona")] // Esta es la clave primaria y a la vez la clave foránea a la tabla tbPersonas
        public int id {  get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres.")]
        public string nombre_usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]

        [StringLength(255, ErrorMessage= "La contraseña debe tener al menos 255 caracteres.")]
        public string contraseña { get; set; }

        [Required(ErrorMessage = "El rol del usuario es obligatorio.")]
        public int rol_id { get; set; }

        // Propiedad de navegación para acceder a los datos de la persona vinculada.
        // Esto crea un enlace a la clase clsPersona.
        public clsPersona Persona { get; set; }

        // Constructor vacío
        public clsUsuario() { }

        // Constructor con parámetros

        public clsUsuario(int id, string nombre_usuario, string contraseña, int rol_id)
        {
            this.id = id;
            this.nombre_usuario = nombre_usuario;
            this.contraseña = contraseña;

        }
    }
}
