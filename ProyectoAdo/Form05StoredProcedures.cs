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

#region PROCEDIMIENTOS ALMACENADOS
    //create procedure TodosEmpleados
    //as
    //	select* from EMP
    //go

    //create procedure BuscarEmpleado(@apellido nvarchar(30))
    //as
    //	select* from emp where apellido like @apellido + '%'
    //go
#endregion

namespace ProyectoAdo
{
    public partial class Form05StoredProcedures : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form05StoredProcedures()
        {
            InitializeComponent();
            //String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "todosempleados";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstempleados.Items.Add(this.reader["apellido"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnbuscarempleados_Click(object sender, EventArgs e)
        {
            this.lstempleados.Items.Clear();
            this.com.Parameters.AddWithValue("@apellido", this.txtapellido.Text);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "BUSCAREMPLEADO";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstempleados.Items.Add(this.reader["apellido"].ToString());
            }
            this.reader.Close();
            this.com.Parameters.Clear();
            this.cn.Close();
        }
    }
}