//using Entities;
//using Services;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

<<<<<<< HEAD
//namespace UI
//{
//    public partial class frmProductoLista : Form
//    {
//        List<clsProducto> lista;
=======
/*namespace UI
{
    public partial class frmProductoLista : Form
    {
        List<clsProducto> _listaUsuarios;
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

//        private readonly ProductoService _productoService;
//        public frmProductoLista()
//        {
//            InitializeComponent();
//            _productoService = new ProductoService();
//        }

<<<<<<< HEAD
//        private void frmProductoLista_Load(object sender, EventArgs e)
//        {
//            try
//            {
//                this.lista = _productoService.consultarTodos();
//                cargarLista(lista);
//            }
//            catch (Exception)
//            {

//                MessageBox.Show("Error al cargar la lista de productos");
//            }
=======
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
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

//        }

//        private void btnNuevo_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                frmProducto frmProducto = new frmProducto();
//                frmProducto.ShowDialog();


<<<<<<< HEAD
//                //actualiar la lista
//                this.lista = _productoService.consultarTodos();
//                cargarLista(lista);
=======
                //actualiar la _listaUsuarios
                this._listaUsuarios = _productoService.consultarTodos();
                cargarLista(_listaUsuarios);
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4


               

//            }
//            catch (Exception)
//            {

//                throw;
//            }
           

//        }

<<<<<<< HEAD
//        private void cargarLista(List<clsProducto> lista)
//        {

           
=======
        private void cargarLista(List<clsProducto> _listaUsuarios)
        {
            if (lista == null) lista = new List<clsProducto>();
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

//            lstvLista.Items.Clear();

<<<<<<< HEAD
//            foreach (clsProducto producto in lista)
//            {
//                ListViewItem item = new ListViewItem(producto.id.ToString());
//                item.SubItems.Add(producto.nombre);
//                item.SubItems.Add(producto.precio.ToString());
//                lstvLista.Items.Add(item);
//            }

//        }
=======
            foreach (clsProducto producto in _listaUsuarios)
            {
                ListViewItem item = new ListViewItem(producto.id.ToString());
                item.SubItems.Add(producto.nombre);
                item.SubItems.Add(producto.precio.ToString());
                lstvLista.Items.Add(item);
            }
        }
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

//        private void lstvLista_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void lstvLista_MouseDoubleClick(object sender, MouseEventArgs e)
//        {
//            try
//            {
//                //validar si hay un elemento seleccionado
//                if (lstvLista.SelectedItems.Count > 0)
//                {
//                    //extraigo el id del producto seleccionado de la listview
//                    int id = int.Parse(lstvLista.SelectedItems[0].SubItems[0].Text);

<<<<<<< HEAD
//                    //consulto el producto por id a la lista    

//                    clsProducto producto = lista.Where(p => p.id == id).SingleOrDefault();
=======
                    //consulto el producto por id a la _listaUsuarios    

<<<<<<< HEAD
                    clsProducto producto = _listaUsuarios.Where(p => p.id == id).SingleOrDefault();
=======
                    clsProducto producto = lista.Where(p => p.id.Equals(id)).SingleOrDefault();
>>>>>>> 12b8aef8e1a45169e765f6fe9b12c66e91c9845e
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

//                    if (producto != null)
//                    {
//                        //creo una instancia del formulario de producto
//                        frmProducto frmProducto = new frmProducto();
//                        //le asigno a la propiedad el producto seleccionado
//                        frmProducto.productoSelected = producto;
//                        //abro el formulario
//                        frmProducto.ShowDialog();

<<<<<<< HEAD
//                        //actualiar la lista
//                        this.lista = _productoService.consultarTodos();
//                        cargarLista(lista);
//                    }
=======
                        //actualiar la _listaUsuarios
                        this._listaUsuarios = _productoService.consultarTodos();
                        cargarLista(_listaUsuarios);
                    }
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4


//                }

//            }
//            catch (Exception)
//            {

<<<<<<< HEAD
//                MessageBox.Show("Error al seleccionar el producto de la lista");
//            }
//        }

//        private void txtBusqueda_TextChanged(object sender, EventArgs e)
//        {
//            //FILTRAR POR NOMBRE Y POR EL ID
//            var listaFiltrada = this.lista.Where(p => p.id.ToString().ToUpper()
//            .Contains(txtBusqueda.Text.ToUpper()) || 
//            p.nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();
=======
                MessageBox.Show("Error al seleccionar el producto de la _listaUsuarios");
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //FILTRAR POR NOMBRE Y POR EL ID
            var listaFiltrada = this._listaUsuarios.Where(p => p.id.ToString().ToUpper()
            .Contains(txtBusqueda.Text.ToUpper()) || 
            p.nombre.ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();
>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

//            cargarLista(listaFiltrada);




//        }
//    }

