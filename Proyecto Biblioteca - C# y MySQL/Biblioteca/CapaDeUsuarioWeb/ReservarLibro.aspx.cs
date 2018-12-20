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
    public partial class ReservarLibro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ListBox1.DataSource = ((Administradora)Session["Administradora"]).Listalibros;
                ListBox1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                Label1.Visible = false;
                if (RadioButtonList1.Text == "Por Isbn")
                {
                    int codigo = int.Parse(TextBox1.Text);
                    ListBox1.DataSource = ((Administradora)Session["Administradora"]).FiltroIsbn(codigo);
                    ListBox1.DataBind();
                }
                else
                {
                    string variable = TextBox1.Text;
                    if (variable.Length == 0)
                        throw new BlancoException();
                    if (RadioButtonList1.Text == "Por Editorial")
                    {
                        ListBox1.DataSource = ((Administradora)Session["Administradora"]).Filtroeditorial(variable);
                        ListBox1.DataBind();
                    }
                    else
                    {
                        if (RadioButtonList1.Text == "Por Genero")
                        {
                            ListBox1.DataSource = ((Administradora)Session["Administradora"]).Filtrogenero(variable);
                            ListBox1.DataBind();
                        }
                        else
                        {
                            if (RadioButtonList1.Text == "Por Autor")
                            {
                                ListBox1.DataSource = ((Administradora)Session["Administradora"]).Filtroautor(variable);
                                ListBox1.DataBind();
                            }
                            else
                            {
                                Label1.Visible = true;
                                Label1.Text = "no selecciono ningun filtro";
                            }
                        }
                    }
                }
                    
                


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
            //finally---> no me lo toma(revisar)
            //restableser datos
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/PaginaPrincipal.aspx");
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(ListBox1.SelectedIndex > -1)
            {
                Libro lib = ((Administradora)Session["Administradora"]).darLibro(ListBox1.SelectedIndex);

                if(lib != null)
                {
                    
                   
                }
            }
        }
    }
}