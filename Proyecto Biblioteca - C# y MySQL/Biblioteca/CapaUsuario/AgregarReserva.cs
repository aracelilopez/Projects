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
    public partial class AgregarReserva : Form
    {
        Administradora adminCopia;
        List<Cliente> listaclientes;
        List<Libro> listalibros;
        Cliente cli;
        Libro lib;

        public AgregarReserva(Administradora admin)
        {
            InitializeComponent();
            adminCopia = admin;
            listaclientes = adminCopia.Listaclientes;
            listalibros = adminCopia.Listalibros;

            listBox1.DataSource = null;
            listBox1.DataSource = listaclientes;
            listBox1.ClearSelected();

            listBox2.DataSource = null;
            listBox2.DataSource = listalibros;
            listBox2.ClearSelected();

            panel1.Enabled = false;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSeleccionar_Click(object sender, EventArgs e)
        {
            if (radioButtonSi.Checked)
            {
                panel1.Enabled = true;
            }
            else
            {
                if (radioButtonNO.Checked)
                    panel1.Enabled = false;
            }
            listBox2.DataSource = null;
            listBox2.DataSource = listalibros;
            listBox2.ClearSelected();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarPrestamoReserva buscar = new BuscarPrestamoReserva();
            buscar.ShowDialog();
            int codigo = buscar.darcodigo();

            if (codigo != 0)
            {
                cli = adminCopia.buscarCliente(codigo);

                if (cli == null)
                {
                    DialogResult boton = MessageBox.Show("El Cliente no se encuentra,¿ desea agregarlo ? ", "ALERTA", MessageBoxButtons.YesNo);

                    if (boton == DialogResult.Yes)
                    {
                        AgregarCliente agregar = new AgregarCliente(codigo);
                        agregar.ShowDialog();
                        Cliente clien = agregar.darcliente();

                        if (clien != null)
                        {
                            if (adminCopia.agregarCliente(clien))
                            {
                                cli = clien;
                                MessageBox.Show("Se ha guardado el cliente en la BD con éxito");
                            }
                            else
                                MessageBox.Show("No se ha podido guardar");
                        }
                    }

                    listBox1.DataSource = null;
                    listBox1.DataSource = listaclientes;
                    listBox1.ClearSelected();
                }
                else
                {
                    MessageBox.Show("Se ha seleccionado el cliente");
                }

            }
        }

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            Cliente cli2 = (Cliente)listBox1.SelectedItem;
            lib = (Libro)listBox2.SelectedItem;
            Cliente cli3;

            if (cli2 == null)
            {
                if (cli == null)
                    cli3 = null;
                else
                    cli3 = cli;
            }
            else
                cli3 = cli2;

            if (cli3 == null)
                MessageBox.Show("No ha seleccionado ningún cliente");
            else
            {
                if (adminCopia.estadodecliente(cli3.CodigoSocio))
                {
                    if (lib == null)
                        MessageBox.Show("No se ha seleccionado ningún libro");
                    else
                    {
                        try
                            {
                                    int codigo = int.Parse(textBoxCodigo.Text);
                                    
                                    if (adminCopia.ahireserva(codigo))
                                        MessageBox.Show("Ya existía una reserva con este código");
                                    else
                                    {
                                        
                                            Reserva reserva = adminCopia.buscarReservaEspecifica(cli3.CodigoSocio, lib.Isbn, lib.Ejemplar);

                                            DateTime fecha = adminCopia.fechaDeReserva(cli3, lib);
                                            bool estado;

                                            if (reserva == null)
                                            {
                                                reserva = new Reserva(codigo, cli3, lib, fecha);

                                                MostrarReserva2 mostrar = new MostrarReserva2(reserva);
                                                mostrar.ShowDialog();

                                                estado = mostrar.darEstado();

                                                if (estado)
                                                {
                                                    if (adminCopia.reservarlibro(lib))
                                                    {
                                                        MessageBox.Show("Fué aceptado");
                                                        if (adminCopia.agregarReservas(reserva))
                                                            MessageBox.Show("Se ha agregado con éxito a la base de datos");
                                                        else
                                                            MessageBox.Show("No se ha agregado");
                                                    }
                                                    else
                                                        MessageBox.Show("No se a podido cambiar el estado del libro");
                                                }
                                                else
                                                    MessageBox.Show("Fué cancelado");
                                            }
                                            else
                                            {
                                                DateTime fechaactual = reserva.FechaDisponibilidad;
                                                if (fechaactual >= DateTime.Now)
                                                    MessageBox.Show("Ya existe una reserva disponible con estos datos ");
                                                else
                                                {

                                                    MostrarReserva2 mostrar = new MostrarReserva2(reserva, fecha);
                                                    mostrar.ShowDialog();

                                                    estado = mostrar.darEstado();

                                                    if (estado)
                                                    {
                                                        if (adminCopia.reservarlibro(lib))
                                                        {
                                                            
                                                            if (adminCopia.modificarReserva(reserva, fecha))
                                                                MessageBox.Show("Se ha modificado la reserva con éxito");
                                                            else
                                                                MessageBox.Show("No se ha modificado");
                                                        }
                                                        else
                                                            MessageBox.Show("No se ha podido cambiar el estado del libro");
                                                    }
                                                    else
                                                        MessageBox.Show("Fué cancelado");
                                                }
                                            }
                            
                                    }
                                }

                            catch (FormatException ex)
                            {
                                MessageBox.Show("Ingresó letras en lugar de número / o no ingresó nada");
                                textBoxCodigo.Focus();

                            }
                            catch (BlancoException ex)
                            {
                                MessageBox.Show(ex.Message);

                            }

                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }
                           // finally---> no me lo toma(revisar)ç
                       
                        }
                    }

            }
            //this.Close();
        }

        public Administradora devolverAdmin()
        {
            return adminCopia;
        }
    }
}
