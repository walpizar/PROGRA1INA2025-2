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
        //atributos con decoradores
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

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

        //constructor vacio
        public clsPersona() { }

        //constructor con parametros
        public clsPersona(string id, string nombre, string apellido1, string apellido2, DateTime fechaNac, string email, string direccion, string telefono, bool estado)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.fechaNac = fechaNac;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.estado = estado;
        }

        //metodo toString
        public override string ToString()
        {
            return $"ID: {id}, Nombre: {nombre}, Apellido1: {apellido1}, Apellido2: {apellido2}, FechaNac: {fechaNac.ToShortDateString()}, Email: {email}, Direccion: {direccion}, Telefono: {telefono}, Estado: {estado}";
        }
        //relacion 1 a 1 con donante
        public clsDonante Donante { get; set; }
    }
}
