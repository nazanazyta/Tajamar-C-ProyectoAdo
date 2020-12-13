using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAdo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form01PrimerAdo());
            //Application.Run(new Form02BuscadorEmpleados());
            //Application.Run(new Form03EliminarEnfermo());
            Application.Run(new Form04ModificarSala());
        }
    }
}
