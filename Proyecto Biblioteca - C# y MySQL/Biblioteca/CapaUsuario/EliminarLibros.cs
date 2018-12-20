using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using excepciones;

namespace CapaUsuario
{
    public partial class EliminarLibros : Form
    {
        int isbn;

        public EliminarLibros()
        {
            InitializeComponent();
        }
        public bool esta()
        {
            return isbn != 0;
        }

        public int darisbn()
        {
            return isbn;
        }

        

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            isbn = 0;
           
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                isbn = int.Parse(textBox1.Text);
               

                this.Close();

            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingreso letras en lugar de numero / o no ingreso nada");
                textBox1.Focus();

            }

            catch (BlancoException ex)
            {
                MessageBox.Show(ex.Message);

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }


        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            isbn = 0;
            this.Close();
        }
    }
}
