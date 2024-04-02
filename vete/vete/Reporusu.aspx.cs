using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vete
{
    public partial class Reporusu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LlenarGrid();
            }
        }

        private void LlenarGrid()
        {
            SqlConnection con = null;
            try
            {
                string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                con = new SqlConnection(constr);
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM USUARIOS", con))
                {
                    con.Open();
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        GridView1.DataSource = dt;
                        GridView1.DataBind();
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        protected void Bingresar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO USUARIOS VALUES('" + tusuario.Text + "','" + tcontrasena.Text + "','" + tnombre.Text + "','" + tapellidos.Text + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }

        protected void Bborrar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = null;
            try
            {
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                conexion = new SqlConnection(connectionString);
                conexion.Open();

                string query = "DELETE FROM USUARIOS WHERE login_usuario = @Usuario";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", tusuario.Text);
                    comando.ExecuteNonQuery();
                }
                LlenarGrid();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                if (conexion != null)
                {
                    conexion.Close();
                }
            }
        }
        protected void Bcambiar_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string query = "UPDATE USUARIOS SET nombre = @Nombre, apellidos = @Apellidos, clave_usuario = @Contrasena WHERE login_usuario = @Usuario";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@Nombre", tnombre.Text);
                    comando.Parameters.AddWithValue("@Apellidos", tapellidos.Text);
                    comando.Parameters.AddWithValue("@Contrasena", tcontrasena.Text);
                    comando.Parameters.AddWithValue("@Usuario", tusuario.Text); // Assuming tcodigo is a TextBox

                    comando.ExecuteNonQuery();
                }
            }

            LlenarGrid();
        }
    }
}