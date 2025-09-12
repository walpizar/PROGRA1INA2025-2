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
        public string personaId {  get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre de usuario no puede tener más de 50 caracteres.")]

        public int personaTipoId {  get; set; }

       

        public string nombre_usuario { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria.")]

        [StringLength(255, ErrorMessage= "La contraseña no puede tener más de 255 caracteres.")]
        public string contraseña { get; set; }

        [Required(ErrorMessage = "El rol del usuario es obligatorio.")]
        public int rol_id { get; set; }

        // Propiedad de navegación para acceder a los datos de la persona vinculada.
        // Esto crea un enlace a la clase clsPersona.
        public clsPersona Persona { get; set; }

        // Constructor vacío
        public clsUsuario() { }

        // Constructor con parámetros

        public clsUsuario(string personaId, string nombre_usuario, string contraseña, int rol_id)
        {
            this.personaId = personaId;
            this.nombre_usuario = nombre_usuario;
            this.contraseña = contraseña;

        }
    }
}
