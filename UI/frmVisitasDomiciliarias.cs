using DAO;
using Entities;
using Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class frmVisitasDomiciliarias : Form
    {
        private readonly VisitasService _VisitasService;
        private List<clsVisitasDomiciliares> lista;

        public frmVisitasDomiciliarias()
        {
            InitializeComponent();
            _VisitasService = new VisitasService();
        }

        private void button2_Click(object sender, EventArgs e) //BTN NUEVA VISITA
        {
            frmNuevaVisita frm = new frmNuevaVisita();
            frm.ShowDialog();

            // refrescar la lista después de agregar una visita
            cargarListaVisitas(textBox1.Text);
        }

        public void cargarListaVisitas(string textoBusqueda = "")//CARAR LISTA
        {
            lista = _VisitasService.consultarTodos();//OBTENER LISTA

            if (!string.IsNullOrWhiteSpace(textoBusqueda))//BUSCAR EN LISTA PACIENTE O VISITANTE
            {
                textoBusqueda = textoBusqueda.Trim().ToLower();

                lista = lista
                    .Where(e => (e.nombrePaciente != null && e.nombrePaciente.ToLower().Contains(textoBusqueda))
                             || (e.nombreVisitante != null && e.nombreVisitante.ToLower().Contains(textoBusqueda)))
                    .ToList();
            }
            // Limpiar y llenar el ListView
            listView1.Items.Clear();
            foreach (clsVisitasDomiciliares visita in lista)
            {
                ListViewItem item = new ListViewItem(visita.fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(visita.nombrePaciente);
                item.SubItems.Add(visita.nombreVisitante);
                item.Tag = visita.idVisita;
                listView1.Items.Add(item);
            }
        }

        private void frmVisitasDomiciliarias_Load(object sender, EventArgs e)
        {
            cargarListaVisitas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)//FILTARAR MIENTRAS SE ESCRIBE
        {
            cargarListaVisitas(textBox1.Text);
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)//MOSTRAR DETALLES DE VISITA
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    // EXTRAR Y GUARDAR EN TAG EL ID
                    int id = (int)listView1.SelectedItems[0].Tag;

                    //CONSULTAR VISITA POR ID
                    clsVisitasDomiciliares visita = lista.SingleOrDefault(v => v.idVisita == id);

                    if (visita != null)
                    {
                        frmNuevaVisita frm = new frmNuevaVisita//INSTANCIAR FRM
                        {
                            visitaSelected = visita // PROPIEDAD DE INSTACIA
                        };
                        frm.ShowDialog();// MOSTRAR FRM

                        // ACTUALZAR
                        lista = _VisitasService.consultarTodos();
                        cargarListaVisitas();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al seleccionar una visita de la lista");
            }
        }
    }
}
