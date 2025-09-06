using Entities;
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
    public partial class frmTipoAyuda : Form
    {

        public clsTiposAyudas selectTiposAyudas { get; set; }
        public frmTipoAyuda()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (true)
                {
                    clsTiposAyudas tiposAyudas = selectTiposAyudas == null ? new clsTiposAyudas() : selectTiposAyudas;

                    tiposAyudas.nombre = txtNombre.Text;
                    tiposAyudas.descripcion = txtDescripcion.Text;
                    tiposAyudas.responsable = (int)cboResponsable.SelectedItem;
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void limpiarForm()
        {
            txtNombre.ResetText();
        }

        private void InitializeComponent()
        {

        }
    }
}
