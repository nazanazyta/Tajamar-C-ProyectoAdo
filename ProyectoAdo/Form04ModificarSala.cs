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
    public partial class Form04ModificarSala : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form04ModificarSala()
        {
            InitializeComponent();
            String cadenaconexion = "Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.cn = new SqlConnection(cadenaconexion);
            this.com = new SqlCommand();
            this.CargarSalas();
        }
        private void CargarSalas()
        {
            this.lstsalas.Items.Clear();
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = "select distinct nombre from sala";
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            while (this.reader.Read())
            {
                this.lstsalas.Items.Add(this.reader["nombre"].ToString());
            }
            this.reader.Close();
            this.cn.Close();
        }

        private void btnmodificarsala_Click(object sender, EventArgs e)
        {
            this.com.Parameters.AddWithValue("@salaantigua", this.lstsalas.SelectedItem.ToString());
            this.com.Parameters.AddWithValue("@salanueva", this.txtnuevonombre.Text);
            String query = "update sala set nombre = @salanueva where nombre = @salaantigua";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = query;
            this.cn.Open();
            this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarSalas();
        }
    }
}
