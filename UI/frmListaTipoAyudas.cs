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
            if (lvtCatalogoTipoAyuda.SelectedItems.Count > 0)
            {
                // Obtener ID seleccionado
                int idSeleccionado = int.Parse(lvtCatalogoTipoAyuda.SelectedItems[0].Text);

                // Consultar el registro desde el servicio
                var tipoAyuda = _tipoAyudasService.ConsultarPorID(idSeleccionado);

                if (tipoAyuda != null)
                {
                    // Abrir el formulario en modo edición
                    frmTipoAyuda frm = new frmTipoAyuda();
                    frm.selectTiposAyudas = tipoAyuda; // Pasamos la entidad existente
                    frm.ShowDialog();

                    // Refrescar lista después de cerrar
                    cargarTiposAyuda();
                }
            }

        }

        //Cargar datos al iniciar el formulario
        private void frmListaTipoAyudas_Load(object sender, EventArgs e)
        {
            //llamar al metodo para cargar los tipos de ayuda
            cargarTiposAyuda();
        }

        // Filtrar la lista mientras se escribe en el cuadro de búsqueda
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            //llamar al metodo para buscar los tipos de ayuda
            buscarTiposAyudas(txtBusqueda.Text);
        }

        // Método para buscar y filtrar tipos de ayuda
        private void buscarTiposAyudas(string filtro)
        {
            // Limpiar la lista antes de aplicar el filtro
            lvtCatalogoTipoAyuda.Items.Clear();

            // Obtener todos los tipos de ayuda
            var lista = _tipoAyudasService.ConsultarTodos();

            // Filtrar por nombre
            var filtrados = lista
                .Where(t => string.IsNullOrEmpty(filtro) ||
                            t.nombre.Contains(filtro, StringComparison.OrdinalIgnoreCase))
                .ToList();

            // Agregar los elementos filtrados a la lista
            foreach (var t in filtrados)
            {
                ListViewItem item = new ListViewItem(t.id_tipoAyuda.ToString());
                item.SubItems.Add(t.nombre ?? "");
                item.SubItems.Add(t.id_responsable ?? "");

                lvtCatalogoTipoAyuda.Items.Add(item);
            }
        }
    }
}
