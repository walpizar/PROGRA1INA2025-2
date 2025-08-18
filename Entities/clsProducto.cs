using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class clsProducto
    {
        //atributos
        public int id { get; set; }
        //atributos
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

        public int precio { get; set; }
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
