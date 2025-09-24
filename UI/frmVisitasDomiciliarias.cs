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
    public partial class frmVisitasDomiciliarias : Form
    {
        private readonly clsUsuario _usuarioActual;
        private readonly VisitasDAO _visitasDAO;

        public frmVisitasDomiciliarias()
        {
            InitializeComponent();
            _visitasDAO = new VisitasDAO();
        }

        private void button2_Click(object sender, EventArgs e)//?????????
        {
            frmNuevaVisita frm = new frmNuevaVisita();
            frm.ShowDialog();
        }
    }
}
