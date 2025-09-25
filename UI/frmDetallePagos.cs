using Entities;
using Services;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace UI
{
    public partial class frmDetallePagos : Form
    {
        private readonly clsDonante _persona;
        private readonly DonacionService _donacionService;
        private readonly AfiliadoDonanteService _afiliadoService;

        public frmDetallePagos(clsDonante persona, DonacionService donacionService, AfiliadoDonanteService afiliadoService)
        {
            InitializeComponent();
            _persona = persona;
            _donacionService = donacionService;
            _afiliadoService = afiliadoService;

            Load += frmDetallePagos_Load;
            cbFrecuencia.SelectedIndexChanged += cbFrecuencia_SelectedIndexChanged;
        }

        private void frmDetallePagos_Load(object sender, EventArgs e)
        {
            // Datos básicos
            nombre.Text = _persona.persona.nombre;
            apellido.Text = _persona.persona.apellido1;
            apellido2.Text = _persona.persona.apellido2 ?? "";
            correo.Text = _persona.persona.email ?? "";

            if (_persona.tipoDonante == 1) // Afiliado
            {
                listView1.Visible = true;
                montoAnual.Visible = true;
                saldoPendiente.Visible = true;
                cbFrecuencia.Visible = true;

                // Configurar ComboBox de frecuencia
                cbFrecuencia.Items.Clear();
                cbFrecuencia.Items.AddRange(new string[] { "Mensual", "Trimestral", "Semestral" });
                cbFrecuencia.SelectedIndex = 0;

                CargarPagosAfiliado();
            }
            else // Donante ocasional
            {
                listView1.Visible = true;
                cbFrecuencia.Visible = false;

                var ultimaDonacion = _donacionService.consultarTodos()
                    .Where(d => d.donanteId == _persona.personaId
                             && d.donanteTipoId == _persona.personaTipoId
                             && d.estado)
                    .OrderByDescending(d => d.fechaDonacion)
                    .FirstOrDefault();

                decimal montoDonado = ultimaDonacion?.monto ?? 0;

                label9.Text = "Donación Única";
                montoAnual.Text = montoDonado.ToString("C");

                label12.Visible = false;
                saldoPendiente.Visible = false;

                CargarDonaciones();
            }
        }

        private void cbFrecuencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_persona.tipoDonante == 1)
            {
                CargarPagosAfiliado();
            }
        }

        // Cargar pagos de afiliado según frecuencia
        private void CargarPagosAfiliado()
        {
            listView1.Clear();
            listView1.View = View.Details;
            listView1.Columns.Add("Fecha de Pago", 120);
            listView1.Columns.Add("Monto", 100);
            listView1.Columns.Add("Estado", 100);

            var donacionBase = _donacionService.consultarTodos()
                .FirstOrDefault(d => d.donanteId == _persona.personaId
                                  && d.donanteTipoId == _persona.personaTipoId
                                  && d.estado);

            if (donacionBase == null) return;

            decimal cuotaMensual = donacionBase.monto ?? 0;
            decimal totalAnual = cuotaMensual * 12;

            montoAnual.Text = totalAnual.ToString("C");

            decimal totalPagado = _donacionService.consultarTodos()
                .Where(d => d.donanteId == _persona.personaId
                         && d.donanteTipoId == _persona.personaTipoId
                         && d.estado)
                .Sum(d => d.monto ?? 0);

            saldoPendiente.Text = (totalAnual - totalPagado).ToString("C");

            string frecuencia = cbFrecuencia.SelectedItem.ToString();
            int mesesPorPago = frecuencia switch
            {
                "Mensual" => 1,
                "Trimestral" => 3,
                "Semestral" => 6,
                _ => 1
            };

            int cantidadPagos = 12 / mesesPorPago;
            decimal montoPorPago = cuotaMensual * mesesPorPago;

            var fechasFuturas = new List<DateTime>();
            var fechaInicio = donacionBase.fechaDonacion;
            for (int i = 0; i < cantidadPagos; i++)
            {
                fechasFuturas.Add(fechaInicio.AddMonths(i * mesesPorPago));
            }

            decimal acumuladoPagado = totalPagado;

            foreach (var fecha in fechasFuturas)
            {
                var item = new ListViewItem(fecha.ToShortDateString());
                item.SubItems.Add(montoPorPago.ToString("C"));

                string estado;
                if (acumuladoPagado >= montoPorPago)
                {
                    estado = "Pagado";
                    acumuladoPagado -= montoPorPago;
                }
                else if (fecha <= DateTime.Today)
                {
                    estado = "Pendiente";
                }
                else
                {
                    estado = "Futuro";
                }

                item.SubItems.Add(estado);
                listView1.Items.Add(item);
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

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            if (_persona.tipoDonante != 1)
            {
                MessageBox.Show("Solo se pueden agregar pagos a afiliados.");
                return;
            }

            string frecuencia = cbFrecuencia.SelectedItem.ToString();
            var pagoForm = new frmPagoAfiliado(_persona, _donacionService, frecuencia);
            pagoForm.ShowDialog();

            // Recargar la lista después de agregar pago
            CargarPagosAfiliado();
        }

        private void frmDetallePagos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
