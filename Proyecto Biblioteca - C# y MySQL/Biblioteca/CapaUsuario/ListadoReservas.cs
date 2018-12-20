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
using excepciones;

namespace CapaUsuario
{
    public partial class ListadoReservas : Form
    {
        Administradora copiaadmin;
        public ListadoReservas(Administradora admin)
        {
            InitializeComponent();

            copiaadmin = admin;
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = admin.Listareservas;
            listBoxListado.ClearSelected();

            panel1.Enabled = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            Reserva res = (Reserva)listBoxListado.SelectedItem;
            if (res != null)
            {
                MostrarReserva mostrar = new MostrarReserva(res);
                mostrar.ShowDialog();
            }
            else
                MessageBox.Show("No se a seleccionado nada");
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if (radioButtonNo.Checked)
            {
                panel1.Enabled = false;
            }
            else
            {
                if (radioButtonSi.Checked)
                {
                    panel1.Enabled = true;
                }
            }
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = copiaadmin.Listareservas;
            listBoxListado.ClearSelected();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(textBox1.Text);

                List<Reserva> res = copiaadmin.Reservaxclientes(codigo);

                if (res.Count != 0)
                {
                    MessageBox.Show("Fue encontrado");
                    listBoxListado.DataSource = null;
                    listBoxListado.DataSource = res;
                    listBoxListado.ClearSelected();
                }
                else
                {
                    MessageBox.Show("No fue encontrado");
                    listBoxListado.DataSource = null;
                    listBoxListado.DataSource = copiaadmin.Listareservas;
                    listBoxListado.ClearSelected();
                }
            }


            catch (FormatException ex)
            {
                MessageBox.Show("Ingreso letras en lugar de numero / o no ingreso nada");
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

        public Administradora daradmin()
        {
            return copiaadmin;
        }

        
      
    }
}
