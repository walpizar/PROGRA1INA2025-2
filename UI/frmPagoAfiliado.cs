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
            // Cargar los meses disponibles según frecuencia
            CargarMesesDisponibles();
        }

        private void CargarMesesDisponibles()
        {
            listBoxMeses.Items.Clear();

            // Obtener la donación base
            var donacionBase = _donacionService.consultarTodos()
                .FirstOrDefault(d => d.donanteId == _afiliado.personaId
                                  && d.donanteTipoId == _afiliado.personaTipoId
                                  && d.estado);

            if (donacionBase == null) return;

            // Definir número de meses por pago según frecuencia
            int mesesPorPago = _frecuencia switch
            {
                "Mensual" => 1,
                "Trimestral" => 3,
                "Semestral" => 6,
                _ => 1
            };

            int cantidadPagos = 12 / mesesPorPago;
            DateTime fechaInicio = donacionBase.fechaDonacion;

            for (int i = 0; i < cantidadPagos; i++)
            {
                DateTime fechaPago = fechaInicio.AddMonths(i * mesesPorPago);
                listBoxMeses.Items.Add(fechaPago.ToString("MMMM yyyy"));
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (listBoxMeses.SelectedItems.Count == 0)
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

            // Calcular monto por pago según frecuencia
            int mesesPorPago = _frecuencia switch
            {
                "Mensual" => 1,
                "Trimestral" => 3,
                "Semestral" => 6,
                _ => 1
            };

            decimal montoPorPago = (donacionBase.monto ?? 0) * mesesPorPago;

            foreach (string item in listBoxMeses.SelectedItems)
            {
                // Convertir la selección a fecha
                DateTime fecha = DateTime.Parse("01 " + item);
                DateTime fechaPago = new DateTime(fecha.Year, fecha.Month, donacionBase.fechaDonacion.Day);

                // Crear el objeto clsDonacion
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
            }

            MessageBox.Show("Pago(s) registrado(s) correctamente.");
            this.Close();
        }
    }
}


