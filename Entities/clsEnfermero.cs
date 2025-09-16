using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tbEnfermeros")]
    public class clsEnfermero
    {
        // Llave primaria compuesta de persona
        [Key, Column(Order = 0)]
        public string id { get; set; }
        [Key, Column(Order = 1)]
        public int tipoId { get; set; }

        [Required]
        [StringLength(300, ErrorMessage = "El área no puede tener más de 300 caracteres")]
        public string area { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El número de colegiado no puede tener más de 20 caracteres")]
        public string numeroColegiado { get; set; }

        // Auditoría
        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaCrea { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El usuario de creación no puede tener más de 100 caracteres")]
        public string usuarioCrea { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaUltMod { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El usuario de la última modificación no puede tener más de 100 caracteres")]
        public string usuarioUltMod { get; set; }

        [Required]
        public bool estado { get; set; }

        // Relación 1 a 1 con persona
        [ForeignKey("id, tipoId")]
        public clsPersona persona { get; set; }

        public clsEnfermero() { }

        public clsEnfermero(string id,int tipoId,string area,
            string numeroColegiado,
            DateTime fechaCrea,
            string usuarioCrea,
            DateTime fechaUltMod,
            string usuarioUltMod,
            bool estado
        )
        {
            this.id = id;
            this.tipoId = tipoId;
            this.area = area;
            this.numeroColegiado = numeroColegiado;
            
            this.usuarioCrea = usuarioCrea;
            this.fechaUltMod = fechaUltMod;
            this.usuarioUltMod = usuarioUltMod;
            this.estado = estado;
        }

        public override string ToString()
        {
            return $"id: {id}, tipoId: {tipoId}, area: {area}, " +
                $"numeroColegiado: {numeroColegiado}, fechaCrea: {fechaCrea}, " +
                $"usuarioCrea: {usuarioCrea}, fechaUltMod: {fechaUltMod}," +
                $" usuarioUltMod: {usuarioUltMod}, estado: {estado}";
        }
    }
}