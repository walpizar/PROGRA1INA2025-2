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
    public partial class frmAsignacionActivos : Form
    {
        //creo lass instancia de la capa service
        private readonly AsignacActivoService _asigActivosService;
        private readonly ActivosServices _activosService;

        private clsPaciente pacienteSeleccion;//variable para guardar el paciente seleccionado q viene del formulario de lista de pacientes
        //private int tipoIdPacienteSeleccionado;//variable para guardar el tipo de ID del paciente seleccionado

        public frmAsignacionActivos()
        {
            InitializeComponent();

            //centro el formulario en la pantalla
            this.StartPosition = FormStartPosition.CenterScreen;

            //instancio las capas del service
            _asigActivosService = new AsignacActivoService();
            _activosService = new ActivosServices();
        }

        private void frmAsignacionActivos_Load(object sender, EventArgs e)
        {
            //llamo al método para agregar renglones vacíos al DataGridView
            agregarRenglonesVacios();

            dateTimePicker1.Value = DateTime.Now; //asigno la fecha actual al DateTimePicker

            gbxActivoAsig.Enabled = false; //desactivo el GroupBox de activos mientras no se seleccione un paciente
        }

        //método para agregar renglones vacíos al DataGridView
        private void agregarRenglonesVacios()
        {
            //agrego renglones vacíos al DataGridView
            int reglonesVacios = 4;
            for (int i = 0; i < reglonesVacios; i++)
            {
                dgvActivosAsig.Rows.Add();
            }
        }

        //evento click del botón de lupa de paciente
        private void btnLupaPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                //instancio el formulario de lista de pacientes para mostrarlo
                frmPacienteLista frmPacienteLista = new frmPacienteLista();
                frmPacienteLista.modoSeleccion = true; //activo el modo selección

                //muestro el formulario de lista de pacientes dependiendo del resultado del diálogo
                DialogResult resultado = frmPacienteLista.ShowDialog();

                //si el resultado es OK y hay un paciente selecionado
                if (resultado == DialogResult.OK && frmPacienteLista.pacienteSeleccionado != null)
                {
                    pacienteSeleccion = frmPacienteLista.pacienteSeleccionado; //asigno el paciente seleccionado a la variable global

                    //asigno el tipo de ID del paciente seleccionado a la variable global x si hay un paciente con el mismo ID pero diferente tipo de ID
                    //tipoIdPacienteSeleccionado = pacienteSeleccionado.tipoId; 

                    //muestro el nombre del paciente en el TextBox
                    txtPacienteAsig.Text = pacienteSeleccion.persona.nombre + " " + pacienteSeleccion.persona.apellido1 + " "
                        + pacienteSeleccion.persona.apellido2 + ".  Cedula: " + pacienteSeleccion.persona.id;

                    gbxActivoAsig.Enabled = true; //activo el GroupBox de activos
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de pacientes. Contacte con soporte o su administrador." +
                        "\n" + "Error: " + "\n" + ex.Message);
            }

        }

        //evento click del botón aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //llamo al método para validar los datos de entrada
            validarDatosEntrada();
        }

        //método para validar los datos de entrada del form
        private void validarDatosEntrada()
        {
            //valido que haya un paciente seleccionado
            if (pacienteSeleccion == null) //si no hay un paciente seleccionado
            {
                MessageBox.Show("Debe buscar y seleccionar un paciente.");
                return;
            }

            //valido que haya un activo seleccionado, currentRow es la fila seleccionada en el DataGridView
            if (dgvActivosAsig.CurrentRow == null || dgvActivosAsig
                .CurrentRow.Cells["idActivo"].Value == null) //el currentRow["idActivo"] es la celda de la columna idActivo de la fila seleccionada
            {
                MessageBox.Show("Debe seleccionar un activo de la lista.");
                return;
            }

            //valido que haya al menos un activo agregado en el DataGridView
            if (dgvActivosAsig.Rows.Count == 0)
            {
                MessageBox.Show("Debe agregar al menos un activo a la lista.");
                return;
            }
        }

        //evento click del botón cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //cierro el formulario
            this.Close();
        }
    }
}
