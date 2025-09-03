using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbPersonas")]
    public class clsPersona
    {
        // atributos con decoradores en camelCase
        public string id { get; set; }
        public int tipoId { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(50, ErrorMessage = "El nombre no puede superar los 50 caracteres.")]
        public string nombre { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio.")]
        [StringLength(50, ErrorMessage = "El primer apellido no puede superar los 50 caracteres.")]
        public string apellido1 { get; set; }

        [StringLength(50, ErrorMessage = "El segundo apellido no puede superar los 50 caracteres.")]
        public string apellido2 { get; set; }

        [Required(ErrorMessage = "La fecha de nacimiento es obligatoria.")]
        public DateTime fechaNac { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        [StringLength(100, ErrorMessage = "El correo electrónico no puede superar los 100 caracteres.")]
        public string email { get; set; }

        [StringLength(200, ErrorMessage = "La dirección no puede superar los 200 caracteres.")]
        public string direccion { get; set; }

        [Phone(ErrorMessage = "El formato del teléfono no es válido.")]
        [StringLength(20, ErrorMessage = "El teléfono no puede superar los 20 caracteres.")]
        public string telefono { get; set; }

        public bool estado { get; set; }

        // relación 1 a 1 con donante en camelCase
        public clsDonante donante { get; set; }

        // constructor vacío
        public clsPersona() { }

        // constructor con parámetros en camelCase
        public clsPersona(string id, int tipoId, string nombre, string apellido1, string apellido2, DateTime fechaNac, string email, string direccion, string telefono, bool estado)
        {
            this.id = id;
            this.tipoId = tipoId;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fechaNac = fechaNac;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.estado = estado;
        }

        // método toString
        public override string ToString()
        {
            return $"id: {id}, tipoId: {tipoId}, nombre: {nombre}, apellido1: {apellido1}, apellido2: {apellido2}, fechaNac: {fechaNac.ToShortDateString()}, email: {email}, direccion: {direccion}, telefono: {telefono}, estado: {estado}";
        }
    }
}
