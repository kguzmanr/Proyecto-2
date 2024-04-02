using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace vete
{
    public partial class Ingresar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void tboton_Click(object sender, EventArgs e)
        {
           if (CLusuarios.Ingresar(Tnombre.Text, Tclave.Text) > 0)
            {
                Response.Redirect("Registro1.aspx");

            }
            else
            {
           // lmensaje.Text = "Usuario o Contarsena incorrecto";
            }
        }

        protected void Bingresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro1.aspx");
        }
    }
}