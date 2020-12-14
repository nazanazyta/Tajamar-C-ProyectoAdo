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

namespace ProyectoAdo
{
    public partial class Form03EliminarEnfermo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        //SqlParameter pam;

        public Form03EliminarEnfermo()
        {
            InitializeComponent();
            //String cadena = @"Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            //this.pam = new SqlParameter();
            //this.pam.ParameterName = "@INSCRIPCION";
            //this.pam.Value = "";
            ////LÍNEA OPCIONAL (EN ESTE CASO AL MENOS)
            //this.pam.DbType = DbType.String;
            //this.com.Parameters.Add(pam);
            this.CargarEnfermos();
        }

        private void CargarEnfermos()
        {
            this.lstenfermos.Items.Clear();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from enfermo";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                String ape = this.reader["apellido"].ToString();
                String inscripcion = this.reader["inscripcion"].ToString();
                this.lstenfermos.Items.Add(ape + " - " + inscripcion);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            //SqlParameter pam = new SqlParameter(
            //    parameterName: "@INSCRIPCION",
            //    value: this.txtinscripcion.Text
            //);
            SqlParameter pam;
            pam = new SqlParameter();
            pam.ParameterName = "@INSCRIPCION";
            pam.Value = this.txtinscripcion.Text;
            //LÍNEA OPCIONAL (EN ESTE CASO AL MENOS)
            pam.DbType = DbType.String;
            //this.com.Parameters.Add(pam);
            //this.com.Parameters.Add(new SqlParameter("@INSCRIPCION", this.txtinscripcion.Text));
            this.com.Parameters.AddWithValue("@INSCRIPCION", this.txtinscripcion.Text);
            String query = "delete from enfermo where inscripcion = @inscripcion";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = query;
            this.cn.Open();
            //ExecuteNonQuery SE USA PARA CONSULTAS DE ACCIÓN: DELETE, UPDATE O INSERT
            int afectados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarEnfermos();
        }
    }
}
