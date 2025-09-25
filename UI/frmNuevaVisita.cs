using DAO;
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
    public partial class frmNuevaVisita : Form
    {
        private readonly VisitasService _visitaService;

        public frmNuevaVisita()
        {
            InitializeComponent();
            _visitaService = new VisitasService();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void frmNuevaVisita_Load(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarDatos())
                {
                    clsVisitasDomiciliares visita = new clsVisitasDomiciliares();
                    visita.fecha = DateTime.Now.Date;
                    visita.nombreVisitante = textBox2.Text;
                    visita.nombrePaciente = textBox3.Text;
                    visita.direccion = textBox4.Text;
                    visita.detalles = richTextBox1.Text;

                    _visitaService.crear(visita);

                    MessageBox.Show("visita registrada");

                    textBox2.Clear();
                    textBox3.Clear();
                    textBox3.Clear();
                    richTextBox1.Clear();
                    //extraer el nombre del usuario
                    //consultar si existe nombre en tb de personas
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Faltan datos obligatorios.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private bool validarDatos()
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) return false;
            if (string.IsNullOrWhiteSpace(textBox3.Text)) return false;
            if (string.IsNullOrWhiteSpace(textBox4.Text)) return false;
            if (string.IsNullOrWhiteSpace(richTextBox1.Text)) return false;
            return true;
        }
    }
}
