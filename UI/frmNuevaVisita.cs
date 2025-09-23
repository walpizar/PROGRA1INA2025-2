using DAO;
using Entities;
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
        private clsPersona _usuarioActual;

        private readonly VisitasDAO _visitasDAO;

        public frmNuevaVisita(clsUsuario usuario)
        {
            InitializeComponent();
            _visitasDAO = new VisitasDAO();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = _usuarioActual.nombre;
        }


    }
}
