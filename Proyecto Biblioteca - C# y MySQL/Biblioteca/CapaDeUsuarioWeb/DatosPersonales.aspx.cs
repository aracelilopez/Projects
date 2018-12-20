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
    public partial class DatosPersonales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                if (((UsuarioWeb)Session["Usuario"]) != null)
                {
                    TextBoxCodigoUsuario.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio.ToString();
                    TextBoxDni.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Dni.ToString();
                    TextBoxNombre.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Nombre;
                    TextBoxApellido.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Apellido;
                    TextBoxLocalidad.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Localidad;
                }
            }
        }

        protected void ButtonVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://localhost:55374/PaginaPrincipal.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //habilitar textbox y botones
            Labelmod1.Enabled = true;
            Labelmod1.Visible = true;
            Labelmod2.Enabled = true;
            Labelmod2.Visible = true;
            Labelmod3.Enabled = true;
            Labelmod3.Visible = true;

            TextBoxContraseña.Enabled = true;
            TextBoxContraseña.Visible = true;
            TextBoxNuevaContraseña.Visible = true;
            TextBoxNuevaContraseña.Enabled = true;
            TextBoxRepetirContra.Visible = true;
            TextBoxRepetirContra.Enabled = true;

            ButtonModifContra.Visible = true;
            ButtonModifContra.Enabled = true;

            ButtonCancelar.Visible = true;
            ButtonCancelar.Enabled = true;

            //mensajes de error
            Label2.Visible = false;
            Label3.Visible = false;
            LabelContradistinta.Visible = false;
            LabelContraseñaEquivocada.Visible = false;
            LabelDniError.Visible = false;
            
            //desabilitar textbox y botones y checkbox
            TextBoxDni.Enabled = false;
            TextBoxNombre.Enabled = false;
            TextBoxApellido.Enabled = false;
            TextBoxLocalidad.Enabled = false;
            ButtonModificar.Enabled = false;
            CheckBox1.Enabled = false;
            
            Label3.ForeColor = System.Drawing.Color.Red;
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            //desabilitar botones y textbox
            Labelmod1.Enabled = false;
            Labelmod1.Visible = false;
            Labelmod2.Enabled = false;
            Labelmod2.Visible = false;
            Labelmod3.Enabled = false;
            Labelmod3.Visible = false;

            TextBoxContraseña.Enabled = false;
            TextBoxContraseña.Visible = false;
            TextBoxNuevaContraseña.Visible = false;
            TextBoxNuevaContraseña.Enabled = false;
            TextBoxNuevaContraseña.Enabled = false;
            TextBoxRepetirContra.Visible = false;
            TextBoxRepetirContra.Enabled = false;

            ButtonModifContra.Visible = false;
            ButtonModifContra.Enabled = false;

            ButtonCancelar.Visible = false;
            ButtonCancelar.Enabled = false;
            
            //label de error
            Label2.Visible = false;
            Label3.Visible = false;
            LabelContradistinta.Visible = false;
            LabelContraseñaEquivocada.Visible = false;
            LabelDniError.Visible = false;
            
            //habilitar denuevo los textbox botones y checkbox
            TextBoxDni.Enabled = true;
            TextBoxNombre.Enabled = true;
            TextBoxApellido.Enabled = true;
            TextBoxLocalidad.Enabled = true;
            ButtonModificar.Enabled = true;
            CheckBox1.Enabled = true;

            //restableser datos
            TextBoxCodigoUsuario.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio.ToString();
            TextBoxDni.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Dni.ToString();
            TextBoxNombre.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Nombre;
            TextBoxApellido.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Apellido;
            TextBoxLocalidad.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Localidad;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox1.Checked == true)
            {
                TextBoxDni.Enabled = true;
                TextBoxNombre.Enabled = true;
                TextBoxApellido.Enabled = true;
                TextBoxLocalidad.Enabled = true;
                ButtonModificar.Enabled = true;
            }
            else
            {
                if (CheckBox1.Checked == false)
                {
                    TextBoxDni.Enabled = false;
                    TextBoxNombre.Enabled = false;
                    TextBoxApellido.Enabled = false;
                    TextBoxLocalidad.Enabled = false;
                    ButtonModificar.Enabled = false;
                }
            }
            Label2.Visible = false;
            Label3.Visible = false;
            LabelContradistinta.Visible = false;
            LabelContraseñaEquivocada.Visible = false;
            LabelDniError.Visible = false;
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Label2.Visible = true;
                Label2.Text = " ";
                int dni = int.Parse(TextBoxDni.Text);
               if(dni <= 10000000 || dni>99999999)
                  throw new DniException();
                string nombre = TextBoxNombre.Text;
                string apellido = TextBoxApellido.Text ;
                string localidad = TextBoxLocalidad.Text;
                int codigo = ((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio;


                if (((Administradora)Session["Administradora"]).modificarusuarioWeb(codigo, dni, nombre, apellido, localidad))
                {
                    string popupScript = "<script language='JavaScript'> alert('SE A MODIFICADO CON EXITO AL USUARIO/CLIENTE'); </script>";
                    Page.RegisterStartupScript("PopupScript", popupScript);
                    Label2.Visible = false;
                    Label3.Visible = false;
                    LabelContradistinta.Visible = false;
                    LabelContraseñaEquivocada.Visible = false;
                    LabelDniError.Visible = false;

                    Response.Redirect("http://localhost:55374/PaginaPrincipal.aspx");
                }
                else
                {
                    Label2.Text = " hubo un problema y no se a podido modificar ";
                    Label2.Visible = true;
                }


            }

            catch (FormatException ex)
            {
                LabelDniError.Text = "Ingreso letras en lugar de numero / o no ingreso nada";
                LabelDniError.Visible = true;
                Label2.Text = " hubo un problema y no se a podido modificar ";
                TextBoxDni.Focus();

            }
            catch (DniException ex)
            {
                LabelDniError.Text = "Ingreso un dni incorrecto, " + ex.Message;
                LabelDniError.Visible = true;
                Label2.Text = " hubo un problema y no se a podido modificar ";
                TextBoxDni.Focus();


            }
            catch (BlancoException ex)
            {
                Label2.Text = ex.Message;
                Label2.Visible = true;
                TextBoxDni.Focus();
                
            }

            catch (Exception ex)
            {
                Label2.Text = ex.Message;
                Label2.Visible = true;
                TextBoxDni.Focus();
            }
            //finally---> no me lo toma(revisar)
            LabelContradistinta.Visible = false;
            LabelContraseñaEquivocada.Visible = false;
            Label3.Visible = false;
        }

        protected void ButtonModifContra_Click(object sender, EventArgs e)
        {
            try
            {
                Label3.Visible = true;
                Label3.Text = " ";
                string contraseña = TextBoxContraseña.Text;
                string contraseñanueva = TextBoxNuevaContraseña.Text;
                string contraseñarepetida = TextBoxRepetirContra.Text;
                int codigo = ((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio;

                Label3.Text = "algo salio mal";
                if(((Administradora)Session["Administradora"]).validarUsuario(codigo,contraseña))
                {
                    if(contraseñanueva == contraseñarepetida)
                    {
                        if(((Administradora)Session["Administradora"]).modificarcontraseña(codigo, contraseña))
                        {
                            Label3.Text = "Se a cambiado con exito la contraseña";
                            Label3.Enabled = true;
                            Label3.ForeColor = System.Drawing.Color.Green;
                        }
                        else
                            Label3.Text = "algo salio mal y no se pudo modificar";
                            Label3.Enabled = true;
                    }
                    else
                        LabelContradistinta.Enabled = true;
                }
                else
                    LabelContraseñaEquivocada.Enabled = true;


            }

            
            
            catch (BlancoException ex)
            {
                Label3.Text = ex.Message;
                Label3.Text = "algo salio mal y no se pudo modificar";
                Label3.Visible = true;
                TextBoxDni.Focus();
                
            }

            catch (Exception ex)
            {
                Label2.Text = ex.Message;
                Label3.Text = "algo salio mal y no se pudo modificar";
                Label2.Visible = true;
                TextBoxDni.Focus();
            }
            //finally---> no me lo toma(revisar)
            //restableser datos
            TextBoxCodigoUsuario.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.CodigoSocio.ToString();
            TextBoxDni.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Dni.ToString();
            TextBoxNombre.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Nombre;
            TextBoxApellido.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Apellido;
            TextBoxLocalidad.Text = ((UsuarioWeb)Session["Usuario"]).Cliente.Localidad;
        }
            
                
    }
}