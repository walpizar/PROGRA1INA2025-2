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
    public partial class frmLogin : Form
    {

        //declaro instamncia para capa de servicios
        private LoginService loginService;

        public frmLogin()
        {
            InitializeComponent();

            //instancio la clase de servicios
            loginService = new LoginService();
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


        //evento link click del link label de olvido contraseña       
        private void linkLblOlvidoContra_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //esto hace que el formulario de login se oculte mientras se muestra el de recuperar contraseña            
            this.Hide();

            //muestro el formulario de recuperar contraseña
            frmRecuperarContra frmRecuperar = new frmRecuperarContra();
            frmRecuperar.ShowDialog();

            //cuando se cierre el formulario de recuperar contraseña, el de login se vuelve a mostrar
            this.Show();
            
        }
    }
}
