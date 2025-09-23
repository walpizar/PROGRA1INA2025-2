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
        private readonly EspecialidadService _especialidadService; //SERVICIO DE ESPECIALIDAD
        List<clsEspecialidadMedica> lista; //LISTA DE ESPECIALIDADES

        public frmEspecialidadLista()
        {
            InitializeComponent();
            _especialidadService = new EspecialidadService(); //INICIALIZAR SERVICIO
        }

        private void frmEspecialidadLista_Load(object sender, EventArgs e)
        {
            cargarListaEspecialidades();
        }

        public void cargarListaEspecialidades(string filtro = "")
        {
            // OBTENER TODAS LAS ESPECIALIDADES
            lista = _especialidadService.consultarTodos();

            // FILTRAR SOLO LOS ACTIVOS
            lista = lista.Where(e => e.estado).ToList();

            // APLICAR FILTRO POR ID, NOMBRE O DESCRIPCIÓN SI HAY TEXTO
            if (!string.IsNullOrWhiteSpace(filtro))
            {
                filtro = filtro.Trim().ToLower();
                bool esNumero = int.TryParse(filtro, out int filtroId);

                lista = lista.Where(e =>
                            (esNumero && e.idEspecialidadMedica == filtroId) || // FILTRAR POR ID
                            e.nombreEspecialidad.ToLower().Contains(filtro) ||   // FILTRAR POR NOMBRE
                            (e.descripcion != null && e.descripcion.ToLower().Contains(filtro)) // FILTRAR POR DESCRIPCIÓN
                        ).ToList();
            }

            // LIMPIAR LISTVIEW Y LLENARLO
            lstvListaEspecialidad.Items.Clear();
            foreach (clsEspecialidadMedica especialidad in lista)
            {
                ListViewItem item = new ListViewItem(especialidad.idEspecialidadMedica.ToString());
                item.SubItems.Add(especialidad.nombreEspecialidad);
                item.SubItems.Add(especialidad.descripcion);
                item.SubItems.Add("Activo"); // Todos son activos
                lstvListaEspecialidad.Items.Add(item);
            }
        }




        private void btnNuevaEspecialidad_Click(object sender, EventArgs e)
        {
            frmEspecialidad frm = new frmEspecialidad();
            frm.ShowDialog();
            cargarListaEspecialidades();
        }

        //INVOCAR AL FORMULARIO DE ESPECIALIDAD PARA MODIFICAR
        private void lstvListaEspecialidad_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstvListaEspecialidad.SelectedItems.Count > 0)
            {
                int id = int.Parse(lstvListaEspecialidad.SelectedItems[0].SubItems[0].Text);
                clsEspecialidadMedica especialidad = lista.Where(c => c.idEspecialidadMedica == id).SingleOrDefault();

                if (especialidad != null)
                {
                    frmEspecialidad frm = new frmEspecialidad
                    {
                        especialidadSelected = especialidad
                    };

                    if (frm.ShowDialog() == DialogResult.OK)
                    {
                        cargarListaEspecialidades();
                    }
                }
            }
        }

        private void txtBusquedaEspecialidad_TextChanged(object sender, EventArgs e)
        {
            cargarListaEspecialidades(txtBusquedaEspecialidad.Text); //LLAMAR AL METODO PARA FILTRAR LISTA DE ACUERDO AL TEXTO INGRESADO
        }

        private void lblTitulo_TextChanged(object sender, EventArgs e) { }
        private void gbxListaEspecialidad_Enter(object sender, EventArgs e) { }
        private void btnNuevaEspecialidad_TextChanged(object sender, EventArgs e) { }
        private void lstvListaEspecialidad_SelectedIndexChanged(object sender, EventArgs e) { }


    }
}
