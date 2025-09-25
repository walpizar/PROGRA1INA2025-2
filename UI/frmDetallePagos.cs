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

            // Columnas unificadas
            listView1.Columns.Add("Mes / Año", 120);
            listView1.Columns.Add("Monto", 100);
            listView1.Columns.Add("Estado", 100);
            listView1.Columns.Add("Fecha Pago Real", 120);

            var donacionBase = _donacionService.consultarTodos()
                .FirstOrDefault(d => d.donanteId == _persona.personaId
                                  && d.donanteTipoId == _persona.personaTipoId
                                  && d.estado);

            if (donacionBase == null) return;

            decimal cuotaMensual = donacionBase.monto ?? 0;
            decimal totalAnual = cuotaMensual * 12;
            montoAnual.Text = totalAnual.ToString("C");

            // Obtener pagos existentes
            var pagosExistentes = _donacionService.consultarTodos()
                .Where(d => d.donanteId == _persona.personaId
                         && d.donanteTipoId == _persona.personaTipoId
                         && d.estado)
                .ToList();

            // Calcular saldo pendiente
            decimal totalPagado = pagosExistentes.Sum(d => d.monto ?? 0);
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
            var fechaInicio = donacionBase.fechaDonacion;

            for (int i = 0; i < cantidadPagos; i++)
            {
                var fechaPago = fechaInicio.AddMonths(i * mesesPorPago);

                var pagoRealizado = pagosExistentes
                    .FirstOrDefault(p => p.fechaDonacion.Month == fechaPago.Month &&
                                         p.fechaDonacion.Year == fechaPago.Year);

                string estado;
                string fechaReal = "-";

                if (pagoRealizado != null)
                {
                    estado = "Pagado";
                    fechaReal = pagoRealizado.fechaDonacion.ToShortDateString();
                }
                else if (fechaPago <= DateTime.Today)
                {
                    estado = "Pendiente";
                }
                else
                {
                    estado = "Futuro";
                }

                var item = new ListViewItem($"{fechaPago:MMMM yyyy}");
                item.SubItems.Add(montoPorPago.ToString("C"));
                item.SubItems.Add(estado);
                item.SubItems.Add(fechaReal);
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

            // Recargar lista automáticamente al cerrar el formulario de pago
            pagoForm.FormClosed += (s, args) =>
            {
                CargarPagosAfiliado();
            };

            pagoForm.ShowDialog();
        }
    }
}
