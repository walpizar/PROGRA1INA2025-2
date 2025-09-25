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

        private void button2_Click(object sender, EventArgs e) // NUEVA VISITA
        {
            frmNuevaVisita frm = new frmNuevaVisita();
            frm.ShowDialog();

            // refrescar la lista después de agregar una visita
            cargarListaVisitas(textBox1.Text);
        }

        /// <summary>
        /// Carga y muestra las visitas, con filtro opcional por texto.
        /// </summary>
        public void cargarListaVisitas(string textoBusqueda = "")
        {
            // Obtener todas las visitas desde el servicio
            lista = _VisitasService.consultarTodos();

            // Aplicar filtro si hay texto
            if (!string.IsNullOrWhiteSpace(textoBusqueda))
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
                item.SubItems.Add(visita.nombrePaciente ?? "");
                item.SubItems.Add(visita.nombreVisitante ?? "");
                listView1.Items.Add(item);
            }
        }

        private void frmVisitasDomiciliarias_Load(object sender, EventArgs e)
        {
            cargarListaVisitas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Filtrar mientras se escribe
            cargarListaVisitas(textBox1.Text);
        }
    }
}
