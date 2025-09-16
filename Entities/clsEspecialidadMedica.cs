using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbEspecialidadMedica")]
    public class clsEspecialidadMedica
    {
        [Key]
        public int idEspecialidadMedica { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre de la especialidad no puede tener más de 100 caracteres")]
        public string nombreEspecialidad { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }

        public clsEspecialidadMedica() { }

        public clsEspecialidadMedica(int idEspecialidadMedica, string nombreEspecialidad, string descripcion, bool estado)
        {
            this.idEspecialidadMedica = idEspecialidadMedica;
            this.nombreEspecialidad = nombreEspecialidad;
            this.descripcion = descripcion;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"idEspecialidadMedica: {idEspecialidadMedica}, nombreEspecialidad: {nombreEspecialidad}, descripcion: {descripcion}, estado: {estado}";
        }
    }
}
