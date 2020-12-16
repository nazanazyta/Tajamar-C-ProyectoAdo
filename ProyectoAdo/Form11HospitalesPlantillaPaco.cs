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
    public partial class Form11HospitalesPlantillaPaco : Form
    {
        HospitalesPlantillaContext context;

        public Form11HospitalesPlantillaPaco()
        {
            InitializeComponent();
            this.context = new HospitalesPlantillaContext();
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            List<Hospital> hospitales = this.context.GetHospitalesPaco();
            int posy = 20;
            foreach (Hospital hosp in hospitales)
            {
                CheckBox chk = new CheckBox();
                chk.Text = hosp.Nombre;
                chk.Tag = hosp.IdHospital;
                chk.AutoSize = true;
                chk.Location = new Point(10, posy);
                posy += 40;
                chk.CheckedChanged += MostrarPlantilla;
                this.pnlhospitales.Controls.Add(chk);
            }
        }

        private void MostrarPlantilla(object sender, EventArgs e)
        {
            String datos = "";
            foreach (Control c in this.pnlhospitales.Controls)
            {
                if (c is CheckBox)
                {
                    if(((CheckBox)c).Checked == true)
                    {
                        String id = c.Tag.ToString();
                        datos += id + ",";
                    }
                }
            }
            this.lsvplantilla.Items.Clear();
            if (datos != "")
            {
                //TENEMOS HOSPITALES 19,22,...,
                datos = datos.Trim(',');
                List<Plantilla> plantillas = this.context.GetPlantillaHospital(datos);
                foreach (Plantilla plan in plantillas)
                {
                    ListViewItem it = new ListViewItem();
                    it.Text = plan.Apellido;
                    it.SubItems.Add(plan.Funcion);
                    it.SubItems.Add(plan.Salario.ToString());
                    it.SubItems.Add(plan.Hospital.ToString());
                    this.lsvplantilla.Items.Add(it);
                }
            }
        }
    }
}
