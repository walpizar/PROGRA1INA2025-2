using Entities;
using Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmSolicitudApoyo : Form
    {
        private readonly SolicitudApoyoService _solicitudService;

        // Constructor
        public frmSolicitudApoyo()
        {
            InitializeComponent();
            _solicitudService = new SolicitudApoyoService();
        }

        // Evento Load del formulario
        private void frmSolicitudApoyo_Load(object sender, EventArgs e)
        {
            // Al crear una solicitud nueva, todos los campos son editables
            txtIdSolicitud.Enabled = true;  // El ID lo define el usuario
            btnAdjuntarReferencia.Enabled = false; // Se habilita cuando haya paciente válido
            btnAdjuntarEstudio.Enabled = false;   // Se habilita cuando haya paciente válido
        }

        // Validación de campos obligatorios
        private bool validarDatos()
        {
            if (string.IsNullOrWhiteSpace(txtIdSolicitud.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtIDPaciente.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtJustificacion.Text)) return false;
            if (string.IsNullOrWhiteSpace(txtEquipos.Text)) return false;
            return true;
        }

        // Botón Guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarDatos())
                {
                    MessageBox.Show("Faltan datos obligatorios.");
                    return;
                }

                // Crear nueva solicitud con los datos ingresados
                clsSolicitudApoyo nuevaSolicitud = new clsSolicitudApoyo
                {
                    idSolicitud = Convert.ToInt32(txtIdSolicitud.Text),
                    idPaciente = Convert.ToInt32(txtIDPaciente.Text),
                    justificacion = txtJustificacion.Text,
                    equiposNecesarios = txtEquipos.Text,
                    referenciaCCSS = null,        // Se puede adjuntar después
                    estudioSocioeconomico = null  // Se puede adjuntar después
                };

                // Llamada al servicio para guardar la solicitud
                _solicitudService.crear(nuevaSolicitud);

                MessageBox.Show("Solicitud creada correctamente");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        // Botón Cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Evento click del título (no hace nada por ahora)
        private void lblTitulo_Click(object sender, EventArgs e)
        {
        }
    }
}
