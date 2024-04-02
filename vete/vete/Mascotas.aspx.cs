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
    public partial class Mascotas : System.Web.UI.Page
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
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM MASCOTAS", con))
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

        protected void Bagregar_Click(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            SqlConnection conexion = new SqlConnection(s);
            conexion.Open();
            SqlCommand comando = new SqlCommand("INSERT INTO MASCOTAS VALUES('" + mascota.Text + "','" + tipo.Text + "','" + comida.Text + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
            LlenarGrid();
        }

        protected void Beliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = null;
            try
            {
                String connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
                conexion = new SqlConnection(connectionString);
                conexion.Open();

                string query = "DELETE FROM MASCOTAS WHERE id_mascota = @ID_MASCOTA";
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@ID_MASCOTA", codigo.Text);
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
        protected void Bmodificar_Click(object sender, EventArgs e)
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();

                string query = "UPDATE MASCOTAS SET nombre_mascota = @NombreMascota, tipo_mascota = @TipoMascota, comida_favorita = @ComidaFavorita WHERE id_mascota = @IdMascota";

                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@NombreMascota", mascota.Text);
                    comando.Parameters.AddWithValue("@TipoMascota", tipo.Text);
                    comando.Parameters.AddWithValue("@ComidaFavorita", comida.Text);
                    comando.Parameters.AddWithValue("@IdMascota", codigo.Text); // Assuming tcodigo is a TextBox

                    comando.ExecuteNonQuery();
                }
            }

            LlenarGrid();
        }
    }
}