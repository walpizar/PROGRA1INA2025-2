using DAO;
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
    public partial class frmListaTipoAyudas : Form
    {
        private readonly TipoAyudasService _tipoAyudasService;

        public frmListaTipoAyudas(dbContextINA _context)
        {
            _tipoAyudasService = new TipoAyudasService(_context);
            InitializeComponent();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            frmTipoAyuda fmrTipoAyuda = new frmTipoAyuda();
            fmrTipoAyuda.ShowDialog();

        }

        private void frmListaTipoAyudas_Load(object sender, EventArgs e)
        {

        }
    }
}
