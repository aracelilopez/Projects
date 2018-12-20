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
    public partial class BuscarPrestamoReserva : Form
    {
        int codigo = 0;
        public BuscarPrestamoReserva()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            codigo = 0;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                codigo = int.Parse(textBox1.Text);

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
            //finally---> no me lo toma(revisar)
        }

        public int darcodigo()
        {
            return codigo;
        }


    }
}
