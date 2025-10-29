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
<<<<<<< HEAD
        Application.Run(new FrmPersonalAdministrativo());


            //Application.Run(new frmActivos());
=======

        Application.Run(new frmUsuarioLista());
       

        //Application.Run(new frmProductoLista());


        //solo ejemplo
        Application.Run(new frmPacienteLista());

        
        //Application.Run(new frmActivos());


>>>>>>> 416191829142a4485c7b56ec28b08b69ec2982c4

        }
    }
}