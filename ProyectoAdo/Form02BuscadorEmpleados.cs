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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            String cadena = @"Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //String deptno = this.txtdato.Text;
            String dato = this.txtdato.Text;
            //String query = "select apellido, oficio from emp where dept_no = " + deptno;
            String query = "select apellido, oficio from emp where oficio = '" + dato + "'";
            this.lstempleados.Items.Clear();
            //ENTRAR SALIR
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = query;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                //GetString() NO LO USAMOS MÁS PORQUE SI CAMBIAMOS LA CONSULTA, SE ROMPE EL CÓDIGO
                //String apellido = this.reader.GetString(0);
                //String oficio = this.reader.GetString(1);
                String apellido = this.reader["apellido"].ToString();
                String oficio = this.reader["oficio"].ToString();
                this.lstempleados.Items.Add(apellido + " - " + oficio);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
