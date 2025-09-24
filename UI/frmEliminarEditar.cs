using Entities;
using Services;
using System;
using System.Collections;
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
    public partial class frmEliminarEditar : Form
    {

        private readonly VisitasService _Service;//ACCESO A SERVICE
        public clsVisitasDomiciliares pasienteVisitado{ get; set; }

        public frmEliminarEditar()
        {
            InitializeComponent();
            _Service = new VisitasService();//INICIALIZO EL ACCESO
        }

        private void frmEliminarEditar_Load(object sender, EventArgs e)
        {
            cargarSelecionado();
        }

        public void cargarSelecionado()//MUESTRO
        {

        }

        private void button1_Click(object sender, EventArgs e)//ELIMINAR
        {

        }


        private void frmEliminarEditar_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }
    }
}
