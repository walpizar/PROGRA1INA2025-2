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
    public partial class frmListaActivos : Form
    {
        List<clsActivos> lista;
        private readonly ActivosServices _activoService;
        public frmListaActivos()
        {
            InitializeComponent();
            _activoService = new ActivosServices();

        }

        private void frmListaActivos_Load(object sender, EventArgs e)
        {
            this.lista = _activoService.consultarTodos();
            cargarLista(lista);
            try
            {
                this.lista = _activoService.consultarTodos();
                cargarLista(lista);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar la lista de activos");

            }
        }

        private void cargarLista(List<clsActivos> lista)
        {
            lstvListaActivos.Items.Clear();
            foreach (clsActivos activos in lista)
            {
                ListViewItem item = new ListViewItem(activos.idActivo.ToString());
                item.SubItems.Add(activos.nombreActivo);
                item.SubItems.Add(activos.descripcion);
                item.SubItems.Add(activos.idCategoria.ToString());
                // Si quieres mostrar más campos, agrégalos aquí
                lstvListaActivos.Items.Add(item);
            }



        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //filtrar por nombre y por el id
            var listaFiltrada = this.lista.Where(p => p.idActivo.ToString().ToUpper().Contains(txtBusqueda.Text.ToUpper()) || p.nombreActivo.ToUpper().Contains(txtBusqueda.Text.ToUpper())).ToList();
            cargarLista(listaFiltrada);
        }

        private void lstvListaActivos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                //validar si hay un elemento seleccionado
                if (lstvListaActivos.SelectedItems.Count > 0)
                {
                    //extraigo el id del producto seleccionado de la listview
                    int id = int.Parse(lstvListaActivos.SelectedItems[0].SubItems[0].Text);

                    //consulto el producto por id a la lista    

                    clsActivos activos = lista.Where(p => p.idActivo == id).SingleOrDefault();

                    if (activos != null)
                    {
                        //creo una instancia del formulario de producto
                        frmActivos frmActivos = new frmActivos();
                        //le asigno a la propiedad el producto seleccionado
                        frmActivos.activosSelected = activos;
                        //abro el formulario
                        frmActivos.ShowDialog();

                        //actualiar la lista
                        this.lista = _activoService.consultarTodos();
                        cargarLista(lista);
                    }


                }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al seleccionar el Activo de la lista");
            }
        }
    }
}
