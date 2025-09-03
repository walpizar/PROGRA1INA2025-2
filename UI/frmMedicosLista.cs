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
    public partial class frmMedicosLista : Form
    {
        public frmMedicosLista()
        {
            InitializeComponent();
        }

        private void frmMedicosLista_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMedico frmMedico = new frmMedico();
                frmMedico.ShowDialog();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
