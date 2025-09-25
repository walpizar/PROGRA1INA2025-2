using Entities;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmAsignacionCita : Form
    {
        private readonly citaService _citaService;
        private  clsPaciente _clsPaciente;
        private  clsMedico _clsMedico;
        private readonly MedicoService _medicoService;
        private readonly clsPersona _clsPersona;

        public frmAsignacionCita()
        {
            InitializeComponent();
            _citaService = new citaService();
            _clsMedico = new clsMedico();
            _clsPaciente = new clsPaciente();
            _medicoService = new MedicoService();
            _clsPersona = new clsPersona();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void cargarComboMedico()
        {

            try
            {
                var combMedico = _medicoService.consultarTodos()
                    .Select(m => new
                    {
                        IdPersona = m.idPersona,
                        NombreCompleto = m.persona.nombre + " " + m.persona.apellido1 + " " + (m.persona.apellido2 ?? "")
                    })
                    .ToList();

                this.combMedico.DataSource = combMedico;
                this.combMedico.DisplayMember = "NombreCompleto";
                this.combMedico.ValueMember = "IdPersona";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los médicos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {


        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnAsiganar_Click(object sender, EventArgs e)
        {
            try
            {
                validarDatos();
                MessageBox.Show("Cita creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la cita: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void validarDatos()
        {
            // 1. Validar paciente
            if (string.IsNullOrWhiteSpace(textPaciente.Text))
                throw new Exception("Debe ingresar o seleccionar un paciente.");

            if (_clsPaciente == null || string.IsNullOrWhiteSpace(_clsPaciente.id))
                throw new Exception("Debe seleccionar un paciente válido.");

            // 2. Validar médico seleccionado
            if (combMedico.SelectedItem == null)
                throw new Exception("Debe seleccionar un médico.");

            // Obtener el IdPersona del ComboBox
            var medicoIdPersona = (int)combMedico.SelectedValue;

            // Buscar el clsMedico completo
            var medico = _medicoService.consultarTodos()
                        .FirstOrDefault(m => m.idPersona == medicoIdPersona);

            if (medico == null)
                throw new Exception("El médico seleccionado no existe.");

            // Guardar en la variable privada
            _clsMedico = medico;

            // 3. Validar fecha
            if (dateCita.Value.Date < DateTime.Today)
                throw new Exception("La fecha de la cita no puede ser anterior al día de hoy.");

            // 4. Validar hora (formato HH:mm)
            if (!TimeSpan.TryParse(textHora.Text, out TimeSpan horaSeleccionada))
                throw new Exception("La hora de la cita debe tener un formato válido (HH:mm).");

            // 5. Validar horario laboral (08:00 - 18:00)
            if (horaSeleccionada < new TimeSpan(8, 0, 0) || horaSeleccionada > new TimeSpan(18, 0, 0))
                throw new Exception("La cita debe estar dentro del horario laboral (08:00 - 18:00).");

            // 6. Crear objeto clsCita
            clsCita cita = new clsCita
            {
                idPaciente = _clsPaciente.id,
                tipoIdPaciente = _clsPaciente.tipoId,
                idMedico = _clsMedico.id,
                tipoIdMedico = _clsMedico.tipoId,
                fechaCita = dateCita.Value.Date,
                horaCita = horaSeleccionada,
                estado = "Pendiente",
                activo = true,
                fechaCrea = DateTime.Now,
                usuarioCrea = "UsuarioActual", // Cambiar por el usuario logueado
                fechaUltMod = DateTime.Now,
                motivo = richTextBox1.Text
            };

            // 7. Llamar al Service para crear la cita
            _citaService.crear(cita);

            MessageBox.Show("Cita creada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void combMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarComboMedico();
        }

        private void frmAsignacionCita_Load(object sender, EventArgs e)
        {
            cargarComboMedico();
        }

        private void textPaciente_MouseClick(object sender, MouseEventArgs e)
        {
            using (frmBuscarPaciente frm = new frmBuscarPaciente())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // frm.PacienteSeleccionado es el objeto clsPaciente que devuelve el form
                    var paciente = frm.pacienteSeleccionado;
                    if (paciente != null)
                    {
                        textPaciente.Text = $"{paciente.id} - {paciente.persona.nombre} {paciente.persona.apellido1}";
                        // Guardar en variable privada para usar en la cita
                        _clsPaciente.id = paciente.id;
                        _clsPaciente.tipoId = paciente.tipoId;
                    }
                }
            }

        }
    }
}
