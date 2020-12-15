using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoAdo.Data;
using ProyectoAdo.Models;

namespace ProyectoAdo
{
    public partial class Form11HospitalesPlantilla : Form
    {
        HospitalesPlantillaContext context;

        public Form11HospitalesPlantilla()
        {
            InitializeComponent();
            this.context = new HospitalesPlantillaContext();
            int posy = 10;
            foreach(String hospi in this.context.GetHospitales())
            {
                CheckBox chk = new CheckBox();
                chk.Text = hospi;
                chk.AutoSize = true;
                chk.Location = new Point(10, posy);
                posy += 40;
                this.panel1.Controls.Add(chk);
                chk.CheckedChanged += MostrarPlantilla;
            }
        }

        private void MostrarPlantilla(object sender, EventArgs e)
        {
            this.lstplantilla.Items.Clear();
            //CheckBox chk = (CheckBox)sender;
            List<Plantilla> lista = new List<Plantilla>();
            foreach (CheckBox check in this.panel1.Controls)
            {
                if (check.Checked == true)
                {
                    foreach (Plantilla emple in this.context.GetPlantilla(check.Text))
                    {
                        ListViewItem it = new ListViewItem();
                        it.Text = emple.Apellido;
                        it.SubItems.Add(emple.Funcion);
                        it.SubItems.Add(emple.Salario.ToString());
                        this.lstplantilla.Items.Add(it);
                    }
                }
            }
        }


        //public void CargarEmpleados(List<Empleado> empleados)
        //{
        //    this.lsvempleados.Items.Clear();
        //    foreach (Empleado emp in empleados)
        //    {
        //        ListViewItem it = new ListViewItem();
        //        it.Text = emp.IdEmpleado.ToString();
        //        it.SubItems.Add(emp.Apellido);
        //        it.SubItems.Add(emp.Oficio);
        //        it.SubItems.Add(emp.Salario.ToString());
        //        this.lsvempleados.Items.Add(it);
        //    }
        //}
    }
}
