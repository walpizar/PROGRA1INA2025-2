using Entities;
using Services;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class frmSolicitudApoyo : Form
    {
        private readonly SolicitudApoyoService _solicitudService;

        public frmSolicitudApoyo()
        {
            InitializeComponent();
            _solicitudService = new SolicitudApoyoService();
        }

        private void frmSolicitudApoyo_Load(object sender, EventArgs e)
        {
            // Al crear, todos los campos son editables
            txtIdSolicitud.Enabled = true;
            btnAdjuntarReferencia.Enabled = false;
            btnAdjuntarEstudio.Enabled = false;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarDatos())
                {
                    MessageBox.Show("Faltan datos obligatorios.");
                    return;
                }

                clsSolicitudApoyo nuevaSolicitud = new clsSolicitudApoyo
                {
                    idSolicitud = Convert.ToInt32(txtIdSolicitud.Text),
                    idPaciente = Convert.ToInt32(txtIDPaciente.Text),
                    justificacion = txtJustificacion.Text,
                    equiposNecesarios = txtEquipos.Text,
                    referenciaCCSS = null,
                    estudioSocioeconomico = null
                };

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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
