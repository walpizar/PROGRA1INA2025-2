using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbPuestos")]
    public class clsPuestos
    {
        [Key]
        public int idPuesto { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del puesto no puede tener más de 100 caracteres")]
        public string nombrePuesto { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        public clsPuestos() { }

        public clsPuestos(int idPuesto, string nombrePuesto, string descripcion, bool estado)
        {
            this.idPuesto = idPuesto;
            this.nombrePuesto = nombrePuesto;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"idPuesto: {idPuesto}, nombrePuesto: {nombrePuesto}, descripcion: {descripcion}, estado: {estado}";
        }
    }
}
