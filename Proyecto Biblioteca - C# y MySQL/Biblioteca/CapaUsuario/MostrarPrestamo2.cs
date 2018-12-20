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
    public partial class MostrarPrestamo2 : Form
    {
        public MostrarPrestamo2(Prestamo presta)
        {
            InitializeComponent();

            textBoxCodigo.Text = presta.Cliente.CodigoSocio.ToString();
            textBoxNombre.Text = presta.Cliente.Nombre;
            textBoxApellido.Text = presta.Cliente.Apellido;
            textBoxIsbn.Text = presta.Libro.Isbn.ToString();
            textBoxEjemplar.Text = presta.Libro.Ejemplar.ToString();
            textBoxTitulo.Text = presta.Libro.Titulo;
            textBoxFechaPrestamo.Text = presta.FechaReserva.ToString();
            textBoxFechaDevolucion.Text = presta.Fechadevolucion.ToString();
        }

        private void buttonCancelr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
