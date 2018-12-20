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
    public partial class MostrarCliente : Form
    {
        public MostrarCliente(Cliente cli)
        {
            InitializeComponent();
            textBoxCodigo.Text = cli.CodigoSocio.ToString();
            textBoxDni.Text = cli.Dni.ToString();
            textBoxNombre.Text = cli.Nombre.ToString();
            textBoxApellido.Text = cli.Apellido.ToString();
            textBoxLocalidad.Text = cli.Localidad.ToString();

            if (cli.dardiasXretirar() == 3)
                radioButtonComun.Select();
            else
                radioButtonEspecial.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
