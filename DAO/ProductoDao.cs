using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ProductoDao
    {
        //CRUD

        public List<clsProducto> listaProducto { get; set; }

        public ProductoDao()
        {
            listaProducto = new List<clsProducto>();
        }

        public void crear(clsProducto producto)
        {
            listaProducto.Add(producto);
        }

        public void modificar(clsProducto producto)
        {
            //expresion lambda
            //busco por id el producto que quiero modificar en la lista 
            clsProducto prodModificar = listaProducto.Where(p => p.id
                                                == producto.id).SingleOrDefault();

            // clsProducto prodModificar = listaProducto.SingleOrDefault(p => p.id
            //            == producto.id);
            //int 
            // encuento el indice del producto que quiero modificar, indice de la lista
            int indice = listaProducto.IndexOf(prodModificar);
            //le caigo encima al indice del producto que quiero modificar
            listaProducto[indice] = producto;


        }

        public void eliminar(int id)
        {
            clsProducto prodEliminar = listaProducto.Where(p => p.id
                                                == id).SingleOrDefault();
            listaProducto.Remove(prodEliminar);

        }
        public clsProducto consultarPorID(int id)
        {
          return  listaProducto.Where(p => p.id
                                               == id).SingleOrDefault();
        }
        public clsProducto consultarPorNombre(string nombre)
        {
            return listaProducto.Where(p => p.getNombre().Trim().ToUpper()
                                                 == nombre.Trim().ToUpper()).SingleOrDefault();
        }


        public List<clsProducto> consultarTodos()
        {
            return listaProducto;
        }






      

    }
}
