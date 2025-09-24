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
    public partial class frmDonacion : Form
    {
        public frmDonacion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDonacionSelectIdDonante_Click(object sender, EventArgs e)
        {
            //abro el formulario de donante en modo de seleccion
            frmDonanteLista formularioDonanteLista = new frmDonanteLista();
            formularioDonanteLista.ShowDialog();

            //cuando se cierre el formulario de donante, obtengo el id del donante seleccionado
            //txtDonacionIdDonante.Text = formularioDonanteLista.DonanteSeleccionadoId.ToString();
        }
    }
}
