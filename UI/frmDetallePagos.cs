using Entities;
using Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class frmDetallePagos : Form
    {
        private readonly clsDonante _persona; // Puede ser afiliado o donante
        private readonly DonacionService _donacionService;
        private readonly AfiliadoDonanteService _afiliadoService;

        public frmDetallePagos(clsDonante persona, DonacionService donacionService, AfiliadoDonanteService afiliadoService)
        {
            InitializeComponent();
            _persona = persona;
            _donacionService = donacionService;
            _afiliadoService = afiliadoService;

            Load += frmDetallePagos_Load;
        }
        private void frmDetallePagos_Load(object sender, EventArgs e)
        {
            // Información básica
            nombre.Text = _persona.persona.nombre;
            apellido.Text = _persona.persona.apellido1;
            apellido2.Text = _persona.persona.apellido2 ?? "";
            correo.Text = _persona.persona.email ?? "";

            if (_persona.tipoDonante == 1) // Afiliado
            {
                // Ejemplo de monto anual (esto deberías traer de la BD)
                decimal montoAnualValue = 1200;

                // Calcular saldo pendiente
                decimal totalPagado = _donacionService.consultarTodos()
                    .Where(d => d.donanteId == _persona.personaId
                             && d.donanteTipoId == _persona.personaTipoId
                             && d.estado)
                    .Sum(d => d.monto ?? 0);

                montoAnual.Text = montoAnualValue.ToString("C");
                saldoPendiente.Text = (montoAnualValue - totalPagado).ToString("C");

                // Ocultar ListViews
                listView1.Visible = false;
                listView2.Visible = false;
            }
            else // Donante ocasional
            {
                // Ocultar etiquetas de monto
                label9.Visible = montoAnual.Visible = false;
                label12.Visible = saldoPendiente.Visible = false;

                listView1.Visible = true;
                listView2.Visible = false; // si solo usarás listView1
                CargarDonaciones();
            }
        }
        private void CargarDonaciones()
        {
            listView1.Clear();
            listView1.View = View.Details;

            listView1.Columns.Add("Fecha", 100);
            listView1.Columns.Add("Monto", 100);
            listView1.Columns.Add("Tipo Donación", 150);
            listView1.Columns.Add("Observaciones", 300);

            var donaciones = _donacionService.consultarTodos()
                .Where(d => d.donanteId == _persona.personaId
                         && d.donanteTipoId == _persona.personaTipoId
                         && d.estado)
                .OrderByDescending(d => d.fechaDonacion);

            foreach (var d in donaciones)
            {
                var item = new ListViewItem(d.fechaDonacion.ToShortDateString());
                item.SubItems.Add(d.monto?.ToString("C") ?? "-");
                item.SubItems.Add(d.tipoDonacion?.nombreTipoDonacion ?? "-");
                item.SubItems.Add(d.observaciones ?? "-");
                listView1.Items.Add(item);
            }
        }
    }
}
