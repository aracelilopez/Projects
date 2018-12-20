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
    public partial class EliminarLibroEjemplar : Form
    {
        int isbn;
        int ejemplar;

        public EliminarLibroEjemplar()
        {
            InitializeComponent();
        }
        

        public bool esta()
        {
            return isbn != 0 && ejemplar != 0;
        }

        public int darisbn()
        {
            return isbn;
        }

        public int darejemplar()
        {
            return ejemplar;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            isbn = 0;
            ejemplar = 0;
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            
            try
            {
               isbn = int.Parse(textBox1.Text);
                ejemplar = int.Parse(textBox2.Text);
                
                this.Close();

            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingresó letras en lugar de número / o no ingresó nada");
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



    }
}
