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
    public partial class EliminarCliente2 : Form
    {


        Cliente cli;
        Administradora admincopia;
        public EliminarCliente2(Administradora admin)
        {
            InitializeComponent();
            listBox1.DataSource = null;
            listBox1.DataSource = admin.Listaclientes;
            listBox1.ClearSelected();
            admincopia = admin;
        }

        //public Cliente darCliente()
        //{
        //    return Cli;
        //}

        private void EliminarCliente2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            button2.Visible = false;
            radioButtonTextbox.Enabled = true;
            radioButtonLista.Enabled = true;
            button6.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
           // cli = null;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButtonLista.Checked == true)
            {
                panel1.Visible = true;
                button2.Visible = true;
                button6.Visible = true;
                radioButtonLista.Enabled = false;
                radioButtonTextbox.Enabled = false;
            }
            else
            {
                if (radioButtonTextbox.Checked == true)
                {
                    panel2.Visible = true;
                    button2.Visible = true;
                    button6.Visible = true;
                    radioButtonTextbox.Enabled = false;
                    radioButtonLista.Enabled = false;
                }
                else
                    MessageBox.Show("No seleccionó nada");
            }
            cli = null;

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            button2.Visible = false;
            radioButtonTextbox.Enabled = true;
            radioButtonLista.Enabled = true;
            button6.Visible = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int contador = 0;
            if (radioButtonLista.Checked == true)
            {
                cli =(Cliente)listBox1.SelectedItem;
                if(cli==null)
                    MessageBox.Show("No se pudo seleccionar nada de la lista");
                else
                {
                    contador++;
                }
            }
            else
            {
                if (radioButtonTextbox.Checked == true)
                {
                    int codigo = int.Parse(textBox1.Text);
                    cli = admincopia.buscarCliente(codigo);
                    if(cli == null)
                        MessageBox.Show("No se encontró al cliente");
                    else
                    {
                        contador++;
                    }
                }
                else
                    MessageBox.Show("No seleccionó nada");
            }
            if(contador > 0)
            {
                panel3.Visible = true;
                List<Prestamo> aux = admincopia.prestamosxclientes(cli.CodigoSocio);
                listBox2.DataSource = null;
                listBox2.DataSource = aux;
                listBox2.ClearSelected();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if(cli != null)
                {
                    if (admincopia.eliminarCliente(cli.CodigoSocio))
                    {
                        //if (admincopia.eliminarUsuarioWeb(cli.CodigoSocio))
                        //{
                        //    admincopia.limpiarPrestamoxCliente(cli.CodigoSocio);
                        //    admincopia.limpiarReservaxCliente(cli.CodigoSocio);
                        //    MessageBox.Show("Se ha eliminado con exito de la base de datos");
                        //}
                        //else
                        //    MessageBox.Show("No se ha podido eliminar de la BD");
                    }
                    else
                        MessageBox.Show("No se ha podido eliminar de la BD");
                }
                MessageBox.Show("Vuelva a intentarlo más tarde");

            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingresó letras en lugar de número / o no ingresó nada");
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //finally---> no me lo toma(revisar)
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        public Administradora daradmin()
        {
            return admincopia;
        }
    }
}
