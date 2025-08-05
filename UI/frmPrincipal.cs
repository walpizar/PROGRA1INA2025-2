

using Entities;

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

            //clsProducto prod = new clsProducto();

            //prod.setNombre("Camisa");
            //prod.precio = 15;
            //prod.cantidad = 2;

            //clsProducto prod1 = new clsProducto();
            //clsProducto prod2 = new clsProducto();
            //clsProducto prod3 = new clsProducto();
            clsProducto prodX = new clsProducto();




            for (int j = 0; j < 10; j++)
            {
                //clsProducto prodX = new clsProducto();
            
                prodX.setNombre("");             
      

            }






            frmLogin frmLogin = new frmLogin();
            frmLogin.StartPosition = FormStartPosition.CenterParent;
            frmLogin.ShowDialog();
        }
    }
}
