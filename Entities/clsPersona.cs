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
        public int id { get; set; }
        public int PersonaTipoId { get; set; }

        [Required, StringLength(50)]
        public string nombre { get; set; }

        [Required, StringLength(50)]
        public string apellido1 { get; set; }

        [StringLength(50)]
        public string apellido2 { get; set; }

        [Required]
        public DateTime fechaNac { get; set; }

        [Required, EmailAddress, StringLength(100)]
        public string email { get; set; }

        [StringLength(200)]
        public string direccion { get; set; }

        [Phone, StringLength(20)]
        public string telefono { get; set; }

        public bool estado { get; set; }

        // Relación 1 a 1 con Donante
        public clsDonante Donante { get; set; }
        //constructor vacio
        public clsPersona() { }

        //constructor con parametros
        public clsPersona(int id, string nombre, string apellido1, string apellido2, DateTime fechaNac, string email, string direccion, string telefono, bool estado)
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
    }
}
  

