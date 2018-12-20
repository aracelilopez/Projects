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
    public partial class CrearPrestamo : Form
    {
        Administradora adminCopia;
        List<Cliente> listaClientes;
        List<Libro> listalibros;
        Cliente cli;
        Libro lib;

        public CrearPrestamo(Administradora admin)
        {
            InitializeComponent();
            adminCopia = admin;
            listaClientes = adminCopia.Listaclientes;
            listalibros = adminCopia.Listalibros;

            listBox1.DataSource = null;
            listBox1.DataSource = listaClientes;
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

        public Administradora Daradministradora()
        {
            return adminCopia;
        }

        private void ButtonSeleccionar_Click(object sender, EventArgs e)
        {
            if(radioButtonSi.Checked)
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

        private void buttonRealizar_Click(object sender, EventArgs e)
        {
            Cliente cli2 = (Cliente) listBox1.SelectedItem;
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
                if (adminCopia.limiteDePrestamos(cli3.Dni))
                {
                    if (adminCopia.estadodecliente(cli3.CodigoSocio))
                    {
                        if (lib == null)
                            MessageBox.Show("No se ha seleccionado ningún libro");
                        else
                        {

                            if (lib.Estado == "Reservado" || lib.Estado == "Disponible")
                            {
                                try
                                {
                                    int codigo = int.Parse(textBoxCodigo.Text);
                                    Prestamo presta = adminCopia.buscarprestamo(codigo);
                                    if (presta == null)
                                    {

                                        DateTime hoy = DateTime.Now;//aqui modificar para probar
                                        if (lib.Estado == "Reservado")
                                        {
                                            List<Reserva> reseraux = adminCopia.ReservaxLibro(lib.Isbn, lib.Ejemplar);

                                            if (reseraux != null)
                                            {
                                                Reserva rese = adminCopia.buscarReservaEspecifica(cli3.CodigoSocio, lib.Isbn, lib.Ejemplar);
                                                if (rese != null)
                                                {
                                                    if (adminCopia.soselproximo(rese, hoy))
                                                    {
                                                        if (adminCopia.eliminarReserva(rese.Codigo))
                                                            MessageBox.Show("Hay una reserva y es el siguiente asi que se elimino la reserva");
                                                        else
                                                        {
                                                            MessageBox.Show("Algo salió mal y no se pudo eliminar");
                                                            throw new Exception();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        //MessageBox.Show("ya existe esta reserva pero ahi reservas con este libro anterior a este cliente");
                                                        throw new PrestamoException();
                                                    }
                                                }
                                                else
                                                    throw new PrestamoException();
                                            }

                                        }


                                        int dardias = cli3.dardiasXretirar();

                                        DateTime devolucion = hoy.AddDays(dardias);

                                        if (adminCopia.Prestarlibro(lib))
                                        {

                                            presta = new Prestamo(codigo, cli3, lib, hoy, devolucion);

                                            MostrarPrestamo mostrar = new MostrarPrestamo(presta);
                                            mostrar.ShowDialog();

                                            bool estado = mostrar.darestado();

                                            if (estado)
                                            {
                                                if (adminCopia.agregarPrestamo(presta))
                                                {
                                                    int cantidad = adminCopia.cantidadPrestamosFaltantes(presta.Cliente.Dni);
                                                    if (cantidad == 0)
                                                        MessageBox.Show("el prestamo fue un exito pero el cliente ahora tiene el limite maximo de libros a su favor");
                                                    else
                                                        MessageBox.Show("A este cliente le quedan todavia " + cantidad + " prestamos para realizar");
                                                    MessageBox.Show("Se ha agregado con exito a la base de datos");
                                                }
                                                else
                                                    MessageBox.Show("No se a agregado");
                                            }
                                            else
                                                MessageBox.Show("fue cancelado");

                                        }
                                        else
                                            MessageBox.Show("No se a podido cambiar el estado del libro");

                                    }
                                    else
                                        MessageBox.Show("Ya existe un prestamo con este codigo");
                                }

                                catch (FormatException ex)
                                {
                                    MessageBox.Show("Ingreso letras en lugar de numero / o no ingreso nada");
                                    textBoxCodigo.Focus();

                                }
                                catch (BlancoException ex)
                                {
                                    MessageBox.Show(ex.Message);

                                }

                                catch (PrestamoException ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }

                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }
                                //finally---> no me lo toma(revisar)
                            }
                            else
                            {
                                if (lib.Estado == "Prestado")
                                    MessageBox.Show("El libro ya fue prestado");
                            }


                        }

                    }
                    else
                        MessageBox.Show("Este cliente ya posee una prestamo a su nombre");

                }
                else
                    MessageBox.Show("El cliente ya posee 3 libros a su nombre");
            }
            //this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarPrestamoReserva buscar = new BuscarPrestamoReserva();
            buscar.ShowDialog();
            int codigo = buscar.darcodigo();

            if(codigo != 0)
            {
                cli = adminCopia.buscarCliente(codigo);

                if(cli == null)
                {
                    DialogResult boton = MessageBox.Show("El Cliente no se encuentra,¿ Desea agregarlo ? ", "ALERTA", MessageBoxButtons.YesNo);

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
                                MessageBox.Show("Se ha guardado el cliente en la BD con exito");
                            }
                            else
                                MessageBox.Show("No se ha podido guardar");
                        }
                    }

                    listBox1.DataSource = null;
                    listBox1.DataSource = listaClientes;
                    listBox1.ClearSelected();
                }
                else
                {
                    MessageBox.Show("Se ha seleccionado el cliente");
                }
                
            }
        }

        private void buttonFiltrar_Click(object sender, EventArgs e)
        {

        }

    }
}
