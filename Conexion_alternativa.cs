using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Crear_CRUD
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection con = new SqlConnection("SERVER=DESKTOP-7KUUIV2;DATABASE=REGISTRO;integrated security=true;");
            con.Open();
            return con;
        }
        public static SqlConnection Desconectar()
        {
            SqlConnection con = new SqlConnection("SERVER=DESKTOP-7KUUIV2;DATABASE=REGISTRO;integrated security=true;");
            con.Close();
            return con;
        }
    }
}
