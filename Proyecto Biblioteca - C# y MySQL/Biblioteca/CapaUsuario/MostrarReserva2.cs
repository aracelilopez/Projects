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
    public partial class MostrarReserva2 : Form
    {
        bool estado = false;
        public MostrarReserva2(Reserva rese)
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

        public MostrarReserva2(Reserva rese, DateTime fecha)
        {
            InitializeComponent();
            textBoxCodigo.Text = rese.Cliente.CodigoSocio.ToString();
            textBoxNombre.Text = rese.Cliente.Nombre;
            textBoxApellido.Text = rese.Cliente.Apellido;
            textBoxIsbn.Text = rese.Libro.Isbn.ToString();
            textBoxEjemplar.Text = rese.Libro.Ejemplar.ToString();
            textBoxTitulo.Text = rese.Libro.Titulo;
            textBoxFechaDisponibilidad.Text = fecha.ToString();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            estado = true;
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            estado = false;
            this.Close();
        }

        public bool darEstado()
        {
            return estado;
        }
    }
}
