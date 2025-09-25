using Entities;
using Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class FrmControlAfiliados : Form
    {
        private readonly AfiliadoDonanteService _service;

        public FrmControlAfiliados(AfiliadoDonanteService service)
        {
            InitializeComponent();
            _service = service;
            Load += FrmControlAfiliados_Load;

            // Asociar botones a eventos separados
            button1.Click += btnDetallesAfiliado_Click;
            button4.Click += btnDetallesDonante_Click;

            // Asociar TextBox para filtrar
            textBox1.TextChanged += FiltrarAfiliados;
            textBox2.TextChanged += FiltrarDonantes;
        }

        private void FrmControlAfiliados_Load(object sender, EventArgs e)
        {
            // Configurar ListViews
            ConfigurarListView(lvAfiliados);
            ConfigurarListView(LvDonantes);

            // Cargar datos
            CargarAfiliados();
            CargarDonantes();
        }

        private void ConfigurarListView(ListView lv)
        {
            lv.View = View.Details;
            lv.FullRowSelect = true;
            lv.GridLines = true;
            lv.Columns.Clear();
            lv.Columns.Add("ID", 100);
            lv.Columns.Add("Nombre", 150);
            lv.Columns.Add("Apellido 1", 150);
            lv.Columns.Add("Apellido 2", 150);
            lv.Columns.Add("Correo", 200);
        }
        private void CargarAfiliados()
        {
            lvAfiliados.Items.Clear();
            var afiliados = _service.ConsultarAfiliados();

            foreach (var a in afiliados)
            {
                if (a.persona != null)
                {
                    var item = new ListViewItem(a.personaId);
                    item.SubItems.Add(a.persona.nombre);
                    item.SubItems.Add(a.persona.apellido1);
                    item.SubItems.Add(a.persona.apellido2 ?? "");
                    item.SubItems.Add(a.persona.email ?? "");
                    lvAfiliados.Items.Add(item);
                }
            }
        }

        private void CargarDonantes()
        {
            LvDonantes.Items.Clear();
            var donantes = _service.ConsultarDonantes();

            foreach (var d in donantes)
            {
                if (d.persona != null)
                {
                    var item = new ListViewItem(d.personaId);
                    item.SubItems.Add(d.persona.nombre);
                    item.SubItems.Add(d.persona.apellido1);
                    item.SubItems.Add(d.persona.apellido2 ?? "");
                    item.SubItems.Add(d.persona.email ?? "");
                    LvDonantes.Items.Add(item);
                }
            }
        }

        // Filtro por nombre para Afiliados
        private void FiltrarAfiliados(object sender, EventArgs e)
        {
            string filtro = textBox1.Text.Trim().ToLower();
            lvAfiliados.Items.Clear();

            var afiliados = _service.ConsultarAfiliados()
                .Where(a => a.persona != null &&
                            (a.persona.nombre.ToLower().Contains(filtro) ||
                             a.persona.apellido1.ToLower().Contains(filtro) ||
                             (a.persona.apellido2 ?? "").ToLower().Contains(filtro)));

            foreach (var a in afiliados)
            {
                var item = new ListViewItem(a.personaId);
                item.SubItems.Add(a.persona.nombre);
                item.SubItems.Add(a.persona.apellido1);
                item.SubItems.Add(a.persona.apellido2 ?? "");
                item.SubItems.Add(a.persona.email ?? "");
                lvAfiliados.Items.Add(item);
            }
        }
        // Filtro por nombre para Donantes

        private void FiltrarDonantes(object sender, EventArgs e)
        {
            string filtro = textBox2.Text.Trim().ToLower();
            LvDonantes.Items.Clear();

            var donantes = _service.ConsultarDonantes()
                .Where(d => d.persona != null &&
                            (d.persona.nombre.ToLower().Contains(filtro) ||
                             d.persona.apellido1.ToLower().Contains(filtro) ||
                             (d.persona.apellido2 ?? "").ToLower().Contains(filtro)));

            foreach (var d in donantes)
            {
                var item = new ListViewItem(d.personaId);
                item.SubItems.Add(d.persona.nombre);
                item.SubItems.Add(d.persona.apellido1);
                item.SubItems.Add(d.persona.apellido2 ?? "");
                item.SubItems.Add(d.persona.email ?? "");
                LvDonantes.Items.Add(item);
            }
        }
        // Evento para botón "Detalles de pago" de Afiliados
        private void btnDetallesAfiliado_Click(object sender, EventArgs e)
        {
            if (lvAfiliados.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un afiliado de la lista primero.");
                return;
            }

            var id = lvAfiliados.SelectedItems[0].Text;
            var seleccionado = _service.ConsultarAfiliados()
                                      .FirstOrDefault(a => a.personaId == id);

            if (seleccionado != null)
            {
                var detalleForm = new frmDetallePagos(seleccionado, new DonacionService(), _service);
                detalleForm.ShowDialog();
            }
        }

        // Evento para botón "Detalles de pago" de Donantes
        private void btnDetallesDonante_Click(object sender, EventArgs e)
        {
            if (LvDonantes.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione un donante de la lista primero.");
                return;
            }

            var id = LvDonantes.SelectedItems[0].Text;
            var seleccionado = _service.ConsultarDonantes()
                                      .FirstOrDefault(d => d.personaId == id);

            if (seleccionado != null)
            {
                var detalleForm = new frmDetallePagos(seleccionado, new DonacionService(), _service);
                detalleForm.ShowDialog();
            }
        }
    }
}
