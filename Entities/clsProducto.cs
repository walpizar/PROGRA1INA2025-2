using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [Table("tbProductos")]
    public class clsProducto
    {
        //atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }
       
        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        public string nombre { get; set; }
        
        [Required]
        [Range(0, 1000000, ErrorMessage = "El precio debe estar entre 0 y 1000000")]
        public int precio { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "La cantidad debe estar entre 0 y 1000")]
        [Column("cantidad", TypeName = "int")]      
        public int cantidad { get; set; }

        [Required]
        public int familia { get; set; }

        public int CategoriaId { get; set; }
        public clsCategoria Categoria { get; set; }



        //constructor
        //sobrecarga de constructores
        public clsProducto(int id,string nombre, int precio, int cantidad)
        {
            this.id = id;
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
        }

        public clsProducto()
        {
           
        }

       

        //metodos
        public decimal calcularPrecioTotal() {
            return this.precio * this.cantidad;
        }

        private string transformarNombre()
        {
            return this.nombre.ToUpper();
        }





    }
}
