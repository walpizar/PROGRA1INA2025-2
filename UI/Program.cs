using DAO;
using Services;

namespace UI
{
    internal static class Program
    {
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            using var context = new dbContextINA();
            Application.Run(new frmListaTipoAyudas(context));
        }
    }
}