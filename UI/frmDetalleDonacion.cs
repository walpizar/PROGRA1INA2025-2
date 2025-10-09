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
    public partial class frmDetalleDonacion : Form
    {
        //parametro

        public clsDonacion donacionsSelected { set; get; }
        public frmDetalleDonacion()
        {
            InitializeComponent();
        }

        private void frmDetalleDonacion_Load(object sender, EventArgs e)
        {

        }
    }
}
