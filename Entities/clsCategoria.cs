using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbCategorias")]
    public class clsCategoria
    {
        [Key]
        public int idCategoria { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres")]
        public string nombreCategoria { get; set; }

        [StringLength(200, ErrorMessage = "La descripción no puede tener más de 200 caracteres")]
        public string descripcion { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool estado { get; set; }

        public clsCategoria(int idCategoria, string nombreCategoria, string descripcion)
        {
            this.idCategoria = idCategoria;
            this.nombreCategoria = nombreCategoria;
            this.descripcion = descripcion;
            this.estado = true; // Valor predeterminado, puedes ajustarlo si es necesario
        }

        //string tamplate para mostrar en el combo
        public string display => $" {idCategoria} - {nombreCategoria}"; 


        public override string ToString()
        {
            return $"idCategoria: {idCategoria}, nombreCategoria: {nombreCategoria}, descripcion: {descripcion}";
        }
    }
}
