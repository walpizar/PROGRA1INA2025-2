using Common.Enums;
using Entities;
using Services;
using System;
using System.Drawing;
using System.Windows.Forms;
using static Common.Enums.Enums;


namespace UI
{
    public partial class frmSolicitudApoyo : Form
    {
        private readonly SolicitudApoyoService _solicitudService;
        private readonly PacienteService _pacienteService; //servicio de paciente
        private int tipoIdPacienteSeleccionado;
        public clsSolicitudApoyo solicitudSelected;


        // Constructor
        public frmSolicitudApoyo()
        {
            InitializeComponent();
            _solicitudService = new SolicitudApoyoService();
            _pacienteService = new PacienteService();
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
        // Eliminar solicitud
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (solicitudSelected != null)
            {
                try
                {
                    DialogResult resp = MessageBox.Show(
                        "¿Desea marcar esta solicitud como rechazada?",
                        "Confirmación",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (resp == DialogResult.Yes)
                    {
                        // Cambiar estado a 3. Rechazada
                        solicitudSelected.estado = (int)EstadoAprobacionSolicitudApoyo.Rechazada;

                        // Guardar cambios en la BD
                        _solicitudService.modificar(solicitudSelected);

                        MessageBox.Show(
                            "Solicitud marcada como rechazada.",
                            "Éxito",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al actualizar la solicitud: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }
        // Cargar datos si estamos editando
        private void frmSolicitudApoyo_Load(object sender, EventArgs e)
        {
            if (solicitudSelected != null) //se esta modificando
            {
                lblTitulo.Text = "Editar Solicitud de Apoyo";
                btnGuardar.Text = "Editar";

                // Cargar datos existentes
                txtIdSolicitud.Text = solicitudSelected.idSolicitud;
                txtIDPaciente.Text = solicitudSelected.idPaciente;
                tipoIdPacienteSeleccionado = solicitudSelected.tipoIdPaciente;
                txtJustificacion.Text = solicitudSelected.justificacion;
                txtEquipos.Text = solicitudSelected.equiposNecesarios;

                // Inhabilitar edición de ID y Paciente
                txtIdSolicitud.Enabled = false;
                txtIDPaciente.Enabled = false;
                btnBuscarPaciente.Enabled = false;

                // Habilitar campos editables
                txtJustificacion.Enabled = true;
                txtEquipos.Enabled = true;
                btnAdjuntarReferencia.Enabled = true;
                btnAdjuntarEstudio.Enabled = true;
                btnEliminar.Visible = true;

            }
            else
            {
                // Nueva solicitud
                txtIdSolicitud.Enabled = true;
                txtIDPaciente.Enabled = true;
                txtJustificacion.Enabled = false;
                txtEquipos.Enabled = false;
                btnAdjuntarReferencia.Enabled = false;
                btnAdjuntarEstudio.Enabled = false;
                btnEliminar.Visible = false;

            }
        }
        // Guardar o editar solicitud
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!validarDatos())
                {
                    MessageBox.Show("Faltan datos obligatorios.");
                    return;
                }

                if (solicitudSelected == null) // Crear nueva
                {
                    var solicitud = new clsSolicitudApoyo()
                    {
                        idSolicitud = txtIdSolicitud.Text.Trim(),
                        idPaciente = txtIDPaciente.Text.Trim(),
                        tipoIdPaciente = tipoIdPacienteSeleccionado,
                        justificacion = txtJustificacion.Text.Trim(),
                        equiposNecesarios = txtEquipos.Text.Trim(),
                        referenciaCCSS = "url",
                        estudioSocioeconomico = "url2"
                    };

                    _solicitudService.crear(solicitud);
                    MessageBox.Show("Solicitud guardada exitosamente.");
                }
                else // Editar existente
                {
                    solicitudSelected.justificacion = txtJustificacion.Text.Trim();
                    solicitudSelected.equiposNecesarios = txtEquipos.Text.Trim();

                    _solicitudService.modificar(solicitudSelected);
                    MessageBox.Show("Solicitud actualizada exitosamente.");
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
        // Cancelar y cerrar formulario
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        // Buscar paciente por ID
        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya escrito un ID
                if (string.IsNullOrWhiteSpace(txtIDPaciente.Text))
                {
                    lblPacienteEncontrado.Text = "Debe ingresar un ID de paciente.";
                    lblPacienteEncontrado.ForeColor = Color.Red;
                    return;
                }

                string idPaciente = txtIDPaciente.Text.Trim();// Obtener y limpiar el ID ingresado

                // Consultar en la base de datos
                clsPaciente paciente = _pacienteService.consultarPorID(idPaciente);

                if (paciente != null && paciente.persona != null)
                {
                    lblPacienteEncontrado.Text = $"Paciente: {paciente.persona.nombre} {paciente.persona.apellido1}";
                    lblPacienteEncontrado.ForeColor = Color.Green;
                    tipoIdPacienteSeleccionado = paciente.tipoId;

                    // Habilitar botones de adjuntar si el paciente existe
                    btnAdjuntarReferencia.Enabled = true;
                    btnAdjuntarEstudio.Enabled = true;
                    txtJustificacion.Enabled = true;
                    txtEquipos.Enabled = true;
                }

                else
                {
                    lblPacienteEncontrado.Text = "Paciente no existe.";
                    lblPacienteEncontrado.ForeColor = Color.Red;

                    // Deshabilitar botones de adjuntar si no existe el paciente
                    btnAdjuntarReferencia.Enabled = false;
                    btnAdjuntarEstudio.Enabled = false;
                    txtJustificacion.Enabled = false;
                    txtEquipos.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar paciente: " + ex.Message);
            }
        }
    }
}
