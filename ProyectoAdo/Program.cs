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
            //Application.Run(new Form04ModificarSala());
            //Application.Run(new Form05StoredProcedures());
            //Application.Run(new Form06MensajesServidor());
            //Application.Run(new Form07ParametrosSalida());
            //Application.Run(new Form08PlantillaDoctorHospital());
            //Application.Run(new Form09ClasesEnfermo());
            //Application.Run(new Form10ClasesEmpleado());
            Application.Run(new Form11HospitalesPlantilla());
        }
    }
}
