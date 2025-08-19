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
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //para que sea autonumerico
        public int id { get; set; }
        //atributos

        [Required]
        [StringLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        private string nombre;
        //private decimal precio;
        //private int cantidad;

        //propiedades

        public void setNombre(string nombre)
        {
            ////validacion y comprobacion del dato, transformacion de datos
            //if (nombre.Length <= 5)
            //{
            //    throw new Exception("El nombre debe tener mas de 5 caracteres");

            //}
            this.nombre = nombre.ToUpper();
        }

        public string getNombre()
        {
            return this.nombre;
        }

        [Required]
        [Range(0, 1000000, ErrorMessage = "El precio debe estar entre 0 y 1000000")]
        public int precio { get; set; }

        [Required]
        [Range(0, 1000, ErrorMessage = "La cantidad debe estar entre 0 y 1000")]
        [Column("cantidad", TypeName = "int")]      
        public int cantidad { get; set; }


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
