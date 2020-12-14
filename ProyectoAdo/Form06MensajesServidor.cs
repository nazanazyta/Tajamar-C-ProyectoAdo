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
    //create procedure InsertarDepartamento(@numero int, @nombre nvarchar(30), @localidad nvarchar(30))
    //as
    //	insert into dept([DEPT_NO], [DNOMBRE], [LOC]) values(@numero, @nombre, @localidad)
    //go

    //alter procedure InsertarDepartamento(@numero int, @nombre nvarchar(30), @localidad nvarchar(30))
    //as
	//  --NO QUEREMOS INSERTAR NADA EN TERUEL
	//  if (@localidad = 'Teruel')
    //  begin
    //      print 'Teruel no existe'
    //  end
    //  else
    //  begin
    //      insert into dept([DEPT_NO], [DNOMBRE], [LOC]) values(@numero, @nombre, @localidad)
    //  end
    //go

    //create procedure CargarDepartamentos
    //as
    //	select* from dept
    //go
#endregion

namespace ProyectoAdo
{
    public partial class Form06MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        
        public Form06MensajesServidor()
        {
            InitializeComponent();
            this.lblmensajes.Text = "";
            //String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            String cadena = "Data Source=localhost;Initial Catalog=HOSPITAL;User ID=sa;Password=MCSD2020";
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.cn.InfoMessage += Cn_InfoMessage;
            this.CargarDepartamentos();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblmensajes.Text = e.Message;
        }

        private void CargarDepartamentos()
        {
            this.lstdepartamentos.Items.Clear();
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "CargarDepartamentos";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstdepartamentos.Items.Add(this.reader["dept_no"].ToString() + " - " + this.reader["dnombre"]
                    + " - " + this.reader["loc"]);
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btninsertardepartamento_Click(object sender, EventArgs e)
        {
            this.lblmensajes.Text = "";
            this.lstdepartamentos.Items.Clear();
            this.com.Parameters.AddWithValue("@numero", this.txtnumero.Text);
            this.com.Parameters.AddWithValue("@nombre", this.txtnombre.Text);
            this.com.Parameters.AddWithValue("@localidad", this.txtlocalidad.Text);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "InsertarDepartamento";
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarDepartamentos();
        }
    }
}
