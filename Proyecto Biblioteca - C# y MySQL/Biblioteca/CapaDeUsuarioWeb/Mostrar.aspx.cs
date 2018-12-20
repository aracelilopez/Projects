using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDeNegocio;

namespace CapaDeUsuarioWeb
{
    public partial class Mostrar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if((Prestamo)Session["Prestamo"] != null)
            {
                LabelTitulo.Text = "Datos de el Prestamo";
                LabelCod.Text = "Codigo de el prestamo:";
                LabelFecha1.Text = "Fecha de el Prestamo: ";
                LabelFecha2.Text = "Fecha de devolucion: ";
                LabelFecha2.Visible = true;
                TextBoxFecha2.Visible = true;

                //cargar textbox
                TextBoxCodigo.Text = ((Prestamo)Session["Prestamo"]).Codigo.ToString();
                TextBoxNombre.Text = ((Prestamo)Session["Prestamo"]).Cliente.Nombre;
                TextBoxLibro.Text = ((Prestamo)Session["Prestamo"]).Libro.Titulo;
                TextBoxFecha.Text = ((Prestamo)Session["Prestamo"]).FechaReserva.ToString();
                TextBoxFecha2.Text = ((Prestamo)Session["Prestamo"]).Fechadevolucion.ToString();
            }
            else
            {
                if((Reserva)Session["Reserva"] != null)
                {
                    LabelTitulo.Text = "Datos de la Reserva";
                    LabelCod.Text = "Codigo de la reserva:";
                    LabelFecha1.Text = "Fecha de la reserva: ";

                    LabelFecha2.Visible = false;
                    TextBoxFecha2.Visible = false;

                    //cargar textbox
                    TextBoxCodigo.Text = ((Reserva)Session["Reserva"]).Codigo.ToString();
                    TextBoxNombre.Text = ((Reserva)Session["Reserva"]).Cliente.Nombre;
                    TextBoxLibro.Text = ((Reserva)Session["Reserva"]).Libro.Titulo;
                    TextBoxFecha.Text = ((Reserva)Session["Reserva"]).FechaDisponibilidad.ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/Transacciones.aspx");
        }
    }
}