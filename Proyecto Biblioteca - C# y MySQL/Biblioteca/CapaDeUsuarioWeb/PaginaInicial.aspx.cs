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
    public partial class PaginaInicial : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                Administradora admin = new Administradora("Moron");

                //admin.ponerPath(@"C:\Users\Gonzalo\Documents\Cosas de la facultad\Electiva de programacion\PROYECTOS\FINAL\BibliotecaFinal2014v0.4");
                admin.cargarDatosDesdeBD();

                Session["Administradora"] = admin;
                if (CheckBoxContra.Checked == true)
                    TextBox2.TextMode = TextBoxMode.SingleLine;
                else
                    TextBox2.TextMode = TextBoxMode.Password;
                //Label1.Text = ((Administradora)Session["Administradora"]).Nombre;
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            

            try
            {
               // Label1.ForeColor = System.Drawing.Color.Red;
                int codigo = int.Parse(TextBox1.Text);

                string contraseña = TextBox2.Text;

                if(contraseña.Length == 0)
                    throw new BlancoException();

                UsuarioWeb usu = ((Administradora)Session["Administradora"]).buscarusuario(codigo);

                if (usu != null)
                {
                    if (((Administradora)Session["Administradora"]).validarUsuario(codigo, contraseña))
                    {
                        Session["Usuario"] = usu;
                        String popupScript = "<script language='JavaScript'> alert('Bienvenido + " + usu.Cliente.Nombre + "'); </script>";
                        Page.RegisterStartupScript("PopupScript", popupScript);
                        Response.Redirect("http://localhost:55374/PaginaPrincipal.aspx");
                    }
                    else
                    {
                        Label1.Text = "La contraseña es incorrecta";
                    }

                }
                else
                {
                    Label1.Text = "El usuario ingresado es incorrecto";
                }
            }
            catch (FormatException ex)
            {
                //Response.Write("ingreso letras en lugar de numero / o no ingreso nada");
                string popupScript = "<script language='JavaScript'> alert('ingreso letras en lugar de numero / o no ingreso nada'); </script>";
                Page.RegisterStartupScript("PopupScript", popupScript);
                TextBox1.Focus();

            }
            
            catch (BlancoException ex)
            {
                //Response.Write(ex.Message);
                string popupScript = "<script language='JavaScript'> alert(" + ex.Message + "); </script>";
                Page.RegisterStartupScript("PopupScript", popupScript);
            }

            catch (Exception ex)
            {
                //Response.Write(ex.Message);
                string popupScript = "<script language='JavaScript'> alert(" + ex.Message + "); </script>";
                Page.RegisterStartupScript("PopupScript", popupScript);
            }
                            
        
        }

        protected void CheckBoxContra_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxContra.Checked == true)
                TextBox2.TextMode = TextBoxMode.SingleLine;
            else
                TextBox2.TextMode = TextBoxMode.Password;
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            //visualizar verificador
            LabelDni.Visible = true;
            LabelNombre.Visible = true;
            TextBoxNombre.Visible = true;
            TextBoxDni.Visible = true;
            ButtonVerificar.Visible = true;
            ButtonCancelar.Visible = true;

            // bloquear boton y textbox
            //TextBox1.Enabled = false;
            //TextBox2.Enabled = false;
            //CheckBoxContra.Enabled = false;
            //Button2.Enabled = false;
            TextBox1.Visible = false;
            TextBox2.Visible = false;
            CheckBoxContra.Visible = false;
            Button2.Visible = false;
            LinkButton1.Visible = false;
            LabelUsuario.Visible = false;
            LabelContraseña.Visible = false;
            Label1.Visible = false;

            TextBoxNombre.Focus();

            TextBox1.Text = "";
            TextBox2.Text = "";
            
        }

        protected void ButtonCancelar_Click(object sender, EventArgs e)
        {
            //habilitar bottones y textbox
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            CheckBoxContra.Visible = true;
            Button2.Visible = true;
            LinkButton1.Visible = true;
            LabelUsuario.Visible = true;
            LabelContraseña.Visible = true;

            //desabilitar botones y textbox
            LabelDni.Visible = false;
            LabelNombre.Visible = false;
            TextBoxNombre.Visible = false;
            TextBoxDni.Visible = false;
            ButtonVerificar.Visible = false;
            ButtonCancelar.Visible = false;

            //error
            Label1.Visible = false;
            LabelErrorDni.Visible = false;
            LabelErrorUsuario.Visible = false;
            Label5.Visible = false;
            LabelExito.Visible = false;

            TextBoxNombre.Text = "";
            TextBoxDni.Text = "";

            TextBox1.Focus();
        }

        protected void ButtonVerificar_Click(object sender, EventArgs e)
        {            
            try
            {

                Label1.Visible = false;
                LabelErrorDni.Visible = false;
                LabelErrorUsuario.Visible = false;

                int dni = int.Parse(TextBoxDni.Text);
                if(dni<10000000 || dni>99999999)
                    throw new DniException();
                int usuario = int.Parse(TextBoxNombre.Text);


                Session["UsuarioAuxiliar"] = ((Administradora)Session["Administradora"]).buscarusuarioDni(dni, usuario);


                if (Session["UsuarioAuxiliar"] != null)//((Administradora)Session["Administradora"]).buscarusuario(usuario) == null)
                {
                    //habilitar botones
                    LabelExito.Visible = true;
                    Label3.Visible = true;
                    Label4.Visible = true;
                    TextBoxContraseñanueva.Focus();
                    TextBoxContraseñanueva.Visible = true;
                    TextBoxRepetirContra.Visible = true;
                    ButtonCancelar2.Visible = true;
                    ButtonModificar.Visible = true;
                    TextBoxContraseñanueva.Focus();
                    
                    //limpiar Textbox
                    TextBoxNombre.Text = "";
                    TextBoxDni.Text = "";

                    //desabilitarBotones y texxtebox
                    LabelDni.Visible = false;
                    LabelNombre.Visible = false;
                    TextBoxNombre.Visible = false;
                    TextBoxDni.Visible = false;
                    ButtonVerificar.Visible = false;
                    ButtonCancelar.Visible = false;

                    //error
                    Label1.Visible = false;
                    LabelErrorDni.Visible = false;
                    LabelErrorUsuario.Visible = false;
                    Label5.Visible = false;
                   // LabelExito.Visible = false;

                    TextBoxNombre.Text = "";
                    TextBoxDni.Text = "";
                }
                else
                {
                    LabelErrorUsuario.Visible = true;
                    LabelErrorUsuario.Text = "Datos incorrecto";
                }


            }

            catch (FormatException ex)
            {
                LabelErrorUsuario.Visible = true;
                LabelErrorUsuario.Text = ex.Message;
               

            }
            catch (DniException ex)
            {
                LabelErrorDni.Visible = true;
                LabelErrorDni.Text = "dni incorrecto, " + ex.Message;


            }
            catch (BlancoException ex)
            {
                LabelErrorUsuario.Visible = true;
                LabelErrorUsuario.Text = ex.Message;
            }

            catch (Exception ex)
            {
                LabelErrorUsuario.Visible = true;
                LabelErrorUsuario.Text = ex.Message;
            }
        }

        protected void ButtonCancelar2_Click(object sender, EventArgs e)
        {
            //habilitar bottones y textbox
            LabelDni.Visible = true;
            LabelNombre.Visible = true;
            TextBoxNombre.Visible = true;
            TextBoxDni.Visible = true;
            ButtonVerificar.Visible = true;
            ButtonCancelar.Visible = true;
            TextBoxNombre.Focus();

            //desabilitar bottones y textbox
            
            Label3.Visible = false;
            Label4.Visible = false;
            TextBoxContraseñanueva.Visible = false;
            TextBoxRepetirContra.Visible = false;
            ButtonCancelar2.Visible = false;
            ButtonModificar.Visible = false;
            

            //error
            Label1.Visible = false;
            LabelErrorDni.Visible = false;
            LabelErrorUsuario.Visible = false;
            Label5.Visible = false;
            LabelExito.Visible = false;

            TextBoxContraseñanueva.Text = "";
            TextBoxRepetirContra.Text = "";
        }

        protected void ButtonModificar_Click(object sender, EventArgs e)
        {
           

             try
            {

                  Label1.Visible = false;
                  LabelErrorDni.Visible = false;
                  LabelErrorUsuario.Visible = false;
                  Label5.Visible = false;
                  LabelExito.Visible = false;
                 string contraseña = TextBoxContraseñanueva.Text;
                 string nuevacontra = TextBoxRepetirContra.Text;
                 if (contraseña.Length == 0 || nuevacontra.Length == 0)
                     throw new BlancoException();

                 if (contraseña == nuevacontra)
                 {

                     if (Session["UsuarioAuxiliar"] != null)
                     {
                         if (((Administradora)Session["Administradora"]).modificarcontraseña(((UsuarioWeb)Session["UsuarioAuxiliar"]).Cliente.CodigoSocio, contraseña))
                         {

                             //desabilitarBotones y texxtebox
                             LabelExito.Visible = false;
                             Label3.Visible = false;
                             Label4.Visible = false;
                             TextBoxContraseñanueva.Visible = false;
                             TextBoxRepetirContra.Visible = false;
                             ButtonCancelar2.Visible = false;
                             ButtonModificar.Visible = false;

                             LabelDni.Visible = false;
                             LabelNombre.Visible = false;
                             TextBoxNombre.Visible = false;
                             TextBoxDni.Visible = false;
                             ButtonVerificar.Visible = false;
                             ButtonCancelar.Visible = false;



                             //habilitar bottones y textbox
                             TextBox1.Visible = true;
                             TextBox2.Visible = true;
                             CheckBoxContra.Visible = true;
                             Button2.Visible = true;
                             LinkButton1.Visible = true;
                             LabelUsuario.Visible = true;
                             LabelContraseña.Visible = true;

                             //error
                             Label1.Visible = true;
                             Label1.Text = "Contraseña cambiada con exito";
                             //Label1.ForeColor = System.Drawing.Color.Green;
                             LabelErrorDni.Visible = false;
                             LabelErrorUsuario.Visible = false;
                             Label5.Visible = false;
                             LabelExito.Visible = false;

                             TextBoxContraseñanueva.Text = "";
                             TextBoxRepetirContra.Text = "";
                         }
                     }
                     else
                     {
                         Label5.Visible = true;
                         Label5.Text = "algo salio mal, vuelva a intentarlo mas tarde";
                     }
                 }
                 else
                 {
                     Label5.Visible = true;
                     Label5.Text = "Las contraseñas no coinciden";
                 }

            }

            catch (FormatException ex)
            {
                Label5.Visible = true;
                Label5.Text = ex.Message;
               

            }
            
            catch (BlancoException ex)
            {
                Label5.Visible = true;
                Label5.Text = ex.Message;
            }

            catch (Exception ex)
            {
                Label5.Visible = true;
                Label5.Text = ex.Message;
            }
        }

        
    }
}