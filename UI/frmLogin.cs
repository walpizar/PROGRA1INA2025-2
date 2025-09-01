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
    //formulario de login : hereda de Form
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }


        //evento click del boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //aqui cierro el formulario
            this.Close();
        }
    }
}
