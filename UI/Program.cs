using DAO;
using Services;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           



            
            ProductoService _productoServ = new ProductoService();
           


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        Application.Run(new frmProductoLista(_productoServ));

        //solo ejemplo
        //Application.Run(new frmLogin());

        }
    }
}