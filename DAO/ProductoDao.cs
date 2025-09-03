using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Interfaces;

namespace DAO
{
    public class ProductoDao: IGenerica<clsProducto>
    {
        //CRUD
        private dbContextINA _context;  


        //public List<clsProducto> listaProducto { get; set; }

        public ProductoDao()
        {
            _context= new dbContextINA();
           // listaProducto = new List<clsProducto>();
        }

        public void crear(clsProducto producto)
        {
            // listaProducto.Add(producto);
            //_context.Entry(clsMedico.Persona).State = EntityState.Added;


            //_context.Producto.Add(producto);
            //_context.SaveChanges();
        }

        public void modificar(clsProducto producto)
        {
           
            //_context.Producto.Update(producto);
            //_context.SaveChanges();



            //expresion lambda
            //busco por id el producto que quiero modificar en la lista 
            //clsProducto prodModificar = listaProducto.Where(p => p.id
            //== producto.id).SingleOrDefault();

            // clsProducto prodModificar = listaProducto.SingleOrDefault(p => p.id
            //            == producto.id);
            //int 
            // encuento el indice del producto que quiero modificar, indice de la lista
            //int indice = listaProducto.IndexOf(prodModificar);
            //le caigo encima al indice del producto que quiero modificar
            //listaProducto[indice] = producto;


        }

        public void eliminar(int id)
        {
           // var prod = consultarPorID(id);
           // _context.Producto.Remove(prod);
           // _context.SaveChanges();

           //// clsProducto prodEliminar = listaProducto.Where(p => p.id
           //                                    // == id).SingleOrDefault();
           // listaProducto.Remove(prodEliminar);

        }
        public clsProducto consultarPorID(int id)
        {
          //return  _context.Producto.Where(p => p.id
                                               //== id).SingleOrDefault();

            return null;
        }



        public clsProducto consultarPorNombre(string nombre)
        {
            //return _context.Producto.Where(p => p.nombre.Trim().ToUpper()
            //                                     == nombre.Trim().ToUpper()).SingleOrDefault()
            //
            //                                     ;

            return null;
        }


        public List<clsProducto> consultarTodos()
        {
            try
            {
                using (var context = new dbContextINA())
                {
                    return context.Productos.ToList(); // si no hay, devuelve []
                }
            }
            catch
            {
                return new List<clsProducto>();
            }
        }



    }
}
