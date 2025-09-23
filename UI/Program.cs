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
            Application.Run(new frmActivos());
        Application.Run(new frmUsuario());
       

        }
    }
}