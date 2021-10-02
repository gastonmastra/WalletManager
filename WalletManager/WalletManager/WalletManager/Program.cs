using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WalletManager.Model;
using WalletManager.Repository;

namespace WalletManager
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (UnidadDeTrabajo unidadDeTrabajo = new UnidadDeTrabajo(new DBContext()))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Principal(unidadDeTrabajo));
            }
        }
    }
}
