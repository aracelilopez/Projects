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
    public partial class DevolucionPrestamo : Form
    {
        int codigosocio;
        int isbn;
        int ejemplar;
        public DevolucionPrestamo()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            codigosocio = 0;
            isbn = 0;
            ejemplar = 0;
            this.Close();
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            try
            {
                codigosocio = int.Parse(textBoxCodigoSocio.Text);
                isbn = int.Parse(textBoxCodigoIsbn.Text);
                ejemplar = int.Parse(textBoxEjemplar.Text);
               
                this.Close();

            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingreso letras en lugar de numero / o no ingreso nada");
                textBoxCodigoSocio.Focus();

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

        public int devolverCodigo()
        {
            return codigosocio;
        }
        public int devolveIsbn()
        {
            return isbn;
        }
        public int devolverEjemplar()
        {
            return ejemplar;
        }

        
        
    }
}
