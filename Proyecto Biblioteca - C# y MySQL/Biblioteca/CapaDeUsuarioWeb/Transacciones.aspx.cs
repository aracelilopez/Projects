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
    public partial class Transacciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (Session["Usuario"] != null)
                {
                    //List<Prestamo> prestamos = ((Administradora)Session["Administradora"]).prestamosxclientes(((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio);
                    List<Reserva> reservas = ((Administradora)Session["Administradora"]).Reservaxclientes(((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio);

                    //ListBox1.DataSource = null;
                    ListBox1.DataSource = ((Administradora)Session["Administradora"]).prestamosxclientes(((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio);
                    ListBox1.DataBind();

                    //ListBox2.DataSource = null;
                    ListBox2.DataSource = ((Administradora)Session["Administradora"]).Reservaxclientes(((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio);
                    ListBox2.DataBind();

                    Label1.Visible = false;
                    

                }
                else
                    TextBox1.Text = "Hola";
            }
            
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/PaginaPrincipal.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox1.SelectedIndex > -1)
            {
                Prestamo pres = ((Administradora)Session["Administradora"]).darPrestamo(ListBox1.SelectedIndex);

                Session["Prestamo"] = pres;

                if (Session["Prestamo"] != null)
                {
                    Response.Redirect("http://localhost:55374/Mostrar.aspx");
                }
                else
                {
                    String popupScript = "<script language='JavaScript'> alert('algo salio mal, no se selecciono nada de la lista'); </script>";
                    Page.RegisterStartupScript("PopupScript", popupScript);
                }

            }
            else
            {
                String popupScript = "<script language='JavaScript'> alert('no se selecciono nada de la lista'); </script>";
                Page.RegisterStartupScript("PopupScript", popupScript);
            }
        }

        protected void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox2.SelectedIndex > -1)
            {
                Reserva res = ((Administradora)Session["Administradora"]).darReserva(ListBox2.SelectedIndex);

                Session["Reserva"] = res;

                if (Session["Reserva"] != null)
                {
                    Response.Redirect("http://localhost:55374/Mostrar.aspx");
                }
                else
                {
                    String popupScript = "<script language='JavaScript'> alert('algo salio mal, no se selecciono nada de la lista'); </script>";
                    Page.RegisterStartupScript("PopupScript", popupScript);
                }

            }
            else
            {
                String popupScript = "<script language='JavaScript'> alert('no se selecciono nada de la lista'); </script>";
                Page.RegisterStartupScript("PopupScript", popupScript);
            }
        }

        //protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        //{
        //    if(CheckBox1.Checked == true)
        //    {
        //        TextBox1.Visible = true;
        //        Button1.Visible = true;
        //        RadioButtonList1.Visible = true;

        //        Session["Prestamo"] = null;
        //        Session["Reserva"] = null;
        //        TextBox1.Text = "";
        //    }
        //    else
        //    {
        //        TextBox1.Visible = false;
        //        Button1.Visible = false;
        //        RadioButtonList1.Visible = false;

        //         Session["Prestamo"] = null;
        //        Session["Reserva"] = null;
        //        TextBox1.Text = "";

        //    }

        //    //Label1.Visible = false;
            
        //}

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(TextBox1.Text);
                if(RadioButtonList1.Text == "Prestamo")
                {
                    List<Prestamo> lista = ((Administradora)Session["Administradora"]).prestamosxclientes(((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio);
                    int i = 0;
                    while (i < lista.Count && lista[i].Codigo != codigo)
                        i++;
                    Prestamo pres;
                    if (i == lista.Count)
                        pres = null;
                    else
                        pres = lista[i];
                    Session["Prestamo"] = pres;

                    if(Session["Prestamo"] != null)
                        Response.Redirect("http://localhost:55374/Mostrar.aspx");
                    else
                    {
                        Label1.Visible = true;
                         Label1.Text = "No se encontro el prestamo";
                    }
                }
                else
                {
                    if(RadioButtonList1.Text == "Reserva")
                    {
                        List<Reserva> lista2 = ((Administradora)Session["Administradora"]).Reservaxclientes(((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio);
                        int o = 0;
                        while (o < lista2.Count && lista2[o].Codigo != codigo)
                            o++;
                        Reserva res;
                        if (o == lista2.Count)
                            res = null;
                        else
                            res = lista2[o];

                        Session["Reserva"] = res;

                        if(Session["Reserva"] != null)
                              Response.Redirect("http://localhost:55374/Mostrar.aspx");
                         else
                        {
                             Label1.Visible = true;
                              Label1.Text = "No se encontro la reserva";
                         }
                    }
                    else
                    {
                        Label1.Visible = true;
                        Label1.Text = "No selecciono ninguna opcion";
                    }

                }


            }

            catch (FormatException ex)
            {
                Label1.Visible = true;
                Label1.Text = ex.Message;
               

            }
            catch (BlancoException ex)
            {
               Label1.Visible = true;
                Label1.Text = ex.Message;
            }

            catch (Exception ex)
            {
                Label1.Visible = true;
                Label1.Text = ex.Message;
            }
        }
        
        
    }
}