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
    public partial class ListadoPrestamo : Form
    {
        Administradora copiaadmin;
        //List<Cliente> clientes;
        public ListadoPrestamo(Administradora admin)
        {
            InitializeComponent();
            copiaadmin = admin;
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = admin.Listaprestamos;
            listBoxListado.ClearSelected();

            panel1.Enabled = false;
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSeleccionar_Click(object sender, EventArgs e)
        {
            if(radioButtonNo.Checked)
            {
                panel1.Enabled = false;
            }
            else
            {
                if(radioButtonSi.Checked)
                {
                    panel1.Enabled = true;
                }
            }
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = copiaadmin.Listaprestamos;
            listBoxListado.ClearSelected();
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                int codigo = int.Parse(textBox1.Text);
               
                List<Prestamo> pres = copiaadmin.prestamosxclientes(codigo);

                if (pres.Count != 0)
                {
                    MessageBox.Show("Fué encontrado");
                    listBoxListado.DataSource = null;
                    listBoxListado.DataSource = pres;
                    listBoxListado.ClearSelected();
                }
                else
                {
                    MessageBox.Show("No fué encontrado");
                    listBoxListado.DataSource = null;
                    listBoxListado.DataSource = copiaadmin.Listaprestamos;
                    listBoxListado.ClearSelected();
                }
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

        public Administradora daradmin()
        {
            return copiaadmin;
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            Prestamo pres = (Prestamo)listBoxListado.SelectedItem;
            if (pres != null)
            {
                MostrarPrestamo mostrar = new MostrarPrestamo(pres);
                mostrar.ShowDialog();
            }
            else
                MessageBox.Show("No se ha seleccionado nada");
        }

    }
}
