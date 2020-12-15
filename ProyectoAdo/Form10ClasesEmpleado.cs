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
    public partial class Form10ClasesEmpleado : Form
    {
        EmpleadoContext context;
        public Form10ClasesEmpleado()
        {
            InitializeComponent();
            this.context = new EmpleadoContext();
            this.CargarEmpleados(this.context.GetEmpleados());
            //this.CargarOficios();
            foreach(String ofi in this.context.GetOficios())
            {
                this.cmboficios.Items.Add(ofi);
            }
        }

        public void CargarEmpleados(List<Empleado> empleados)
        {
            this.lsvempleados.Items.Clear();
            foreach (Empleado emp in empleados)
            {
                ListViewItem it = new ListViewItem();
                it.Text = emp.IdEmpleado.ToString();
                it.SubItems.Add(emp.Apellido);
                it.SubItems.Add(emp.Oficio);
                it.SubItems.Add(emp.Salario.ToString());
                this.lsvempleados.Items.Add(it);
            }
        }

        //private void CargarOficios()
        //{
        //    List<String> oficios = this.context.GetOficios();
        //    this.cmboficios.Items.Clear();
        //    foreach (String ofi in oficios)
        //    {
        //        this.cmboficios.Items.Add(ofi);
        //    }
        //}

        private void cmboficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            String oficio = this.cmboficios.SelectedItem.ToString();
            List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
            this.CargarEmpleados(empleados);
        }

        private void btnincrementar_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtincremento.Text);
            String oficio = this.cmboficios.SelectedItem.ToString();
            this.context.ModificarSalarioEmpleados(incremento, oficio);
            List<Empleado> empleados = this.context.GetEmpleadosOficio(oficio);
            this.CargarEmpleados(empleados);
        }
    }
}
