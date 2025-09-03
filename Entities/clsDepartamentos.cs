using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbDepartamento")]
    public class clsDepartamentos
    {
        [Key]
        public int idDepartamento { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre del departamento no puede tener más de 100 caracteres")]
        public string nombreDepartamento { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        public bool estado { get; set; }
        
        [Required]
        public string usuarioCreacion { get; set; }
        [Required]
        public DateTime fechaCreacion { get; set; }

        public string usuarioModificacion { get; set; }
        public DateTime? fechaModificacion { get; set; }

        public clsDepartamentos() { }

        public clsDepartamentos(DateTime fechaCreacion,string usuarioCreacion, int idDepartamento, string nombreDepartamento, string descripcion, bool estado)
        {
            this.idDepartamento = idDepartamento;
            this.nombreDepartamento = nombreDepartamento;
            this.descripcion = descripcion;
            this.estado = estado;
            this.fechaCreacion = fechaCreacion;
            this.usuarioCreacion = usuarioCreacion;
        }

        public override string ToString()
        {
            return $"idDepartamento: {idDepartamento}, nombreDepartamento: {nombreDepartamento}, descripcion: {descripcion}, estado: {estado}";
        }
    }
}
