using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CapaDeUsuarioWeb
{
    public partial class PaginaPrincipal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/DatosPersonales.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/Transacciones.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/ReservarLibro.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/Renovar.aspx");
        }
    }
}