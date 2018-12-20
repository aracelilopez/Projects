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
    public partial class ListadoCliente : Form
    {
        public ListadoCliente(List<Cliente> clientes)
        {

            InitializeComponent();

            listBoxListado.DataSource = null;
            listBoxListado.DataSource = clientes;
            listBoxListado.ClearSelected();

        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            Cliente cli = (Cliente)listBoxListado.SelectedItem;

            if (cli != null)
            {
                MostrarCliente mostrar = new MostrarCliente(cli);
                mostrar.ShowDialog();
                this.Close();
            }
            else
                MessageBox.Show("No se ha encontrado a ningún cliente");
        }
    }
}
