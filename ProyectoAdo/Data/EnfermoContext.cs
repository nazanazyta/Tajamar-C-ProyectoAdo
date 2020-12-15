using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using ProyectoAdo.Models;

namespace ProyectoAdo.Data
{
    public class EnfermoContext
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;
        
        public EnfermoContext()
        {
            String cadena =
                ConfigurationManager.ConnectionStrings["conexionhospitalcasa"].ConnectionString;
            this.cn = new SqlConnection(cadena);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }
        
        public List<Enfermo> GetEnfermos()
        {
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select * from enfermo";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            List<Enfermo> lista = new List<Enfermo>();
            while (this.reader.Read()){
                Enfermo enf = new Enfermo();
                enf.Inscripcion = Convert.ToInt32(this.reader["inscripcion"]);
                enf.Apellido = this.reader["apellido"].ToString();
                enf.Direccion = this.reader["direccion"].ToString();
                enf.FechaNacimiento = Convert.ToDateTime(this.reader["fecha_nac"]);
                lista.Add(enf);
            }
            this.reader.Close();
            this.cn.Close();
            return lista;
        }

        public int EliminarEnfermo(int inscripcion)
        {
            this.com.Parameters.AddWithValue("@inscrip", inscripcion);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText =
                "delete from enfermo where inscripcion = @inscrip";
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            return eliminados;
        }
    }
}
