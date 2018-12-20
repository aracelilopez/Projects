using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDeNegocio;
using excepciones;

namespace CapaUsuario
{
    public partial class AgregarCliente : Form
    {
        Cliente cli;
        //UsuarioWeb usu;
        

        public AgregarCliente()
        {
            InitializeComponent();
        }

        public AgregarCliente(int codigo)
        {
            InitializeComponent();
            textBoxCodigo.Text = codigo.ToString();
        }

        public Cliente darcliente()
        {
            return cli;
        }

        //public UsuarioWeb darUsuario()
        //{
        //    return usu;
        //}

        private void CANCELAR_Click(object sender, EventArgs e)
        {
            cli = null;
            //usu = null;
            this.Close();
        }

        private void ACEPTAR_Click(object sender, EventArgs e)
        {
            try
            {
                int cod = int.Parse(textBoxCodigo.Text);
                int dni = int.Parse(textBoxDni.Text);
                string nombre = textBoxNombre.Text;
                if (nombre.Length == 0)
                    throw new BlancoException();
                string apellido = textBoxApellido.Text;
                if (apellido.Length == 0)
                    throw new BlancoException();
                string Localidad = textBoxLocalidad.Text;
                if (Localidad.Length == 0)
                    throw new BlancoException();
                
                bool EspecialComun = true;

                if (radioButtonEspecial.Checked)
                {
                    EspecialComun = true;
                }
                else
                {
                    if (radioButtonComun.Checked)
                    {
                        EspecialComun = false;
                    }
                    else
                        throw new Exception("No a realizado seleccion");
                }

                if (EspecialComun)
                    cli = new ClienteEspecial(cod,dni,nombre,apellido,Localidad);
                else
                    cli = new ClienteComun(cod,dni,nombre,apellido,Localidad);

                //usu = new UsuarioWeb(cli);
                
                
             
                this.Close();

            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingreso letras en lugar de numero / o no ingreso nada");
                textBoxCodigo.Focus();

            }
            catch (DniException ex)
            {
                MessageBox.Show(ex.Message);
                label6.BackColor = Color.Red; 
                textBoxDni.Focus();


            }
            catch (BlancoException ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally---> no me lo toma(revisar)
        }

        
    }
}
