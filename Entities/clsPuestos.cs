using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbPuestos")]
    public class clsPuestos
    {
        [Key]
        public int idPuesto { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "El codigo no puede tener más de 20 caracteres")]
        public string codigo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El codigo no puede tener más de 100 caracteres")]
        public string Nombre { get; set; }

        [Required]
        [StringLength(250, ErrorMessage = "La descripcion no puede tener más de 250 caracteres")]
        public string descripcion { get; set; }


        [Required]
        public int idDepartamento { get; set; }
        [ForeignKey("idDepartamento")]
        public clsDepartamentos Departamento { get; set; }

        // este es cuando se desactiva el puesto, debe guardar el motivo.

        [StringLength(300, ErrorMessage = "El motivo no puede tener mas de 300 caracteres")]
        public string motivoInactivo { get; set; }

        // auditoria

        [Required]
        public bool Estado { get; set; } = true;

        [Required]
        public DateTime fecha_crea { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario_crea { get; set; }

        public DateTime fecha_ult_mod { get; set; }

        [StringLength(50)]
        public string? usuario_ult_mod { get; set; }

        // constructor
        public clsPuestos() { }

        public clsPuestos(string codigo, string nombre, int departamentoID, string usuario)
        {
            this.codigo = codigo;
            this.Nombre = nombre;
            this.idDepartamento = departamentoID;
            this.usuario_crea = usuario;
        }

        // métodos
        public void Inactivar(string motivo, string usuario)
        {
            this.Estado = false;
            this.motivoInactivo = motivo;
            this.usuario_ult_mod = usuario;
            this.fecha_ult_mod = DateTime.UtcNow;
        }

        public void Reactivar(string usuario)
        {
            this.Estado = true;
            this.motivoInactivo = null;
            this.usuario_ult_mod = usuario;
            this.fecha_ult_mod = DateTime.UtcNow;

            //UtcNow devuelve la fecha y hora actual de la computadora.
        }
    }
}
