using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ProyectoAdo.Models;

#region PROCEDIMIENTOS ALMACENADOS
//create procedure incrementarsalariooficios
//(@incremento int, @oficio nvarchar(30))
//as
//    update EMP set SALARIO = SALARIO + @incremento
//		where oficio = @oficio
//go
#endregion

namespace ProyectoAdo.Data
{
    public class EmpleadoContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public EmpleadoContext()
        {
            String cadena =
                ConfigurationManager.ConnectionStrings["conexionhospitalcasa"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<Empleado> GetEmpleados()
        {
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from emp";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Empleado> lista = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                emp.IdEmpleado = Convert.ToInt32(this.reader["emp_no"]);
                emp.Apellido = this.reader["apellido"].ToString();
                emp.Oficio = this.reader["oficio"].ToString();
                emp.Salario = Convert.ToInt32(this.reader["salario"]);
                lista.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }

        public List<String> GetOficios()
        {
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select distinct oficio from emp";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> lista = new List<String>();
            while (this.reader.Read())
            {
                lista.Add(this.reader["oficio"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }

        public List<Empleado> GetEmpleadosOficio(String oficio)
        {
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from emp where oficio = @oficio";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Empleado> lista = new List<Empleado>();
            while (this.reader.Read())
            {
                Empleado emp = new Empleado();
                emp.IdEmpleado = Convert.ToInt32(this.reader["emp_no"]);
                emp.Apellido = this.reader["apellido"].ToString();
                emp.Oficio = this.reader["oficio"].ToString();
                emp.Salario = Convert.ToInt32(this.reader["salario"]);
                lista.Add(emp);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return lista;
        }

        public int ModificarSalarioEmpleados (int incremento, String oficio)
        {
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "incrementarsalariooficios";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.cn.Open();
            int modificados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return modificados;
        }
    }
}
