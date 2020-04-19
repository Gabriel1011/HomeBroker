using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BuscaAcoesF
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            CompositionRoot.Wire(new ApplicationModule());

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                //Application.Run(CompositionRoot.Resolve<BuscarAcoes>());
                Application.Run(CompositionRoot.Resolve<Formularios.HomeBroker>());
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
