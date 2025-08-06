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
        public frmProductoLista()
        {
            InitializeComponent();
        }

        private void frmProductoLista_Load(object sender, EventArgs e)
        {
            cargarLista();

        }

        private void cargarLista()
        {
            //throw new NotImplementedException();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProducto frmProducto = new frmProducto();
            frmProducto.ShowDialog();
        }
    }
}
