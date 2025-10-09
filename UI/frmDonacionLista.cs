using Entities;
using Services;
using System;
using System.CodeDom;
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
    public partial class frmDonacionLista : Form
    {
        //lista de donaciones
        private List<clsDonacion> donacionLst = new List<clsDonacion>();

        //instancio el servicio de donacion
        public DonacionService donacionService;



        public frmDonacionLista()
        {
            //inicializo la lista de donaciones
            donacionService = new DonacionService();

            InitializeComponent();
        }

        private void frmDonacionLista_Load(object sender, EventArgs e)
        {
            try
            {

                donacionLst = donacionService.consultarTodos();
                cargarLista(donacionLst);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de donaciones: " + ex.Message);
            }

        }

        private void cargarLista(List<clsDonacion> donacionLst)
        {
            lstvwDonacionLista.Items.Clear();

            foreach (var donacion in donacionLst)
            {
                var idTipoDonacionName = donacion.tipoDonacion != null ? donacion.tipoDonacion.nombreTipoDonacion : "Sin tipo";
                var item = new ListViewItem(donacion.idDonacion.ToString());
                item.SubItems.Add(donacion.donanteId.ToString());
                //var tipoDonacionNombre = donacion.tipoDonacion?.nombreTipoDonacion ?? "Sin tipo";
                item.SubItems.Add(idTipoDonacionName);
                item.SubItems.Add(donacion.fechaDonacion.ToString("dd/MM/yyyy"));
                item.SubItems.Add(donacion.observaciones);

                lstvwDonacionLista.Items.Add(item);
            }
        }

        private void btnNuevaDonacion_Click(object sender, EventArgs e)
        {
            //abro el formulario de donacion en modo de creacion
            frmDonacion formularioDonacion = new frmDonacion();
            formularioDonacion.ShowDialog();

            // Actualiza la lista después de cerrar el formulario
            donacionLst = donacionService.consultarTodos();
            cargarLista(donacionLst);
        }

        private void btnDonacionDetalle_Click(object sender, EventArgs e)
        {

            //abrir el formulario detalle de donacion en modo de vista
            frmDetalleDonacion formularioDetalleDonacion = new frmDetalleDonacion();

            //seteo la instancia de donacion al parametro del formulario detalle
            formularioDetalleDonacion.donacionsSelected = donacionLst.Find(d => d.idDonacion.ToString() == lstvwDonacionLista.SelectedItems[0].Text);

            formularioDetalleDonacion.ShowDialog();
        }

        private void txtbxBuscarDonacion_TextChanged(object sender, EventArgs e)
        {
            //filtro donacion por ID, iddonante, tipo donacion
            var filtro = txtbxBuscarDonacion.Text.ToLower();
            var donacionFiltrada = donacionLst.Where(d =>
                d.idDonacion.ToString().Contains(filtro) ||
                d.donanteId.ToString().Contains(filtro) ||
                (d.tipoDonacion != null && d.tipoDonacion.nombreTipoDonacion.ToLower().Contains(filtro))
            ).ToList();

            cargarLista(donacionFiltrada);
        }

        private void lstvwDonacionLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //busco el id de la donacion seleccionada
            int id = int.Parse(lstvwDonacionLista.SelectedItems[0].Text);
            var donacionSeleccionada = donacionLst.Find(d => d.idDonacion == id);

            //abro el formulario de donacion en modo edicion
            frmDonacion formularioDonacion = new frmDonacion();
            formularioDonacion.donacionSelected = donacionSeleccionada;
            formularioDonacion.ShowDialog();

            // Actualiza la lista después de cerrar el formulario
            donacionLst = donacionService.consultarTodos();
            cargarLista(donacionLst);
        }

        
    }
}
