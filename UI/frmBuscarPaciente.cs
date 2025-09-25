using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Services;

namespace UI
{
    public partial class frmBuscarPaciente : Form
    {
        private readonly  PacienteService _pacienteService;
        public clsPaciente pacienteSeleccionado { get; private set; }
        public frmBuscarPaciente()
        {
            InitializeComponent();
            _pacienteService = new PacienteService();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtIdentificacion.Text.Trim();
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Debe digitar una identificación.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try { 
 
                pacienteSeleccionado = _pacienteService.consultarPorID(id);

                if (pacienteSeleccionado != null)
                {
                    MessageBox.Show($"Paciente encontrado: {pacienteSeleccionado.persona.nombre} {pacienteSeleccionado.persona.apellido1}");
                    this.DialogResult = DialogResult.OK; // cierra el form y devuelve el resultado
                }
                else
                {
                    MessageBox.Show("Paciente no encontrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al buscar paciente: {ex.Message}");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
