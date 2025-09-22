using DAO;
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
    public partial class frmListaTipoAyudas : Form
    {
        private readonly TipoAyudasService _tipoAyudasService;

        public frmListaTipoAyudas()
        {
            InitializeComponent();
            _tipoAyudasService = new TipoAyudasService();


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoAyuda frmTipoAyuda = new frmTipoAyuda();
            if (frmTipoAyuda.ShowDialog() == DialogResult.OK)
            {
                cargarTiposAyuda();
            }

        }


        private void cargarTiposAyuda()
        {
            lvtCatalogoTipoAyuda.Items.Clear(); // limpiar filas

            // Solo definir columnas si aún no están
            if (lvtCatalogoTipoAyuda.Columns.Count == 0)
            {
                lvtCatalogoTipoAyuda.Columns.Add("ID", 80);
                lvtCatalogoTipoAyuda.Columns.Add("Nombre", 150);
                lvtCatalogoTipoAyuda.Columns.Add("Responsable", 150);
            }

            var lista = _tipoAyudasService.ConsultarTodos();

            foreach (var t in lista)
            {
                ListViewItem item = new ListViewItem(t.id_tipoAyuda.ToString()); // Columna ID
                item.SubItems.Add(t.nombre ?? "");                              // Columna Nombre
                item.SubItems.Add(t.id_responsable ?? "");                      // Columna Responsable

                lvtCatalogoTipoAyuda.Items.Add(item);
            }
        }


        private void lvtCatalogoTipoAyuda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmListaTipoAyudas_Load(object sender, EventArgs e)
        {
            cargarTiposAyuda();
        }

        
    }
}
