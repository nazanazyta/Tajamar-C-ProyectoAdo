using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

#region VISTAS Y PROCEDIMIENTOS ALMACENADOS
    //create procedure cargarhospitales
    //as
    // select nombre from hospital
    //go

    //create view doctoresplantillas
    //as
    //  select apellido, salario, hospital_cod from doctor
    //  union
    //  select apellido, salario, hospital_cod from plantilla
    //go

    //create procedure empleadoshospitalout
    //(@nombre nvarchar(30), @suma int out, @media int out, @emple int out)
    //as
    //  declare @hospno int
    //  select @hospno = hospital_cod from hospital where nombre =  @nombre
    //  select* from doctoresplantillas where hospital_cod = @hospno
    //  select @suma = sum(salario),  @media = avg(salario), @emple = count(apellido) from doctoresplantillas
    //  where hospital_cod = @hospno
#endregion

namespace ProyectoAdo
{
    public partial class Form08PlantillaDoctorHospital : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form08PlantillaDoctorHospital()
        {
            InitializeComponent();
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospitalclase"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.CargarHospitales();
        }

        private void CargarHospitales()
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "cargarhospitales";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbhospitales.Items.Add(this.reader["nombre"]);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void cmbhospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstempleados.Items.Clear();
            this.com.Parameters.AddWithValue("@nombre", this.cmbhospitales.SelectedItem.ToString());
            SqlParameter pamsuma = new SqlParameter("@suma", 0);
            SqlParameter pammedia = new SqlParameter("@media", 0);
            SqlParameter pamtotal = new SqlParameter("@emple", 0);
            pamsuma.Direction = ParameterDirection.Output;
            pammedia.Direction = ParameterDirection.Output;
            pamtotal.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamsuma);
            this.com.Parameters.Add(pammedia);
            this.com.Parameters.Add(pamtotal);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "empleadoshospitalout";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstempleados.Items.Add(this.reader["apellido"]);
            }
            this.reader.Close();
            //HASTA QUE NO CERRAMOS EL LECTOR, LOS PARÁMETROS DE SALIDA NO SON LIBERADOS
            this.txtsumasalarial.Text = pamsuma.Value.ToString();
            this.txtmediasalarial.Text = pammedia.Value.ToString();
            this.txtnumeroempleados.Text = pamtotal.Value.ToString();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
