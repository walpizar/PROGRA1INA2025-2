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


        private readonly ProductoService _productoService;
        public frmProductoLista(ProductoService _proServ  )
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

            List<clsProducto> lista =  _productoService.consultarTodos();

            lstvLista.Items.Clear();

            foreach (clsProducto producto in lista)
            {
                ListViewItem item = new ListViewItem(producto.id.ToString());
                item.SubItems.Add(producto.getNombre());
                item.SubItems.Add(producto.precio.ToString());              
                lstvLista.Items.Add(item);
            }







        }
    }
}
