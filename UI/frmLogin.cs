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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
<<<<<<< Updated upstream
=======


        //evento click del boton cancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //aqui cierro el formulario
            this.Close();
        }


        //evento linkclicked del linklabel olvido contraseña
        private void linklblOlvidoContra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //muestro el formulario de recuperar contraseña
            frmRecuperarContra frmRecuperar = new frmRecuperarContra();
            frmRecuperar.ShowDialog();
            //esto hace que el formulario de login se oculte mientras se muestra el de recuperar contraseña
            this.Show();
            //cuando se cierre el formulario de recuperar contraseña, el de login se vuelve a mostrar
            this.Hide();

        }
>>>>>>> Stashed changes
    }
}
