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
    public partial class frmEspecialidadLista : Form
    {
        private readonly EspecialidadService _especialidadService; // Servicio de Especialidades
        List<clsEspecialidadMedica> lista; // Lista de especialidades

        public frmEspecialidadLista()
        {
            InitializeComponent();
            _especialidadService = new EspecialidadService();
        }

        private void frmEspecialidadLista_Load(object sender, EventArgs e)
        {
            cargarListaEspecialidades();
        }

        public void cargarListaEspecialidades()
        {
            lista = _especialidadService.consultarTodos();
            lstvListaEspecialidad.Items.Clear();

            foreach (clsEspecialidadMedica especialidad in lista)
            {
                ListViewItem item = new ListViewItem(especialidad.idEspecialidadMedica.ToString());
                item.SubItems.Add(especialidad.nombreEspecialidad);
                item.SubItems.Add(especialidad.descripcion);
                item.SubItems.Add(especialidad.estado ? "Activo" : "Inactivo");
                lstvListaEspecialidad.Items.Add(item);
            }
        }

        private void btnNuevaEspecialidad_Click(object sender, EventArgs e)
        {
            frmEspecialidad frm = new frmEspecialidad();
            frm.ShowDialog();
            cargarListaEspecialidades();
        }

        private void lstvListaEspecialidad_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvListaEspecialidad.SelectedItems.Count > 0)
            {
                int id = int.Parse(lstvListaEspecialidad.SelectedItems[0].SubItems[0].Text);
                clsEspecialidadMedica cliente = lista.Where(c => c.idEspecialidadMedica == id).SingleOrDefault();

                if (cliente != null)
                {
                    frmEspecialidad frm = new frmEspecialidad
                    {
                        especialidadSelected = cliente
                    };
                    frm.ShowDialog();
                    cargarListaEspecialidades();
                }
            }
        }

        // Eventos vacíos para diseño
        private void lblTitulo_TextChanged(object sender, EventArgs e) { }
        private void gbxListaEspecialidad_Enter(object sender, EventArgs e) { }
        private void txtBusquedaEspecialidad_TextChanged(object sender, EventArgs e) { }
        private void btnNuevaEspecialidad_TextChanged(object sender, EventArgs e) { }
        private void lstvListaEspecialidad_SelectedIndexChanged(object sender, EventArgs e) { }


    }
}
