using Common.Exceptions;
using DAO;
using Entities;
using Microsoft.IdentityModel.Tokens;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmNuevaVisita : Form
    {
        private readonly VisitasService _visitaService;

        public clsVisitasDomiciliares visitaSelected { get; set; }

        public frmNuevaVisita()
        {
            InitializeComponent();
            _visitaService = new VisitasService();
        }

        private void frmNuevaVisita_Load(object sender, EventArgs e)
        {
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;

            if (visitaSelected != null) //SI SE SELECIONA ALGUNO DE LA LISTA
            {
                label2.Text = "Visita Domiciliaria Hecha";
                dateTimePicker1.Value = visitaSelected.fecha;
                textBox2.Text = visitaSelected.nombreVisitante;
                textBox3.Text = visitaSelected.nombrePaciente;
                textBox4.Text = visitaSelected.direccion;
                textBox5.Text = visitaSelected.telefono.ToString();
                richTextBox1.Text = visitaSelected.detalles;

                dateTimePicker1.Enabled = false;//NO PERMITE QUE SE MODIFIQUEN
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                textBox4.ReadOnly = true;
                textBox5.ReadOnly = true;
                richTextBox1.ReadOnly = true;

                button1.Visible = false;
                button2.Visible = false;// NO MOSTAR BTNS
            }
        }

        private void button1_Click(object sender, EventArgs e)//CREAR VISIITA
        {
            try
            {
                if (validarDatos())
                {
                    try
                    {
                        if(_visitaService.existenciaPersonaPorNombre(textBox3.Text))
                        {
                            clsVisitasDomiciliares visita = new clsVisitasDomiciliares();
                            visita.fecha = DateTime.Now.Date;
                            visita.nombreVisitante = textBox2.Text;//OBTENER EL NOMBRE DE LA PERSONA LOGEADA
                            visita.nombrePaciente = textBox3.Text;//NOMBRE DE LA PERSONA
                            visita.direccion = textBox4.Text;
                            visita.telefono = int.Parse(textBox5.Text);
                            visita.detalles = richTextBox1.Text;//OBTENER DIRECCION DE LA PERSONA PUESTA EN TXT

                            _visitaService.crear(visita);

                            MessageBox.Show("visita registrada");

                            textBox2.Clear();
                            textBox3.Clear();
                            textBox3.Clear();
                            textBox4.Clear();
                            textBox5.Clear();
                            richTextBox1.Clear();
                            //extraer el nombre del usuario
                            //consultar si existe nombre en tb de personas
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                    }
                    catch(EntityNotExistDBException ex)
                    {
                        MessageBox.Show(ex.Message);
                        MessageBox.Show("El paciente no existe dentro del sistema");
                    }
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

        private bool validarDatos()//VALIDACION DE CAMPOS
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text)) return false;
            if (string.IsNullOrWhiteSpace(textBox3.Text)) return false;
            if (string.IsNullOrWhiteSpace(textBox4.Text)) return false;
            if (string.IsNullOrWhiteSpace(textBox5.Text)) return false;
            if (string.IsNullOrWhiteSpace(richTextBox1.Text)) return false;
            return true;
        }

        private void button2_Click(object sender, EventArgs e)//OBTENER DIRECCION DEL PACIENTE VISISTADO DE FORMA AUTOMATICA
        {
            try
            {
                if (_visitaService.existenciaPersonaPorNombre(textBox3.Text))
                {
                    string nombreCompleto = textBox3.Text;
                    string direcc = _visitaService.consultarDireccion(nombreCompleto);
                    textBox4.Text = direcc;
                    string numero = _visitaService.consultarTelefono(nombreCompleto);
                    textBox5.Text = numero;
                }
            }
            catch (EntityNotExistDBException ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("El paciente no existe dentro del sistema");
            }
        }
    }
}
