using DAO;
using Services;

namespace UI
{
    internal static class Program
    {
        static void Main()
        {
            // Asegúrate de tener una instancia de dbContextINA para pasarla al formulario.
            // Supongamos que la clase se llama dbContextINA y tiene un constructor sin parámetros.
            var context = new dbContextINA();

            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}