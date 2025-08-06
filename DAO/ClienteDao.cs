using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ClienteDao
    {
        public List<clsCliente> listaCliente { get; set; }

        public ClienteDao()
        {
            listaCliente = new List<clsCliente>();
        }

        public void crear(clsCliente cliente)
        {
            listaCliente.Add(cliente);
        }

        public void modificar(clsCliente cliente)
        {
            //expresion lambda
            //busco por id el cliente que quiero modificar en la lista 
            clsCliente clienteModificar = listaCliente.Where(p => p.id
                                                == cliente.id).SingleOrDefault();

            //int 
            // encuento el indice del cliente que quiero modificar, indice de la lista
            int indice = listaCliente.IndexOf(clienteModificar);
            //le caigo encima al indice del cliente que quiero modificar
            listaCliente[indice] = cliente;


        }

        public void eliminar(int id)
        {
            clsCliente clienteEliminar = listaCliente.Where(p => p.id
                                                == id).SingleOrDefault();
            listaCliente.Remove(clienteEliminar);

        }
        public clsCliente consultarPorID(int id)
        {
            return listaCliente.Where(p => p.id
                                                 == id).SingleOrDefault();
        }

        public List<clsCliente> consultarTodos()
        {
            return listaCliente;
        }




    }
}
