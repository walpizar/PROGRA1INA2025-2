using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
        [Table("tbPermisos")]//TABLA INTERMEDIA
        public class clsPermiso
        {
            //LLAVE PRIMARIA COMPUESTA POR DOS FK

            public int idModulo { get; set; } //RELACION CON MODULO
            [ForeignKey("idModulo")]
            public clsModulo modulo { get; set; }//PROPIEDAD DE NAVEGACION PARA CONSULTAS

            public int idRol { get; set; } // RELACION CON ROL
            [ForeignKey("idRol")]
            public clsRol rol { get; set; }//PROPIEDAD DE NAVEGACION PARA CONSULTAS


            //NO SON METODOS, SON ATRIBUTOS QUE REPRESENTAN LOS PERMISOS ASIGNADOS
            [Required]
            [DefaultValue(false)]
            public bool consultar { get; set; }
            [Required]
            [DefaultValue(false)]
            public bool crear { get; set; }
            [Required]
            [DefaultValue(false)]
            public bool editar { get; set; }
            [Required]
            [DefaultValue(false)]
            public bool eliminar { get; set; }
        }
}
