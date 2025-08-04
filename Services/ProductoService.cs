using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProductoService : Generica
    {
        //atributos

        //constructor


        //propiedades//encapsulados


        //metodos--acciones
        public void otro()
        {

            correr();
        }

       

        private void guardar()
        {

            ProductoDAO productoDAO = new ProductoDAO();
            productoDAO.guardar();


            Generica genererica = new Generica();
            

        }
   
    }
}
