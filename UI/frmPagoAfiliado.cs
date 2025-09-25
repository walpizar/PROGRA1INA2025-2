using Entities;
using Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class frmPagoAfiliado : Form
    {
        private readonly clsDonante _afiliado;
        private readonly DonacionService _donacionService;
        private readonly string _frecuencia;

        public frmPagoAfiliado(clsDonante afiliado, DonacionService donacionService, string frecuencia)
        {
            InitializeComponent();
            _afiliado = afiliado;
            _donacionService = donacionService;
            _frecuencia = frecuencia;

            Load += FrmPagoAfiliado_Load;
            btnPagar.Click += BtnPagar_Click;
        }

        private void FrmPagoAfiliado_Load(object sender, EventArgs e)
        {
            // Mostrar nombre del afiliado
            lblNombre.Text = $"{_afiliado.persona.nombre} {_afiliado.persona.apellido1}";

            // Configurar ListView
            listViewMeses.Clear();
            listViewMeses.View = View.Details;
            listViewMeses.FullRowSelect = true;
            listViewMeses.GridLines = true;
            listViewMeses.Columns.Add("Mes / Año", 120);
            listViewMeses.Columns.Add("Monto", 100);
            listViewMeses.Columns.Add("Estado", 100);
            listViewMeses.Columns.Add("Fecha Pago Real", 120);

            // Cargar los meses disponibles según frecuencia
            VerificarContinuidadAnual();
            CargarMesesDisponibles();
        }

        private void CargarMesesDisponibles()
        {
            listViewMeses.Items.Clear();

            var donacionBase = _donacionService.consultarTodos()
                .FirstOrDefault(d => d.donanteId == _afiliado.personaId
                                  && d.donanteTipoId == _afiliado.personaTipoId
                                  && d.estado);

            if (donacionBase == null) return;

            decimal cuotaMensual = donacionBase.monto ?? 0;

            int mesesPorPago = _frecuencia switch
            {
                "Mensual" => 1,
                "Trimestral" => 3,
                "Semestral" => 6,
                _ => 1
            };

            int cantidadPagos = 12 / mesesPorPago;
            decimal montoPorPago = cuotaMensual * mesesPorPago;
            var fechaInicio = donacionBase.fechaDonacion;

            var pagosExistentes = _donacionService.consultarTodos()
                .Where(d => d.donanteId == _afiliado.personaId
                         && d.donanteTipoId == _afiliado.personaTipoId
                         && d.estado)
                .ToList();

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
                listViewMeses.Items.Add(item);
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (listViewMeses.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos un mes a pagar.");
                return;
            }

            // Obtener la donación base
            var donacionBase = _donacionService.consultarTodos()
                .FirstOrDefault(d => d.donanteId == _afiliado.personaId
                                  && d.donanteTipoId == _afiliado.personaTipoId
                                  && d.estado);

            if (donacionBase == null)
            {
                MessageBox.Show("No se encontró la donación base del afiliado.");
                return;
            }

            int mesesPorPago = _frecuencia switch
            {
                "Mensual" => 1,
                "Trimestral" => 3,
                "Semestral" => 6,
                _ => 1
            };

            decimal montoPorPago = (donacionBase.monto ?? 0) * mesesPorPago;

            foreach (ListViewItem item in listViewMeses.SelectedItems)
            {
                DateTime fecha = DateTime.Parse("01 " + item.Text);
                DateTime fechaPago = new DateTime(fecha.Year, fecha.Month, donacionBase.fechaDonacion.Day);

                var pago = new clsDonacion
                {
                    donanteId = _afiliado.personaId,
                    donanteTipoId = _afiliado.personaTipoId,
                    idTipoDonacion = donacionBase.idTipoDonacion,
                    fechaDonacion = fechaPago,
                    monto = montoPorPago,
                    estado = true,
                    usuarioCreacion = "UsuarioActual",
                    fechaCreacion = DateTime.Now,
                    usuarioModificacion = "UsuarioActual",
                    fechaModificacion = DateTime.Now
                };

                // Guardar en la base de datos
                _donacionService.crear(pago);

                // Enviar correo al afiliado
                if (!string.IsNullOrWhiteSpace(_afiliado.persona.email))
                {
                    string asunto = "Confirmación de Pago";
                    string cuerpo = $"Estimado {_afiliado.persona.nombre} {_afiliado.persona.apellido1},\n\n" +
                                    $"Se ha registrado su pago de {montoPorPago:C} correspondiente a {fechaPago:MMMM yyyy}.\n" +
                                    $"Gracias por su aporte.\n\n" +
                                    "Atentamente,\n" +
                                    "Asociación / Sistema de Donaciones";

                    try
                    {
                        clsEmailHelper.EnviarCorreo(_afiliado.persona.email, asunto, cuerpo);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"El pago se registró correctamente, pero no se pudo enviar el correo: {ex.Message}");
                    }
                }
            }

            // Refrescar vista
            CargarMesesDisponibles();

            MessageBox.Show("Pago(s) registrado(s) correctamente.");
        }

        private void VerificarContinuidadAnual()
        {
            int anioActual = DateTime.Today.Year;

            // Buscar si ya existe donación base de este año
            var donacionBase = _donacionService.consultarTodos()
                .FirstOrDefault(d => d.donanteId == _afiliado.personaId
                                  && d.donanteTipoId == _afiliado.personaTipoId
                                  && d.estado
                                  && d.fechaDonacion.Year == anioActual);

            if (donacionBase == null)
            {
                // Obtener la última donación base del afiliado
                var ultimaDonacion = _donacionService.consultarTodos()
                    .Where(d => d.donanteId == _afiliado.personaId
                             && d.donanteTipoId == _afiliado.personaTipoId
                             && d.estado)
                    .OrderByDescending(d => d.fechaDonacion)
                    .FirstOrDefault();

                if (ultimaDonacion != null)
                {
                    // Crear compromiso para el nuevo año
                    var nuevoCompromiso = new clsDonacion
                    {
                        donanteId = ultimaDonacion.donanteId,
                        donanteTipoId = ultimaDonacion.donanteTipoId,
                        idTipoDonacion = ultimaDonacion.idTipoDonacion,
                        fechaDonacion = new DateTime(anioActual, 1, ultimaDonacion.fechaDonacion.Day),
                        monto = ultimaDonacion.monto,
                        estado = true,
                        usuarioCreacion = "Sistema",
                        fechaCreacion = DateTime.Now,
                        usuarioModificacion = "Sistema",
                        fechaModificacion = DateTime.Now
                    };

                    _donacionService.crear(nuevoCompromiso);
                }
            }
        }

    }
}
