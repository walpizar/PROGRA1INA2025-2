using Entities;
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
    public partial class frmEnfermeroLista : Form
    {
        List<clsEnfermero> lista;
        private readonly EnfermeroService _enfermeroService;
        public frmEnfermeroLista()
        {
            _enfermeroService = new EnfermeroService();
            InitializeComponent();
        }

        private void frmEnfermeroLista_Load(object sender, EventArgs e)
        {
            try
            {
                this.lista = _enfermeroService.consultarTodos();
                cargarLista(this.lista);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar la lista de enfermeros");
            }
        }

        private void cargarLista(List<clsEnfermero> lista)
        {
            lstvLista.Items.Clear();

            //Solo se muestran los enfermeros activos y con persona activa (persona = true y enfermero = true)
            var enfemerosActivos = lista.Where(e =>
                e.estado == true &&
                e.persona != null &&
                e.persona.estado == true
                ).ToList();

            foreach (clsEnfermero enfermero in enfemerosActivos)
            {
                ListViewItem item = new ListViewItem(enfermero.id.ToString());
                item.SubItems.Add(enfermero.persona.tipoId.ToString());
                item.SubItems.Add(enfermero.persona.nombre);
                item.SubItems.Add(enfermero.persona.apellido1);
                item.SubItems.Add(enfermero.persona.apellido2);
                item.SubItems.Add(enfermero.area);
                lstvLista.Items.Add(item);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmEnfermeros frmEnfermeros = new frmEnfermeros();
                frmEnfermeros.ShowDialog();
                this.lista = _enfermeroService.consultarTodos();
                cargarLista(this.lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.ToLower();
            var listaFiltrada = lista.Where(e =>
                e.id.ToLower().Contains(filtro) ||
                e.tipoId.ToString().ToLower().Contains(filtro) ||
                e.persona.id.ToLower().Contains(filtro) ||
                e.persona.nombre.ToLower().Contains(filtro) ||
                e.persona.apellido1.ToLower().Contains(filtro) ||
                e.persona.apellido2.ToLower().Contains(filtro) ||
                e.area.ToLower().Contains(filtro)
            ).ToList();
            cargarLista(listaFiltrada);
        }

        private void lstvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvLista.SelectedItems.Count > 0)
            {
                // Obtengo el id del médico seleccionado
                string id = lstvLista.SelectedItems[0].SubItems[0].Text;
                // Obtengo el tipoId del medico seleccionado
                int tipoId = Convert.ToInt32(lstvLista.SelectedItems[0].SubItems[1].Text);

                // Busco el médico en la lista
                clsEnfermero enfermero = lista.Find(e => e.id == id && e.tipoId == tipoId);

                if (enfermero != null)
                {
                    frmEnfermeros frmEnfermeros = new frmEnfermeros();
                    frmEnfermeros.enfermeroSelected = enfermero;
                    frmEnfermeros.ShowDialog();
                    //actualizar la lista
                    this.lista = _enfermeroService.consultarTodos();
                    cargarLista(this.lista);
                }
            }
        }
    }
}
