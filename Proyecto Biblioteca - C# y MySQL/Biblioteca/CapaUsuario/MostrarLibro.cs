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

namespace CapaUsuario
{
    public partial class MostrarLibro : Form
    {
        public MostrarLibro(Libro lib)
        {
            InitializeComponent();
            textBoxIsbn.Text = lib.Isbn.ToString();
            textBoxEjemplar.Text = lib.Ejemplar.ToString();
            textBoxAutor.Text = lib.Autor.ToString();
            textBoxTitulo.Text = lib.Titulo.ToString();
            textBoxEditorial.Text = lib.Editorial.ToString();
            textBoxGenero.Text = lib.Genero.ToString();
            textBoxEstado.Text = lib.Estado.ToString();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
