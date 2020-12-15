using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAdo.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace ProyectoAdo.Data
{
    public class HospitalesPlantillaContext
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public HospitalesPlantillaContext()
        {
            String cadena =
                ConfigurationManager.ConnectionStrings["conexionhospitalcasa"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public List<String> GetHospitales()
        {
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select nombre from hospital";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<String> lista = new List<String>();
            while (this.reader.Read())
            {
                lista.Add(this.reader["nombre"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }

        public List<Plantilla> GetPlantilla(String hospital)
        {
            this.com.Parameters.AddWithValue("@hospital", hospital);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = "plantillahospital";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Plantilla> lista = new List<Plantilla>();
            while (this.reader.Read())
            {
                Plantilla emple = new Plantilla();
                emple.Apellido = this.reader["apellido"].ToString();
                emple.Funcion = this.reader["funcion"].ToString();
                emple.Salario = Convert.ToInt32(this.reader["salario"]);
                lista.Add(emple);
            }
            this.reader.Close();
            this.cn.Close();
            this.com.Parameters.Clear();
            return lista;
        }
    }
}
