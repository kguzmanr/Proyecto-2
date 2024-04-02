using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vete
{
    public partial class Registro1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Bregistrar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO USUARIOS VALUES('" + tusuario.Text + "','" + tcontrasena.Text + "','" + tnombre.Text + "','" + tapellidos.Text + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}