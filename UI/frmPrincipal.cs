using Services;

namespace UI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }



        private void btnAceptar_Click(object sender, EventArgs e)
        {

            //ProductoService productoServ = new ProductoService();
            //productoServ.otro();



            int i = 0;

            bool reslt = i > 5 && i < 10 || i == 20;






        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           
            frmLogin frmLogin = new frmLogin();
            frmLogin.StartPosition = FormStartPosition.CenterParent;
            frmLogin.ShowDialog();
        }
    }
}
