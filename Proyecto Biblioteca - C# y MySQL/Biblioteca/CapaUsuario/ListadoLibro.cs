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
    public partial class ListadoLibro : Form
    {
        List<Libro> libros;
        Administradora admincopia;

        public ListadoLibro(Administradora admin)
        {
            InitializeComponent();
            libros = admin.Listalibros;
            admincopia = admin;
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = libros;
            listBoxListado.ClearSelected();
        }

        public Administradora daradmin()
        {
            return admincopia;
        }

        private void buttonVer_Click(object sender, EventArgs e)
        {
            Libro lib = (Libro)listBoxListado.SelectedItem;

            if (lib == null)
                MessageBox.Show("No ha seleccionada nada antes");
            else
            {
                MostrarLibro mostrar = new MostrarLibro(lib);
                mostrar.ShowDialog();

            }
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = libros;
            listBoxListado.ClearSelected();
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = libros;
            listBoxListado.ClearSelected();
        }

        private void ButtonSeleccionar_Click(object sender, EventArgs e)
        {
            if(radioButtonSi.Checked == true)
            {
                panel1.Enabled = true;
            }
            else
            {
                if (radioButtonNO.Checked == true)
                    panel1.Enabled = false;

            }
            listBoxListado.DataSource = null;
            listBoxListado.DataSource = libros;
            listBoxListado.ClearSelected();

        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(radioIsbn.Checked == true)
                {
                    int codigo = int.Parse(textBoxFiltro.Text);
                    List<Libro> aux = admincopia.FiltroIsbn(codigo);
                    listBoxListado.DataSource = null;
                    listBoxListado.DataSource = aux;
                    listBoxListado.ClearSelected();
                    MessageBox.Show("Filtrado exitoso");
                }
                else
                {
                    if (radioButtonGenero.Checked == true)
                    {
                        string variable = textBoxFiltro.Text;
                        if (variable.Length == 0)
                            throw new BlancoException();
                        List<Libro> aux = admincopia.Filtrogenero(variable);
                        listBoxListado.DataSource = null;
                        listBoxListado.DataSource = aux;
                        listBoxListado.ClearSelected();
                        MessageBox.Show("Filtrado exitoso");
                    }
                    else
                    {
                        if (radioButtonEditorial.Checked == true)
                        {
                            string variable = textBoxFiltro.Text;
                            if (variable.Length == 0)
                                throw new BlancoException();
                            List<Libro> aux = admincopia.Filtroeditorial(variable);
                            listBoxListado.DataSource = null;
                            listBoxListado.DataSource = aux;
                            listBoxListado.ClearSelected();
                            MessageBox.Show("Filtrado exitoso");
                        }
                        else
                        {
                            if (radioButtonAutor.Checked == true)
                            {
                                string variable = textBoxFiltro.Text;
                                if (variable.Length == 0)
                                    throw new BlancoException();
                                List<Libro> aux = admincopia.Filtroautor(variable);
                                listBoxListado.DataSource = null;
                                listBoxListado.DataSource = aux;
                                listBoxListado.ClearSelected();
                                MessageBox.Show("Filtrado exitoso");
                            }
                            else
                            {
                                MessageBox.Show("No se encontro");
                                listBoxListado.DataSource = null;
                                listBoxListado.DataSource = libros;
                                listBoxListado.ClearSelected();
                                
                            }
                        }
                    }
                }
                
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Ingresó letras en lugar de número / o no ingresó nada");
                

            }
            catch (DniException ex)
            {
                MessageBox.Show(ex.Message);
                


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
