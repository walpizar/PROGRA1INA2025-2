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
    public partial class frmMedicosLista : Form
    {
        List<clsMedico> lista;
        private readonly MedicoService _medicoService;
        public frmMedicosLista()
        {
            _medicoService = new MedicoService();
            InitializeComponent();
        }

        private void frmMedicosLista_Load(object sender, EventArgs e)
        {
            try
            {
                this.lista = _medicoService.consultarTodos();
                cargarLista(this.lista);
            }
            catch (Exception)
            {

                MessageBox.Show("Error al cargar la lista de medicos");
            }

        }

        public void cargarLista(List<clsMedico> lista)
        {
            lstvLista.Items.Clear();

            //Solo se muestran los medicos activos y con persona activa (persona = true y medico = true)
            var medicosActivos = lista.Where(m =>
                m.estado == true &&
                m.persona != null &&
                m.persona.estado == true
                ).ToList();

            foreach (clsMedico medico in medicosActivos)
            {
                try
                {
                    ListViewItem item = new ListViewItem(medico.id.ToString());
                    item.SubItems.Add(medico.tipoId.ToString());
                    item.SubItems.Add(medico.persona.nombre);
                    item.SubItems.Add(medico.persona.apellido1);
                    item.SubItems.Add(medico.persona.apellido2);
                    item.SubItems.Add(medico.especialidad);
                    lstvLista.Items.Add(item);
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Error en metodo cargarlista");
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMedico frmMedico = new frmMedico();
                frmMedico.ShowDialog();
                
                this.lista = _medicoService.consultarTodos();
                cargarLista(this.lista);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void lstvLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstvLista_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvLista.SelectedItems.Count > 0)
            {
                // Obtengo el id del médico seleccionado
                string id = lstvLista.SelectedItems[0].SubItems[0].Text;
                // Obtengo el tipoId del medico seleccionado
                int tipoId = Convert.ToInt32(lstvLista.SelectedItems[0].SubItems[1].Text);

                // Busco el médico en la lista segun su id y tipoId
                clsMedico medico = lista.FirstOrDefault(m => m.id == id && m.tipoId == tipoId);

                if (medico != null)
                {
                    frmMedico frmMedico = new frmMedico();
                    frmMedico.medicoSelected = medico;                   
                    frmMedico.ShowDialog();
                    this.lista = _medicoService.consultarTodos();
                    cargarLista(this.lista);
                }
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBusqueda.Text.ToLower();
            var listaFiltrada = lista.Where
               (m => m.id.ToLower().Contains(filtro) ||
                m.tipoId.ToString().ToLower().Contains(filtro) ||
                m.persona.id.ToLower().Contains(filtro) ||
                m.persona.nombre.ToLower().Contains(filtro) ||
                m.persona.apellido1.ToLower().Contains(filtro) ||
                m.persona.apellido2.ToLower().Contains(filtro) ||
                m.especialidad.ToLower().Contains(filtro)
            ).ToList();
            cargarLista(listaFiltrada);
        }

        private void gbxListaMedicos_Enter(object sender, EventArgs e)
        {

        }
    }
}