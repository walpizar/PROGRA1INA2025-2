using Entities;
using Services;
using System;
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
            this.Load += FrmControlAfiliados_Load;
        }

        private void FrmControlAfiliados_Load(object sender, EventArgs e)
        {
            // Configurar lvAfiliados
            lvAfiliados.View = View.Details;
            lvAfiliados.FullRowSelect = true;
            lvAfiliados.GridLines = true;
            lvAfiliados.Columns.Clear();
            lvAfiliados.Columns.Add("ID", 100);
            lvAfiliados.Columns.Add("Nombre", 150);
            lvAfiliados.Columns.Add("Apellido 1", 150);
            lvAfiliados.Columns.Add("Apellido 2", 150);
            lvAfiliados.Columns.Add("Correo", 200);

            // Configurar LvDonantes
            LvDonantes.View = View.Details;
            LvDonantes.FullRowSelect = true;
            LvDonantes.GridLines = true;
            LvDonantes.Columns.Clear();
            LvDonantes.Columns.Add("ID", 100);
            LvDonantes.Columns.Add("Nombre", 150);
            LvDonantes.Columns.Add("Apellido 1", 150);
            LvDonantes.Columns.Add("Apellido 2", 150);
            LvDonantes.Columns.Add("Correo", 200);

            // Cargar datos
            CargarAfiliados();
            CargarDonantes();
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

        private void button4_Click(object sender, EventArgs e)
        {
            // Obtener el donante/afiliado seleccionado
            if (lvAfiliados.SelectedItems.Count > 0)
            {
                // Por ejemplo, tomar el primer seleccionado
                var personaId = lvAfiliados.SelectedItems[0].Text;

                // Buscar el objeto completo usando el servicio
                var personaSeleccionada = _service.ConsultarAfiliados()
                                                 .FirstOrDefault(a => a.personaId == personaId);

                if (personaSeleccionada != null)
                {
                    // Crear la instancia del formulario DetallePagos
                    var detallePagosForm = new frmDetallePagos(personaSeleccionada, new DonacionService(), _service);
                    detallePagosForm.ShowDialog(); // o Show() si no quieres que sea modal
                }
                else
                {
                    MessageBox.Show("No se encontró el afiliado seleccionado.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un afiliado de la lista primero.");
            }
        }


    }
}
