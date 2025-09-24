using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    [Table("tb_tipoAyuda")]
    public class clsTiposAyudas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tipoAyuda { get; set; }

        [Required]
        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(300)]
        public string descripcion { get; set; }

        //Responsable
        [Required]
        [StringLength(20)]
        public string id_responsable { get; set; }

        [Required]
        public int personaTipoId_responsable { get; set; }

        //Auditoría
        [Required]
        [StringLength(20)]
        public string id_usuarioCrea { get; set; }

        [Required]
        public int personaTipoId_usuarioCrea { get; set; }

        [Required]
        [StringLength(20)]
        public string id_usuarioUltimaModificacion { get; set; }

        [Required]
        public int personaTipoId_usuarioUltimaModificacion { get; set; }

        [Required]
        public DateTime fecha_crea { get; set; }

        [Required]
        public DateTime fecha_ultimaModificacion { get; set; }

        [Required]
        public bool estado { get; set; }

        // Constructor
        public clsTiposAyudas()
        {
            fecha_crea = DateTime.Now;
            fecha_ultimaModificacion = DateTime.Now;
            estado = true;
        }

        // Constructor con datos clave
        public clsTiposAyudas(
            string nombre,
            string descripcion,
            string idResponsable,
            int tipoResponsable,
            string idUsuarioCrea,
            int tipoUsuarioCrea
        )
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.id_responsable = idResponsable;
            this.personaTipoId_responsable = tipoResponsable;

            this.id_usuarioCrea = idUsuarioCrea;
            this.personaTipoId_usuarioCrea = tipoUsuarioCrea;

            this.id_usuarioUltimaModificacion = idUsuarioCrea;
            this.personaTipoId_usuarioUltimaModificacion = tipoUsuarioCrea;

            this.fecha_crea = DateTime.Now;
            this.fecha_ultimaModificacion = DateTime.Now;
            this.estado = true;
        }
    }
}

