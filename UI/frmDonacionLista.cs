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
    public partial class frmDonacionLista : Form
    {
        public frmDonacionLista()
        {
            InitializeComponent();
        }

        private void gbxDonacionLista_Enter(object sender, EventArgs e)
        {

        }



        private void btnNuevaDonacion_Click(object sender, EventArgs e)
        {
            //abro el formulario de donacion en modo de creacion
            frmDonacion formularioDonacion = new frmDonacion();
            formularioDonacion.ShowDialog();

            //cuando se cierre el formulario de donacion, actualizo la lista de donaciones
            //actualizarListaDonaciones();
        }

        private void lblMantDonacion_Click(object sender, EventArgs e)
        {

        }

        private void btnDonacionDetalle_Click(object sender, EventArgs e)
        {
            //abrir el formulario detalle de donacion en modo de vista
            frmDetalleDonacion formularioDetalleDonacion = new frmDetalleDonacion();
            formularioDetalleDonacion.ShowDialog();


        }
    }
}
