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
using CapaDeNegocio;

namespace CapaUsuario
{
    public partial class AgregarLibro : Form
    {
        Libro lib;
        public AgregarLibro()
        {
            InitializeComponent();
        }

        public Libro darlibro()
        {
            return lib;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            lib = null;
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
             try
            {
                int isbn = int.Parse(textBoxIsbn.Text);
                int ejemplar = int.Parse(textBoxEjemplar.Text);
                string titulo = textBoxTitulo.Text;

                if (titulo.Length == 0)
                    throw new BlancoException();

                string autor = textBoxAutor.Text;
                if (autor.Length == 0)
                    throw new BlancoException();

                string editorial = textBoxEditorial.Text;
                if (editorial.Length == 0)
                    throw new BlancoException();

                 string genero = comboBox1.Text;

                 if (genero.Length == 0)
                     throw new BlancoException();
                string estado = "Disponible";

                lib = new Libro(isbn, ejemplar, titulo, autor, editorial, genero, estado);

                this.Close();

            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingreso letras en lugar de numero / o no ingreso nada");
                textBoxIsbn.Focus();

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
