using DAO;
using Services;
using UI;
using System;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var context = new dbContextINA();
            var dao = new AfiliadoDonanteDAO(context);
            var service = new AfiliadoDonanteService(dao);

            Application.Run(new FrmControlAfiliados(service));
        }
    }
}
