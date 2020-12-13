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
    public partial class Form01PrimerAdo : Form
    {
        String cadenaconexion;
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            //INSTANCIAMOS LOS OBJETOS
            this.cadenaconexion =
                @"Data Source=localhost;Initial Catalog=HOSPITAL;Integrated Security=True";
            this.cn = new SqlConnection(this.cadenaconexion);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblestado.Text = "Connection pasando de " + e.OriginalState
                + " a " + e.CurrentState;
        }

        private void btnconectar_Click(object sender, EventArgs e)
        {
            //SIEMPRE ES CONVENIENTE METERLO DENTRO DE UN TRY Y UN CATCH
            //PARA QUE CAPTURE LA EXCEPCIÓN POR SI EL SERVIDOR ESTÁ PARADO
            //EN CLASE NO LO HAREMOS PARA VER LOS ERRORES
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
                this.lblestado.BackColor = Color.LightGreen;
            }
        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblestado.BackColor = Color.LightCoral;
            this.lstapellidos.Items.Clear();
            this.lstcolumnas.Items.Clear();
            this.lsttipos.Items.Clear();
        }

        private void btnleerdatos_Click(object sender, EventArgs e)
        {
            //this.lstapellidos.Items.Clear();
            //this.lstcolumnas.Items.Clear();
            //this.lsttipos.Items.Clear();
            //TENEMOS QUE INDICAR AL COMANDO LA CONEXIÓN
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA A REALIZAR
            this.com.CommandType = CommandType.Text;
            //LA CONSULTA A BBDD
            this.com.CommandText = "select * from emp";
            //EJECUTAMOS EL COMANDO CON LA CONEXIÓN ABIERTA
            this.reader = this.com.ExecuteReader();

            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                String columna = this.reader.GetName(i);
                String tipo = this.reader.GetDataTypeName(i);
                this.lstcolumnas.Items.Add(columna);
                this.lsttipos.Items.Add(tipo);
            }

            while (this.reader.Read())
            {
                String apellido = this.reader.GetString(1);
                this.lstapellidos.Items.Add(apellido);
            }
            this.reader.Close();
        }
    }
}