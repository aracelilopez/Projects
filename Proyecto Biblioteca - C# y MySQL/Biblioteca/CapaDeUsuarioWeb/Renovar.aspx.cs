using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDeNegocio;
using excepciones;

namespace CapaDeUsuarioWeb
{
    public partial class Renovar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ListBox1.DataSource = ((Administradora)Session["Administradora"]).prestamosxclientes(((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio);
                ListBox1.DataBind();
            }
        }

        protected void ButtonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Session["prestamoBuscar"] = null;
                int codigo = int.Parse(TextBox2.Text);

                Prestamo pres = ((Administradora)Session["Administradora"]).buscarprestamo(codigo);
                Session["prestamoBuscar"] = pres;

                if (Session["prestamoBuscar"] != null)
                {
                    int isbn = ((Prestamo)Session["prestamoBuscar2"]).Libro.Isbn;
                    int ejemplar = ((Prestamo)Session["prestamoBuscar2"]).Libro.Ejemplar;

                    if (((Administradora)Session["Administradora"]).ahireserva(isbn, ejemplar))
                    {
                        Label4.Visible = false;
                        Label2.Visible = false;
                        Label3.Visible = false;
                        LabelFecha1.Visible = false;
                        LabelFecha2.Visible = false;
                        TextBoxLibro.Visible = false;
                        TextBoxFecha.Visible = false;
                        TextBoxFecha2.Visible = false;
                        TextBoxFecha3.Visible = false;
                        ButtonConfirmar.Visible = false;

                        // LabelError.Visible = false;

                        TextBoxFecha.Text = "";
                        TextBoxFecha2.Text = "";
                        TextBoxFecha3.Text = "";
                        TextBoxLibro.Text = "";

                        LabelError.Visible = false;
                        LabelError2.Visible = false;
                        LabelError2.Text = "no se puede,ya que existe una reserva";
                        LabelError2.Visible = true;
                    }
                    else
                    {
                        //asignar
                        TextBoxLibro.Text = ((Prestamo)Session["prestamoBuscar"]).Libro.Titulo;
                        TextBoxFecha.Text = ((Prestamo)Session["prestamoBuscar"]).FechaReserva.ToString();
                        TextBoxFecha2.Text = ((Prestamo)Session["prestamoBuscar"]).Fechadevolucion.ToString();
                        int dias = ((Prestamo)Session["prestamoBuscar"]).Cliente.dardiasXretirar();

                        TextBoxFecha3.Text = ((Prestamo)Session["prestamoBuscar"]).Fechadevolucion.AddDays(dias).ToString();




                        //habilitar
                        Label4.Visible = true;
                        Label2.Visible = true;
                        Label3.Visible = true;
                        LabelFecha1.Visible = true;
                        LabelFecha2.Visible = true;
                        TextBoxLibro.Visible = true;
                        TextBoxFecha.Visible = true;
                        TextBoxFecha2.Visible = true;
                        TextBoxFecha3.Visible = true;
                        ButtonConfirmar.Visible = true;

                        LabelError.Visible = false;
                        LabelError2.Visible = false;
                    }
                }
                else
                {
                    LabelError2.Visible = true;
                    LabelError2.Text = "No se encontro el prestamo"; Label4.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    LabelFecha1.Visible = false;
                    LabelFecha2.Visible = false;
                    TextBoxLibro.Visible = false;
                    TextBoxFecha.Visible = false;
                    TextBoxFecha2.Visible = false;
                    TextBoxFecha3.Visible = false;
                    ButtonConfirmar.Visible = false;

                    //LabelError.Visible = false;

                    TextBoxFecha.Text = "";
                    TextBoxFecha2.Text = "";
                    TextBoxFecha3.Text = "";
                    TextBoxLibro.Text = "";

                    LabelError.Visible = false;
                    //LabelError2.Visible = false;
                }


            }



            catch (BlancoException ex)
            {
                LabelError.Text = ex.Message;
                LabelError.Visible = true;
                TextBox2.Focus();

            }

            catch (Exception ex)
            {
                LabelError2.Text = ex.Message;
                LabelError2.Visible = true;
                TextBox2.Focus();
            }
            //finally---> no me lo toma(revisar)
            //restableser datos

        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Label4.Visible = false;
            Label2.Visible = false;
            Label3.Visible = false;
            LabelFecha1.Visible = false;
            LabelFecha2.Visible = false;
            TextBoxLibro.Visible = false;
            TextBoxFecha.Visible = false;
            TextBoxFecha2.Visible = false;
            TextBoxFecha3.Visible = false;
            ButtonConfirmar.Visible = false;

            //LabelError.Visible = false;

            TextBoxFecha.Text = "";
            TextBoxFecha2.Text = "";
            TextBoxFecha3.Text = "";
            TextBoxLibro.Text = "";

            LabelError.Visible = false;
            LabelError2.Visible = false;


        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Session["prestamoBuscar"] = null;
                if (ListBox1.SelectedIndex > -1)
                {

                    Prestamo pres = ((Administradora)Session["Administradora"]).darPrestamo(ListBox1.SelectedIndex);

                    Session["prestamoBuscar"] = pres;

                    if (Session["prestamoBuscar"] != null)
                    {
                        int isbn = ((Prestamo)Session["prestamoBuscar"]).Libro.Isbn;
                        int ejemplar = ((Prestamo)Session["prestamoBuscar"]).Libro.Ejemplar;

                        if (((Administradora)Session["Administradora"]).ahireserva(isbn, ejemplar))
                        {
                            Label4.Visible = false;
                            Label2.Visible = false;
                            Label3.Visible = false;
                            LabelFecha1.Visible = false;
                            LabelFecha2.Visible = false;
                            TextBoxLibro.Visible = false;
                            TextBoxFecha.Visible = false;
                            TextBoxFecha2.Visible = false;
                            TextBoxFecha3.Visible = false;
                            ButtonConfirmar.Visible = false;

                            // LabelError.Visible = false;

                            TextBoxFecha.Text = "";
                            TextBoxFecha2.Text = "";
                            TextBoxFecha3.Text = "";
                            TextBoxLibro.Text = "";

                            LabelError.Visible = false;
                            LabelError2.Visible = false;
                            LabelError.Text = "no se puede,ya que existe una reserva";
                            LabelError.Visible = true;
                        }
                        else
                        {

                            //asignar
                            TextBoxLibro.Text = ((Prestamo)Session["prestamoBuscar"]).Libro.Titulo;
                            TextBoxFecha.Text = ((Prestamo)Session["prestamoBuscar"]).FechaReserva.ToString();
                            TextBoxFecha2.Text = ((Prestamo)Session["prestamoBuscar"]).Fechadevolucion.ToString();
                            int dias = ((Prestamo)Session["prestamoBuscar"]).Cliente.dardiasXretirar();

                            TextBoxFecha3.Text = ((Prestamo)Session["prestamoBuscar"]).Fechadevolucion.AddDays(dias).ToString();

                            //habilitar
                            Label4.Visible = true;
                            Label2.Visible = true;
                            Label3.Visible = true;
                            LabelFecha1.Visible = true;
                            LabelFecha2.Visible = true;
                            TextBoxLibro.Visible = true;
                            TextBoxFecha.Visible = true;
                            TextBoxFecha2.Visible = true;
                            TextBoxFecha3.Visible = true;
                            ButtonConfirmar.Visible = true;

                            LabelError.Visible = false;
                            LabelError2.Visible = false;
                        }
                    }
                    else
                    {
                        LabelError2.Visible = true;
                        LabelError2.Text = "no se encontro el prestamo";
                        Label4.Visible = false;
                        Label2.Visible = false;
                        Label3.Visible = false;
                        LabelFecha1.Visible = false;
                        LabelFecha2.Visible = false;
                        TextBoxLibro.Visible = false;
                        TextBoxFecha.Visible = false;
                        TextBoxFecha2.Visible = false;
                        TextBoxFecha3.Visible = false;
                        ButtonConfirmar.Visible = false;

                        LabelError.Visible = false;

                        TextBoxFecha.Text = "";
                        TextBoxFecha2.Text = "";
                        TextBoxFecha3.Text = "";
                        TextBoxLibro.Text = "";

                        LabelError.Visible = false;
                        //LabelError2.Visible = false;
                    }
                }
                else
                {
                    LabelError2.Visible = true;
                    LabelError2.Text = "no se indexa";
                    Label4.Visible = false;
                    Label2.Visible = false;
                    Label3.Visible = false;
                    LabelFecha1.Visible = false;
                    LabelFecha2.Visible = false;
                    TextBoxLibro.Visible = false;
                    TextBoxFecha.Visible = false;
                    TextBoxFecha2.Visible = false;
                    TextBoxFecha3.Visible = false;
                    ButtonConfirmar.Visible = false;

                    //LabelError.Visible = false;

                    TextBoxFecha.Text = "";
                    TextBoxFecha2.Text = "";
                    TextBoxFecha3.Text = "";
                    TextBoxLibro.Text = "";

                    LabelError.Visible = false;
                    //                LabelError2.Visible = false;
                }
            }
            catch (BlancoException ex)
            {
                LabelError.Text = ex.Message;
                LabelError.Visible = true;
                TextBox2.Focus();

            }

            catch (Exception ex)
            {
                LabelError2.Text = ex.Message;
                LabelError2.Visible = true;
                TextBox2.Focus();
            }
            //finally---> no me lo toma(revisar)
            //restableser datos
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/PaginaPrincipal.aspx");
        }

        protected void ButtonConfirmar_Click(object sender, EventArgs e)
        {
            
            try
            {
                  if(Session["prestamoBuscar"] !=null)
              {
                int isbn = ((Prestamo)Session["prestamoBuscar"]).Libro.Isbn;
                int ejemplar = ((Prestamo)Session["prestamoBuscar"]).Libro.Ejemplar;

                if(!((Administradora)Session["Administradora"]).ahireserva(isbn,ejemplar))
                {
                       if(((Administradora)Session["Administradora"]).renovarPrestamo(((Prestamo)Session["prestamoBuscar"])))
                       {
                           Response.Redirect("http://localhost:55374/PaginaPrincipal.aspx");
                       }
                       else
                       {
                           LabelError2.Text = "hubo un problema";
                           LabelError2.Visible = true;
                       }
                }
                else
                {
                     LabelError2.Text = "fallo, ya existe reserva futuras";
                     LabelError2.Visible = true;
                }
                  }
                  else
                  {
                       LabelError2.Text = "no ahi prestamo indicado";
                           LabelError2.Visible = true;
                  }
            }
            catch (BlancoException ex)
            {
                LabelError.Text = ex.Message;
                LabelError.Visible = true;
                TextBox2.Focus();

            }

            catch (Exception ex)
            {
                LabelError2.Text = ex.Message;
                LabelError2.Visible = true;
                TextBox2.Focus();
            }
            //finally---> no me lo toma(revisar)
            //restableser datos
                
        }

    }
    
}