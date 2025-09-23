using Entities;
using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*namespace UI
{
    public partial class frmProductoLista : Form
    {
        List<clsProducto> _listaUsuarios;

        private readonly ProductoService _productoService;
        public frmProductoLista()
        {
            InitializeComponent();
            _productoService = new ProductoService();
        }

        private void frmProductoLista_Load(object sender, EventArgs e)
        {
            try
            {
                this._listaUsuarios = _productoService.consultarTodos();
                cargarLista(_listaUsuarios);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar la _listaUsuarios de productos");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmProducto frmProducto = new frmProducto();
                frmProducto.ShowDialog();


                //actualiar la _listaUsuarios
                this._listaUsuarios = _productoService.consultarTodos();
                cargarLista(_listaUsuarios);


               

            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void cargarLista(List<clsProducto> _listaUsuarios)
        {
            if (lista == null) lista = new List<clsProducto>();

            lstvLista.Items.Clear();

            foreach (clsProducto producto in _listaUsuarios)
            {
                ListViewItem item = new ListViewItem(producto.id.ToString());
                item.SubItems.Add(producto.nombre);
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
                if (lstvLista.SelectedItems.Count > 0)
                {
                    //extraigo el id del producto seleccionado de la listview
                    int id = int.Parse(lstvLista.SelectedItems[0].SubItems[0].Text);

                    //consulto el producto por id a la _listaUsuarios    

                    clsProducto producto = _listaUsuarios.Where(p => p.id == id).SingleOrDefault();

                    if (producto != null)
                    {
                        //creo una instancia del formulario de producto
                        frmProducto frmProducto = new frmProducto();
                        //le asigno a la propiedad el producto seleccionado
                        frmProducto.productoSelected = producto;
                        //abro el formulario
                        frmProducto.ShowDialog();

                        //actualiar la _listaUsuarios
                        this._listaUsuarios = _productoService.consultarTodos();
                        cargarLista(_listaUsuarios);
                    }


                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al seleccionar el producto de la _listaUsuarios");
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //FILTRAR POR NOMBRE Y POR EL ID
            var listaFiltrada = this._listaUsuarios.Where(p => p.id.ToString().ToUpper()
            .Contains(txtBusqueda.Text.ToUpper()) || 
            p.nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();

            cargarLista(listaFiltrada);




        }
    }
}*/
