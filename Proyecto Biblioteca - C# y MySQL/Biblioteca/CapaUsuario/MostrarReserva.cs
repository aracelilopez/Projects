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
    public partial class MostrarReserva : Form
    {
        
        public MostrarReserva(Reserva rese)
        {
            InitializeComponent();

            textBoxCodigo.Text = rese.Cliente.CodigoSocio.ToString();
            textBoxNombre.Text = rese.Cliente.Nombre;
            textBoxApellido.Text = rese.Cliente.Apellido;
            textBoxIsbn.Text = rese.Libro.Isbn.ToString();
            textBoxEjemplar.Text = rese.Libro.Ejemplar.ToString();
            textBoxTitulo.Text = rese.Libro.Titulo;
            textBoxFechaDisponibilidad.Text = rese.FechaDisponibilidad.ToString();
            
        }

        private void buttonCancelr_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
