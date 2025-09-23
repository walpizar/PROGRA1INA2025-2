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
    public partial class frmGastosLista : Form
    {
        public frmGastosLista()
        {
            InitializeComponent();
        }
        private void frmGastosLista_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            { // Crear nuevo departamento
                using (var frm = new frmGastos())
                {
                    if (frm.ShowDialog(this) == DialogResult.OK)
                    {
                      //  CargarDepartamentos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir formulario de creación: {ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lstvListaGastos_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

    }
}
