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
    public partial class frmDonanteLista : Form
    {
        public frmDonanteLista()
        {
            InitializeComponent();
        }

        private void frmDonanteLista_Load(object sender, EventArgs e)
        {

        }
        private void btnNuevoDonante_Click(object sender, EventArgs e)
        {
            //abro el formulario de donante en modo de creacion
            frmDonante formularioDonante = new frmDonante();
            formularioDonante.ShowDialog();

            //cuando se cierre el formulario de donante, actualizo la lista de donantes
            //actualizarListaDonantes();
        }
    }
}
