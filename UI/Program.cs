using DAO;
using Entities;
using Services;

namespace UI
{
    namespace UI
    {
        internal static class Program
        {
            [STAThread]
            static void Main()
            {
                ApplicationConfiguration.Initialize();

                // Pasamos los DAO al servicio



            
            //ProductoService _productoServ = new ProductoService();
           


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Application.Run(new frmProductoLista());

                // Inyectamos el servicio en el formulario
                Application.Run(new frmMantenimientoRoles());
            }
        }
    }
}