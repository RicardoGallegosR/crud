using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crear_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.Conectar();
                DTGView.DataSource = llenar_grid();
                // MessageBox.Show("Conexion exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en conexion --" + ex.Message);
            }
        }

        public DataTable llenar_grid()
        {
            Conexion.Conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM ALUMNO";

            SqlCommand cmd = new SqlCommand(consulta, Conexion.Conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;

        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Conexion.Conectar();
            string insertar = "INSERT INTO ALUMNO (CODIGO,NOMBRE,APELLIDO,DIRECCION) VALUES(@CODIGO,@NOMBRE,@APELLIDO,@DIRECCION)";
            SqlCommand cmd = new SqlCommand(insertar, Conexion.Conectar());
            cmd.Parameters.AddWithValue("@CODIGO", txtcodigo.Text);
            cmd.Parameters.AddWithValue("@NOMBRE", txtnombre.Text);
            cmd.Parameters.AddWithValue("@APELLIDO", txtapellido.Text);
            cmd.Parameters.AddWithValue("@DIRECCION", txtdireccion.Text);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Los datos fueron cargados");
            DTGView.DataSource = llenar_grid();
        }

        private void button_2_Click(object sender, EventArgs e)
        {

        }
    }
}
