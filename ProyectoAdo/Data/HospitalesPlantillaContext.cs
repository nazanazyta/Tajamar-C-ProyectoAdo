using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoAdo.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

#region
//create procedure plantillahospital
//(@hospital nvarchar(30))
//as
//    declare @codigo int
//    select @codigo = hospital_cod from HOSPITAL where NOMBRE = @hospital
//    select apellido, funcion, salario from PLANTILLA where HOSPITAL_COD = @codigo
//go
#endregion

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

        //PACO
        public List<Hospital> GetHospitalesPaco()
        {
            List<Hospital> hospitales = new List<Hospital>();
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from hospital";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                Hospital hospital = new Hospital();
                hospital.IdHospital = Convert.ToInt32(this.reader["hospital_cod"]);
                hospital.Nombre = this.reader["nombre"].ToString();
                hospitales.Add(hospital);
            }
            this.reader.Close();
            this.cn.Close();
            return hospitales;
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

        //PACO
        public List<Plantilla> GetPlantillaHospital (String datos)
        {
            List<Plantilla> plantillas = new List<Plantilla>();
            String sql = "select * from plantilla where hospital_cod in (" + datos + ")";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                Plantilla plantilla = new Plantilla();
                plantilla.Apellido = this.reader["apellido"].ToString();
                plantilla.Funcion = this.reader["funcion"].ToString();
                plantilla.Salario = Convert.ToInt32(this.reader["salario"]);
                plantilla.Hospital = Convert.ToInt32(this.reader["hospital_cod"]);
                plantillas.Add(plantilla);
            }
            this.reader.Close();
            this.cn.Close();
            return plantillas;
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
