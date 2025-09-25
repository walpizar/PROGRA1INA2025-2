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
        //ApplicationConfiguration.Initialize();

        //Application.Run(new frmUsuarioLista());
       

            
            //ProductoService _productoServ = new ProductoService();
           


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Application.Run(new frmProductoLista());

        //HENRRY LEIBA -- PRUEBA PARA ESPECIALIDADES
        //Application.Run(new frmEspecialidadLista());

        

        Application.Run(new frmListaTipoAyudas());


        }
    }
}