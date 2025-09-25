using DAO;
using Services;

namespace UI
{
    internal static class Program
    {


        private static UsuarioService usuarioService;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
  
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();


            
            //ProductoService _productoServ = new ProductoService();
           


            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


            //abrir formulario donante lista
            //Application.Run(new frmDonanteLista());

            //abrir formulario donacion lista
            //Application.Run(new frmDonacionLista());

            //ABRIR FORMULARIO TIPO DONACION LISTA
            //Application.Run(new frmTipoDonacionLista());

            //abrir formulario donante lista
            Application.Run(new frmDonanteLista());






            //solo ejemplo
            //Application.Run(new frmPacienteLista());


            //Application.Run(new frmActivos());



        }
    }
}