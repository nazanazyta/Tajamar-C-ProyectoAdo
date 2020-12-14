using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

#region PROCEDIMIENTOS ALMACENADOS
    //create procedure CargarDepartamentos
    //as
    //	select* from dept
    //go

    //create procedure empleadosdeptout
    //(@nombre nvarchar(30), @suma int out)
    //as
    //  declare @deptno int
    //  select @deptno = dept_no from dept where dnombre = @nombre
    //  select* from emp where dept_no = @deptno
    //  select @suma = sum(salario) from emp where dept_no = @deptno
    //go
#endregion

namespace ProyectoAdo
{
    public partial class Form07ParametrosSalida : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form07ParametrosSalida()
        {
            InitializeComponent();
            String color = ConfigurationManager.AppSettings["colorfondo"];
            //this.BackColor = Color.FromName(color);
            String cadena = ConfigurationManager.ConnectionStrings["conexionhospitalclase"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "cargardepartamentos";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.cmbdepartamentos.Items.Add(this.reader["dnombre"]);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void cmbdepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstempleados.Items.Clear();
            this.com.Parameters.AddWithValue("@nombre", this.cmbdepartamentos.SelectedItem.ToString());
            SqlParameter pamsuma = new SqlParameter();
            pamsuma.ParameterName = "@suma";
            pamsuma.Direction = ParameterDirection.Output;
            pamsuma.Value = 0;
            this.com.Parameters.Add(pamsuma);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "empleadosdeptout";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstempleados.Items.Add(this.reader["apellido"]);
            }
            this.reader.Close();
            //HASTA QUE NO CERRAMOS EL LECTOR, LOS PARÁMETROS DE SALIDA NO SON LIBERADOS
            this.txtsumasalarial.Text = pamsuma.Value.ToString();
            this.cn.Close();
            this.com.Parameters.Clear();
        }
    }
}
