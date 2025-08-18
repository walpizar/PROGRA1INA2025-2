using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmProductoLista : Form
    {
        List<clsProducto> lista;

        private readonly ProductoService _productoService;
        public frmProductoLista(ProductoService _proServ)
        {
            InitializeComponent();
            _productoService = _proServ;
        }

        private void frmProductoLista_Load(object sender, EventArgs e)
        {
            cargarLista();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto(_productoService);
            frmProducto.ShowDialog();


            //actualiar la lista
            cargarLista();


        }

        private void cargarLista()
        {

            this.lista = _productoService.consultarTodos();

            lstvLista.Items.Clear();

            foreach (clsProducto producto in lista)
            {
                ListViewItem item = new ListViewItem(producto.id.ToString());
                item.SubItems.Add(producto.getNombre());
                item.SubItems.Add(producto.precio.ToString());
                lstvLista.Items.Add(item);
            }

        }

        private void lstvLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //validar si hay un elemento seleccionado
                if(lstvLista.SelectedItems.Count > 0)
                {
                    //extraigo el id del producto seleccionado de la listview
                    int id = int.Parse(lstvLista.SelectedItems[0].SubItems[0].Text);

                    //consulto el producto por id a la lista    

                    clsProducto producto= lista.Where(p => p.id == id).SingleOrDefault();

                    if(producto != null)
                    {
                        //creo una instancia del formulario de producto
                        frmProducto frmProducto = new frmProducto(_productoService);
                        //le asigno a la propiedad el producto seleccionado
                        frmProducto.productoSelected = producto;
                        //abro el formulario
                        frmProducto.ShowDialog();

                        //actualiar la lista
                        cargarLista();
                    }   
              

                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al seleccionar el producto de la lista");
            }
        }
    }
}
